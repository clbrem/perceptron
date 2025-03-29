namespace Perceptron
open System.Collections.Generic
open TorchSharp
open type TorchSharp.TensorExtensionMethods



type ShortTermLoss(termInterestRate : torch.Tensor) =
    inherit torch.nn.Module<torch.Tensor,torch.Tensor>("ShortTermLoss")
    override _.forward (observed) =
        let rates = torch.unsqueeze(termInterestRate, 0)
        let observed = torch.log(observed.flatten())        
        let n = observed.size(0)
        let logDiscount = torch.log(1 / (1 + rates)) * torch.arange(0, n, 1, dtype = torch.float)        
        let sell = (observed - observed[0]*torch.ones(n) + logDiscount).mean()
        let buy = -sell
        let hold = torch.zeros(sell.size())
        torch.stack(List([buy;hold;sell;]))
        
        
        
        

module Model =
    let model n_in : torch.nn.Module<torch.Tensor,torch.Tensor> = torch.nn.Linear(n_in, 3, dtype=torch.float)
    let grad learning_rate (model: torch.nn.Module) =  torch.optim.Adam(model.parameters(), learning_rate)
    
    