namespace Vega

open Fable.Core
open Fable.Core.JsInterop
open System


[<AllowNullLiteral>]
[<Interface>]
type OnTrigger =
    abstract member trigger: Expr with get, set
    abstract member insert: Expr option with get, set
    abstract member remove: U2<bool, Expr> option with get, set
    abstract member toggle: Expr option with get, set
    abstract member modify: Expr option with get, set
    abstract member values: Expr option with get, set

[<AllowNullLiteral>]
[<Interface>]
type OnMarkTrigger =
    abstract member trigger: Expr with get, set
    abstract member modify: Expr option with get, set
    abstract member values: Expr option with get, set
