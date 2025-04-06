namespace Perceptron
open System
open Perceptron
open MyAssert
open Xunit
open TorchSharp
open type TorchSharp.TensorExtensionMethods
open Xunit.Abstractions
module private String =
    let join (s: string): string seq -> string = fun items -> String.Join(s, items)
type Test(logger: ITestOutputHelper) =
    
    let matrix = Array2DBuilder<int>()
    let tt = TensorBuilder<float>()
    let ttf = TensorBuilder<float32>()
    
    let gbm = new Gbm(1000, 0.001f)
    
    [<Fact>]
    let ``Test Loss Model``() =
        let pred =
            ttf {
                yield [1.0f; 0f; 0f]
                yield [0f; 1.0f; 0f]
                yield [0f; 0f; 1.0f]
                yield [0f; 0f; 1.0f]
            }
        let outcomes =
            ttf {
                yield [1.0f; 2.0f; 3.0f; 4.0f; 5.0f]
                yield [1.0f; 2.0f; 1.0f; 1.0f; 1.0f]
                yield [5f; 4f; 3f; 2f; 1f]
                yield [7f; 4f; 5f; 6f; 2f]
            }
        use lossModule= new ShortTermLoss(torch.tensor(0.01f))
        let output = lossModule.forward(pred, outcomes)
        Assert.FailWith "%s" (output.ToString(TensorStringStyle.Julia))
        
        
    [<Fact>]
    let ``tensor indexing``() =
        let t =
            ttf {
                yield [1f; 2f; 3f]
                yield [4f ;5f; 6f]
            }
            
        t[0].size() |> Assert.EqualTo [|3L|]
    

        
    [<Fact>]
    let ``Can GBM``() =
        let zeroIndex = torch.TensorIndex.Single(0)
        let data = gbm.forward(tt{yield[1]},tt{yield[1]},tt{yield[100]})
        let series = data[torch.TensorIndex.Ellipsis,zeroIndex,zeroIndex,zeroIndex]
        series.size() |> Assert.EqualTo  [|1000L|]
        
        
        
    [<Fact>]
    let ``Forward``() =
        let observed =
            ttf {
                yield [1.0f;2.0f;3.0f;4.0f;5.0f]
                yield [5f; 4f; 3f; 2f; 1f]
            }
        let input =
            ttf {
                yield [1.0f;2.0f;3.0f;4.0f;5.0f]
                yield [5f;4f;3f;2f;1f]
            } 
        
        use lossModule= new ShortTermLoss(torch.tensor(0.01f))
        use model = torch.nn.Linear(5,3,dtype=torch.float)
        let loss (pred: torch.Tensor) (observed: torch.Tensor) = lossModule.forward(pred, observed)                                                  
        let optimizer = torch.optim.Adam(model.parameters(), lr = 0.01)
        for epoch = 1 to 2 do
            let pred = model.forward(input).softmax(0)
            let output = loss pred observed 
            logger.WriteLine(sprintf "loss is %s" (output.ToString(TensorStringStyle.Numpy)))
            model.zero_grad()        
            output.backward()
            logger.WriteLine(sprintf "grad is %s" (model.parameters() |> Seq.head |> _.ToString(TensorStringStyle.Julia)))                
            optimizer.step() |> ignore
        printfn "Epoch %d" 2
        
        
        
    [<Fact>]
    let ``Can Reshape``() =
        let data = gbm.forward(ttf{yield[0.1f]},ttf{yield[0.01f]},ttf{yield[100f]}).squeeze() 
        let input, observed = Gbm.trainingData (10, 10) (data.squeeze())
        use lossModule= new ShortTermLoss(torch.tensor(0.001f))
        use model = torch.nn.Linear(10,3,dtype=torch.float32)
        let loss (pred: torch.Tensor) (observed: torch.Tensor) = lossModule.forward(pred, observed)
        let pred = model.forward(input) 
        loss pred observed
        

        
        
        
        
    