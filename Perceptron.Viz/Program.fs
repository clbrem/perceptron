open Browser
open Perceptron.Viz
open Fable.Core

  

[<EntryPoint>]
let main args =
    
    let div = document.createElement "div"
    let innerDiv  = document.createElement "div"
    innerDiv.id <- "vis"
    div.appendChild innerDiv |> ignore
        
    
    
    
    let sch =        
            {|
              
               description= "A simple bar chart with embedded data."
               data =
                {|
                    values = [
                      {|a= "A"; b= 28|}; {|a= "B"; b= 55|}; {|a= "C";b= 43|};
                      {|a= "D"; b= 91|}; {|a= "E"; b =81|}; {|a= "F"; b=53|};
                      {|a="G";b= 19|}; {|a= "H";b= 87|}; {|a= "I";b= 52|}
                    ]
                |};
               mark= "bar";
               
        |}        
        
    Vega.embed.Invoke(U2.Case2 "#vis", U2.Case1 sch) |> ignore
        

    0
    
