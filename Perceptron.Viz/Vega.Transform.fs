namespace Vega

open Fable.Core


type DataName =
    string

type ProjectionName =
    string

type SignalName =
    string

type ExprString =
    string


type FieldParam = {
    field: string
}
type TransformField =
    U3<SignalRef, FieldParam, ExprRef>

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type AggregateOp =
    | argmax
    | argmin
    | average
    | count
    | distinct
    | max
    | mean
    | median
    | min
    | missing
    | product
    | q1
    | q3
    | ci0
    | ci1
    | stderr
    | stdev
    | stdevp
    | sum
    | valid
    | values
    | variance
    | variancep
    | exponential
    | exponentialb


type AggregateTransform =
    {
        [<CompiledName("type")>]
        transformType: string
        signal: string option
        groupby: U2<ResizeArray<FieldRef>, SignalRef> option
        fields: U2<ResizeArray<FieldRef option>, SignalRef> option
        ops: U2<ResizeArray<AggregateOp>, SignalRef> option
        aggregate_params: ResizeArray<float> option
        ``as``: U2<ResizeArray<U2<string, SignalRef> option>, SignalRef> option
        drop: U2<bool, SignalRef> option
        cross: U2<bool, SignalRef> option
        key: U2<string, TransformField> option        
    }
    

type BaseBin =
    {
    /// <summary>
    /// The number base to use for automatic bin determination (default is base 10).
    ///
    /// __Default value:__ <c>10</c>
    /// </summary>
    [<CompiledName("base")>] 
    binBase: U2<float, SignalRef> option
    /// <summary>
    /// An exact step size to use between bins.
    ///
    /// __Note:__ If provided, options such as maxbins will be ignored.
    /// </summary>
    step: U2<float, SignalRef> option
    /// <summary>
    /// An array of allowable step sizes to choose from.
    /// </summary>
    steps: U2<ResizeArray<U2<float, SignalRef>>, SignalRef> option
    /// <summary>
    /// A minimum allowable step size (particularly useful for integer values).
    /// </summary>
    minstep: U2<float, SignalRef> option
    /// <summary>
    /// Scale factors indicating allowable subdivisions. The default value is [5, 2], which indicates that for base 10 numbers (the default base), the method may consider dividing bin sizes by 5 and/or 2. For example, for an initial step size of 10, the method can check if bin sizes of 2 (= 10/5), 5 (= 10/2), or 1 (= 10/(5*2)) might also satisfy the given constraints.
    ///
    /// __Default value:__ <c>[5, 2]</c>
    /// </summary>
    divide: U2<Vector.Vec2<U2<float, SignalRef>>, SignalRef> option
    /// <summary>
    /// Maximum number of bins.
    ///
    /// __Default value:__ <c>6</c> for <c>row</c>, <c>column</c> and <c>shape</c> channels; <c>10</c> for other channels
    /// </summary>
    maxbins: U2<float, SignalRef> option
    /// <summary>
    /// If true (the default), attempts to make the bin boundaries use human-friendly boundaries, such as multiples of ten.
    /// </summary>
    nice: U2<bool, SignalRef> option
}
    

    



type FieldRef =
    U2<string, TransformField>

type BinTransform =
    {
        /// <summary>
    /// The number base to use for automatic bin determination (default is base 10).
    ///
    /// __Default value:__ <c>10</c>
    /// </summary>
    [<CompiledName("base")>] 
    binBase: U2<float, SignalRef> option
    /// <summary>
    /// An exact step size to use between bins.
    ///
    /// __Note:__ If provided, options such as maxbins will be ignored.
    /// </summary>
    step: U2<float, SignalRef> option
    /// <summary>
    /// An array of allowable step sizes to choose from.
    /// </summary>
    steps: U2<ResizeArray<U2<float, SignalRef>>, SignalRef> option
    /// <summary>
    /// A minimum allowable step size (particularly useful for integer values).
    /// </summary>
    minstep: U2<float, SignalRef> option
    /// <summary>
    /// Scale factors indicating allowable subdivisions. The default value is [5, 2], which indicates that for base 10 numbers (the default base), the method may consider dividing bin sizes by 5 and/or 2. For example, for an initial step size of 10, the method can check if bin sizes of 2 (= 10/5), 5 (= 10/2), or 1 (= 10/(5*2)) might also satisfy the given constraints.
    ///
    /// __Default value:__ <c>[5, 2]</c>
    /// </summary>
    divide: U2<Vector.Vec2<U2<float, SignalRef>>, SignalRef> option
    /// <summary>
    /// Maximum number of bins.
    ///
    /// __Default value:__ <c>6</c> for <c>row</c>, <c>column</c> and <c>shape</c> channels; <c>10</c> for other channels
    /// </summary>
    maxbins: U2<float, SignalRef> option
    /// <summary>
    /// If true (the default), attempts to make the bin boundaries use human-friendly boundaries, such as multiples of ten.
    /// </summary>
    nice: U2<bool, SignalRef> option
    [<CompiledName("type")>]
    transformType: string
    field: FieldRef
    interval: U2<bool, SignalRef> option
    anchor: U2<float, SignalRef> option
    extent: U2<Vector.Vec2<U2<float, SignalRef>>, SignalRef>
    span: U2<float, SignalRef> option
    signal: SignalName option
    name: U2<string, SignalRef> option
    [<CompiledName("as")>]
    binAs: U2<Vector.Vec2<U2<string, SignalRef>>, SignalRef> option
    

    }
    

type CollectTransform =
    {
        [<CompiledName("type")>]
        transformType: string
        sort: Compare
    }
    

[<AllowNullLiteral>]
[<Interface>]
type CountPatternTransform of CountPatternTransform =
    ``type``: string
    field: FieldRef
    case: U2<string, SignalRef> option
    pattern: U2<string, SignalRef> option
    stopwords: U2<string, SignalRef> option
    ``as``: U2<Vector2<U2<string, SignalRef>>, SignalRef> option

[<AllowNullLiteral>]
[<Interface>]
type ContourTransform of ContourTransform =
    ``type``: string
    signal: string option
    size: U2<ResizeArray<U2<float, SignalRef>>, SignalRef>
    values: U2<ResizeArray<U2<float, SignalRef>>, SignalRef> option
    x: FieldRef option
    y: FieldRef option
    cellSize: U2<float, SignalRef> option
    bandwidth: U2<float, SignalRef> option
    count: U2<float, SignalRef> option
    nice: U2<float, SignalRef> option
    thresholds: U2<ResizeArray<U2<float, SignalRef>>, SignalRef> option

[<AllowNullLiteral>]
[<Interface>]
type CrossTransform of CrossTransform =
    ``type``: string
    filter: ExprString option
    ``as``: U2<Vector2<U2<string, SignalRef>>, SignalRef> option

[<AllowNullLiteral>]
[<Interface>]
type CrossFilterTransform of CrossFilterTransform =
    ``type``: string
    fields: U2<ResizeArray<U2<string, TransformField>>, SignalRef>
    query: U2<ResizeArray<U2<Vector2<U2<float, SignalRef>>, SignalRef>>, SignalRef>
    signal: SignalName option

[<AllowNullLiteral>]
[<Interface>]
type DensityTransform of DensityTransform =
    ``type``: string
    extent: U2<Vector2<U2<float, SignalRef>>, SignalRef> option
    steps: U2<float, SignalRef> option
    minsteps: U2<float, SignalRef> option
    maxsteps: U2<float, SignalRef> option
    ``method``: DensityTransform of DensityTransform.``method`` option
    distribution: U2<Distribution, SignalRef> option
    ``as``: U2<Vector2<U2<string, SignalRef>>, SignalRef> option

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type DensityMethod =
    | pdf
    | cdf

[<AllowNullLiteral>]
[<Interface>]
type DistributionNormal =
    ``function``: string
    mean: U2<float, SignalRef> option
    stdev: U2<float, SignalRef> option

[<AllowNullLiteral>]
[<Interface>]
type DistributionLogNormal =
    ``function``: string
    mean: U2<float, SignalRef> option
    stdev: U2<float, SignalRef> option

[<AllowNullLiteral>]
[<Interface>]
type DistributionUniform =
    ``function``: string
    min: U2<float, SignalRef> option
    max: U2<float, SignalRef> option

[<AllowNullLiteral>]
[<Interface>]
type DistributionKDE =
    ``function``: string
    field: U2<string, TransformField>
    from: DataName option
    bandwidth: U2<float, SignalRef> option

[<AllowNullLiteral>]
[<Interface>]
type DistributionMixture =
    ``function``: string
    field: U2<string, TransformField>
    distributions: U2<ResizeArray<U2<Distribution, SignalRef>>, SignalRef> option
    weights: U2<ResizeArray<U2<float, SignalRef>>, SignalRef> option

type Distribution =
    U5<DistributionNormal, DistributionLogNormal, DistributionUniform, DistributionKDE, DistributionMixture>

[<AllowNullLiteral>]
[<Interface>]
type DotBinTransform of DotBinTransform =
    ``type``: string
    field: FieldRef
    groupby: U2<ResizeArray<FieldRef>, SignalRef> option
    step: U2<float, SignalRef> option
    smooth: U2<bool, SignalRef> option
    ``as``: U2<string, SignalRef> option
    signal: SignalName option

[<AllowNullLiteral>]
[<Interface>]
type ExtentTransform of ExtentTransform =
    ``type``: string
    field: FieldRef
    signal: string option

[<AllowNullLiteral>]
[<Interface>]
type FilterTransform of FilterTransform =
    ``type``: string
    expr: ExprString

[<AllowNullLiteral>]
[<Interface>]
type FlattenTransform of FlattenTransform =
    ``type``: string
    fields: U2<ResizeArray<FieldRef>, SignalRef>
    index: U2<string, SignalRef> option
    ``as``: U2<ResizeArray<U2<string, SignalRef>>, SignalRef> option

[<AllowNullLiteral>]
[<Interface>]
type FoldTransform of FoldTransform =
    ``type``: string
    fields: U2<ResizeArray<FieldRef>, SignalRef>
    ``as``: U2<Vector2<U2<string, SignalRef>>, SignalRef> option

[<AllowNullLiteral>]
[<Interface>]
type ForceTransform of ForceTransform =
    ``type``: string
    ``static``: U2<bool, SignalRef> option
    restart: U2<bool, SignalRef> option
    iterations: U2<float, SignalRef> option
    alpha: U2<float, SignalRef> option
    alphaMin: U2<float, SignalRef> option
    alphaTarget: U2<float, SignalRef> option
    velocityDecay: U2<float, SignalRef> option
    forces: U2<ResizeArray<U2<Force, SignalRef>>, SignalRef> option
    signal: SignalName option

[<AllowNullLiteral>]
[<Interface>]
type ForceCenter =
    force: string
    x: U2<float, SignalRef> option
    y: U2<float, SignalRef> option

[<AllowNullLiteral>]
[<Interface>]
type ForceCollide =
    force: string
    radius: U3<float, SignalRef, ExprRef> option
    strength: U2<float, SignalRef> option
    iterations: U2<float, SignalRef> option

[<AllowNullLiteral>]
[<Interface>]
type ForceLink =
    force: string
    links: DataName option
    id: FieldRef option
    distance: U3<float, SignalRef, ExprRef> option
    strength: U3<float, SignalRef, ExprRef> option
    iterations: U2<float, SignalRef> option

[<AllowNullLiteral>]
[<Interface>]
type ForceNBody =
    force: string
    strength: U3<float, SignalRef, ExprRef> option
    theta: U2<float, SignalRef> option
    distanceMin: U2<float, SignalRef> option
    distanceMax: U2<float, SignalRef> option

[<AllowNullLiteral>]
[<Interface>]
type ForceX =
    force: string
    strength: U2<float, SignalRef> option
    x: FieldRef option

[<AllowNullLiteral>]
[<Interface>]
type ForceY =
    force: string
    strength: U2<float, SignalRef> option
    y: FieldRef option

type Force =
    U6<ForceCenter, ForceCollide, ForceLink, ForceNBody, ForceX, ForceY>

[<AllowNullLiteral>]
[<Interface>]
type FormulaTransform of FormulaTransform =
    ``type``: string
    expr: ExprString
    initonly: bool option
    ``as``: U2<string, SignalRef>

[<AllowNullLiteral>]
[<Interface>]
type GeoJSONTransform of GeoJSONTransform =
    ``type``: string
    fields: U2<Vector2<FieldRef>, SignalRef> option
    geojson: FieldRef option
    signal: SignalName option

[<AllowNullLiteral>]
[<Interface>]
type GeoPointTransform of GeoPointTransform =
    ``type``: string
    projection: ProjectionName
    fields: U2<Vector2<FieldRef>, SignalRef>
    ``as``: U2<Vector2<U2<string, SignalRef>>, SignalRef> option

[<AllowNullLiteral>]
[<Interface>]
type GeoPathTransform of GeoPathTransform =
    ``type``: string
    projection: ProjectionName option
    field: FieldRef option
    pointRadius: U3<float, SignalRef, ExprRef> option
    ``as``: U2<string, SignalRef> option

[<AllowNullLiteral>]
[<Interface>]
type GeoShapeTransform of GeoShapeTransform =
    ``type``: string
    projection: ProjectionName option
    field: FieldRef option
    pointRadius: U3<float, SignalRef, ExprRef> option
    ``as``: U2<string, SignalRef> option

[<AllowNullLiteral>]
[<Interface>]
type GraticuleTransform of GraticuleTransform =
    ``type``: string
    signal: SignalName option
    extent: U2<Vector2<U2<Vector2<U2<float, SignalRef>>, SignalRef>>, SignalRef> option
    extentMajor: U2<Vector2<U2<Vector2<U2<float, SignalRef>>, SignalRef>>, SignalRef> option
    extentMinor: U2<Vector2<U2<Vector2<U2<float, SignalRef>>, SignalRef>>, SignalRef> option
    step: U2<Vector2<U2<float, SignalRef>>, SignalRef> option
    stepMajor: U2<Vector2<U2<float, SignalRef>>, SignalRef> option
    stepMinor: U2<Vector2<U2<float, SignalRef>>, SignalRef> option
    precision: U2<float, SignalRef> option

[<AllowNullLiteral>]
[<Interface>]
type HeatmapTransform of HeatmapTransform =
    ``type``: string
    field: U2<string, TransformField> option
    color: U2<string, TransformField> option
    opacity: U2<float, TransformField> option
    resolve: HeatmapTransform of HeatmapTransform.resolve option
    ``as``: U2<string, SignalRef> option

[<AllowNullLiteral>]
[<Interface>]
type IdentifierTransform of IdentifierTransform =
    ``type``: string
    ``as``: U2<string, SignalRef>

[<AllowNullLiteral>]
[<Interface>]
type ImputeTransform of ImputeTransform =
    ``type``: string
    field: FieldRef
    key: FieldRef
    keyvals: U2<ResizeArray<obj>, SignalRef> option
    groupby: U2<ResizeArray<FieldRef>, SignalRef> option
    ``method``: ImputeTransform of ImputeTransform.``method`` option
    value: obj option

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type ImputeMethod =
    | value
    | median
    | max
    | min
    | mean

[<AllowNullLiteral>]
[<Interface>]
type IsocontourTransform of IsocontourTransform =
    ``type``: string
    field: U2<string, TransformField> option
    scale: U2<float, TransformField> option
    translate: U2<ResizeArray<float>, TransformField> option
    levels: U2<float, SignalRef> option
    smooth: U2<bool, SignalRef> option
    nice: U2<bool, SignalRef> option
    zero: U2<bool, SignalRef> option
    resolve: IsocontourTransform of IsocontourTransform.resolve option
    thresholds: U2<ResizeArray<U2<float, SignalRef>>, SignalRef> option
    ``as``: U2<string, SignalRef> option option

[<AllowNullLiteral>]
[<Interface>]
type JoinAggregateTransform of JoinAggregateTransform =
    ``type``: string
    groupby: U2<ResizeArray<FieldRef>, SignalRef> option
    ops: U2<ResizeArray<JoinAggregateTransform of JoinAggregateTransform.ops.U2.Case1>, SignalRef> option
    fields: U2<ResizeArray<FieldRef option>, SignalRef> option
    ``as``: U2<ResizeArray<U2<string, SignalRef> option>, SignalRef> option

[<AllowNullLiteral>]
[<Interface>]
type KDETransform of KDETransform =
    ``type``: string
    field: FieldRef
    groupby: U2<ResizeArray<FieldRef>, SignalRef> option
    cumulative: U2<bool, SignalRef> option
    counts: U2<bool, SignalRef> option
    bandwidth: U2<float, SignalRef> option
    extent: U2<Vector2<U2<float, SignalRef>>, SignalRef> option
    resolve: KDETransform of KDETransform.resolve option
    steps: U2<float, SignalRef> option
    minsteps: U2<float, SignalRef> option
    maxsteps: U2<float, SignalRef> option
    ``as``: U2<Vector2<U2<string, SignalRef>>, SignalRef> option

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type KDEResolve =
    | shared
    | independent

[<AllowNullLiteral>]
[<Interface>]
type LinkPathTransform of LinkPathTransform =
    ``type``: string
    sourceX: FieldRef option
    sourceY: FieldRef option
    targetX: FieldRef option
    targetY: FieldRef option
    orient: LinkPathTransform of LinkPathTransform.orient option
    shape: LinkPathTransform of LinkPathTransform.shape option
    require: SignalRef option
    ``as``: U2<string, SignalRef> option

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type LinkPathOrient =
    | horizontal
    | vertical
    | radial

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type LinkPathShape =
    | line
    | arc
    | curve
    | diagonal
    | orthogonal

[<AllowNullLiteral>]
[<Interface>]
type KDE2DTransform of KDE2DTransform =
    ``type``: string
    size: U2<ResizeArray<U2<float, SignalRef>>, SignalRef>
    x: U2<string, TransformField>
    y: U2<string, TransformField>
    groupby: U2<ResizeArray<U2<string, TransformField>>, SignalRef> option
    weight: U2<string, TransformField> option
    cellSize: U2<float, SignalRef> option
    bandwidth: U2<ResizeArray<U2<float, SignalRef>>, SignalRef> option
    counts: U2<bool, SignalRef> option
    ``as``: U2<string, SignalRef> option

[<AllowNullLiteral>]
[<Interface>]
type LoessTransform of LoessTransform =
    ``type``: string
    x: FieldRef
    y: FieldRef
    groupby: U2<ResizeArray<FieldRef>, SignalRef> option
    bandwidth: U2<float, SignalRef> option
    ``as``: U2<Vector2<U2<string, SignalRef>>, SignalRef> option

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type LabelAnchor =
    | left
    | right
    | top
    | bottom
    | ``top-left``
    | ``top-right``
    | ``bottom-left``
    | ``bottom-right``
    | middle

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type LineLabelAnchor =
    | start
    | ``end``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type AreaLabelMethod =
    | naive
    | ``reduced-search``
    | floodfill

[<AllowNullLiteral>]
[<Interface>]
type LabelTransform of LabelTransform =
    ``type``: string
    size: U2<Vector2<U2<float, SignalRef>>, SignalRef>
    sort: Compare option
    offset: U3<ResizeArray<float>, float, SignalRef> option
    anchor: LabelTransform of LabelTransform.anchor option
    padding: U2<float, SignalRef> option option
    markIndex: float option
    lineAnchor: LabelTransform of LabelTransform.lineAnchor option
    avoidBaseMark: U2<bool, SignalRef> option
    avoidMarks: ResizeArray<string> option
    ``method``: AreaLabelMethod option
    ``as``: U2<Vector7<U2<string, SignalRef>>, SignalRef> option

[<AllowNullLiteral>]
[<Interface>]
type LookupTransform of LookupTransform =
    ``type``: string
    from: DataName
    key: FieldRef
    fields: U2<ResizeArray<FieldRef>, SignalRef>
    values: U2<ResizeArray<FieldRef>, SignalRef> option
    ``as``: U2<ResizeArray<U2<string, SignalRef>>, SignalRef> option
    ``default``: obj option

[<AllowNullLiteral>]
[<Interface>]
type NestTransform of NestTransform =
    ``type``: string
    keys: U2<ResizeArray<FieldRef>, SignalRef> option
    generate: U2<bool, SignalRef> option

[<AllowNullLiteral>]
[<Interface>]
type PackTransform of PackTransform =
    ``type``: string
    field: FieldRef option
    sort: Compare option
    padding: U2<float, SignalRef> option
    radius: FieldRef option
    size: U2<Vector2<U2<float, SignalRef>>, SignalRef> option
    ``as``: U2<Vector5<U2<string, SignalRef>>, SignalRef> option

[<AllowNullLiteral>]
[<Interface>]
type PartitionTransform of PartitionTransform =
    ``type``: string
    field: FieldRef option
    sort: Compare option
    padding: U2<float, SignalRef> option
    round: U2<bool, SignalRef> option
    size: U2<Vector2<U2<float, SignalRef>>, SignalRef> option
    ``as``: U2<Vector6<U2<string, SignalRef>>, SignalRef> option

[<AllowNullLiteral>]
[<Interface>]
type PieTransform of PieTransform =
    ``type``: string
    field: FieldRef option
    startAngle: U2<float, SignalRef> option
    endAngle: U2<float, SignalRef> option
    sort: U2<bool, SignalRef> option
    ``as``: U2<Vector2<U2<string, SignalRef>>, SignalRef> option

[<AllowNullLiteral>]
[<Interface>]
type PivotTransform of PivotTransform =
    ``type``: string
    field: FieldRef
    value: FieldRef
    groupby: U2<ResizeArray<FieldRef>, SignalRef> option
    limit: U2<float, SignalRef> option
    op: U2<string, SignalRef> option
    key: U2<string, TransformField> option

[<AllowNullLiteral>]
[<Interface>]
type ProjectTransform of ProjectTransform =
    ``type``: string
    fields: U2<ResizeArray<FieldRef>, SignalRef> option
    ``as``: U2<ResizeArray<U2<string, SignalRef> option>, SignalRef> option

[<AllowNullLiteral>]
[<Interface>]
type QuantileTransform of QuantileTransform =
    ``type``: string
    field: FieldRef
    groupby: U2<ResizeArray<FieldRef>, SignalRef> option
    step: U2<float, SignalRef> option
    probs: U2<ResizeArray<float>, SignalRef> option
    ``as``: U2<ResizeArray<U2<string, SignalRef>>, SignalRef> option

[<AllowNullLiteral>]
[<Interface>]
type RegressionTransform of RegressionTransform =
    ``type``: string
    x: FieldRef
    y: FieldRef
    groupby: U2<ResizeArray<FieldRef>, SignalRef> option
    ``method``: RegressionTransform of RegressionTransform.``method`` option
    order: U2<float, SignalRef> option
    extent: U2<float * float, SignalRef> option
    ``params``: U2<bool, SignalRef> option
    ``as``: U2<Vector2<U2<string, SignalRef>>, SignalRef> option

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type RegressionMethod =
    | linear
    | exp
    | log
    | quad
    | poly
    | pow

[<AllowNullLiteral>]
[<Interface>]
type ResolveFilterTransform of ResolveFilterTransform =
    ``type``: string
    ignore: U2<float, SignalRef>
    filter: SignalRef

[<AllowNullLiteral>]
[<Interface>]
type SampleTransform of SampleTransform =
    ``type``: string
    size: U2<float, SignalRef>

[<AllowNullLiteral>]
[<Interface>]
type SequenceTransform of SequenceTransform =
    ``type``: string
    start: U2<float, SignalRef>
    stop: U2<float, SignalRef>
    step: U2<float, SignalRef> option
    ``as``: U2<string, SignalRef> option

[<AllowNullLiteral>]
[<Interface>]
type StackTransform of StackTransform =
    ``type``: string
    field: FieldRef option
    groupby: ResizeArray<FieldRef> option
    sort: Compare option
    offset: StackTransform of StackTransform.offset option
    ``as``: U2<Vector2<U2<string, SignalRef>>, SignalRef> option

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type StackOffset =
    | zero
    | center
    | normalize

[<AllowNullLiteral>]
[<Interface>]
type StratifyTransform of StratifyTransform =
    ``type``: string
    key: FieldRef
    parentKey: FieldRef

[<AllowNullLiteral>]
[<Interface>]
type TimeUnitTransform of TimeUnitTransform =
    ``type``: string
    field: FieldRef
    interval: U2<bool, SignalRef> option
    units: U2<ResizeArray<TimeUnitTransform of TimeUnitTransform.units.U2.Case1>, SignalRef> option
    step: U2<float, SignalRef> option
    timezone: TimeUnitTransform of TimeUnitTransform.timezone option
    ``as``: U2<Vector2<U2<string, SignalRef>>, SignalRef> option
    signal: SignalName option

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type TimeZone =
    | local
    | utc

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type TimeUnit =
    | year
    | quarter
    | month
    | week
    | day
    | date
    | dayofyear
    | hours
    | minutes
    | seconds
    | milliseconds

[<AllowNullLiteral>]
[<Interface>]
type TreeTransform of TreeTransform =
    ``type``: string
    field: FieldRef option
    sort: Compare option
    ``method``: TreeTransform of TreeTransform.``method`` option
    size: U2<Vector2<U2<float, SignalRef>>, SignalRef> option
    nodeSize: U2<Vector2<U2<float, SignalRef>>, SignalRef> option
    separation: U2<bool, SignalRef> option
    ``as``: U2<Vector4<U2<string, SignalRef>>, SignalRef> option

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type TreeMethod =
    | tidy
    | cluster

[<AllowNullLiteral>]
[<Interface>]
type TreeLinksTransform of TreeLinksTransform =
    ``type``: string

[<AllowNullLiteral>]
[<Interface>]
type TreemapTransform of TreemapTransform =
    ``type``: string
    field: FieldRef option
    sort: Compare option
    ``method``: TreemapTransform of TreemapTransform.``method`` option
    padding: U2<float, SignalRef> option
    paddingInner: U2<float, SignalRef> option
    paddingOuter: U2<float, SignalRef> option
    paddingTop: U2<float, SignalRef> option
    paddingRight: U2<float, SignalRef> option
    paddingBottom: U2<float, SignalRef> option
    paddingLeft: U2<float, SignalRef> option
    ratio: U2<float, SignalRef> option
    round: U2<bool, SignalRef> option
    size: U2<Vector2<U2<float, SignalRef>>, SignalRef> option
    ``as``: U2<Vector6<U2<string, SignalRef>>, SignalRef> option

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type TreemapMethod =
    | squarify
    | resquarify
    | binary
    | dice
    | slice
    | slicedice

[<AllowNullLiteral>]
[<Interface>]
type VoronoiTransform of VoronoiTransform =
    ``type``: string
    x: FieldRef
    y: FieldRef
    size: U2<Vector2<U2<float, SignalRef>>, SignalRef> option
    extent: U2<Vector2<U2<Vector2<U2<float, SignalRef>>, SignalRef>>, SignalRef> option
    ``as``: U2<string, SignalRef> option

[<AllowNullLiteral>]
[<Interface>]
type WindowTransform of WindowTransform =
    ``type``: string
    sort: Compare option
    groupby: U2<ResizeArray<FieldRef>, SignalRef> option
    ops: ResizeArray<WindowTransform of WindowTransform.ops> option
    aggregate_params: ResizeArray<float> option
    ``params``: U2<ResizeArray<U2<float, SignalRef> option>, SignalRef> option
    fields: U2<ResizeArray<FieldRef option>, SignalRef> option
    ``as``: U2<ResizeArray<U2<string, SignalRef> option>, SignalRef> option
    frame: U2<Vector2<U2<float, SignalRef> option>, SignalRef> option
    ignorePeers: U2<bool, SignalRef> option

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type WindowOnlyOp =
    | row_number
    | rank
    | dense_rank
    | percent_rank
    | cume_dist
    | ntile
    | lag
    | lead
    | first_value
    | last_value
    | nth_value
    | prev_value
    | next_value

[<AllowNullLiteral>]
[<Interface>]
type WordcloudTransform of WordcloudTransform =
    ``type``: string
    size: U2<Vector2<U2<float, SignalRef>>, SignalRef> option
    font: U2<string, TransformField> option
    fontStyle: U2<FontStyle, TransformField> option
    fontWeight: U2<FontWeight, TransformField> option
    fontSize: U2<float, TransformField> option
    fontSizeRange: U2<Vector2<U2<float, SignalRef>>, SignalRef> option
    rotate: U2<float, TransformField> option
    text: U2<string, TransformField> option
    spiral: WordcloudTransform of WordcloudTransform.spiral option
    padding: U2<float, TransformField> option
    ``as``: U2<Vector7<U2<string, SignalRef>>, SignalRef> option

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type WordcloudSpiral =
    | archimedian
    | rectangular

module Transforms =

    module U51 =

        module Case1 =

            module AggregateTransform =

                module ops =

                    module U2 =

                        [<RequireQualifiedAccess>]
                        [<StringEnum(CaseRules.None)>]
                        type Case1 =
                            | argmax
                            | argmin
                            | average
                            | count
                            | distinct
                            | max
                            | mean
                            | median
                            | min
                            | missing
                            | product
                            | q1
                            | q3
                            | ci0
                            | ci1
                            | stderr
                            | stdev
                            | stdevp
                            | sum
                            | valid
                            | values
                            | variance
                            | variancep
                            | exponential
                            | exponentialb

        module Case8 =

            module DensityTransform of DensityTransform =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type ``method`` =
                    | pdf
                    | cdf

        module Case16 =

            module HeatmapTransform of HeatmapTransform =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type resolve =
                    | independent
                    | shared

        module Case23 =

            module ImputeTransform of ImputeTransform =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type ``method`` =
                    | value
                    | median
                    | max
                    | min
                    | mean

        module Case24 =

            module IsocontourTransform of IsocontourTransform =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type resolve =
                    | shared
                    | independent

        module Case25 =

            module JoinAggregateTransform of JoinAggregateTransform =

                module ops =

                    module U2 =

                        [<RequireQualifiedAccess>]
                        [<StringEnum(CaseRules.None)>]
                        type Case1 =
                            | argmax
                            | argmin
                            | average
                            | count
                            | distinct
                            | max
                            | mean
                            | median
                            | min
                            | missing
                            | product
                            | q1
                            | q3
                            | ci0
                            | ci1
                            | stderr
                            | stdev
                            | stdevp
                            | sum
                            | valid
                            | values
                            | variance
                            | variancep
                            | exponential
                            | exponentialb

        module Case26 =

            module KDETransform of KDETransform =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type resolve =
                    | shared
                    | independent

        module Case28 =

            module LabelTransform of LabelTransform =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type anchor =
                    | left
                    | right
                    | top
                    | bottom
                    | ``top-left``
                    | ``top-right``
                    | ``bottom-left``
                    | ``bottom-right``
                    | middle

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type lineAnchor =
                    | start
                    | ``end``

        module Case29 =

            module LinkPathTransform of LinkPathTransform =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type orient =
                    | horizontal
                    | vertical
                    | radial

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type shape =
                    | line
                    | arc
                    | curve
                    | diagonal
                    | orthogonal

        module Case39 =

            module RegressionTransform of RegressionTransform =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type ``method`` =
                    | linear
                    | exp
                    | log
                    | quad
                    | poly
                    | pow

        module Case43 =

            module StackTransform of StackTransform =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type offset =
                    | zero
                    | center
                    | normalize

        module Case45 =

            module TimeUnitTransform of TimeUnitTransform =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type timezone =
                    | local
                    | utc

                module units =

                    module U2 =

                        [<RequireQualifiedAccess>]
                        [<StringEnum(CaseRules.None)>]
                        type Case1 =
                            | year
                            | quarter
                            | month
                            | week
                            | day
                            | date
                            | dayofyear
                            | hours
                            | minutes
                            | seconds
                            | milliseconds

        module Case46 =

            module TreeTransform of TreeTransform =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type ``method`` =
                    | tidy
                    | cluster

        module Case48 =

            module TreemapTransform of TreemapTransform =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type ``method`` =
                    | squarify
                    | resquarify
                    | binary
                    | dice
                    | slice
                    | slicedice

        module Case50 =

            module WindowTransform of WindowTransform =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type ops =
                    | argmax
                    | argmin
                    | average
                    | count
                    | distinct
                    | max
                    | mean
                    | median
                    | min
                    | missing
                    | product
                    | q1
                    | q3
                    | ci0
                    | ci1
                    | stderr
                    | stdev
                    | stdevp
                    | sum
                    | valid
                    | values
                    | variance
                    | variancep
                    | exponential
                    | exponentialb
                    | row_number
                    | rank
                    | dense_rank
                    | percent_rank
                    | cume_dist
                    | ntile
                    | lag
                    | lead
                    | first_value
                    | last_value
                    | nth_value
                    | prev_value
                    | next_value

        module Case51 =

            module WordcloudTransform of WordcloudTransform =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type spiral =
                    | archimedian
                    | rectangular

module AggregateTransform of AggregateTransform =

    module ops =

        module U2 =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type Case1 =
                | argmax
                | argmin
                | average
                | count
                | distinct
                | max
                | mean
                | median
                | min
                | missing
                | product
                | q1
                | q3
                | ci0
                | ci1
                | stderr
                | stdev
                | stdevp
                | sum
                | valid
                | values
                | variance
                | variancep
                | exponential
                | exponentialb

module DensityTransform of DensityTransform =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type ``method`` =
        | pdf
        | cdf

module HeatmapTransform of HeatmapTransform =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type resolve =
        | independent
        | shared

module ImputeTransform of ImputeTransform =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type ``method`` =
        | value
        | median
        | max
        | min
        | mean

module IsocontourTransform of IsocontourTransform =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type resolve =
        | shared
        | independent

module JoinAggregateTransform of JoinAggregateTransform =

    module ops =

        module U2 =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type Case1 =
                | argmax
                | argmin
                | average
                | count
                | distinct
                | max
                | mean
                | median
                | min
                | missing
                | product
                | q1
                | q3
                | ci0
                | ci1
                | stderr
                | stdev
                | stdevp
                | sum
                | valid
                | values
                | variance
                | variancep
                | exponential
                | exponentialb

module KDETransform of KDETransform =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type resolve =
        | shared
        | independent

module LinkPathTransform of LinkPathTransform =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type orient =
        | horizontal
        | vertical
        | radial

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type shape =
        | line
        | arc
        | curve
        | diagonal
        | orthogonal

module LabelTransform of LabelTransform =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type anchor =
        | left
        | right
        | top
        | bottom
        | ``top-left``
        | ``top-right``
        | ``bottom-left``
        | ``bottom-right``
        | middle

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type lineAnchor =
        | start
        | ``end``

module RegressionTransform of RegressionTransform =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type ``method`` =
        | linear
        | exp
        | log
        | quad
        | poly
        | pow

module StackTransform of StackTransform =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type offset =
        | zero
        | center
        | normalize

module TimeUnitTransform of TimeUnitTransform =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type timezone =
        | local
        | utc

    module units =

        module U2 =

            [<RequireQualifiedAccess>]
            [<StringEnum(CaseRules.None)>]
            type Case1 =
                | year
                | quarter
                | month
                | week
                | day
                | date
                | dayofyear
                | hours
                | minutes
                | seconds
                | milliseconds

module TreeTransform of TreeTransform =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type ``method`` =
        | tidy
        | cluster

module TreemapTransform of TreemapTransform =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type ``method`` =
        | squarify
        | resquarify
        | binary
        | dice
        | slice
        | slicedice

module WindowTransform of WindowTransform =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type ops =
        | argmax
        | argmin
        | average
        | count
        | distinct
        | max
        | mean
        | median
        | min
        | missing
        | product
        | q1
        | q3
        | ci0
        | ci1
        | stderr
        | stdev
        | stdevp
        | sum
        | valid
        | values
        | variance
        | variancep
        | exponential
        | exponentialb
        | row_number
        | rank
        | dense_rank
        | percent_rank
        | cume_dist
        | ntile
        | lag
        | lead
        | first_value
        | last_value
        | nth_value
        | prev_value
        | next_value

module WordcloudTransform of WordcloudTransform =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type spiral =
        | archimedian
        | rectangular
    

type Transforms =
    | AggregateTransform of AggregateTransform
    | BinTransform of BinTransform
    | CollectTransform of CollectTransform
    | CountPatternTransform of CountPatternTransform
    | ContourTransform of ContourTransform
    | CrossTransform of CrossTransform
    | CrossFilterTransform of CrossFilterTransform
    | DensityTransform of DensityTransform
    | DotBinTransform of DotBinTransform
    | ExtentTransform of ExtentTransform
    | FilterTransform of FilterTransform
    | FlattenTransform of FlattenTransform
    | FoldTransform of FoldTransform
    | ForceTransform of ForceTransform
    | FormulaTransform of FormulaTransform
    | HeatmapTransform of HeatmapTransform
    | GeoJSONTransform of GeoJSONTransform
    | GeoPathTransform of GeoPathTransform
    | GeoPointTransform of GeoPointTransform
    | GeoShapeTransform of GeoShapeTransform
    | GraticuleTransform of GraticuleTransform
    | IdentifierTransform of IdentifierTransform
    | ImputeTransform of ImputeTransform
    | IsocontourTransform of IsocontourTransform
    | JoinAggregateTransform of JoinAggregateTransform
    | KDETransform of KDETransform
    | KDE2DTransform of KDE2DTransform
    | LabelTransform of LabelTransform
    | LinkPathTransform of LinkPathTransform
    | LoessTransform of LoessTransform
    | LookupTransform of LookupTransform
    | NestTransform of NestTransform
    | PackTransform of PackTransform
    | PartitionTransform of PartitionTransform
    | PieTransform of PieTransform
    | PivotTransform of PivotTransform
    | ProjectTransform of ProjectTransform
    | QuantileTransform of QuantileTransform
    | RegressionTransform of RegressionTransform
    | ResolveFilterTransform of ResolveFilterTransform
    | SampleTransform of SampleTransform
    | SequenceTransform of SequenceTransform
    | StackTransform of StackTransform
    | StratifyTransform of StratifyTransform
    | TimeUnitTransform of TimeUnitTransform
    | TreeTransform of TreeTransform
    | TreeLinksTransform of TreeLinksTransform
    | TreemapTransform of TreemapTransform
    | VoronoiTransform of VoronoiTransform
    | WindowTransform of WindowTransform
    | WordcloudTransform of WordcloudTransform

