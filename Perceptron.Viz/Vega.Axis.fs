namespace Vega

open Fable.Core
open Fable.Core.JsInterop
open System


[<AllowNullLiteral>]
[<Interface>]
type BaseAxis =
    /// <summary>
    /// Coordinate space translation offset for axis layout. By default, axes are translated by a 0.5 pixel offset for both the x and y coordinates in order to align stroked lines with the pixel grid. However, for vector graphics output these pixel-specific adjustments may be undesirable, in which case translate can be changed (for example, to zero).
    ///
    /// __Default value:__ <c>0.5</c>
    /// </summary>
    abstract member translate: NumberValue option with get, set
    /// <summary>
    /// The minimum extent in pixels that axis ticks and labels should use. This determines a minimum offset value for axis titles.
    ///
    /// __Default value:__ <c>30</c> for y-axis; <c>undefined</c> for x-axis.
    /// </summary>
    abstract member minExtent: NumberValue option with get, set
    /// <summary>
    /// The maximum extent in pixels that axis ticks and labels should use. This determines a maximum offset value for axis titles.
    ///
    /// __Default value:__ <c>undefined</c>.
    /// </summary>
    abstract member maxExtent: NumberValue option with get, set
    /// <summary>
    /// An interpolation fraction indicating where, for <c>band</c> scales, axis ticks should be positioned. A value of <c>0</c> places ticks at the left edge of their bands. A value of <c>0.5</c> places ticks in the middle of their bands.
    ///
    ///  __Default value:__ <c>0.5</c>
    /// </summary>
    abstract member bandPosition: NumberValue option with get, set
    /// <summary>
    /// A boolean flag indicating if [ARIA attributes](https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA) should be included (SVG output only).
    /// If <c>false</c>, the "aria-hidden" attribute will be set on the output SVG group, removing the axis from the ARIA accessibility tree.
    ///
    /// __Default value:__ <c>true</c>
    /// </summary>
    abstract member aria: bool option with get, set
    /// <summary>
    /// A text description of this axis for [ARIA accessibility](https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA) (SVG output only).
    /// If the <c>aria</c> property is true, for SVG output the ["aria-label" attribute](https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA/ARIA_Techniques/Using_the_aria-label_attribute) will be set to this description.
    /// If the description is unspecified it will be automatically generated.
    /// </summary>
    abstract member description: string option with get, set
    /// <summary>
    /// The padding, in pixels, between title and axis.
    /// </summary>
    abstract member titlePadding: NumberValue option with get, set
    /// <summary>
    /// Horizontal text alignment of axis titles.
    /// </summary>
    abstract member titleAlign: AlignValue option with get, set
    /// <summary>
    /// Text anchor position for placing axis titles.
    /// </summary>
    abstract member titleAnchor: AnchorValue option with get, set
    /// <summary>
    /// Angle in degrees of axis titles.
    /// </summary>
    abstract member titleAngle: NumberValue option with get, set
    /// <summary>
    /// X-coordinate of the axis title relative to the axis group.
    /// </summary>
    abstract member titleX: NumberValue option with get, set
    /// <summary>
    /// Y-coordinate of the axis title relative to the axis group.
    /// </summary>
    abstract member titleY: NumberValue option with get, set
    /// <summary>
    /// Vertical text baseline for axis titles. One of <c>"alphabetic"</c> (default), <c>"top"</c>, <c>"middle"</c>, <c>"bottom"</c>, <c>"line-top"</c>, or <c>"line-bottom"</c>. The <c>"line-top"</c> and <c>"line-bottom"</c> values operate similarly to <c>"top"</c> and <c>"bottom"</c>, but are calculated relative to the *lineHeight* rather than *fontSize* alone.
    /// </summary>
    abstract member titleBaseline: TextBaselineValue option with get, set
    /// <summary>
    /// Color of the title, can be in hex color code or regular color name.
    /// </summary>
    abstract member titleColor: ColorValue option with get, set
    /// <summary>
    /// Font of the title. (e.g., <c>"Helvetica Neue"</c>).
    /// </summary>
    abstract member titleFont: StringValue option with get, set
    /// <summary>
    /// Font size of the title.
    /// </summary>
    abstract member titleFontSize: NumberValue option with get, set
    /// <summary>
    /// Font style of the title.
    /// </summary>
    abstract member titleFontStyle: FontStyleValue option with get, set
    /// <summary>
    /// Font weight of the title.
    /// This can be either a string (e.g <c>"bold"</c>, <c>"normal"</c>) or a number (<c>100</c>, <c>200</c>, <c>300</c>, ..., <c>900</c> where <c>"normal"</c> = <c>400</c> and <c>"bold"</c> = <c>700</c>).
    /// </summary>
    abstract member titleFontWeight: FontWeightValue option with get, set
    /// <summary>
    /// Maximum allowed pixel width of axis titles.
    /// </summary>
    abstract member titleLimit: NumberValue option with get, set
    /// <summary>
    /// Line height in pixels for multi-line title text or title text with <c>"line-top"</c> or <c>"line-bottom"</c> baseline.
    /// </summary>
    abstract member titleLineHeight: NumberValue option with get, set
    /// <summary>
    /// Opacity of the axis title.
    /// </summary>
    abstract member titleOpacity: NumberValue option with get, set
    /// <summary>
    /// A boolean flag indicating if the domain (the axis baseline) should be included as part of the axis.
    ///
    /// __Default value:__ <c>true</c>
    /// </summary>
    abstract member domain: bool option with get, set
    /// <summary>
    /// The stroke cap for the domain line's ending style. One of <c>"butt"</c>, <c>"round"</c> or <c>"square"</c>.
    ///
    /// __Default value:__ <c>"butt"</c>
    /// </summary>
    abstract member domainCap: StrokeCapValue option with get, set
    /// <summary>
    /// An array of alternating [stroke, space] lengths for dashed domain lines.
    /// </summary>
    abstract member domainDash: DashArrayValue option with get, set
    /// <summary>
    /// The pixel offset at which to start drawing with the domain dash array.
    /// </summary>
    abstract member domainDashOffset: NumberValue option with get, set
    /// <summary>
    /// Color of axis domain line.
    ///
    /// __Default value:__ <c>"gray"</c>.
    /// </summary>
    abstract member domainColor: ColorValue option with get, set
    /// <summary>
    /// Opacity of the axis domain line.
    /// </summary>
    abstract member domainOpacity: NumberValue option with get, set
    /// <summary>
    /// Stroke width of axis domain line
    ///
    /// __Default value:__ <c>1</c>
    /// </summary>
    abstract member domainWidth: NumberValue option with get, set
    /// <summary>
    /// Boolean value that determines whether the axis should include ticks.
    ///
    /// __Default value:__ <c>true</c>
    /// </summary>
    abstract member ticks: BooleanValue option with get, set
    /// <summary>
    /// For band scales, indicates if ticks and grid lines should be placed at the <c>"center"</c> of a band (default) or at the band <c>"extent"</c>s to indicate intervals
    /// </summary>
    abstract member tickBand: BaseAxis.tickBand option with get, set
    /// <summary>
    /// The stroke cap for the tick lines' ending style. One of <c>"butt"</c>, <c>"round"</c> or <c>"square"</c>.
    ///
    /// __Default value:__ <c>"butt"</c>
    /// </summary>
    abstract member tickCap: StrokeCapValue option with get, set
    /// <summary>
    /// The color of the axis's tick.
    ///
    /// __Default value:__ <c>"gray"</c>
    /// </summary>
    abstract member tickColor: ColorValue option with get, set
    /// <summary>
    /// An array of alternating [stroke, space] lengths for dashed tick mark lines.
    /// </summary>
    abstract member tickDash: DashArrayValue option with get, set
    /// <summary>
    /// The pixel offset at which to start drawing with the tick mark dash array.
    /// </summary>
    abstract member tickDashOffset: NumberValue option with get, set
    /// <summary>
    /// Boolean flag indicating if an extra axis tick should be added for the initial position of the axis. This flag is useful for styling axes for <c>band</c> scales such that ticks are placed on band boundaries rather in the middle of a band. Use in conjunction with <c>"bandPosition": 1</c> and an axis <c>"padding"</c> value of <c>0</c>.
    /// </summary>
    abstract member tickExtra: BooleanValue option with get, set
    /// <summary>
    /// Position offset in pixels to apply to ticks, labels, and gridlines.
    /// </summary>
    abstract member tickOffset: NumberValue option with get, set
    /// <summary>
    /// Opacity of the ticks.
    /// </summary>
    abstract member tickOpacity: NumberValue option with get, set
    /// <summary>
    /// Boolean flag indicating if pixel position values should be rounded to the nearest integer.
    ///
    /// __Default value:__ <c>true</c>
    /// </summary>
    abstract member tickRound: BooleanValue option with get, set
    /// <summary>
    /// The size in pixels of axis ticks.
    ///
    /// __Default value:__ <c>5</c>
    /// </summary>
    abstract member tickSize: NumberValue option with get, set
    /// <summary>
    /// The width, in pixels, of ticks.
    ///
    /// __Default value:__ <c>1</c>
    /// </summary>
    abstract member tickWidth: NumberValue option with get, set
    /// <summary>
    /// A boolean flag indicating if grid lines should be included as part of the axis.
    /// </summary>
    abstract member grid: bool option with get, set
    /// <summary>
    /// The stroke cap for grid lines' ending style. One of <c>"butt"</c>, <c>"round"</c> or <c>"square"</c>.
    ///
    /// __Default value:__ <c>"butt"</c>
    /// </summary>
    abstract member gridCap: StrokeCapValue option with get, set
    /// <summary>
    /// Color of gridlines.
    ///
    /// __Default value:__ <c>"lightGray"</c>.
    /// </summary>
    abstract member gridColor: ColorValue option with get, set
    /// <summary>
    /// An array of alternating [stroke, space] lengths for dashed grid lines.
    /// </summary>
    abstract member gridDash: DashArrayValue option with get, set
    /// <summary>
    /// The pixel offset at which to start drawing with the grid dash array.
    /// </summary>
    abstract member gridDashOffset: NumberValue option with get, set
    /// <summary>
    /// The stroke opacity of grid (value between [0,1])
    ///
    /// __Default value:__ <c>1</c>
    /// </summary>
    abstract member gridOpacity: NumberValue option with get, set
    /// <summary>
    /// The grid width, in pixels.
    ///
    /// __Default value:__ <c>1</c>
    /// </summary>
    abstract member gridWidth: NumberValue option with get, set
    /// <summary>
    /// A boolean flag indicating if labels should be included as part of the axis.
    ///
    /// __Default value:__ <c>true</c>.
    /// </summary>
    abstract member labels: bool option with get, set
    /// <summary>
    /// Horizontal text alignment of axis tick labels, overriding the default setting for the current axis orientation.
    /// </summary>
    abstract member labelAlign: AlignValue option with get, set
    /// <summary>
    /// Vertical text baseline of axis tick labels, overriding the default setting for the current axis orientation.
    /// One of <c>"alphabetic"</c> (default), <c>"top"</c>, <c>"middle"</c>, <c>"bottom"</c>, <c>"line-top"</c>, or <c>"line-bottom"</c>. The <c>"line-top"</c> and <c>"line-bottom"</c> values operate similarly to <c>"top"</c> and <c>"bottom"</c>, but are calculated relative to the *lineHeight* rather than *fontSize* alone.
    /// </summary>
    abstract member labelBaseline: TextBaselineValue option with get, set
    /// <summary>
    /// Indicates if labels should be hidden if they exceed the axis range. If <c>false</c> (the default) no bounds overlap analysis is performed. If <c>true</c>, labels will be hidden if they exceed the axis range by more than 1 pixel. If this property is a number, it specifies the pixel tolerance: the maximum amount by which a label bounding box may exceed the axis range.
    ///
    /// __Default value:__ <c>false</c>.
    /// </summary>
    abstract member labelBound: U3<float, bool, SignalRef> option with get, set
    /// <summary>
    /// Indicates if the first and last axis labels should be aligned flush with the scale range. Flush alignment for a horizontal axis will left-align the first label and right-align the last label. For vertical axes, bottom and top text baselines are applied instead. If this property is a number, it also indicates the number of pixels by which to offset the first and last labels; for example, a value of 2 will flush-align the first and last labels and also push them 2 pixels outward from the center of the axis. The additional adjustment can sometimes help the labels better visually group with corresponding axis ticks.
    /// </summary>
    abstract member labelFlush: U3<float, bool, SignalRef> option with get, set
    /// <summary>
    /// Indicates the number of pixels by which to offset flush-adjusted labels. For example, a value of <c>2</c> will push flush-adjusted labels 2 pixels outward from the center of the axis. Offsets can help the labels better visually group with corresponding axis ticks.
    ///
    /// __Default value:__ <c>0</c>.
    /// </summary>
    abstract member labelFlushOffset: U2<float, SignalRef> option with get, set
    /// <summary>
    /// Line height in pixels for multi-line label text or label text with <c>"line-top"</c> or <c>"line-bottom"</c> baseline.
    /// </summary>
    abstract member labelLineHeight: NumberValue option with get, set
    /// <summary>
    /// The strategy to use for resolving overlap of axis labels. If <c>false</c> (the default), no overlap reduction is attempted. If set to <c>true</c> or <c>"parity"</c>, a strategy of removing every other label is used (this works well for standard linear axes). If set to <c>"greedy"</c>, a linear scan of the labels is performed, removing any labels that overlaps with the last visible label (this often works better for log-scaled axes).
    /// </summary>
    abstract member labelOverlap: BaseAxis.labelOverlap option with get, set
    /// <summary>
    /// The minimum separation that must be between label bounding boxes for them to be considered non-overlapping (default <c>0</c>). This property is ignored if *labelOverlap* resolution is not enabled.
    /// </summary>
    abstract member labelSeparation: U2<float, SignalRef> option with get, set
    /// <summary>
    /// The rotation angle of the axis labels.
    ///
    /// __Default value:__ <c>-90</c> for nominal and ordinal fields; <c>0</c> otherwise.
    /// </summary>
    abstract member labelAngle: NumberValue option with get, set
    /// <summary>
    /// The color of the tick label, can be in hex color code or regular color name.
    /// </summary>
    abstract member labelColor: ColorValue option with get, set
    /// <summary>
    /// The font of the tick label.
    /// </summary>
    abstract member labelFont: StringValue option with get, set
    /// <summary>
    /// The font size of the label, in pixels.
    /// </summary>
    abstract member labelFontSize: NumberValue option with get, set
    /// <summary>
    /// Font style of the title.
    /// </summary>
    abstract member labelFontStyle: FontStyleValue option with get, set
    /// <summary>
    /// Font weight of axis tick labels.
    /// </summary>
    abstract member labelFontWeight: FontWeightValue option with get, set
    /// <summary>
    /// Maximum allowed pixel width of axis tick labels.
    ///
    /// __Default value:__ <c>180</c>
    /// </summary>
    abstract member labelLimit: NumberValue option with get, set
    /// <summary>
    /// The opacity of the labels.
    /// </summary>
    abstract member labelOpacity: NumberValue option with get, set
    /// <summary>
    /// Position offset in pixels to apply to labels, in addition to tickOffset.
    ///
    /// __Default value:__ <c>0</c>
    /// </summary>
    abstract member labelOffset: NumberValue option with get, set
    /// <summary>
    /// The padding in pixels between labels and ticks.
    ///
    /// __Default value:__ <c>2</c>
    /// </summary>
    abstract member labelPadding: NumberValue option with get, set
    /// <summary>
    /// The integer z-index indicating the layering of the axis group relative to other axis, mark, and legend groups.
    /// </summary>
    abstract member zindex: float option with get, set




[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type AxisOrient =
    | top
    | bottom
    | left
    | right

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type LabelOverlap =
    | parity
    | greedy

type TickCount =
    U4<float, TimeInterval, TimeIntervalStep, SignalRef>

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type FormatType =
    | number
    | time
    | utc

[<AllowNullLiteral>]
[<Interface>]
type TimeFormatSpecifier =
    abstract member year: string option with get, set
    abstract member quarter: string option with get, set
    abstract member month: string option with get, set
    abstract member date: string option with get, set
    abstract member week: string option with get, set
    abstract member day: string option with get, set
    abstract member hours: string option with get, set
    abstract member minutes: string option with get, set
    abstract member seconds: string option with get, set
    abstract member milliseconds: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type Axis =
    inherit BaseAxis
    /// <summary>
    /// The orientation of the axis. One of <c>"top"</c>, <c>"bottom"</c>, <c>"left"</c> or <c>"right"</c>. The orientation can be used to further specialize the axis type (e.g., a y axis oriented for the right edge of the chart).
    ///
    /// __Default value:__ <c>"bottom"</c> for x-axes and <c>"left"</c> for y-axes.
    /// </summary>
    abstract member orient: Axis.orient with get, set
    /// <summary>
    /// The name of the scale backing the axis component.
    /// </summary>
    abstract member scale: string with get, set
    /// <summary>
    /// The name of the scale to use for including grid lines. By default grid lines are driven by the same scale as the ticks and labels.
    /// </summary>
    abstract member gridScale: string option with get, set
    /// <summary>
    /// The format specifier pattern for axis labels. For numerical values, must be a legal [d3-format](https://github.com/d3/d3-format#locale_format) specifier. For date-time values, must be a legal [d3-time-format](https://github.com/d3/d3-time-format#locale_format) specifier or multi-format object.
    /// </summary>
    abstract member format: U3<string, TimeFormatSpecifier, SignalRef> option with get, set
    /// <summary>
    /// The format type for axis labels (number, time, or utc).
    /// </summary>
    abstract member formatType: Axis.formatType option with get, set
    /// <summary>
    /// A title for the axis (none by default).
    /// </summary>
    abstract member title: U2<Text, SignalRef> option with get, set
    /// <summary>
    /// The orthogonal offset in pixels by which to displace the axis from its position along the edge of the chart.
    /// </summary>
    abstract member offset: NumberValue option with get, set
    /// <summary>
    /// The anchor position of the axis in pixels. For x-axes with top or bottom orientation, this sets the axis group x coordinate. For y-axes with left or right orientation, this sets the axis group y coordinate.
    ///
    /// __Default value__: <c>0</c>
    /// </summary>
    abstract member position: NumberValue option with get, set
    /// <summary>
    /// A desired number of ticks, for axes visualizing quantitative scales. The resulting number may be different so that values are "nice" (multiples of <c>2</c>, <c>5</c>, <c>10</c>) and lie within the underlying scale's range.
    ///
    /// For scales of type <c>"time"</c> or <c>"utc"</c>, the tick count can instead be a time interval specifier. Legal string values are <c>"millisecond"</c>, <c>"second"</c>, <c>"minute"</c>, <c>"hour"</c>, <c>"day"</c>, <c>"week"</c>, <c>"month"</c>, and "year". Alternatively, an object-valued interval specifier of the form <c>{"interval": "month", "step": 3}</c> includes a desired number of interval steps. Here, ticks are generated for each quarter (Jan, Apr, Jul, Oct) boundary.
    /// </summary>
    abstract member tickCount: TickCount option with get, set
    /// <summary>
    /// The minimum desired step between axis ticks, in terms of scale domain values. For example, a value of <c>1</c> indicates that ticks should not be less than 1 unit apart. If <c>tickMinStep</c> is specified, the <c>tickCount</c> value will be adjusted, if necessary, to enforce the minimum step value.
    /// </summary>
    abstract member tickMinStep: U2<float, SignalRef> option with get, set
    /// <summary>
    /// Explicitly set the visible axis tick and label values.
    /// </summary>
    abstract member values: U2<ResizeArray<obj>, SignalRef> option with get, set
    /// <summary>
    /// Mark definitions for custom axis encoding.
    /// </summary>
    abstract member encode: AxisEncode option with get, set

[<AllowNullLiteral>]
[<Interface>]
type AxisEncode =
    /// <summary>
    /// Custom encoding for the axis container.
    /// </summary>
    abstract member axis: GuideEncodeEntry<GroupEncodeEntry> option with get, set
    /// <summary>
    /// Custom encoding for axis tick rule marks.
    /// </summary>
    abstract member ticks: GuideEncodeEntry<GroupEncodeEntry> option with get, set
    /// <summary>
    /// Custom encoding for axis label text marks.
    /// </summary>
    abstract member labels: GuideEncodeEntry<TextEncodeEntry> option with get, set
    /// <summary>
    /// Custom encoding for the axis title text mark.
    /// </summary>
    abstract member title: GuideEncodeEntry<TextEncodeEntry> option with get, set
    /// <summary>
    /// Custom encoding for axis gridline rule marks.
    /// </summary>
    abstract member grid: GuideEncodeEntry<RuleEncodeEntry> option with get, set
    /// <summary>
    /// Custom encoding for the axis domain rule mark.
    /// </summary>
    abstract member domain: GuideEncodeEntry<RuleEncodeEntry> option with get, set


module Axis =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type orient =
        | top
        | bottom
        | left
        | right

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type formatType =
        | number
        | time
        | utc

    module BaseAxis =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type tickBand =
            | center
            | extent

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type labelOverlap =
            | parity
            | greedy

module BaseAxis =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type tickBand =
        | center
        | extent

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type labelOverlap =
        | parity
        | greedy
