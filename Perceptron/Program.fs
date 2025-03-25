// For more information see https://aka.ms/fsharp-console-apps
open Perceptron
open Perceptron.Net
open TorchSharp

open Plotly.NET

let zeroIndex = torch.TensorIndex.Single(0)
let gbm = new Gbm(50, 0.1)
let tt = TensorBuilder<float>()
let data = gbm.forward(tt{yield[1]},tt{yield[1]},tt{yield[100]})[torch.TensorIndex.Ellipsis, zeroIndex, zeroIndex, zeroIndex]


Chart.Scatter(data.ToArray(), [1.0..50.0],StyleParam.Mode.Lines_Markers)
