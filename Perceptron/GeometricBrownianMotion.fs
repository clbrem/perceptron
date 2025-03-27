namespace Perceptron
open TorchSharp
open type TorchSharp.TensorExtensionMethods

type Gbm(n_steps: int64,dt: float) =
    inherit torch.nn.Module<torch.Tensor,torch.Tensor,torch.Tensor,torch.Tensor>("Geometric_Brownian_Motion")
    member _.dt = dt
    member _.n_steps = n_steps
    override this.forward(x0, mu, sigma) =
        let mu_flat, sigma_flat, x0_flat = mu.flatten(), sigma.flatten(), x0.flatten()
        let mu_n,sigma_n,x0_n = mu_flat.size(0), sigma_flat.size(0), x0_flat.size(0)
        let prod_n = n_steps * mu_n * sigma_n * x0_n 
        let t =
            torch.normal(torch.zeros(prod_n), torch.sqrt(dt)*torch.ones(prod_n)).reshape(n_steps,x0_n,mu_n,sigma_n)
        let mu = mu_flat.reshape(1L,1L,mu_n,1L)
        let sigma = sigma_flat.reshape(1L,1L,1L,sigma_n)
        let x0 = x0_flat.reshape(1L,x0_n,1L,1L)
        torch.cumprod(
            torch.vstack(
                [|
                  torch.ones(1L, x0_n,mu_n,sigma_n)
                  torch.exp((mu - torch.pow(sigma,torch.tensor(2.0))/2.0)*dt + sigma*t)
                |]
            )
            ,0)*x0
        
type GbmStep(mu: torch.Tensor, sigma: torch.Tensor, dt: float) =    
    inherit torch.nn.Module<torch.Tensor,torch.Tensor>("Geometric_Brownian_Motion_Step")
    let mu_flat, sigma_flat = mu.flatten(), sigma.flatten()
    let mu_n,sigma_n = mu_flat.size(0), sigma_flat.size(0)
    let prod_n = mu_n * sigma_n  
    let t() =
        torch.normal(torch.zeros(prod_n), torch.sqrt(dt)*torch.ones(prod_n)).reshape(mu_n,sigma_n)
    let _mu = mu_flat.reshape(mu_n,1L)
    let _sigma = sigma_flat.reshape(1L,sigma_n)    
    member _.dt = dt
    member _.mu = mu
    member _.sigma = sigma
    override this.forward(input) =
        let dims = [ if input.size(0) = 1 then mu_n else 1L
                     if input.size(1) = 1 then sigma_n else 1L]
        input.repeat(dims[0],dims[1]) * torch.exp((_mu - torch.pow(_sigma,torch.tensor(2.0))/2.0)*dt + _sigma * t())
                
    
