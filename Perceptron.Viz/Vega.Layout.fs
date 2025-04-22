namespace Vega

open Fable.Core
open Fable.Core.JsInterop
open System


[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type LayoutAlign =
    | all
    | each
    | none

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type LayoutTitleAnchor =
    | start
    | ``end``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type LayoutBounds =
    | full
    | flush

type LayoutOffset =
    U3<float, SignalRef, LayoutOffset.U3.Case3>

[<AllowNullLiteral>]
[<Interface>]
type RowColumn<'T> =
    abstract member row: U2<'T, SignalRef> option with get, set
    abstract member column: U2<'T, SignalRef> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type LayoutParams =
    abstract member align: LayoutParams.align option with get, set
    abstract member bounds: LayoutBounds option with get, set
    abstract member columns: U2<float, SignalRef> option with get, set
    abstract member padding: U3<float, SignalRef, RowColumn<float>> option with get, set
    abstract member offset: LayoutOffset option with get, set
    abstract member headerBand: U3<float, SignalRef, RowColumn<float>> option with get, set
    abstract member footerBand: U3<float, SignalRef, RowColumn<float>> option with get, set
    abstract member titleAnchor: LayoutParams.titleAnchor option with get, set
    abstract member titleBand: U3<float, SignalRef, RowColumn<float>> option with get, set

type Layout =
    U2<SignalRef, LayoutParams>

module LayoutOffset =

    module U3 =

        [<Global>]
        [<AllowNullLiteral>]
        type Case3
            [<ParamObject; Emit("$0")>]
            (
                ?rowHeader: U2<float, SignalRef>,
                ?rowFooter: U2<float, SignalRef>,
                ?rowTitle: U2<float, SignalRef>,
                ?columnHeader: U2<float, SignalRef>,
                ?columnFooter: U2<float, SignalRef>,
                ?columnTitle: U2<float, SignalRef>
            ) =

            member val rowHeader : U2<float, SignalRef> option = nativeOnly with get, set
            member val rowFooter : U2<float, SignalRef> option = nativeOnly with get, set
            member val rowTitle : U2<float, SignalRef> option = nativeOnly with get, set
            member val columnHeader : U2<float, SignalRef> option = nativeOnly with get, set
            member val columnFooter : U2<float, SignalRef> option = nativeOnly with get, set
            member val columnTitle : U2<float, SignalRef> option = nativeOnly with get, set

module LayoutParams =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type align =
        | all
        | each
        | none

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type titleAnchor =
        | start
        | ``end``

module Layout =

    module U2 =

        module Case2 =

            module LayoutParams =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type align =
                    | all
                    | each
                    | none

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type titleAnchor =
                    | start
                    | ``end``
