namespace Vega

open Fable.Core




type KeepSignal<'T> =
    'T

[<AllowNullLiteral>]
[<Interface>]
type ExcludeMappedValueRef<'T> =
    interface end

[<AllowNullLiteral>]
[<Interface>]
type Config =
    abstract member autosize: U2<AutoSize, SignalRef> option with get, set
    abstract member background: U2<Color, SignalRef> option option with get, set
    abstract member padding: U2<Padding, SignalRef> option with get, set
    abstract member group: obj option with get, set
    abstract member events: Config.events option with get, set
    abstract member locale: Locale option with get, set
    /// <summary>
    /// A delimiter, such as a newline character, upon which to break text strings into multiple lines. This property provides a global default for text marks, which is overridden by mark or style config settings, and by the "lineBreak" mark encoding channel. If signal-valued, either string or regular expression (regexp) values are valid.
    /// </summary>
    abstract member lineBreak: U2<string, SignalRef> option with get, set
    abstract member style: Config.style option with get, set
    abstract member legend: LegendConfig option with get, set
    abstract member title: TitleConfig option with get, set
    abstract member projection: ProjectionConfig option with get, set
    abstract member range: RangeConfig option with get, set
    abstract member signals: ResizeArray<U2<InitSignal, NewSignal>> option with get, set

/// <summary>
/// The defaults object should have a single property: either "prevent" (to indicate which events should have default behavior suppressed) or "allow" (to indicate only those events whose default behavior should be allowed).
/// </summary>
/// 
type DefaultsConfig = {
    prevent: bool option
    allow: bool option
}
    

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type MarkConfigKeys =
    | mark

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type StrokeCap =
    | butt
    | round
    | square

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type StrokeJoin =
    | miter
    | round
    | bevel

[<AllowNullLiteral>]
[<Interface>]
type MarkConfig =
    /// <summary>
    /// A boolean flag indicating if [ARIA attributes](https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA) should be included (SVG output only).
    /// If <c>false</c>, the "aria-hidden" attribute will be set on the output SVG element, removing the mark item from the ARIA accessibility tree.
    /// </summary>
    abstract member aria: U2<bool, SignalRef> option with get, set
    /// <summary>
    /// Sets the type of user interface element of the mark item for [ARIA accessibility](https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA) (SVG output only).
    /// If specified, this property determines the "role" attribute.
    /// Warning: this property is experimental and may be changed in the future.
    /// </summary>
    abstract member ariaRole: U2<string, SignalRef> option with get, set
    /// <summary>
    /// A human-readable, author-localized description for the role of the mark item for [ARIA accessibility](https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA) (SVG output only).
    /// If specified, this property determines the "aria-roledescription" attribute.
    /// Warning: this property is experimental and may be changed in the future.
    /// </summary>
    abstract member ariaRoleDescription: U2<string, SignalRef> option with get, set
    /// <summary>
    /// A text description of the mark item for [ARIA accessibility](https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA) (SVG output only).
    /// If specified, this property determines the ["aria-label" attribute](https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA/ARIA_Techniques/Using_the_aria-label_attribute).
    /// </summary>
    abstract member description: U2<string, SignalRef> option with get, set
    /// <summary>
    /// Width of the marks.
    /// </summary>
    abstract member width: U2<float, SignalRef> option with get, set
    /// <summary>
    /// Height of the marks.
    /// </summary>
    abstract member height: U2<float, SignalRef> option with get, set
    /// <summary>
    /// Whether to keep aspect ratio of image marks.
    /// </summary>
    abstract member aspect: U2<bool, SignalRef> option with get, set
    /// <summary>
    /// The URL of the image file for image marks.
    /// </summary>
    abstract member url: U2<URI, SignalRef> option with get, set
    /// <summary>
    /// A boolean flag (default true) indicating if the image should be smoothed when resized. If false, individual pixels should be scaled directly rather than interpolated with smoothing. For SVG rendering, this option may not work in some browsers due to lack of standardization.
    /// </summary>
    abstract member smooth: U2<bool, SignalRef> option with get, set
    /// <summary>
    /// Default fill color.
    ///
    /// __Default value:__ (None)
    /// </summary>
    abstract member fill: U3<Color, Gradient, SignalRef> option option with get, set
    /// <summary>
    /// Default stroke color.
    ///
    /// __Default value:__ (None)
    /// </summary>
    abstract member stroke: U3<Color, Gradient, SignalRef> option option with get, set
    /// <summary>
    /// The overall opacity (value between [0,1]).
    /// </summary>
    abstract member opacity: U2<float, SignalRef> option with get, set
    /// <summary>
    /// The fill opacity (value between [0,1]).
    ///
    /// __Default value:__ <c>1</c>
    /// </summary>
    abstract member fillOpacity: U2<float, SignalRef> option with get, set
    /// <summary>
    /// The stroke opacity (value between [0,1]).
    ///
    /// __Default value:__ <c>1</c>
    /// </summary>
    abstract member strokeOpacity: U2<float, SignalRef> option with get, set
    /// <summary>
    /// The color blend mode for drawing an item on its current background. Any valid [CSS mix-blend-mode](https://developer.mozilla.org/en-US/docs/Web/CSS/mix-blend-mode) value can be used.
    ///
    /// __Default value: <c>"source-over"</c>
    /// </summary>
    abstract member blend: Blend option with get, set
    /// <summary>
    /// The stroke width, in pixels.
    /// </summary>
    abstract member strokeWidth: U2<float, SignalRef> option with get, set
    /// <summary>
    /// An array of alternating stroke, space lengths for creating dashed or dotted lines.
    /// </summary>
    abstract member strokeDash: U2<ResizeArray<float>, SignalRef> option with get, set
    /// <summary>
    /// The offset (in pixels) into which to begin drawing with the stroke dash array.
    /// </summary>
    abstract member strokeDashOffset: U2<float, SignalRef> option with get, set
    /// <summary>
    /// The offset in pixels at which to draw the group stroke and fill. If unspecified, the default behavior is to dynamically offset stroked groups such that 1 pixel stroke widths align with the pixel grid.
    /// </summary>
    abstract member strokeOffset: U2<float, SignalRef> option with get, set
    /// <summary>
    /// The stroke cap for line ending style. One of <c>"butt"</c>, <c>"round"</c>, or <c>"square"</c>.
    ///
    /// __Default value:__ <c>"butt"</c>
    /// </summary>
    abstract member strokeCap: MarkConfig.strokeCap option with get, set
    /// <summary>
    /// The stroke line join method. One of <c>"miter"</c>, <c>"round"</c> or <c>"bevel"</c>.
    ///
    /// __Default value:__ <c>"miter"</c>
    /// </summary>
    abstract member strokeJoin: MarkConfig.strokeJoin option with get, set
    /// <summary>
    /// The miter limit at which to bevel a line join.
    /// </summary>
    abstract member strokeMiterLimit: U2<float, SignalRef> option with get, set
    /// <summary>
    /// The orientation of the area mark. One of <c>horizontal</c> or <c>vertical</c> (the default). With a vertical orientation, an area mark is defined by the <c>x</c>, <c>y</c>, and (<c>y2</c> or <c>height</c>) properties; with a horizontal orientation, the <c>y</c>, <c>x</c> and (<c>x2</c> or <c>width</c>) properties must be specified instead.
    /// </summary>
    abstract member orient: U2<Orientation, SignalRef> option with get, set
    /// <summary>
    /// The line interpolation method to use for line and area marks. One of the following:
    /// - <c>"linear"</c>: piecewise linear segments, as in a polyline.
    /// - <c>"linear-closed"</c>: close the linear segments to form a polygon.
    /// - <c>"step"</c>: alternate between horizontal and vertical segments, as in a step function.
    /// - <c>"step-before"</c>: alternate between vertical and horizontal segments, as in a step function.
    /// - <c>"step-after"</c>: alternate between horizontal and vertical segments, as in a step function.
    /// - <c>"basis"</c>: a B-spline, with control point duplication on the ends.
    /// - <c>"basis-open"</c>: an open B-spline; may not intersect the start or end.
    /// - <c>"basis-closed"</c>: a closed B-spline, as in a loop.
    /// - <c>"cardinal"</c>: a Cardinal spline, with control point duplication on the ends.
    /// - <c>"cardinal-open"</c>: an open Cardinal spline; may not intersect the start or end, but will intersect other control points.
    /// - <c>"cardinal-closed"</c>: a closed Cardinal spline, as in a loop.
    /// - <c>"bundle"</c>: equivalent to basis, except the tension parameter is used to straighten the spline.
    /// - <c>"monotone"</c>: cubic interpolation that preserves monotonicity in y.
    /// </summary>
    abstract member interpolate: U2<Interpolate, SignalRef> option with get, set
    /// <summary>
    /// Depending on the interpolation type, sets the tension parameter (for line and area marks).
    /// </summary>
    abstract member tension: U2<float, SignalRef> option with get, set
    /// <summary>
    /// Shape of the point marks. Supported values include:
    /// - plotting shapes: <c>"circle"</c>, <c>"square"</c>, <c>"cross"</c>, <c>"diamond"</c>, <c>"triangle-up"</c>, <c>"triangle-down"</c>, <c>"triangle-right"</c>, or <c>"triangle-left"</c>.
    /// - the line symbol <c>"stroke"</c>
    /// - centered directional shapes <c>"arrow"</c>, <c>"wedge"</c>, or <c>"triangle"</c>
    /// - a custom [SVG path string](https://developer.mozilla.org/en-US/docs/Web/SVG/Tutorial/Paths) (For correct sizing, custom shape paths should be defined within a square bounding box with coordinates ranging from -1 to 1 along both the x and y dimensions.)
    ///
    /// __Default value:__ <c>"circle"</c>
    /// </summary>
    abstract member shape: U3<SymbolShape, string, SignalRef> option with get, set
    /// <summary>
    /// The area in pixels of the symbols bounding box. Note that this value sets the area of the symbol; the side lengths will increase with the square root of this value.
    ///
    /// __Default value:__ <c>30</c>
    /// </summary>
    abstract member size: U2<float, SignalRef> option with get, set
    /// <summary>
    /// The horizontal alignment of the text. One of <c>"left"</c>, <c>"right"</c>, <c>"center"</c>.
    /// </summary>
    abstract member align: U2<Align, SignalRef> option with get, set
    /// <summary>
    /// The rotation angle of the text, in degrees.
    /// </summary>
    abstract member angle: U2<float, SignalRef> option with get, set
    /// <summary>
    /// The start angle in radians for arc marks.
    /// A value of <c>0</c> indicates up (north), increasing values proceed clockwise.
    /// </summary>
    abstract member startAngle: U2<float, SignalRef> option with get, set
    /// <summary>
    /// The end angle in radians for arc marks.
    /// A value of <c>0</c> indicates up (north), increasing values proceed clockwise.
    /// </summary>
    abstract member endAngle: U2<float, SignalRef> option with get, set
    /// <summary>
    /// The angular padding applied to sides of the arc, in radians.
    /// </summary>
    abstract member padAngle: U2<float, SignalRef> option with get, set
    /// <summary>
    /// The inner radius in pixels of arc marks.
    ///
    /// __Default value:__ <c>0</c>
    /// </summary>
    abstract member innerRadius: U2<float, SignalRef> option with get, set
    /// <summary>
    /// The outer radius in pixels of arc marks.
    ///
    /// __Default value:__ <c>0</c>
    /// </summary>
    abstract member outerRadius: U2<float, SignalRef> option with get, set
    /// <summary>
    /// The vertical alignment of the text. One of <c>"top"</c>, <c>"bottom"</c>, <c>"middle"</c>, <c>"alphabetic"</c>.
    ///
    /// __Default value:__ <c>"middle"</c>
    /// </summary>
    abstract member baseline: U2<TextBaseline, SignalRef> option with get, set
    /// <summary>
    /// The direction of the text. One of <c>"ltr"</c> (left-to-right) or <c>"rtl"</c> (right-to-left). This property determines on which side is truncated in response to the limit parameter.
    ///
    /// __Default value:__ <c>"ltr"</c>
    /// </summary>
    abstract member dir: U2<TextDirection, SignalRef> option with get, set
    /// <summary>
    /// The horizontal offset, in pixels, between the text label and its anchor point. The offset is applied after rotation by the _angle_ property.
    /// </summary>
    abstract member dx: U2<float, SignalRef> option with get, set
    /// <summary>
    /// The vertical offset, in pixels, between the text label and its anchor point. The offset is applied after rotation by the _angle_ property.
    /// </summary>
    abstract member dy: U2<float, SignalRef> option with get, set
    /// <summary>
    /// The ellipsis string for text truncated in response to the limit parameter.
    ///
    /// __Default value:__ <c>"…"</c>
    /// </summary>
    abstract member ellipsis: string option with get, set
    /// <summary>
    /// Polar coordinate radial offset, in pixels, of the text label from the origin determined by the <c>x</c> and <c>y</c> properties.
    /// </summary>
    abstract member radius: U2<float, SignalRef> option with get, set
    /// <summary>
    /// The maximum length of the text mark in pixels. The text value will be automatically truncated if the rendered size exceeds the limit.
    ///
    /// __Default value:__ <c>0</c> -- indicating no limit
    /// </summary>
    abstract member limit: U2<float, SignalRef> option with get, set
    /// <summary>
    /// A delimiter, such as a newline character, upon which to break text strings into multiple lines. This property is ignored if the text is array-valued.
    /// </summary>
    abstract member lineBreak: U2<string, SignalRef> option with get, set
    /// <summary>
    /// The line height in pixels (the spacing between subsequent lines of text) for multi-line text marks.
    /// </summary>
    abstract member lineHeight: U2<float, SignalRef> option with get, set
    /// <summary>
    /// Polar coordinate angle, in radians, of the text label from the origin determined by the <c>x</c> and <c>y</c> properties. Values for <c>theta</c> follow the same convention of <c>arc</c> mark <c>startAngle</c> and <c>endAngle</c> properties: angles are measured in radians, with <c>0</c> indicating "north".
    /// </summary>
    abstract member theta: U2<float, SignalRef> option with get, set
    /// <summary>
    /// The typeface to set the text in (e.g., <c>"Helvetica Neue"</c>).
    /// </summary>
    abstract member font: U2<string, SignalRef> option with get, set
    /// <summary>
    /// The font size, in pixels.
    ///
    /// __Default value:__ <c>11</c>
    /// </summary>
    abstract member fontSize: U2<float, SignalRef> option with get, set
    /// <summary>
    /// The font style (e.g., <c>"italic"</c>).
    /// </summary>
    abstract member fontStyle: U2<FontStyle, SignalRef> option with get, set
    /// <summary>
    /// The font weight.
    /// This can be either a string (e.g <c>"bold"</c>, <c>"normal"</c>) or a number (<c>100</c>, <c>200</c>, <c>300</c>, ..., <c>900</c> where <c>"normal"</c> = <c>400</c> and <c>"bold"</c> = <c>700</c>).
    /// </summary>
    abstract member fontWeight: U2<FontWeight, SignalRef> option with get, set
    /// <summary>
    /// Placeholder text if the <c>text</c> channel is not specified
    /// </summary>
    abstract member text: U2<Text, SignalRef> option with get, set
    /// <summary>
    /// A URL to load upon mouse click. If defined, the mark acts as a hyperlink.
    /// </summary>
    abstract member href: U2<URI, SignalRef> option with get, set
    /// <summary>
    /// The tooltip text to show upon mouse hover.
    /// </summary>
    abstract member tooltip: U2<string, SignalRef> option with get, set
    /// <summary>
    /// The mouse cursor used over the mark. Any valid [CSS cursor type](https://developer.mozilla.org/en-US/docs/Web/CSS/cursor#Values) can be used.
    /// </summary>
    abstract member cursor: MarkConfig.cursor option with get, set
    /// <summary>
    /// The radius in pixels of rounded rectangles or arcs' corners.
    ///
    /// __Default value:__ <c>0</c>
    /// </summary>
    abstract member cornerRadius: U2<float, SignalRef> option with get, set
    /// <summary>
    /// The radius in pixels of rounded rectangles' top right corner.
    ///
    /// __Default value:__ <c>0</c>
    /// </summary>
    abstract member cornerRadiusTopLeft: U2<float, SignalRef> option with get, set
    /// <summary>
    /// The radius in pixels of rounded rectangles' top left corner.
    ///
    /// __Default value:__ <c>0</c>
    /// </summary>
    abstract member cornerRadiusTopRight: U2<float, SignalRef> option with get, set
    /// <summary>
    /// The radius in pixels of rounded rectangles' bottom right corner.
    ///
    /// __Default value:__ <c>0</c>
    /// </summary>
    abstract member cornerRadiusBottomRight: U2<float, SignalRef> option with get, set
    /// <summary>
    /// The radius in pixels of rounded rectangles' bottom left corner.
    ///
    /// __Default value:__ <c>0</c>
    /// </summary>
    abstract member cornerRadiusBottomLeft: U2<float, SignalRef> option with get, set

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type Cursor =
    | auto
    | ``default``
    | none
    | ``context-menu``
    | help
    | pointer
    | progress
    | wait
    | cell
    | crosshair
    | text
    | ``vertical-text``
    | alias
    | copy
    | move
    | ``no-drop``
    | ``not-allowed``
    | ``e-resize``
    | ``n-resize``
    | ``ne-resize``
    | ``nw-resize``
    | ``s-resize``
    | ``se-resize``
    | ``sw-resize``
    | ``w-resize``
    | ``ew-resize``
    | ``ns-resize``
    | ``nesw-resize``
    | ``nwse-resize``
    | ``col-resize``
    | ``row-resize``
    | ``all-scroll``
    | ``zoom-in``
    | ``zoom-out``
    | grab
    | grabbing

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type AxisConfigKeys =
    | axis
    | axisX
    | axisY
    | axisTop
    | axisRight
    | axisBottom
    | axisLeft
    | axisBand

type AxisConfig =
    ExcludeMappedValueRef<BaseAxis>

[<AllowNullLiteral>]
[<Interface>]
type LegendConfig =
    inherit ExcludeMappedValueRef<BaseLegend>
    /// <summary>
    /// The default direction (<c>"horizontal"</c> or <c>"vertical"</c>) for gradient legends.
    ///
    /// __Default value:__ <c>"vertical"</c>.
    /// </summary>
    abstract member gradientDirection: Orientation option with get, set
    /// <summary>
    /// The maximum allowed length in pixels of color ramp gradient labels.
    /// </summary>
    abstract member gradientLabelLimit: U2<float, SignalRef> option with get, set
    /// <summary>
    /// Vertical offset in pixels for color ramp gradient labels.
    ///
    /// __Default value:__ <c>2</c>.
    /// </summary>
    abstract member gradientLabelOffset: U2<float, SignalRef> option with get, set
    /// <summary>
    /// Default fill color for legend symbols. Only applied if there is no <c>"fill"</c> scale color encoding for the legend.
    ///
    /// __Default value:__ <c>"transparent"</c>.
    /// </summary>
    abstract member symbolBaseFillColor: U2<Color, SignalRef> option option with get, set
    /// <summary>
    /// Default stroke color for legend symbols. Only applied if there is no <c>"fill"</c> scale color encoding for the legend.
    ///
    /// __Default value:__ <c>"gray"</c>.
    /// </summary>
    abstract member symbolBaseStrokeColor: U2<Color, SignalRef> option option with get, set
    /// <summary>
    /// The default direction (<c>"horizontal"</c> or <c>"vertical"</c>) for symbol legends.
    ///
    /// __Default value:__ <c>"vertical"</c>.
    /// </summary>
    abstract member symbolDirection: Orientation option with get, set
    /// <summary>
    /// Border stroke dash pattern for the full legend.
    /// </summary>
    abstract member strokeDash: U2<ResizeArray<float>, SignalRef> option with get, set
    /// <summary>
    /// Border stroke width for the full legend.
    /// </summary>
    abstract member strokeWidth: U2<float, SignalRef> option with get, set
    /// <summary>
    /// Legend orient group layout parameters.
    /// </summary>
    abstract member layout: LegendLayout option with get, set

[<AllowNullLiteral>]
[<Interface>]
type BaseLegendLayout =
    /// <summary>
    /// The anchor point for legend orient group layout.
    /// </summary>
    abstract member anchor: U2<TitleAnchor, SignalRef> option with get, set
    /// <summary>
    /// The bounds calculation to use for legend orient group layout.
    /// </summary>
    abstract member bounds: LayoutBounds option with get, set
    /// <summary>
    /// A flag to center legends within a shared orient group.
    /// </summary>
    abstract member center: U2<bool, SignalRef> option with get, set
    /// <summary>
    /// The layout direction for legend orient group layout.
    /// </summary>
    abstract member direction: U2<Orientation, SignalRef> option with get, set
    /// <summary>
    /// The pixel margin between legends within a orient group.
    /// </summary>
    abstract member margin: U2<float, SignalRef> option with get, set
    /// <summary>
    /// The pixel offset from the chart body for a legend orient group.
    /// </summary>
    abstract member offset: U2<float, SignalRef> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type LegendLayout =
    inherit BaseLegendLayout
    abstract member left: BaseLegendLayout option with get, set
    abstract member right: BaseLegendLayout option with get, set
    abstract member top: BaseLegendLayout option with get, set
    abstract member bottom: BaseLegendLayout option with get, set
    abstract member ``top-left``: BaseLegendLayout option with get, set
    abstract member ``top-right``: BaseLegendLayout option with get, set
    abstract member ``bottom-left``: BaseLegendLayout option with get, set
    abstract member ``bottom-right``: BaseLegendLayout option with get, set

type TitleConfig =
    ExcludeMappedValueRef<BaseTitle>

type ProjectionConfig =
    ExcludeMappedValueRef<BaseProjection>

[<AllowNullLiteral>]
[<Interface>]
type RangeConfig =
    /// <summary>
    /// Default [color scheme](https://vega.github.io/vega/docs/schemes/) for categorical data.
    /// </summary>
    abstract member category: U2<RangeScheme, ResizeArray<Color>> option with get, set
    /// <summary>
    /// Default [color scheme](https://vega.github.io/vega/docs/schemes/) for diverging quantitative ramps.
    /// </summary>
    abstract member diverging: U2<RangeScheme, ResizeArray<Color>> option with get, set
    /// <summary>
    /// Default [color scheme](https://vega.github.io/vega/docs/schemes/) for quantitative heatmaps.
    /// </summary>
    abstract member heatmap: U2<RangeScheme, ResizeArray<Color>> option with get, set
    /// <summary>
    /// Default [color scheme](https://vega.github.io/vega/docs/schemes/) for rank-ordered data.
    /// </summary>
    abstract member ordinal: U2<RangeScheme, ResizeArray<Color>> option with get, set
    /// <summary>
    /// Default [color scheme](https://vega.github.io/vega/docs/schemes/) for sequential quantitative ramps.
    /// </summary>
    abstract member ramp: U2<RangeScheme, ResizeArray<Color>> option with get, set
    /// <summary>
    /// Array of [symbol](https://vega.github.io/vega/docs/marks/symbol/) names or paths for the default shape palette.
    /// </summary>
    abstract member symbol: ResizeArray<SymbolShape> option with get, set

module Config =

    [<Global>]
    [<AllowNullLiteral>]
    type events
        [<ParamObject; Emit("$0")>]
        (
            ?bind: Config.events.bind,
            ?defaults: DefaultsConfig,
            ?globalCursor: bool,
            ?selector: U2<bool, ResizeArray<string>>,
            ?timer: bool,
            ?view: U2<bool, ResizeArray<string>>,
            ?window: U2<bool, ResizeArray<string>>
        ) =

        member val bind : Config.events.bind option = nativeOnly with get, set
        member val defaults : DefaultsConfig option = nativeOnly with get, set
        member val globalCursor : bool option = nativeOnly with get, set
        member val selector : U2<bool, ResizeArray<string>> option = nativeOnly with get, set
        member val timer : bool option = nativeOnly with get, set
        member val view : U2<bool, ResizeArray<string>> option = nativeOnly with get, set
        member val window : U2<bool, ResizeArray<string>> option = nativeOnly with get, set

    [<AllowNullLiteral>]
    [<Interface>]
    type style =
        [<EmitIndexer>]
        abstract member Item: style: string -> MarkConfig with get, set

    module events =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type bind =
            | any
            | container
            | none

    module style =

        module Item =

            module MarkConfig =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type strokeCap =
                    | butt
                    | round
                    | square

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type strokeJoin =
                    | miter
                    | round
                    | bevel

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type cursor =
                    | auto
                    | ``default``
                    | none
                    | ``context-menu``
                    | help
                    | pointer
                    | progress
                    | wait
                    | cell
                    | crosshair
                    | text
                    | ``vertical-text``
                    | alias
                    | copy
                    | move
                    | ``no-drop``
                    | ``not-allowed``
                    | ``e-resize``
                    | ``n-resize``
                    | ``ne-resize``
                    | ``nw-resize``
                    | ``s-resize``
                    | ``se-resize``
                    | ``sw-resize``
                    | ``w-resize``
                    | ``ew-resize``
                    | ``ns-resize``
                    | ``nesw-resize``
                    | ``nwse-resize``
                    | ``col-resize``
                    | ``row-resize``
                    | ``all-scroll``
                    | ``zoom-in``
                    | ``zoom-out``
                    | grab
                    | grabbing

module DefaultsConfig =

    module U2 =

        [<AllowNullLiteral>]
        [<Interface>]
        type Case1 =
            [<EmitIndexer>]
            abstract member Item: key: string -> U2<bool, ResizeArray<EventType>> with get, set

        [<AllowNullLiteral>]
        [<Interface>]
        type Case2 =
            [<EmitIndexer>]
            abstract member Item: key: string -> U2<bool, ResizeArray<EventType>> with get, set

module MarkConfig =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type strokeCap =
        | butt
        | round
        | square

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type strokeJoin =
        | miter
        | round
        | bevel

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type cursor =
        | auto
        | ``default``
        | none
        | ``context-menu``
        | help
        | pointer
        | progress
        | wait
        | cell
        | crosshair
        | text
        | ``vertical-text``
        | alias
        | copy
        | move
        | ``no-drop``
        | ``not-allowed``
        | ``e-resize``
        | ``n-resize``
        | ``ne-resize``
        | ``nw-resize``
        | ``s-resize``
        | ``se-resize``
        | ``sw-resize``
        | ``w-resize``
        | ``ew-resize``
        | ``ns-resize``
        | ``nesw-resize``
        | ``nwse-resize``
        | ``col-resize``
        | ``row-resize``
        | ``all-scroll``
        | ``zoom-in``
        | ``zoom-out``
        | grab
        | grabbing

