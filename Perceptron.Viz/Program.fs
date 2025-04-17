﻿open Browser
open Perceptron.Viz
open Fable.Core
open Perceptron.Viz
open Perceptron.Viz.Vega  

    

[<EntryPoint>]
let main args =
            
    let doc = document.createElement "div"    
    
    document.body.appendChild doc |> ignore
    
    
    Vega.Embed.embed (U2.Case2 "#vis", U2.Case2 "./schema.json", None) |> ignore
    
    0
    
