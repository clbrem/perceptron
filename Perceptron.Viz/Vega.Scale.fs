namespace Vega

open Fable.Core





[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type RangeEnum =
    | width
    | height
    | symbol
    | category
    | ordinal
    | ramp
    | diverging
    | heatmap

type RangeRawArray =
    ResizeArray<U2<float, SignalRef>>

type RangeRaw =
    ResizeArray<U5<bool, string, float, SignalRef, RangeRawArray> option>

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type RangeScheme =
    | width
    | height
    | symbol
    | category
    | ordinal
    | ramp
    | diverging
    | heatmap

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type RangeBand =
    | width
    | height
    | symbol
    | category
    | ordinal
    | ramp
    | diverging
    | heatmap

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type SortOrder =
    | ascending
    | descending

type ScaleField =
    U2<string, SignalRef>
    
type SortField =    
    U3<bool, {|order: SortOrder|}, {|field: ScaleField option; op: ScaleField; order: SortOrder option|}>

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type SortOp =
    | count
    | min
    | max

/// <summary>
/// Unioned domains can only be sorted by count, min, or max aggregates. Note: case with no ScaleField should only have 'count'
/// </summary>
type UnionSortField =
    U3<bool, {|op:SortOp; order: SortOrder option|}, {| field: ScaleField; op: SortOp; order: SortOrder option |}>


[<AllowNullLiteral>]
[<Interface>]
type ScaleBinParams =
    /// <summary>
    /// The step size defining the bin interval width.
    /// </summary>
    abstract member step: U2<float, SignalRef> with get, set
    /// <summary>
    /// The starting (lowest-valued) bin boundary.
    ///
    /// __Default value:__ The lowest value of the scale domain will be used.
    /// </summary>
    abstract member start: U2<float, SignalRef> option with get, set
    /// <summary>
    /// The stopping (highest-valued) bin boundary.
    ///
    /// __Default value:__ The highest value of the scale domain will be used.
    /// </summary>
    abstract member stop: U2<float, SignalRef> option with get, set

type ScaleBins =
    U3<ResizeArray<U2<float, SignalRef>>, SignalRef, ScaleBinParams>

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type ScaleInterpolateEnum =
    | rgb
    | lab
    | hcl
    | hsl
    | ``hsl-long``
    | ``hcl-long``
    | cubehelix
    | ``cubehelix-long``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type ScaleInterpolateType =
    | rgb
    | cubehelix
    | ``cubehelix-long``
    


type ScaleInterpolateParams =
    {
        [<CompiledName("type")>] interpolateType: U2<ScaleInterpolateType, SignalRef>
        gamma: U2<float, SignalRef> option
    }
    

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type ScaleInterpolate =
    | rgb
    | lab
    | hcl
    | hsl
    | ``hsl-long``
    | ``hcl-long``
    | cubehelix
    | ``cubehelix-long``

[<AllowNullLiteral>]
[<Interface>]
type ScaleDataRef =
    abstract member data: string with get, set
    abstract member field: ScaleField with get, set

[<AllowNullLiteral>]
[<Interface>]
type ScaleMultiDataRef =
    abstract member fields: ResizeArray<U3<ResizeArray<U3<string, float, bool>>, ScaleDataRef, SignalRef>> with get, set

[<AllowNullLiteral>]
[<Interface>]
type ScaleMultiFieldsRef =
    abstract member data: string with get, set
    abstract member fields: ResizeArray<ScaleField> with get, set
    

type ScaleData =
    {
        sort: SortField option
        data: string option
        field: ScaleField option
        fields: U2<ResizeArray<U3<ResizeArray<U3<string, float, bool>>, ScaleDataRef, SignalRef>>, ResizeArray<ScaleField>> option
        
    }
    



[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type QuantScaleType =
    | linear
    | pow
    | sqrt
    | log
    | symlog
    | time
    | utc
    | sequential

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type DiscreteScaleType =
    | ordinal
    | band
    | point

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type DiscretizingScaleType =
    | quantile
    | quantize
    | threshold
    | ``bin-ordinal``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type ScaleType =
    | linear
    | pow
    | sqrt
    | log
    | symlog
    | time
    | utc
    | sequential
    | ordinal
    | band
    | point
    | quantile
    | quantize
    | threshold
    | ``bin-ordinal``
    | identity

[<AllowNullLiteral>]
[<Interface>]
type BaseScale =
    abstract member name: string with get, set
    abstract member ``type``: ScaleType option with get, set
    abstract member domain: U3<ResizeArray<U4<string, float, bool, SignalRef> option>, ScaleData, SignalRef> option with get, set
    abstract member domainMin: U2<float, SignalRef> option with get, set
    abstract member domainMax: U2<float, SignalRef> option with get, set
    abstract member domainMid: U2<float, SignalRef> option with get, set
    abstract member domainRaw: U2<ResizeArray<obj>, SignalRef> option option with get, set
    abstract member reverse: U2<bool, SignalRef> option with get, set
    abstract member round: U2<bool, SignalRef> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type ContinuousScale =
    inherit BaseScale
    abstract member range: RangeScheme option with get, set
    abstract member bins: ScaleBins option with get, set
    abstract member interpolate: ScaleInterpolate option with get, set
    abstract member clamp: U2<bool, SignalRef> option with get, set
    abstract member padding: U2<float, SignalRef> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type NumericScale =
    inherit ContinuousScale
    abstract member nice: U3<bool, float, SignalRef> option with get, set
    abstract member zero: U2<bool, SignalRef> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type BaseBandScale =
    inherit BaseScale
    abstract member range: RangeBand option with get, set
    abstract member padding: U2<float, SignalRef> option with get, set
    abstract member paddingOuter: U2<float, SignalRef> option with get, set
    abstract member align: U2<float, SignalRef> option with get, set
    
[<AllowNullLiteral>]
[<Interface>]
type OrdinalScale =
    inherit BaseScale
    abstract member ``type``: string with get, set
    abstract member range: U2<RangeScheme, ScaleData> option with get, set
    abstract member interpolate: ScaleInterpolate option with get, set
    abstract member domainImplicit: U2<bool, SignalRef> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type BandScale =
    inherit BaseBandScale
    abstract member ``type``: string with get, set
    abstract member paddingInner: U2<float, SignalRef> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type PointScale =
    inherit BaseBandScale
    abstract member ``type``: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type SequentialScale =
    inherit NumericScale
    abstract member ``type``: string with get, set

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type TimeInterval =
    | millisecond
    | second
    | minute
    | hour
    | day
    | week
    | month
    | year

[<AllowNullLiteral>]
[<Interface>]
type TimeIntervalStep =
    abstract member interval: TimeInterval with get, set
    abstract member step: float with get, set
[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type TimeScaleType =
    | time
    | utc
[<AllowNullLiteral>]
[<Interface>]
type TimeScale =
    inherit ContinuousScale
    abstract member ``type``: TimeScaleType with get, set
    abstract member nice: U4<bool, TimeInterval, TimeIntervalStep, SignalRef> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type IdentityScale =
    inherit BaseScale
    abstract member ``type``: string with get, set
    abstract member nice: U2<bool, SignalRef> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type LinearScale =
    inherit NumericScale
    abstract member ``type``: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type LogScale =
    inherit ContinuousScale
    abstract member ``type``: string with get, set
    abstract member ``base``: U2<float, SignalRef> option with get, set
    abstract member nice: U3<bool, float, SignalRef> option with get, set
    abstract member zero: bool option with get, set

[<AllowNullLiteral>]
[<Interface>]
type SymLogScale =
    inherit NumericScale
    abstract member ``type``: string with get, set
    abstract member constant: U2<float, SignalRef> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type PowScale =
    inherit NumericScale
    abstract member ``type``: string with get, set
    abstract member exponent: U2<float, SignalRef> with get, set

[<AllowNullLiteral>]
[<Interface>]
type SqrtScale =
    inherit NumericScale
    abstract member ``type``: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type QuantizeScale =
    inherit BaseScale
    abstract member ``type``: string option with get, set
    abstract member range: RangeScheme option with get, set
    abstract member padding: U2<float, SignalRef> option with get, set
    abstract member nice: U3<bool, float, SignalRef> option with get, set
    abstract member zero: U2<bool, SignalRef> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type ThresholdScale =
    inherit BaseScale
    abstract member ``type``: string option with get, set
    abstract member range: RangeScheme option with get, set
    abstract member padding: U2<float, SignalRef> option with get, set
    abstract member nice: U3<bool, float, SignalRef> option with get, set
    abstract member zero: U2<bool, SignalRef> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type QuantileScale =
    inherit BaseScale
    abstract member ``type``: string option with get, set
    abstract member range: RangeScheme option with get, set
    abstract member interpolate: ScaleInterpolate option with get, set

[<AllowNullLiteral>]
[<Interface>]
type BinOrdinalScale =
    inherit BaseScale
    abstract member ``type``: string with get, set
    abstract member bins: ScaleBins option with get, set
    abstract member range: U2<RangeScheme, ScaleData> option with get, set
    abstract member interpolate: ScaleInterpolate option with get, set

type Scale<'T when 'T :> BaseScale>  = T 
     



module ScaleInterpolateParams =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type ``type`` =
        | rgb
        | cubehelix
        | ``cubehelix-long``

module OrdinalScale =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type range =
        | width
        | height
        | symbol
        | category
        | ordinal
        | ramp
        | diverging
        | heatmap

module TimeScale =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type ``type`` =
        | time
        | utc

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type nice =
        | millisecond
        | second
        | minute
        | hour
        | day
        | week
        | month
        | year

module BinOrdinalScale =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type range =
        | width
        | height
        | symbol
        | category
        | ordinal
        | ramp
        | diverging
        | heatmap

module Scale =

    module U15 =

        module Case1 =

            module OrdinalScale =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type range =
                    | width
                    | height
                    | symbol
                    | category
                    | ordinal
                    | ramp
                    | diverging
                    | heatmap

        module Case5 =

            module TimeScale =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type ``type`` =
                    | time
                    | utc

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type nice =
                    | millisecond
                    | second
                    | minute
                    | hour
                    | day
                    | week
                    | month
                    | year

        module Case15 =

            module BinOrdinalScale =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type range =
                    | width
                    | height
                    | symbol
                    | category
                    | ordinal
                    | ramp
                    | diverging
                    | heatmap
