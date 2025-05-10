namespace Vega

open Fable.Core

type GuideEncodeEntry<'T> =
    {
    name: string option 
    /// <summary>
    /// A boolean flag indicating if the guide element should respond to input events such as mouse hover.
    /// </summary>
    interactive: bool option 
    /// <summary>
    /// A mark style property to apply to the guide group mark.
    /// </summary>
    style: U2<string, ResizeArray<string>> option 
    enter: 'T option 
    update: 'T option 
    exit: 'T option 
    hover: 'T option        
    }
     

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type LegendType =
    | gradient
    | symbol
    | discrete

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type LegendOrient =
    | none
    | left
    | right
    | top
    | bottom
    | ``top-left``
    | ``top-right``
    | ``bottom-left``
    | ``bottom-right``

[<AllowNullLiteral>]
[<Interface>]


[<AllowNullLiteral>]
[<Interface>]
type LegendEncode =
    abstract member title: GuideEncodeEntry<TextEncodeEntry> option with get, set
    abstract member labels: GuideEncodeEntry<TextEncodeEntry> option with get, set
    abstract member legend: GuideEncodeEntry<GroupEncodeEntry> option with get, set
    abstract member entries: GuideEncodeEntry<GroupEncodeEntry> option with get, set
    abstract member symbols: GuideEncodeEntry<SymbolEncodeEntry> option with get, set
    abstract member gradient: GuideEncodeEntry<RectEncodeEntry> option with get, set



module Legend =

    module BaseLegend =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type orient =
            | none
            | left
            | right
            | top
            | bottom
            | ``top-left``
            | ``top-right``
            | ``bottom-left``
            | ``bottom-right``

module BaseLegend =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type orient =
        | none
        | left
        | right
        | top
        | bottom
        | ``top-left``
        | ``top-right``
        | ``bottom-left``
        | ``bottom-right``
[<AllowNullLiteral>]
[<Interface>]
type BaseLegend =
    /// <summary>
    /// The orientation of the legend, which determines how the legend is positioned within the scene. One of "left", "right", "top-left", "top-right", "bottom-left", "bottom-right", "none".
    ///
    /// __Default value:__ <c>"right"</c>
    /// </summary>
    abstract member orient: BaseLegend.orient option with get, set
    /// <summary>
    /// The maximum number of allowed entries for a symbol legend. Additional entries will be dropped.
    /// </summary>
    abstract member symbolLimit: NumberValue option with get, set
    /// <summary>
    /// The desired number of tick values for quantitative legends.
    /// </summary>
    abstract member tickCount: TickCount option with get, set
    /// <summary>
    /// A boolean flag indicating if [ARIA attributes](https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA) should be included (SVG output only).
    /// If <c>false</c>, the "aria-hidden" attribute will be set on the output SVG group, removing the legend from the ARIA accessibility tree.
    ///
    /// __Default value:__ <c>true</c>
    /// </summary>
    abstract member aria: bool option with get, set
    /// <summary>
    /// A text description of this legend for [ARIA accessibility](https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA) (SVG output only).
    /// If the <c>aria</c> property is true, for SVG output the ["aria-label" attribute](https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA/ARIA_Techniques/Using_the_aria-label_attribute) will be set to this description.
    /// If the description is unspecified it will be automatically generated.
    /// </summary>
    abstract member description: string option with get, set
    /// <summary>
    /// Corner radius for the full legend.
    /// </summary>
    abstract member cornerRadius: NumberValue option with get, set
    /// <summary>
    /// Background fill color for the full legend.
    /// </summary>
    abstract member fillColor: ColorValue option with get, set
    /// <summary>
    /// The offset in pixels by which to displace the legend from the data rectangle and axes.
    ///
    /// __Default value:__ <c>18</c>.
    /// </summary>
    abstract member offset: NumberValue option with get, set
    /// <summary>
    /// The padding between the border and content of the legend group.
    ///
    /// __Default value:__ <c>0</c>.
    /// </summary>
    abstract member padding: NumberValue option with get, set
    /// <summary>
    /// Border stroke color for the full legend.
    /// </summary>
    abstract member strokeColor: ColorValue option with get, set
    /// <summary>
    /// Custom x-position for legend with orient "none".
    /// </summary>
    abstract member legendX: NumberValue option with get, set
    /// <summary>
    /// Custom y-position for legend with orient "none".
    /// </summary>
    abstract member legendY: NumberValue option with get, set
    /// <summary>
    /// Horizontal text alignment for legend titles.
    ///
    /// __Default value:__ <c>"left"</c>.
    /// </summary>
    abstract member titleAlign: AlignValue option with get, set
    /// <summary>
    /// Text anchor position for placing legend titles.
    /// </summary>
    abstract member titleAnchor: AnchorValue option with get, set
    /// <summary>
    /// Vertical text baseline for legend titles.  One of <c>"alphabetic"</c> (default), <c>"top"</c>, <c>"middle"</c>, <c>"bottom"</c>, <c>"line-top"</c>, or <c>"line-bottom"</c>. The <c>"line-top"</c> and <c>"line-bottom"</c> values operate similarly to <c>"top"</c> and <c>"bottom"</c>, but are calculated relative to the *lineHeight* rather than *fontSize* alone.
    ///
    /// __Default value:__ <c>"top"</c>.
    /// </summary>
    abstract member titleBaseline: TextBaselineValue option with get, set
    /// <summary>
    /// The color of the legend title, can be in hex color code or regular color name.
    /// </summary>
    abstract member titleColor: ColorValue option with get, set
    /// <summary>
    /// The font of the legend title.
    /// </summary>
    abstract member titleFont: StringValue option with get, set
    /// <summary>
    /// The font size of the legend title.
    /// </summary>
    abstract member titleFontSize: NumberValue option with get, set
    /// <summary>
    /// The font style of the legend title.
    /// </summary>
    abstract member titleFontStyle: FontStyleValue option with get, set
    /// <summary>
    /// The font weight of the legend title.
    /// This can be either a string (e.g <c>"bold"</c>, <c>"normal"</c>) or a number (<c>100</c>, <c>200</c>, <c>300</c>, ..., <c>900</c> where <c>"normal"</c> = <c>400</c> and <c>"bold"</c> = <c>700</c>).
    /// </summary>
    abstract member titleFontWeight: FontWeightValue option with get, set
    /// <summary>
    /// Maximum allowed pixel width of legend titles.
    ///
    /// __Default value:__ <c>180</c>.
    /// </summary>
    abstract member titleLimit: NumberValue option with get, set
    /// <summary>
    /// Line height in pixels for multi-line title text or title text with <c>"line-top"</c> or <c>"line-bottom"</c> baseline.
    /// </summary>
    abstract member titleLineHeight: NumberValue option with get, set
    /// <summary>
    /// Opacity of the legend title.
    /// </summary>
    abstract member titleOpacity: NumberValue option with get, set
    /// <summary>
    /// Orientation of the legend title.
    /// </summary>
    abstract member titleOrient: OrientValue option with get, set
    /// <summary>
    /// The padding, in pixels, between title and legend.
    ///
    /// __Default value:__ <c>5</c>.
    /// </summary>
    abstract member titlePadding: NumberValue option with get, set
    /// <summary>
    /// The length in pixels of the primary axis of a color gradient. This value corresponds to the height of a vertical gradient or the width of a horizontal gradient.
    ///
    /// __Default value:__ <c>200</c>.
    /// </summary>
    abstract member gradientLength: U2<float, SignalRef> option with get, set
    /// <summary>
    /// Opacity of the color gradient.
    /// </summary>
    abstract member gradientOpacity: NumberValue option with get, set
    /// <summary>
    /// The thickness in pixels of the color gradient. This value corresponds to the width of a vertical gradient or the height of a horizontal gradient.
    ///
    /// __Default value:__ <c>16</c>.
    /// </summary>
    abstract member gradientThickness: U2<float, SignalRef> option with get, set
    /// <summary>
    /// The color of the gradient stroke, can be in hex color code or regular color name.
    ///
    /// __Default value:__ <c>"lightGray"</c>.
    /// </summary>
    abstract member gradientStrokeColor: ColorValue option with get, set
    /// <summary>
    /// The width of the gradient stroke, in pixels.
    ///
    /// __Default value:__ <c>0</c>.
    /// </summary>
    abstract member gradientStrokeWidth: NumberValue option with get, set
    /// <summary>
    /// The height in pixels to clip symbol legend entries and limit their size.
    /// </summary>
    abstract member clipHeight: U2<float, SignalRef> option with get, set
    /// <summary>
    /// The number of columns in which to arrange symbol legend entries. A value of <c>0</c> or lower indicates a single row with one column per entry.
    /// </summary>
    abstract member columns: U2<float, SignalRef> option with get, set
    /// <summary>
    /// The horizontal padding in pixels between symbol legend entries.
    ///
    /// __Default value:__ <c>10</c>.
    /// </summary>
    abstract member columnPadding: U2<float, SignalRef> option with get, set
    /// <summary>
    /// The vertical padding in pixels between symbol legend entries.
    ///
    /// __Default value:__ <c>2</c>.
    /// </summary>
    abstract member rowPadding: U2<float, SignalRef> option with get, set
    /// <summary>
    /// The alignment to apply to symbol legends rows and columns. The supported string values are <c>"all"</c>, <c>"each"</c> (the default), and <c>none</c>. For more information, see the [grid layout documentation](https://vega.github.io/vega/docs/layout).
    ///
    /// __Default value:__ <c>"each"</c>.
    /// </summary>
    abstract member gridAlign: U2<LayoutAlign, SignalRef> option with get, set
    /// <summary>
    /// An array of alternating [stroke, space] lengths for dashed symbol strokes.
    /// </summary>
    abstract member symbolDash: DashArrayValue option with get, set
    /// <summary>
    /// The pixel offset at which to start drawing with the symbol stroke dash array.
    /// </summary>
    abstract member symbolDashOffset: NumberValue option with get, set
    /// <summary>
    /// The color of the legend symbol,
    /// </summary>
    abstract member symbolFillColor: ColorValue option with get, set
    /// <summary>
    /// Horizontal pixel offset for legend symbols.
    ///
    /// __Default value:__ <c>0</c>.
    /// </summary>
    abstract member symbolOffset: NumberValue option with get, set
    /// <summary>
    /// Opacity of the legend symbols.
    /// </summary>
    abstract member symbolOpacity: NumberValue option with get, set
    /// <summary>
    /// The size of the legend symbol, in pixels.
    ///
    /// __Default value:__ <c>100</c>.
    /// </summary>
    abstract member symbolSize: NumberValue option with get, set
    /// <summary>
    /// Stroke color for legend symbols.
    /// </summary>
    abstract member symbolStrokeColor: ColorValue option with get, set
    /// <summary>
    /// The width of the symbol's stroke.
    ///
    /// __Default value:__ <c>1.5</c>.
    /// </summary>
    abstract member symbolStrokeWidth: NumberValue option with get, set
    /// <summary>
    /// The symbol shape. One of the plotting shapes <c>circle</c> (default), <c>square</c>, <c>cross</c>, <c>diamond</c>, <c>triangle-up</c>, <c>triangle-down</c>, <c>triangle-right</c>, or <c>triangle-left</c>, the line symbol <c>stroke</c>, or one of the centered directional shapes <c>arrow</c>, <c>wedge</c>, or <c>triangle</c>. Alternatively, a custom [SVG path string](https://developer.mozilla.org/en-US/docs/Web/SVG/Tutorial/Paths) can be provided. For correct sizing, custom shape paths should be defined within a square bounding box with coordinates ranging from -1 to 1 along both the x and y dimensions.
    ///
    /// __Default value:__ <c>"circle"</c>.
    /// </summary>
    abstract member symbolType: U2<SymbolShapeValue, SignalRef> option with get, set
    /// <summary>
    /// The alignment of the legend label, can be left, center, or right.
    /// </summary>
    abstract member labelAlign: AlignValue option with get, set
    /// <summary>
    /// The position of the baseline of legend label, can be <c>"top"</c>, <c>"middle"</c>, <c>"bottom"</c>, or <c>"alphabetic"</c>.
    ///
    /// __Default value:__ <c>"middle"</c>.
    /// </summary>
    abstract member labelBaseline: TextBaselineValue option with get, set
    /// <summary>
    /// The color of the legend label, can be in hex color code or regular color name.
    /// </summary>
    abstract member labelColor: ColorValue option with get, set
    /// <summary>
    /// The font of the legend label.
    /// </summary>
    abstract member labelFont: StringValue option with get, set
    /// <summary>
    /// The font size of legend label.
    ///
    /// __Default value:__ <c>10</c>.
    /// </summary>
    abstract member labelFontSize: NumberValue option with get, set
    /// <summary>
    /// The font style of legend label.
    /// </summary>
    abstract member labelFontStyle: FontStyleValue option with get, set
    /// <summary>
    /// The font weight of legend label.
    /// </summary>
    abstract member labelFontWeight: FontWeightValue option with get, set
    /// <summary>
    /// Maximum allowed pixel width of legend tick labels.
    ///
    /// __Default value:__ <c>160</c>.
    /// </summary>
    abstract member labelLimit: NumberValue option with get, set
    /// <summary>
    /// Opacity of labels.
    /// </summary>
    abstract member labelOpacity: NumberValue option with get, set
    /// <summary>
    /// Padding in pixels between the legend and legend labels.
    /// </summary>
    abstract member labelPadding: NumberValue option with get, set
    /// <summary>
    /// The offset of the legend label.
    ///
    /// __Default value:__ <c>4</c>.
    /// </summary>
    abstract member labelOffset: NumberValue option with get, set
    /// <summary>
    /// The strategy to use for resolving overlap of labels in gradient legends. If <c>false</c>, no overlap reduction is attempted. If set to <c>true</c> (default) or <c>"parity"</c>, a strategy of removing every other label is used. If set to <c>"greedy"</c>, a linear scan of the labels is performed, removing any label that overlaps with the last visible label (this often works better for log-scaled axes).
    ///
    /// __Default value:__ <c>true</c>.
    /// </summary>
    abstract member labelOverlap: U2<LabelOverlap, SignalRef> option with get, set
    /// <summary>
    /// The minimum separation that must be between label bounding boxes for them to be considered non-overlapping (default <c>0</c>). This property is ignored if *labelOverlap* resolution is not enabled.
    /// </summary>
    abstract member labelSeparation: U2<float, SignalRef> option with get, set
    /// <summary>
    /// The integer z-index indicating the layering of the legend group relative to other axis, mark, and legend groups.
    /// </summary>
    abstract member zindex: float option with get, set
    
type Legend =
    inherit BaseLegend
    abstract member size: string option with get, set
    abstract member shape: string option with get, set
    abstract member fill: string option with get, set
    abstract member stroke: string option with get, set
    abstract member strokeDash: string option with get, set
    abstract member strokeWidth: string option with get, set
    abstract member opacity: string option with get, set
    /// <summary>
    /// The type of legend to include. One of <c>"symbol"</c> for discrete symbol legends, <c>"gradient"</c> for a continuous color gradient, or <c>"discrete"</c> for a discrete color gradient. If gradient or discrete are used, only the fill or stroke scale parameters are considered. If unspecified, the type will be inferred based on the scale parameters used and their backing scale types.
    /// </summary>
    abstract member ``type``: LegendType option with get, set
    /// <summary>
    /// The direction of the legend, one of <c>"vertical"</c> (default) or <c>"horizontal"</c>.
    ///
    /// __Default value:__ <c>"vertical"</c>
    /// </summary>
    abstract member direction: Orientation option with get, set
    /// <summary>
    /// The format specifier pattern for legend labels. For numerical values, must be a legal [d3-format](https://github.com/d3/d3-format#locale_format) specifier. For date-time values, must be a legal [d3-time-format](https://github.com/d3/d3-time-format#locale_format) specifier or multi-format object.
    /// </summary>
    abstract member format: U3<string, TimeFormatSpecifier, SignalRef> option with get, set
    /// <summary>
    /// The format type for legend labels (number, time, or utc).
    /// </summary>
    abstract member formatType: U2<FormatType, SignalRef> option with get, set
    /// <summary>
    /// The title for the legend.
    /// </summary>
    abstract member title: U2<Text, SignalRef> option with get, set
    /// <summary>
    /// The minimum desired step between tick values for quantitative legends, in terms of scale domain values. For example, a value of <c>1</c> indicates that ticks should not be less than 1 unit apart. If <c>tickMinStep</c> is specified, the <c>tickCount</c> value will be adjusted, if necessary, to enforce the minimum step value.
    /// </summary>
    abstract member tickMinStep: U2<float, SignalRef> option with get, set
    /// <summary>
    /// Explicitly set the visible legend values.
    /// </summary>
    abstract member values: U2<ResizeArray<obj>, SignalRef> option with get, set
    /// <summary>
    /// Mark definitions for custom legend encoding.
    /// </summary>
    abstract member encode: LegendEncode option with get, set    