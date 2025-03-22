module Tests
open Perceptron
open MyAssert
open Xunit

let matrix = Array2DBuilder<int>()
let tt = TensorBuilder<float>()

[<Fact>]
let ``My test`` () =

    tt {
        yield [1;2;3]
        yield [4;5;6]
    } |> Assert.FailWith "%A"