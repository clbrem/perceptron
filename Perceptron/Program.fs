// For more information see https://aka.ms/fsharp-console-apps
open Perceptron
open Perceptron.SyntheticData
open TorchSharp

let net = new Net(6)
do create_data_file(net, 6L, "train.dat", 2000L)
do create_data_file(net, 6L, "test.dat", 400L)
let x_test, y_test = load_data_file "test.dat"

let lin1 = torch.nn.Linear(6, 10)

printfn "%s" (lin1.weight.ToString(TensorStringStyle.Julia))