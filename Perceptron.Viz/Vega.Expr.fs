namespace Vega

open Fable.Core
open Fable.Core.JsInterop
open System

type Expr =
    string

[<AllowNullLiteral>]
[<Interface>]
type ExprRef =
    abstract member expr: Expr with get, set
