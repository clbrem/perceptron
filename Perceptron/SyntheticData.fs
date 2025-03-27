namespace Perceptron
open TorchSharp
open type TorchSharp.TensorExtensionMethods

type Net(n_in: int)  =
     inherit torch.nn.Module<torch.Tensor,torch.Tensor>("Net")     
     let hidl = torch.nn.Linear(n_in, 10)
     let outpt = torch.nn.Linear(10, 1)
     
     do
         let lim = 0.80
         torch.nn.init.uniform_(hidl.weight, -lim,lim) |> ignore
         torch.nn.init.uniform_(hidl.bias, -lim, lim) |> ignore
         torch.nn.init.uniform_(outpt.weight, -lim, lim) |> ignore
         torch.nn.init.uniform_(outpt.bias, -lim,-lim) |> ignore
     override _.forward(input: torch.Tensor) =
         use _ = torch.NewDisposeScope()
         let z = hidl.call(input).tanh_()
         let x = outpt.call(z).sigmoid_()
         x.MoveToOuterDisposeScope()

module Net =
    let create_data_file(net: Net, n_in: int64, fileName: string, n_items: int64) =
        let x_lo = -1.0
        let x_hi = 1.0
        let one_hundredth = 0.01.ToScalar()
        let X = (x_hi - x_lo).ToScalar() *torch.rand([|n_items; n_in|]) + x_lo.ToScalar()
        use d = torch.no_grad()
        let mutable y = net.call(X)
        y <- y + torch.rand(y.shape) * one_hundredth
        y <- torch.where(y.le(torch.tensor(0.0)), y + one_hundredth * torch.randn (y.shape) + one_hundredth, y)
        X.save(fileName + ".x")
        y.save(fileName + ".y")
    let load_data_file fileName =(torch.Tensor.load(fileName+ ".x"), torch.Tensor.load(fileName+ ".y"))
        

