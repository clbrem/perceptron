open Perceptron
open TorchSharp

open Plotly.NET

let zeroIndex = torch.TensorIndex.Single(0)
let n_points = 1000
let gbm = new Gbm(n_points, 0.1)

let tt = TensorBuilder<float>()
let gbmStep = new GbmStep(tt{yield[0.01;0.02;0.03]}, tt{yield[0.1]},0.1)

let data = gbm.forward(tt{yield[100]},tt{yield[0.01;0.02;0.03]},tt{yield[0.1]})
//data.ToString(TensorStringStyle.Julia) |> printfn "%A"

let series(i:int64,j:int64,k:int64) =
    data[torch.TensorIndex.Ellipsis,torch.TensorIndex.Single(i),torch.TensorIndex.Single(j),torch.TensorIndex.Single(k)]

gbmStep.forward(tt {yield[100]})
|> _.ToString(TensorStringStyle.Julia)
|> printfn "%A"
// [
//  for i in 0L..(data.size(1) - 1L) do
//  for j in 0L ..(data.size(2) - 1L) do
//  for k in 0L..(data.size(3) - 1L) do
//     yield Chart.Scatter([1.0..n_points],series(i,j,k).data<float>().ToArray(),StyleParam.Mode.Lines_Markers);
// ]
// |> Chart.combine
// |> Chart.show
