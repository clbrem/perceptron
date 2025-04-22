namespace Vega

open Fable.Core


type Datum =
    obj

type URI =
    string
[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type DataType =
    | boolean
    | number
    | date
    | string

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type ParseAuto =    
    | auto

type Parse =
    U2<ParseAuto, Map<string,DataType>>

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]    
type JsonType =
    |json    

[<AllowNullLiteral>]
[<Interface>]
type FormatJSON =
    abstract member ``type``: JsonType with get, set
    abstract member parse: Parse option with get, set
    abstract member property: U2<string, SignalRef> option with get, set
    abstract member copy: bool option with get, set
    
[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]    
type SvType =
    |tsv
    |csv
    
[<AllowNullLiteral>]
[<Interface>]
type FormatSV =
    abstract member ``type``: SvType with get, set // Should be 'csv'|'tsv'
    abstract member header: ResizeArray<string> option with get, set
    abstract member parse: Parse option with get, set

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]    
type DsvType =
    |dsv  

[<AllowNullLiteral>]
[<Interface>]
type FormatDSV =
    abstract member ``type``: DsvType with get, set
    abstract member header: ResizeArray<string> option with get, set
    abstract member parse: Parse option with get, set
    abstract member delimiter: string with get, set

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]    
type TopoJsonType =
    |topojson
    
[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]    
type TopoJsonFilter =
    | exterior
    | interior
    | [<CompiledValue(null)>] nullfilter

[<AllowNullLiteral>]
[<Interface>]
type FormatTopoJSON =
    abstract member ``type``: TopoJsonType with get, set
    abstract member property: string option with get, set
    abstract member feature: string with get, set
    abstract member mesh: string with get, set
    abstract member filter: TopoJsonFilter with get, set
type FormatParse = {
    parse: Parse
}

type Format =
    U5<FormatJSON, FormatSV, FormatDSV, FormatTopoJSON, FormatParse>

[<AllowNullLiteral>]
[<Interface>]
type BaseData =
    abstract member name: string with get, set
    abstract member on: ResizeArray<OnTrigger> option with get, set
    abstract member transform: ResizeArray<Transforms> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type SourceData =
    abstract member source: U2<string, ResizeArray<string>> with get, set
    abstract member name: string with get, set
    abstract member on: ResizeArray<OnTrigger> option with get, set
    abstract member transform: ResizeArray<Transforms> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type ValuesData =
    abstract member values: U2<ResizeArray<Datum>, obj> with get, set
    abstract member format: U2<Format, SignalRef> option with get, set
    abstract member async: U2<bool, SignalRef> option with get, set
    abstract member name: string with get, set
    abstract member on: ResizeArray<OnTrigger> option with get, set
    abstract member transform: ResizeArray<Transforms> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type UrlData =
    abstract member url: U2<URI, SignalRef> with get, set
    abstract member format: U2<Format, SignalRef> option with get, set
    abstract member async: U2<bool, SignalRef> option with get, set
    abstract member name: string with get, set
    abstract member on: ResizeArray<OnTrigger> option with get, set
    abstract member transform: ResizeArray<Transforms> option with get, set

type Data =
    U4<SourceData, ValuesData, UrlData, BaseData>



module FormatSV =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type ``type`` =
        | csv
        | tsv

module FormatTopoJSON =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type filter =
        | interior
        | exterior

module Format =

    module U5 =

        [<Global>]
        [<AllowNullLiteral>]
        type Case5
            [<ParamObject; Emit("$0")>]
            (
                parse: Parse
            ) =

            member val parse : Parse = nativeOnly with get, set

        module Case2 =

            module FormatSV =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type ``type`` =
                    | csv
                    | tsv
