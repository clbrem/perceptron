namespace Vega


open Fable.Core
open Fable.Core.JsInterop
open System


[<AllowNullLiteral>]
[<Interface>]
type Spec =
    inherit Scope
    inherit Encodable<EncodeEntry>
    abstract member ``$schema``: string option with get, set
    abstract member config: Config option with get, set
    abstract member description: string option with get, set
    abstract member width: U2<float, SignalRef> option with get, set
    abstract member height: U2<float, SignalRef> option with get, set
    abstract member padding: U2<Padding, SignalRef> option with get, set
    abstract member autosize: U2<AutoSize, SignalRef> option with get, set
    abstract member background: U2<Color, SignalRef> option with get, set
    abstract member style: U2<string, ResizeArray<string>> option with get, set


