open Browser
open Fable.Core
open Fable.Core.JsInterop

[<Emit("undefined")>]
let undefined: obj = jsNative

[<EntryPoint>]
let main args =
    console.log(undefined)
    let div = document.createElement "div"
    div.innerHTML <- """
        <h1>It's a bye</h1>   
    """
    document.body.appendChild div |> ignore
    0
