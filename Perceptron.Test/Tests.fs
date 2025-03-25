module Tests
open Perceptron
open MyAssert
open Xunit
open TorchSharp

let matrix = Array2DBuilder<int>()
let tt = TensorBuilder<float>()

let gbm = new Gbm(50, 0.1)
    

[<Fact>]
let ``My test`` () =
    let mat = tt {yield [1;2;3;4;5]}
    mat[0].set_(0.0) |> ignore
    mat.ToString(TensorStringStyle.Julia)
    |> Assert.FailWith "%s"
    
[<Fact>]
let ``Can GBM``() =
    let zeroIndex = torch.TensorIndex.Single(0)
    let data = gbm.forward(tt{yield[1]},tt{yield[1]},tt{yield[100]})
    let series = data[torch.TensorIndex.Ellipsis,zeroIndex,zeroIndex,zeroIndex]
    series.ToString(TensorStringStyle.Julia) |> Assert.FailWith "%s"