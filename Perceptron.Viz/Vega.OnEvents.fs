
namespace Vega

open Fable.Core
open Fable.Core.JsInterop
open System


type EventListener =
    U3<SignalRef, {|scale: string|}, Stream.Stream>

type Events =
    U2<EventSelector, EventListener>

type Update =
    U4<Expr, ExprRef, SignalRef, {|value: SignalValue|}>

[<AllowNullLiteral>]
[<Interface>]
type OnEvent =
    abstract member encode: string with get, set
    abstract member events: U2<Events, ResizeArray<EventListener>> with get, set
    abstract member force: bool option with get, set
    abstract member update: Update with get, set

module EventListener =

    module U3 =

        [<Global>]
        [<AllowNullLiteral>]
        type Case2
            [<ParamObject; Emit("$0")>]
            (
                scale: string
            ) =

            member val scale : string = nativeOnly with get, set

module Update =

    module U4 =

        [<Global>]
        [<AllowNullLiteral>]
        type Case4
            [<ParamObject; Emit("$0")>]
            (
                value: SignalValue
            ) =

            member val value : SignalValue = nativeOnly with get, set
