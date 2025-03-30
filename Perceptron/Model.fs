namespace Perceptron
open System.Collections.Generic
open TorchSharp
open type TorchSharp.TensorExtensionMethods



/// <summary>
/// This loss function takes an n_batch_size x 3 tensor of predictions from the BuyModel
/// and an n_batch_size x n_time_steps tensor of observed prices.
/// pred:
/// 1.0 0.0 0.0 -- Buy
/// 0.0 0.0.1.0 -- Sell
/// 0.0 1.0 0.0 -- Hold
///
///  
/// </summary>
/// <param name="termInterestRate">The interest rate</param>

type ShortTermLoss(termInterestRate : torch.Tensor) =
    
    inherit torch.nn.Module<torch.Tensor,torch.Tensor,torch.Tensor>("ShortTermLoss")
    override _.forward (pred, observed) =
        let rates = torch.unsqueeze(termInterestRate, 0)
        let observed = torch.log(observed)
        let n = observed.size(1)
        let logDiscount = torch.log(1 / (1 + rates)) * torch.arange(0, n, 1, dtype = torch.float)        
        let sell = (observed - observed[0]*torch.ones(n) + logDiscount).mean([|1L|])
        let buy = -sell
        let hold = torch.zeros(sell.size())
        let stacked = torch.stack(List [buy;hold;sell;], 1)
        (pred * stacked).sum()
        
type BuyModel(n_in, dtype) =
    inherit torch.nn.Module<torch.Tensor,torch.Tensor>("BuyModel")
    let inner = torch.nn.Linear(n_in, 3, dtype=dtype)
    override _.forward (observed) =
        inner.forward(observed).softmax(0)


    
    