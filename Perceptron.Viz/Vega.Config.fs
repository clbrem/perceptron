namespace Vega

open Fable.Core
open Fable.Core.JsInterop
open System
type EventsBind =
    | [<CompiledName("any")>] Any
    | [<CompiledName("container")>] Container
    | [<CompiledName("none")>] BindNone
type EventType =
    |[<CompiledName("click")>] Click
    |[<CompiledName("dblclick")>] DblClick
    |[<CompiledName("dragenter")>] DragEnter
type DefaultPrevent =
    {
        prevent: U2<bool, EventType []>
    }
type DefaultAllow = 
    {
        allow: U2<bool, EventType []>
    }    
type ConfigEvents = {
    bind: EventsBind option
    defaults: U2<DefaultPrevent,DefaultAllow> option
    selector: U2<bool, string []> option
    timer: bool option
    view: U2<bool, string []> option
    window: U2<bool, string[]> option
    }
type KeepSignal<'T> =
    'T
type Padding =
        U2<int, {| top: int option; right: int option; bottom: int option; left: int option |}>    
type AutoSizeType =
    | [<CompiledName("pad")>] Pad
    | [<CompiledName("fit")>] Fit
    | [<CompiledName("fit-x")>] FitX
    | [<CompiledName("fit-y")>] FitY
    | [<CompiledName("none")>] NoneSize
type AutoSizeContains =
    | [<CompiledName("content")>] Content
    | [<CompiledName("padding")>] Padding
type AutoSizeRecord =
    {
        [<CompiledName("type")>] autoSizeType: AutoSizeType
        resize: bool option
        contains: AutoSizeContains option
    }
type AutoSize = U2<AutoSizeType, AutoSizeRecord>

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type MarkConfigKeys =
    | mark
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


type MarkConfig =
    
    {
        /// <summary>
        /// A boolean flag indicating if [ARIA attributes](https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA) should be included (SVG output only).
        /// If <c>false</c>, the "aria-hidden" attribute will be set on the output SVG element, removing the mark item from the ARIA accessibility tree.
        /// </summary>
        aria: U2<bool, SignalRef> option
        /// <summary>
        /// Sets the type of user interface element of the mark item for [ARIA accessibility](https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA) (SVG output only).
        /// If specified, this property determines the "role" attribute.
        /// Warning: this property is experimental and may be changed in the future.
        /// </summary>
        ariaRole: U2<string, SignalRef> option         
        /// <summary>
        /// A human-readable, author-localized description for the role of the mark item for [ARIA accessibility](https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA) (SVG output only).
        /// If specified, this property determines the "aria-roledescription" attribute.
        /// Warning: this property is experimental and may be changed in the future.
        /// </summary>
        ariaRoleDescription: U2<string, SignalRef> option
        /// <summary>
        /// A text description of the mark item for [ARIA accessibility](https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA) (SVG output only).
        /// If specified, this property determines the ["aria-label" attribute](https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA/ARIA_Techniques/Using_the_aria-label_attribute).
        /// </summary>
        description: U2<string, SignalRef> option 
        /// <summary>
        /// Width of the marks.
        /// </summary>
        width: U2<float, SignalRef> option 
        /// <summary>
        /// Height of the marks.
        /// </summary>
        height: U2<float, SignalRef> option 
        /// <summary>
        /// Whether to keep aspect ratio of image marks.
        /// </summary>
        aspect: U2<bool, SignalRef> option 
        /// <summary>
        /// The URL of the image file for image marks.
        /// </summary>
        url: U2<URI, SignalRef> option 
        /// <summary>
        /// A boolean flag (default true) indicating if the image should be smoothed when resized. If false, individual pixels should be scaled directly rather than interpolated with smoothing. For SVG rendering, this option may not work in some browsers due to lack of standardization.
        /// </summary>
        smooth: U2<bool, SignalRef> option 
        /// <summary>
        /// Default fill color.
        ///
        /// __Default value:__ (None)
        /// </summary>
        fill: U3<Color, Gradient, SignalRef> option option 
        /// <summary>
        /// Default stroke color.
        ///
        /// __Default value:__ (None)
        /// </summary>
        stroke: U3<Color, Gradient, SignalRef> option option 
        /// <summary>
        /// The overall opacity (value between [0,1]).
        /// </summary>
        opacity: U2<float, SignalRef> option 
        /// <summary>
        /// The fill opacity (value between [0,1]).
        ///
        /// __Default value:__ <c>1</c>
        /// </summary>
        fillOpacity: U2<float, SignalRef> option 
        /// <summary>
        /// The stroke opacity (value between [0,1]).
        ///
        /// __Default value:__ <c>1</c>
        /// </summary>
        strokeOpacity: U2<float, SignalRef> option 
        /// <summary>
        /// The color blend mode for drawing an item on its current background. Any valid [CSS mix-blend-mode](https://developer.mozilla.org/en-US/docs/Web/CSS/mix-blend-mode) value can be used.
        ///
        /// __Default value: <c>"source-over"</c>
        /// </summary>
        blend: Blend option 
        /// <summary>
        /// The stroke width, in pixels.
        /// </summary>
        strokeWidth: U2<float, SignalRef> option 
        /// <summary>
        /// An array of alternating stroke, space lengths for creating dashed or dotted lines.
        /// </summary>
        strokeDash: U2<ResizeArray<float>, SignalRef> option 
        /// <summary>
        /// The offset (in pixels) into which to begin drawing with the stroke dash array.
        /// </summary>
        strokeDashOffset: U2<float, SignalRef> option 
        /// <summary>
        /// The offset in pixels at which to draw the group stroke and fill. If unspecified, the default behavior is to dynamically offset stroked groups such that 1 pixel stroke widths align with the pixel grid.
        /// </summary>
        strokeOffset: U2<float, SignalRef> option 
        /// <summary>
        /// The stroke cap for line ending style. One of <c>"butt"</c>, <c>"round"</c>, or <c>"square"</c>.
        ///
        /// __Default value:__ <c>"butt"</c>
        /// </summary>
        strokeCap: U2<StrokeCap,SignalRef> option 
        /// <summary>
        /// The stroke line join method. One of <c>"miter"</c>, <c>"round"</c> or <c>"bevel"</c>.
        ///
        /// __Default value:__ <c>"miter"</c>
        /// </summary>
        strokeJoin: U2<StrokeJoin,SignalRef> option 
        /// <summary>
        /// The miter limit at which to bevel a line join.
        /// </summary>
        strokeMiterLimit: U2<float, SignalRef> option 
        /// <summary>
        /// The orientation of the area mark. One of <c>horizontal</c> or <c>vertical</c> (the default). With a vertical orientation, an area mark is defined by the <c>x</c>, <c>y</c>, and (<c>y2</c> or <c>height</c>) properties; with a horizontal orientation, the <c>y</c>, <c>x</c> and (<c>x2</c> or <c>width</c>) properties must be specified instead.
        /// </summary>
        orient: U2<Orientation, SignalRef> option 
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
        interpolate: U2<Interpolate, SignalRef> option 
        /// <summary>
        /// Depending on the interpolation type, sets the tension parameter (for line and area marks).
        /// </summary>
        tension: U2<float, SignalRef> option 
        /// <summary>
        /// Shape of the point marks. Supported values include:
        /// - plotting shapes: <c>"circle"</c>, <c>"square"</c>, <c>"cross"</c>, <c>"diamond"</c>, <c>"triangle-up"</c>, <c>"triangle-down"</c>, <c>"triangle-right"</c>, or <c>"triangle-left"</c>.
        /// - the line symbol <c>"stroke"</c>
        /// - centered directional shapes <c>"arrow"</c>, <c>"wedge"</c>, or <c>"triangle"</c>
        /// - a custom [SVG path string](https://developer.mozilla.org/en-US/docs/Web/SVG/Tutorial/Paths) (For correct sizing, custom shape paths should be defined within a square bounding box with coordinates ranging from -1 to 1 along both the x and y dimensions.)
        ///
        /// __Default value:__ <c>"circle"</c>
        /// </summary>
        shape: U3<SymbolShape, string, SignalRef> option 
        /// <summary>
        /// The area in pixels of the symbols bounding box. Note that this value sets the area of the symbol; the side lengths will increase with the square root of this value.
        ///
        /// __Default value:__ <c>30</c>
        /// </summary>
        size: U2<float, SignalRef> option 
        /// <summary>
        /// The horizontal alignment of the text. One of <c>"left"</c>, <c>"right"</c>, <c>"center"</c>.
        /// </summary>
        align: U2<Align, SignalRef> option 
        /// <summary>
        /// The rotation angle of the text, in degrees.
        /// </summary>
        angle: U2<float, SignalRef> option 
        /// <summary>
        /// The start angle in radians for arc marks.
        /// A value of <c>0</c> indicates up (north), increasing values proceed clockwise.
        /// </summary>
        startAngle: U2<float, SignalRef> option 
        /// <summary>
        /// The end angle in radians for arc marks.
        /// A value of <c>0</c> indicates up (north), increasing values proceed clockwise.
        /// </summary>
        endAngle: U2<float, SignalRef> option 
        /// <summary>
        /// The angular padding applied to sides of the arc, in radians.
        /// </summary>
        padAngle: U2<float, SignalRef> option 
        /// <summary>
        /// The inner radius in pixels of arc marks.
        ///
        /// __Default value:__ <c>0</c>
        /// </summary>
        innerRadius: U2<float, SignalRef> option 
        /// <summary>
        /// The outer radius in pixels of arc marks.
        ///
        /// __Default value:__ <c>0</c>
        /// </summary>
        outerRadius: U2<float, SignalRef> option 
        /// <summary>
        /// The vertical alignment of the text. One of <c>"top"</c>, <c>"bottom"</c>, <c>"middle"</c>, <c>"alphabetic"</c>.
        ///
        /// __Default value:__ <c>"middle"</c>
        /// </summary>
        baseline: U2<TextBaseline, SignalRef> option 
        /// <summary>
        /// The direction of the text. One of <c>"ltr"</c> (left-to-right) or <c>"rtl"</c> (right-to-left). This property determines on which side is truncated in response to the limit parameter.
        ///
        /// __Default value:__ <c>"ltr"</c>
        /// </summary>
        dir: U2<TextDirection, SignalRef> option 
        /// <summary>
        /// The horizontal offset, in pixels, between the text label and its anchor point. The offset is applied after rotation by the _angle_ property.
        /// </summary>
        dx: U2<float, SignalRef> option 
        /// <summary>
        /// The vertical offset, in pixels, between the text label and its anchor point. The offset is applied after rotation by the _angle_ property.
        /// </summary>
        dy: U2<float, SignalRef> option 
        /// <summary>
        /// The ellipsis string for text truncated in response to the limit parameter.
        ///
        /// __Default value:__ <c>"…"</c>
        /// </summary>
        ellipsis: string option 
        /// <summary>
        /// Polar coordinate radial offset, in pixels, of the text label from the origin determined by the <c>x</c> and <c>y</c> properties.
        /// </summary>
        radius: U2<float, SignalRef> option 
        /// <summary>
        /// The maximum length of the text mark in pixels. The text value will be automatically truncated if the rendered size exceeds the limit.
        ///
        /// __Default value:__ <c>0</c> -- indicating no limit
        /// </summary>
        limit: U2<float, SignalRef> option 
        /// <summary>
        /// A delimiter, such as a newline character, upon which to break text strings into multiple lines. This property is ignored if the text is array-valued.
        /// </summary>
        lineBreak: U2<string, SignalRef> option 
        /// <summary>
        /// The line height in pixels (the spacing between subsequent lines of text) for multi-line text marks.
        /// </summary>
        lineHeight: U2<float, SignalRef> option 
        /// <summary>
        /// Polar coordinate angle, in radians, of the text label from the origin determined by the <c>x</c> and <c>y</c> properties. Values for <c>theta</c> follow the same convention of <c>arc</c> mark <c>startAngle</c> and <c>endAngle</c> properties: angles are measured in radians, with <c>0</c> indicating "north".
        /// </summary>
        theta: U2<float, SignalRef> option 
        /// <summary>
        /// The typeface to set the text in (e.g., <c>"Helvetica Neue"</c>).
        /// </summary>
        font: U2<string, SignalRef> option 
        /// <summary>
        /// The font size, in pixels.
        ///
        /// __Default value:__ <c>11</c>
        /// </summary>
        fontSize: U2<float, SignalRef> option 
        /// <summary>
        /// The font style (e.g., <c>"italic"</c>).
        /// </summary>
        fontStyle: U2<FontStyle, SignalRef> option 
        /// <summary>
        /// The font weight.
        /// This can be either a string (e.g <c>"bold"</c>, <c>"normal"</c>) or a number (<c>100</c>, <c>200</c>, <c>300</c>, ..., <c>900</c> where <c>"normal"</c> = <c>400</c> and <c>"bold"</c> = <c>700</c>).
        /// </summary>
        fontWeight: U2<FontWeight, SignalRef> option 
        /// <summary>
        /// Placeholder text if the <c>text</c> channel is not specified
        /// </summary>
        text: U2<Text, SignalRef> option 
        /// <summary>
        /// A URL to load upon mouse click. If defined, the mark acts as a hyperlink.
        /// </summary>
        href: U2<URI, SignalRef> option 
        /// <summary>
        /// The tooltip text to show upon mouse hover.
        /// </summary>
        tooltip: U2<string, SignalRef> option 
        /// <summary>
        /// The mouse cursor used over the mark. Any valid [CSS cursor type](https://developer.mozilla.org/en-US/docs/Web/CSS/cursor#Values) can be used.
        /// </summary>
        cursor: U2<Cursor, SignalRef> option 
        /// <summary>
        /// The radius in pixels of rounded rectangles or arcs' corners.
        ///
        /// __Default value:__ <c>0</c>
        /// </summary>
        cornerRadius: U2<float, SignalRef> option 
        /// <summary>
        /// The radius in pixels of rounded rectangles' top right corner.
        ///
        /// __Default value:__ <c>0</c>
        /// </summary>
        cornerRadiusTopLeft: U2<float, SignalRef> option 
        /// <summary>
        /// The radius in pixels of rounded rectangles' top left corner.
        ///
        /// __Default value:__ <c>0</c>
        /// </summary>
        cornerRadiusTopRight: U2<float, SignalRef> option 
        /// <summary>
        /// The radius in pixels of rounded rectangles' bottom right corner.
        ///
        /// __Default value:__ <c>0</c>
        /// </summary>
        cornerRadiusBottomRight: U2<float, SignalRef> option 
        /// <summary>
        /// The radius in pixels of rounded rectangles' bottom left corner.
        ///
        /// __Default value:__ <c>0</c>
        /// </summary>
        cornerRadiusBottomLeft: U2<float, SignalRef> option 
            
    }
    





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
   {

    /// <summary>
    /// Coordinate space translation offset for axis layout. By default, axes are translated by a 0.5 pixel offset for both the x and y coordinates in order to align stroked lines with the pixel grid. However, for vector graphics output these pixel-specific adjustments may be undesirable, in which case translate can be changed (for example, to zero).
    ///
    /// __Default value:__ <c>0.5</c>
    /// </summary>
    translate: NumberValue option
    /// <summary>
    /// The minimum extent in pixels that axis ticks and labels should use. This determines a minimum offset value for axis titles.
    ///
    /// __Default value:__ <c>30</c> for y-axis; <c>undefined</c> for x-axis.
    /// </summary>
    minExtent: NumberValue option
    /// <summary>
    /// The maximum extent in pixels that axis ticks and labels should use. This determines a maximum offset value for axis titles.
    ///
    /// __Default value:__ <c>undefined</c>.
    /// </summary>
    maxExtent: NumberValue option
    /// <summary>
    /// An interpolation fraction indicating where, for <c>band</c> scales, axis ticks should be positioned. A value of <c>0</c> places ticks at the left edge of their bands. A value of <c>0.5</c> places ticks in the middle of their bands.
    ///
    ///  __Default value:__ <c>0.5</c>
    /// </summary>
    bandPosition: NumberValue option
    /// <summary>
    /// A boolean flag indicating if [ARIA attributes](https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA) should be included (SVG output only).
    /// If <c>false</c>, the "aria-hidden" attribute will be set on the output SVG group, removing the axis from the ARIA accessibility tree.
    ///
    /// __Default value:__ <c>true</c>
    /// </summary>
    aria: bool option
    /// <summary>
    /// A text description of this axis for [ARIA accessibility](https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA) (SVG output only).
    /// If the <c>aria</c> property is true, for SVG output the ["aria-label" attribute](https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA/ARIA_Techniques/Using_the_aria-label_attribute) will be set to this description.
    /// If the description is unspecified it will be automatically generated.
    /// </summary>
    description: string option
    /// <summary>
    /// The padding, in pixels, between title and axis.
    /// </summary>
    titlePadding: NumberValue option
    /// <summary>
    /// Horizontal text alignment of axis titles.
    /// </summary>
    titleAlign: Align option
    /// <summary>
    /// Text anchor position for placing axis titles.
    /// </summary>
    titleAnchor: TitleAnchor option
    /// <summary>
    /// Angle in degrees of axis titles.
    /// </summary>
    titleAngle: NumberValue option
    /// <summary>
    /// X-coordinate of the axis title relative to the axis group.
    /// </summary>
    titleX: NumberValue option
    /// <summary>
    /// Y-coordinate of the axis title relative to the axis group.
    /// </summary>
    titleY: NumberValue option
    /// <summary>
    /// Vertical text baseline for axis titles. One of <c>"alphabetic"</c> (default), <c>"top"</c>, <c>"middle"</c>, <c>"bottom"</c>, <c>"line-top"</c>, or <c>"line-bottom"</c>. The <c>"line-top"</c> and <c>"line-bottom"</c> values operate similarly to <c>"top"</c> and <c>"bottom"</c>, but are calculated relative to the *lineHeight* rather than *fontSize* alone.
    /// </summary>
    titleBaseline: TextBaselineValue option
    /// <summary>
    /// Color of the title, can be in hex color code or regular color name.
    /// </summary>
    titleColor: ColorValue option
    /// <summary>
    /// Font of the title. (e.g., <c>"Helvetica Neue"</c>).
    /// </summary>
    titleFont: StringValue option
    /// <summary>
    /// Font size of the title.
    /// </summary>
    titleFontSize: NumberValue option
    /// <summary>
    /// Font style of the title.
    /// </summary>
    titleFontStyle: FontStyleValue option
    /// <summary>
    /// Font weight of the title.
    /// This can be either a string (e.g <c>"bold"</c>, <c>"normal"</c>) or a number (<c>100</c>, <c>200</c>, <c>300</c>, ..., <c>900</c> where <c>"normal"</c> = <c>400</c> and <c>"bold"</c> = <c>700</c>).
    /// </summary>
    titleFontWeight: FontWeightValue option
    /// <summary>
    /// Maximum allowed pixel width of axis titles.
    /// </summary>
    titleLimit: NumberValue option
    /// <summary>
    /// Line height in pixels for multi-line title text or title text with <c>"line-top"</c> or <c>"line-bottom"</c> baseline.
    /// </summary>
    titleLineHeight: NumberValue option
    /// <summary>
    /// Opacity of the axis title.
    /// </summary>
    titleOpacity: NumberValue option
    /// <summary>
    /// A boolean flag indicating if the domain (the axis baseline) should be included as part of the axis.
    ///
    /// __Default value:__ <c>true</c>
    /// </summary>
    domain: bool option
    /// <summary>
    /// The stroke cap for the domain line's ending style. One of <c>"butt"</c>, <c>"round"</c> or <c>"square"</c>.
    ///
    /// __Default value:__ <c>"butt"</c>
    /// </summary>
    domainCap: StrokeCapValue option
    /// <summary>
    /// An array of alternating [stroke, space] lengths for dashed domain lines.
    /// </summary>
    domainDash: DashArrayValue option
    /// <summary>
    /// The pixel offset at which to start drawing with the domain dash array.
    /// </summary>
    domainDashOffset: NumberValue option
    /// <summary>
    /// Color of axis domain line.
    ///
    /// __Default value:__ <c>"gray"</c>.
    /// </summary>
    domainColor: ColorValue option
    /// <summary>
    /// Opacity of the axis domain line.
    /// </summary>
    domainOpacity: NumberValue option
    /// <summary>
    /// Stroke width of axis domain line
    ///
    /// __Default value:__ <c>1</c>
    /// </summary>
    domainWidth: NumberValue option
    /// <summary>
    /// Boolean value that determines whether the axis should include ticks.
    ///
    /// __Default value:__ <c>true</c>
    /// </summary>
    ticks: BooleanValue option
    /// <summary>
    /// For band scales, indicates if ticks and grid lines should be placed at the <c>"center"</c> of a band (default) or at the band <c>"extent"</c>s to indicate intervals
    /// </summary>
    tickBand: BaseAxis.tickBand option 
    /// <summary>
    /// The stroke cap for the tick lines' ending style. One of <c>"butt"</c>, <c>"round"</c> or <c>"square"</c>.
    ///
    /// __Default value:__ <c>"butt"</c>
    /// </summary>
    tickCap: StrokeCapValue option
    /// <summary>
    /// The color of the axis's tick.
    ///
    /// __Default value:__ <c>"gray"</c>
    /// </summary>
    tickColor: ColorValue option
    /// <summary>
    /// An array of alternating [stroke, space] lengths for dashed tick mark lines.
    /// </summary>
    tickDash: DashArrayValue option
    /// <summary>
    /// The pixel offset at which to start drawing with the tick mark dash array.
    /// </summary>
    tickDashOffset: NumberValue option
    /// <summary>
    /// Boolean flag indicating if an extra axis tick should be added for the initial position of the axis. This flag is useful for styling axes for <c>band</c> scales such that ticks are placed on band boundaries rather in the middle of a band. Use in conjunction with <c>"bandPosition": 1</c> and an axis <c>"padding"</c> value of <c>0</c>.
    /// </summary>
    tickExtra: BooleanValue option
    /// <summary>
    /// Position offset in pixels to apply to ticks, labels, and gridlines.
    /// </summary>
    tickOffset: NumberValue option
    /// <summary>
    /// Opacity of the ticks.
    /// </summary>
    tickOpacity: NumberValue option
    /// <summary>
    /// Boolean flag indicating if pixel position values should be rounded to the nearest integer.
    ///
    /// __Default value:__ <c>true</c>
    /// </summary>
    tickRound: BooleanValue option
    /// <summary>
    /// The size in pixels of axis ticks.
    ///
    /// __Default value:__ <c>5</c>
    /// </summary>
    tickSize: NumberValue option
    /// <summary>
    /// The width, in pixels, of ticks.
    ///
    /// __Default value:__ <c>1</c>
    /// </summary>
    tickWidth: NumberValue option
    /// <summary>
    /// A boolean flag indicating if grid lines should be included as part of the axis.
    /// </summary>
    grid: bool option
    /// <summary>
    /// The stroke cap for grid lines' ending style. One of <c>"butt"</c>, <c>"round"</c> or <c>"square"</c>.
    ///
    /// __Default value:__ <c>"butt"</c>
    /// </summary>
    gridCap: StrokeCapValue option
    /// <summary>
    /// Color of gridlines.
    ///
    /// __Default value:__ <c>"lightGray"</c>.
    /// </summary>
    gridColor: ColorValue option
    /// <summary>
    /// An array of alternating [stroke, space] lengths for dashed grid lines.
    /// </summary>
    gridDash: DashArrayValue option
    /// <summary>
    /// The pixel offset at which to start drawing with the grid dash array.
    /// </summary>
    gridDashOffset: NumberValue option
    /// <summary>
    /// The stroke opacity of grid (value between [0,1])
    ///
    /// __Default value:__ <c>1</c>
    /// </summary>
    gridOpacity: NumberValue option
    /// <summary>
    /// The grid width, in pixels.
    ///
    /// __Default value:__ <c>1</c>
    /// </summary>
    gridWidth: NumberValue option
    /// <summary>
    /// A boolean flag indicating if labels should be included as part of the axis.
    ///
    /// __Default value:__ <c>true</c>.
    /// </summary>
    labels: bool option
    /// <summary>
    /// Horizontal text alignment of axis tick labels, overriding the default setting for the current axis orientation.
    /// </summary>
    labelAlign: AlignValue option
    /// <summary>
    /// Vertical text baseline of axis tick labels, overriding the default setting for the current axis orientation.
    /// One of <c>"alphabetic"</c> (default), <c>"top"</c>, <c>"middle"</c>, <c>"bottom"</c>, <c>"line-top"</c>, or <c>"line-bottom"</c>. The <c>"line-top"</c> and <c>"line-bottom"</c> values operate similarly to <c>"top"</c> and <c>"bottom"</c>, but are calculated relative to the *lineHeight* rather than *fontSize* alone.
    /// </summary>
    labelBaseline: TextBaselineValue option
    /// <summary>
    /// Indicates if labels should be hidden if they exceed the axis range. If <c>false</c> (the default) no bounds overlap analysis is performed. If <c>true</c>, labels will be hidden if they exceed the axis range by more than 1 pixel. If this property is a number, it specifies the pixel tolerance: the maximum amount by which a label bounding box may exceed the axis range.
    ///
    /// __Default value:__ <c>false</c>.
    /// </summary>
    labelBound: U3<float, bool, SignalRef> option 

    labelFlush: U3<float, bool, SignalRef> option 
    /// <summary>
    /// Indicates the number of pixels by which to offset flush-adjusted labels. For example, a value of <c>2</c> will push flush-adjusted labels 2 pixels outward from the center of the axis. Offsets can help the labels better visually group with corresponding axis ticks.
    ///
    /// __Default value:__ <c>0</c>.
    /// </summary>
    labelFlushOffset: U2<float, SignalRef> option 
    /// <summary>
    /// Line height in pixels for multi-line label text or label text with <c>"line-top"</c> or <c>"line-bottom"</c> baseline.
    /// </summary>
    labelLineHeight: NumberValue option
    /// <summary>
    /// The strategy to use for resolving overlap of axis labels. If <c>false</c> (the default), no overlap reduction is attempted. If set to <c>true</c> or <c>"parity"</c>, a strategy of removing every other label is used (this works well for standard linear axes). If set to <c>"greedy"</c>, a linear scan of the labels is performed, removing any labels that overlaps with the last visible label (this often works better for log-scaled axes).
    /// </summary>
    labelOverlap: BaseAxis.labelOverlap option 
    /// <summary>
    /// The minimum separation that must be between label bounding boxes for them to be considered non-overlapping (default <c>0</c>). This property is ignored if *labelOverlap* resolution is not enabled.
    /// </summary>
    labelSeparation: U2<float, SignalRef> option 
    /// <summary>
    /// The rotation angle of the axis labels.
    ///
    /// __Default value:__ <c>-90</c> for nominal and ordinal fields; <c>0</c> otherwise.
    /// </summary>
    labelAngle: NumberValue option
    /// <summary>
    /// The color of the tick label, can be in hex color code or regular color name.
    /// </summary>
    labelColor: ColorValue option
    /// <summary>
    /// The font of the tick label.
    /// </summary>
    labelFont: StringValue option
    /// <summary>
    /// The font size of the label, in pixels.
    /// </summary>
    labelFontSize: NumberValue option
    /// <summary>
    /// Font style of the title.
    /// </summary>
    labelFontStyle: FontStyleValue option
    /// <summary>
    /// Font weight of axis tick labels.
    /// </summary>
    labelFontWeight: FontWeightValue option
    /// <summary>
    /// Maximum allowed pixel width of axis tick labels.
    ///
    /// __Default value:__ <c>180</c>
    /// </summary>
    labelLimit: NumberValue option
    /// <summary>
    /// The opacity of the labels.
    /// </summary>
    labelOpacity: NumberValue option
    /// <summary>
    /// Position offset in pixels to apply to labels, in addition to tickOffset.
    ///
    /// __Default value:__ <c>0</c>
    /// </summary>
    labelOffset: NumberValue option
    /// <summary>
    /// The padding in pixels between labels and ticks.
    ///
    /// __Default value:__ <c>2</c>
    /// </summary>
    labelPadding: NumberValue option
    /// <summary>
    /// The integer z-index indicating the layering of the axis group relative to other axis, mark, and legend groups.
    /// </summary>
    zindex: float option
}


type LegendConfig = {
         /// <summary>
    /// The default direction (<c>"horizontal"</c> or <c>"vertical"</c>) for gradient legends.
    ///
    /// __Default value:__ <c>"vertical"</c>.
    /// </summary>
     gradientDirection: Orientation option 
    /// <summary>
    /// The maximum allowed length in pixels of color ramp gradient labels.
    /// </summary>
     gradientLabelLimit: U2<float, SignalRef> option 
    /// <summary>
    /// Vertical offset in pixels for color ramp gradient labels.
    ///
    /// __Default value:__ <c>2</c>.
    /// </summary>
     gradientLabelOffset: U2<float, SignalRef> option 
    /// <summary>
    /// Default fill color for legend symbols. Only applied if there is no <c>"fill"</c> scale color encoding for the legend.
    ///
    /// __Default value:__ <c>"transparent"</c>.
    /// </summary>
     symbolBaseFillColor: U2<Color, SignalRef> option option 
    /// <summary>
    /// Default stroke color for legend symbols. Only applied if there is no <c>"fill"</c> scale color encoding for the legend.
    ///
    /// __Default value:__ <c>"gray"</c>.
    /// </summary>
     symbolBaseStrokeColor: U2<Color, SignalRef> option option 
    /// <summary>
    /// The default direction (<c>"horizontal"</c> or <c>"vertical"</c>) for symbol legends.
    ///
    /// __Default value:__ <c>"vertical"</c>.
    /// </summary>
     symbolDirection: Orientation option 
    /// <summary>
    /// Border stroke dash pattern for the full legend.
    /// </summary>
     strokeDash: U2<ResizeArray<float>, SignalRef> option 
    /// <summary>
    /// Border stroke width for the full legend.
    /// </summary>
     strokeWidth: U2<float, SignalRef> option 
    /// <summary>
    /// Legend orient group layout parameters.
    /// </summary>
     layout: LegendLayout option        
    }
    

 


type BaseLegendLayout = {
    /// <summary>
    /// The anchor point for legend orient group layout.
    /// </summary>
     anchor: U2<TitleAnchor, SignalRef> option 
    /// <summary>
    /// The bounds calculation to use for legend orient group layout.
    /// </summary>
     bounds: LayoutBounds option 
    /// <summary>
    /// A flag to center legends within a shared orient group.
    /// </summary>
     center: U2<bool, SignalRef> option 
    /// <summary>
    /// The layout direction for legend orient group layout.
    /// </summary>
     direction: U2<Orientation, SignalRef> option 
    /// <summary>
    /// The pixel margin between legends within a orient group.
    /// </summary>
     margin: U2<float, SignalRef> option 
    /// <summary>
    /// The pixel offset from the chart body for a legend orient group.
    /// </summary>
     offset: U2<float, SignalRef> option 
}

type LegendLayout =
    {
        left: BaseLegendLayout option 
        right: BaseLegendLayout option 
        top: BaseLegendLayout option 
        bottom: BaseLegendLayout option
        [<CompiledName("top-left")>]
        topLeft: BaseLegendLayout option
        [<CompiledName("top-right")>]
        topRight: BaseLegendLayout option
        [<CompiledName("bottom-left")>]
        bottomLeft: BaseLegendLayout option
        [<CompiledName("bottom-right")>]
        bottomRight: BaseLegendLayout option
    }    
      

type TitleConfig =BaseTitle

type ProjectionConfig =BaseProjection


type RangeConfig = {
    /// <summary>
    /// Default [color scheme](https://vega.github.io/vega/docs/schemes/) for categorical data.
    /// </summary>
     category: U2<RangeScheme, ResizeArray<Color>> option 
    /// <summary>
    /// Default [color scheme](https://vega.github.io/vega/docs/schemes/) for diverging quantitative ramps.
    /// </summary>
     diverging: U2<RangeScheme, ResizeArray<Color>> option 
    /// <summary>
    /// Default [color scheme](https://vega.github.io/vega/docs/schemes/) for quantitative heatmaps.
    /// </summary>
     heatmap: U2<RangeScheme, ResizeArray<Color>> option 
    /// <summary>
    /// Default [color scheme](https://vega.github.io/vega/docs/schemes/) for rank-ordered data.
    /// </summary>
     ordinal: U2<RangeScheme, ResizeArray<Color>> option 
    /// <summary>
    /// Default [color scheme](https://vega.github.io/vega/docs/schemes/) for sequential quantitative ramps.
    /// </summary>
     ramp: U2<RangeScheme, ResizeArray<Color>> option 
    /// <summary>
    /// Array of [symbol](https://vega.github.io/vega/docs/marks/symbol/) names or paths for the default shape palette.
    /// </summary>
     symbol: ResizeArray<SymbolShape> option 
}
module Config =
    
    type events = obj
        
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

type Config = {
    autosize: U2<AutoSize, SignalRef> option
    background: U2<Vega.Color, SignalRef> option
    padding: U2<Padding, SignalRef> option
    group: obj option
    events: ConfigEvents option
    locale: Locale option
    style: Map<string, MarkConfig> option
    legend: LegendConfig option
    title: TitleConfig option
    projection: ProjectionConfig option
    range: RangeConfig option
    signals: U2<InitSignal,NewSignal>[] option
}