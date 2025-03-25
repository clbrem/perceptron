namespace Perceptron
open TorchSharp
open type TorchSharp.TensorExtensionMethods

type Gbm(n_steps: int64,dt: float) =
    inherit torch.nn.Module<torch.Tensor,torch.Tensor,torch.Tensor,torch.Tensor>("Geometric_Brownian_Motion")
    member _.dt = dt
    member _.n_steps = n_steps
    override this.forward(mu, sigma, x0) =
        let mu_n,sigma_n,x0_n = mu.size(0),sigma.size(0),x0.size(0)
        let prod_n = n_steps * mu_n * sigma_n * x0_n 
        let t =
            torch.normal(torch.zeros(prod_n), torch.sqrt(dt)*torch.ones(prod_n)).reshape(n_steps,x0_n,mu_n,sigma_n)
        let mu = mu.flatten().reshape(1L,1L,mu.size(0),1L)
        let sigma = sigma.flatten().reshape(1L,1L,1L,sigma.size(0))
        let x0 = x0.flatten().reshape(1L,x0.size(0),1L,1L)
        torch.cumprod(
            torch.vstack(
                [|
                  torch.ones(1L, x0.size(0),mu.size(0),sigma.size(0))
                  torch.exp(mu - torch.pow(sigma,torch.tensor(2.0))/2.0 + sigma*t)
                |]
            )
            ,0)*x0
        
        
        
    
    
    
    

