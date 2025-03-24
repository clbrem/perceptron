namespace Perceptron
open TorchSharp
open type TorchSharp.TensorExtensionMethods



type ShortTermLoss(interestRate : float ) =
    inherit torch.nn.Module<torch.Tensor,torch.Tensor,torch.Tensor>("ShortTermLoss")
    override _.forward (input: torch.Tensor, target: torch.Tensor) =
        let diffs = torch.roll(input,1) / input
        diffs[0].set_(0.0) |> ignore
        let exps = torch.pow(interestRate, torch.arange(0, diffs.size(0), 1, dtype = torch.float))
        torch.sum(diffs * exps)
        

module Model =
    let model n_in : torch.nn.Module = torch.nn.Linear(n_in, 2)    
    let grad learning_rate (model: torch.nn.Module) =  torch.optim.Adam(model.parameters(), learning_rate)
    
    