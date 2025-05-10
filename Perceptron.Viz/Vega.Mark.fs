namespace Vega

open Fable.Core
open Fable.Core.JsInterop


type FacetAggregate = {
    cross: bool option
    fields: ResizeArray<string>
    ops: ResizeArray<string>
    [<CompiledName("as")>]
    facetAs: ResizeArray<string>
    
}

type Facet =
    {
        name: string
        data: string
        field: string option
        groupBy: U2<string, ResizeArray<string>> option
        aggregate: FacetAggregate option
                
    }

[<AllowNullLiteral>]
[<Interface>]
type From =
    abstract member data: string option with get, set

type FromFacet =
    U2<From, FromFacet.U2.Case2>

type Clip =
    U3<bool, Clip.U3.Case2, Clip.U3.Case3>

[<AllowNullLiteral>]
[<Interface>]
type Compare =
    abstract member field: U3<string, ExprRef, SignalRef> with get, set
    abstract member order: SortOrder option with get, set
    abstract member field: ResizeArray<U3<string, ExprRef, SignalRef>> with get, set
    abstract member order: ResizeArray<SortOrder> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type BaseMark =
    abstract member role: string option with get, set
    abstract member name: string option with get, set
    abstract member description: string option with get, set
    abstract member aria: bool option with get, set
    abstract member key: string option with get, set
    abstract member clip: Clip option with get, set
    abstract member sort: Compare option with get, set
    abstract member interactive: U2<bool, SignalRef> option with get, set
    abstract member from: From option with get, set
    abstract member transform: ResizeArray<Transforms> option with get, set
    abstract member zindex: float option with get, set
    abstract member on: ResizeArray<OnMarkTrigger> option with get, set
    abstract member style: U2<string, ResizeArray<string>> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type ArcMark =
    inherit BaseMark
    inherit Encode.Encodable<Encode.ArcEncodeEntry>
    abstract member ``type``: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type AreaMark =
    inherit BaseMark
    inherit Encode.Encodable<Encode.AreaEncodeEntry>
    abstract member ``type``: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type ImageMark =
    inherit BaseMark
    inherit Encode.Encodable<Encode.ImageEncodeEntry>
    abstract member ``type``: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type GroupMark =
    inherit BaseMark
    inherit Scope
    inherit Encode.Encodable<Encode.GroupEncodeEntry>
    abstract member ``type``: string with get, set
    abstract member from: FromFacet option with get, set

[<AllowNullLiteral>]
[<Interface>]
type LineMark =
    inherit BaseMark
    inherit Encode.Encodable<Encode.LineEncodeEntry>
    abstract member ``type``: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type PathMark =
    inherit BaseMark
    inherit Encode.Encodable<Encode.PathEncodeEntry>
    abstract member ``type``: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type RectMark =
    inherit BaseMark
    inherit Encode.Encodable<Encode.RectEncodeEntry>
    abstract member ``type``: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type RuleMark =
    inherit BaseMark
    inherit Encode.Encodable<Encode.RuleEncodeEntry>
    abstract member ``type``: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type ShapeMark =
    inherit BaseMark
    inherit Encode.Encodable<Encode.ShapeEncodeEntry>
    abstract member ``type``: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type SymbolMark =
    inherit BaseMark
    inherit Encode.Encodable<Encode.SymbolEncodeEntry>
    abstract member ``type``: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type TextMark =
    inherit BaseMark
    inherit Encode.Encodable<Encode.TextEncodeEntry>
    abstract member ``type``: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type TrailMark =
    inherit BaseMark
    inherit Encode.Encodable<Encode.TrailEncodeEntry>
    abstract member ``type``: string with get, set

type Mark =
    U12<ArcMark, AreaMark, ImageMark, GroupMark, LineMark, PathMark, RectMark, RuleMark, ShapeMark, SymbolMark, TextMark, TrailMark>

module Facet =

    [<Global>]
    [<AllowNullLiteral>]
    type aggregate
        [<ParamObject; Emit("$0")>]
        (
            fields: ResizeArray<string>,
            ops: ResizeArray<string>,
            ``as``: ResizeArray<string>,
            ?cross: bool
        ) =

        member val fields : ResizeArray<string> = nativeOnly with get, set
        member val ops : ResizeArray<string> = nativeOnly with get, set
        member val ``as`` : ResizeArray<string> = nativeOnly with get, set
        member val cross : bool option = nativeOnly with get, set

module FromFacet =

    module U2 =

        [<AllowNullLiteral>]
        [<Interface>]
        type Case2 =
            abstract member data: string option with get, set
            abstract member facet: Facet with get, set

module Clip =

    module U3 =

        [<Global>]
        [<AllowNullLiteral>]
        type Case2
            [<ParamObject; Emit("$0")>]
            (
                path: U2<string, SignalRef>
            ) =

            member val path : U2<string, SignalRef> = nativeOnly with get, set

        [<Global>]
        [<AllowNullLiteral>]
        type Case3
            [<ParamObject; Emit("$0")>]
            (
                sphere: U2<string, SignalRef>
            ) =

            member val sphere : U2<string, SignalRef> = nativeOnly with get, set
