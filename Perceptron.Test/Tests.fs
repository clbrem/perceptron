module Tests
open Perceptron
open MyAssert
open Xunit
open TorchSharp

let matrix = Array2DBuilder<int>()
let tt = TensorBuilder<float>()


    

[<Fact>]
let ``My test`` () =
    let mat = tt {yield [1;2;3;4;5]}
    mat[0].set_(0.0) |> ignore
    mat.ToString(TensorStringStyle.Julia)
    |> Assert.FailWith "%s"
    
