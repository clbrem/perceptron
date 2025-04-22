namespace Vega

open Fable.Core
open Fable.Core.JsInterop
open System



type GeoJsonFeature =
    Feature

type GeoJsonFeatureCollection =
    FeatureCollection

type Fit =
    U3<GeoJsonFeature, GeoJsonFeatureCollection, ResizeArray<GeoJsonFeature>>

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type ProjectionType =
    | albers
    | albersUsa
    | azimuthalEqualArea
    | azimuthalEquidistant
    | conicConformal
    | conicEqualArea
    | conicEquidistant
    | equalEarth
    | equirectangular
    | gnomonic
    | identity
    | mercator
    | naturalEarth1
    | orthographic
    | stereographic
    | transverseMercator

[<AllowNullLiteral>]
[<Interface>]
type BaseProjection =
    abstract member ``type``: BaseProjection.``type`` option with get, set
    /// <summary>
    /// The projection's clipping circle radius to the specified angle in degrees. If <c>null</c>, switches to [antimeridian](http://bl.ocks.org/mbostock/3788999) cutting rather than small-circle clipping.
    /// </summary>
    abstract member clipAngle: U2<float, SignalRef> option with get, set
    /// <summary>
    /// The projection's viewport clip extent to the specified bounds in pixels. The extent bounds are specified as an array <c>[[x0, y0], [x1, y1]]</c>, where <c>x0</c> is the left-side of the viewport, <c>y0</c> is the top, <c>x1</c> is the right and <c>y1</c> is the bottom. If <c>null</c>, no viewport clipping is performed.
    /// </summary>
    abstract member clipExtent: U2<Vector2<Vector2<U2<float, SignalRef>>>, SignalRef> option with get, set
    /// <summary>
    /// The projection’s scale factor. The default scale is projection-specific. The scale factor corresponds linearly to the distance between projected points; however, scale factor values are not equivalent across projections.
    /// </summary>
    abstract member scale: U2<float, SignalRef> option with get, set
    abstract member translate: U2<Vector2<U2<float, SignalRef>>, SignalRef> option with get, set
    /// <summary>
    /// The projection's center, a two-element array of longitude and latitude in degrees.
    ///
    /// __Default value:__ <c>[0, 0]</c>
    /// </summary>
    abstract member center: U2<Vector2<U2<float, SignalRef>>, SignalRef> option with get, set
    /// <summary>
    /// The projection's three-axis rotation to the specified angles, which must be a two- or three-element array of numbers [<c>lambda</c>, <c>phi</c>, <c>gamma</c>] specifying the rotation angles in degrees about each spherical axis. (These correspond to yaw, pitch and roll.)
    ///
    /// __Default value:__ <c>[0, 0, 0]</c>
    /// </summary>
    abstract member rotate: U3<Vector2<U2<float, SignalRef>>, Vector3<U2<float, SignalRef>>, SignalRef> option with get, set
    /// <summary>
    /// For conic projections, the [two standard parallels](https://en.wikipedia.org/wiki/Map_projection#Conic) that define the map layout. The default depends on the specific conic projection used.
    /// </summary>
    abstract member parallels: U2<ResizeArray<U2<float, SignalRef>>, SignalRef> option with get, set
    /// <summary>
    /// The default radius (in pixels) to use when drawing GeoJSON <c>Point</c> and <c>MultiPoint</c> geometries. This parameter sets a constant default value. To modify the point radius in response to data, see the corresponding parameter of the GeoPath and GeoShape transforms.
    ///
    /// __Default value:__ <c>4.5</c>
    /// </summary>
    abstract member pointRadius: U2<float, SignalRef> option with get, set
    /// <summary>
    /// The threshold for the projection's [adaptive resampling](http://bl.ocks.org/mbostock/3795544) to the specified value in pixels. This value corresponds to the [Douglas–Peucker distance](http://en.wikipedia.org/wiki/Ramer%E2%80%93Douglas%E2%80%93Peucker_algorithm). If precision is not specified, returns the projection's current resampling precision which defaults to <c>√0.5 ≅ 0.70710…</c>.
    /// </summary>
    abstract member precision: U2<float, SignalRef> option with get, set
    abstract member fit: U3<Fit, ResizeArray<Fit>, SignalRef> option with get, set
    abstract member extent: U2<Vector2<Vector2<U2<float, SignalRef>>>, SignalRef> option with get, set
    /// <summary>
    /// Used in conjunction with fit, provides the width and height in pixels of the area to which the projection should be automatically fit.
    /// </summary>
    abstract member size: U2<Vector2<U2<float, SignalRef>>, SignalRef> option with get, set
    /// <summary>
    /// The coefficient parameter for the <c>hammer</c> projection.
    ///
    /// __Default value:__ <c>2</c>
    /// </summary>
    abstract member coefficient: U2<float, SignalRef> option with get, set
    /// <summary>
    /// For the <c>satellite</c> projection, the distance from the center of the
    /// sphere to the point of view, as a proportion of the sphere’s radius.
    /// The recommended maximum clip angle for a given <c>distance</c> is
    /// acos(1 / distance) converted to degrees. If tilt is also
    /// applied, then more conservative clipping may be necessary.
    ///
    /// __Default value:__ <c>2.0</c>
    /// </summary>
    abstract member distance: U2<float, SignalRef> option with get, set
    /// <summary>
    /// The fraction parameter for the <c>bottomley</c> projection.
    ///
    /// __Default value:__ <c>0.5</c>, corresponding to a sin(ψ) where ψ = π/6.
    /// </summary>
    abstract member fraction: U2<float, SignalRef> option with get, set
    /// <summary>
    /// The number of lobes in projections that support multi-lobe views:
    /// <c>berghaus</c>, <c>gingery</c>, or <c>healpix</c>.
    /// The default value varies based on the projection type.
    /// </summary>
    abstract member lobes: U2<float, SignalRef> option with get, set
    /// <summary>
    /// The parallel parameter for projections that support it:
    /// <c>armadillo</c>, <c>bonne</c>, <c>craig</c>, <c>cylindricalEqualArea</c>,
    /// <c>cylindricalStereographic</c>, <c>hammerRetroazimuthal</c>, <c>loximuthal</c>,
    /// or <c>rectangularPolyconic</c>.
    /// The default value varies based on the projection type.
    /// </summary>
    abstract member ``parallel``: U2<float, SignalRef> option with get, set
    /// <summary>
    /// The radius parameter for the <c>airy</c> or <c>gingery</c> projection.
    /// The default value varies based on the projection type.
    /// </summary>
    abstract member radius: U2<float, SignalRef> option with get, set
    /// <summary>
    /// The ratio parameter for the <c>hill</c>, <c>hufnagel</c>, or <c>wagner</c> projections.
    /// The default value varies based on the projection type.
    /// </summary>
    abstract member ratio: U2<float, SignalRef> option with get, set
    /// <summary>
    /// The spacing parameter for the <c>lagrange</c> projection.
    ///
    /// __Default value:__ <c>0.5</c>
    /// </summary>
    abstract member spacing: U2<float, SignalRef> option with get, set
    /// <summary>
    /// The tilt angle (in degrees) for the <c>satellite</c> projection.
    ///
    /// __Default value:__ <c>0</c>.
    /// </summary>
    abstract member tilt: U2<float, SignalRef> option with get, set
    /// <summary>
    /// Sets whether or not the x-dimension is reflected (negated) in the output.
    /// </summary>
    abstract member reflectX: U2<bool, SignalRef> option with get, set
    /// <summary>
    /// Sets whether or not the y-dimension is reflected (negated) in the output.
    /// </summary>
    abstract member reflectY: U2<bool, SignalRef> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Projection =
    inherit BaseProjection
    abstract member name: string with get, set

module BaseProjection =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type ``type`` =
        | albers
        | albersUsa
        | azimuthalEqualArea
        | azimuthalEquidistant
        | conicConformal
        | conicEqualArea
        | conicEquidistant
        | equalEarth
        | equirectangular
        | gnomonic
        | identity
        | mercator
        | naturalEarth1
        | orthographic
        | stereographic
        | transverseMercator

module Projection =

    module BaseProjection =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type ``type`` =
            | albers
            | albersUsa
            | azimuthalEqualArea
            | azimuthalEquidistant
            | conicConformal
            | conicEqualArea
            | conicEquidistant
            | equalEarth
            | equirectangular
            | gnomonic
            | identity
            | mercator
            | naturalEarth1
            | orthographic
            | stereographic
            | transverseMercator
