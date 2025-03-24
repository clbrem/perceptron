namespace Perceptron
open System
open TorchSharp

module private JaggedList =
    let (|Rectangular|_|) (input : 'T array list) =
        let lengths = input |> List.map Array.length
        if List.isEmpty lengths || List.forall ((=) lengths[0]) lengths then Some input else None
    let (|Empty|_|): 'T array list -> bool  =
        function
        | [] -> true
        | [ a ] -> Seq.isEmpty a
        | _ -> false
        
    let (|Rank|) =
        function
        | Empty -> 0, 0 
        | Rectangular rows -> (List.length rows), (rows |> List.head |> Seq.length)
        | _ -> failwith "Jagged list must be rectangular"


type MatrixBuilder<'T,'S>(factory: 'T array list -> 'S) =
    member _.Yield(row: #('T seq )) = Array.ofSeq row |> List.singleton    
    member _.Run (rows: 'T array list)=
        match rows with
        | JaggedList.Rectangular rows -> factory rows
        | _ -> ArgumentException("Input must be rectangular") |> raise
    member _.Zero() = [[||]]
    member _.Delay(f) = f()
    member _.Combine(a: 'T array list,b: 'T array list) = List.concat [a;b]
    

        
type Array2DBuilder<'T>() =
    inherit MatrixBuilder<'T, 'T array2d>(
        fun rows ->
            Array2D.init rows.Length (List.head rows |> Array.length) (fun i j -> rows[i][j])
        )

type TensorBuilder<'T>() =    
    inherit MatrixBuilder<'T, torch.Tensor>(
        function
        | JaggedList.Empty  -> torch.empty(0,0)
        | JaggedList.Rectangular rows & JaggedList.Rank (m,n) ->
            rows |> Array.concat |> torch.from_array |> _.reshape(m,n)
        | _ -> failwith "shouldn't happen"        
        )

    