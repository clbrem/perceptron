namespace Vega

open Fable.Core
open Fable.Core.JsInterop
open System

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type MarkType =
    | arc
    | area
    | image
    | group
    | line
    | path
    | rect
    | rule
    | shape
    | symbol
    | text
    | trail
