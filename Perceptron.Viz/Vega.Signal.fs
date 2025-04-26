namespace Vega

open Fable.Core


[<AllowNullLiteral>]
[<Interface>]
type BaseSignal =
    abstract member name: string with get, set
    abstract member description: string option with get, set
    abstract member on: ResizeArray<OnEvent> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type PushSignal =
    inherit BaseSignal
    abstract member push: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type NewSignal =
    inherit BaseSignal
    abstract member value: SignalValue option with get, set
    abstract member react: bool option with get, set
    abstract member update: Expr option with get, set
    abstract member bind: Binding option with get, set

[<AllowNullLiteral>]
[<Interface>]
type InitSignal =
    inherit BaseSignal
    abstract member value: SignalValue option with get, set
    abstract member init: Expr with get, set
    abstract member bind: Binding option with get, set

type Signal =
    U3<NewSignal, InitSignal, PushSignal>


