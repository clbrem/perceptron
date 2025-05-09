namespace Vega

open Fable.Core
open Fable.Core.JsInterop
open System


[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type TitleOrient =
    | none
    | left
    | right
    | top
    | bottom

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type TitleAnchor =
    | start
    | middle
    | ``end``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type TitleFrame =
    | bounds
    | group
type BaseTitle =
    {
    /// <summary>
    /// The anchor position for placing the title and subtitle text. One of <c>"start"</c>, <c>"middle"</c>, or <c>"end"</c>. For example, with an orientation of top these anchor positions map to a left-, center-, or right-aligned title.
    /// </summary>
    anchor: AnchorValue  option
    /// <summary>
    /// The reference frame for the anchor position, one of <c>"bounds"</c> (to anchor relative to the full bounding box) or <c>"group"</c> (to anchor relative to the group width or height).
    /// </summary>
    frame: TitleFrame option
    /// <summary>
    /// The orthogonal offset in pixels by which to displace the title group from its position along the edge of the chart.
    /// </summary>
    offset: NumberValue  option
    /// <summary>
    /// Default title orientation (<c>"top"</c>, <c>"bottom"</c>, <c>"left"</c>, or <c>"right"</c>)
    /// </summary>
    orient: TitleOrient option
    /// <summary>
    /// A boolean flag indicating if [ARIA attributes](https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA) should be included (SVG output only).
    /// If <c>false</c>, the "aria-hidden" attribute will be set on the output SVG group, removing the title from the ARIA accessibility tree.
    ///
    /// __Default value:__ <c>true</c>
    /// </summary>
    aria: bool  option
    /// <summary>
    /// Horizontal text alignment for title text. One of <c>"left"</c>, <c>"center"</c>, or <c>"right"</c>.
    /// </summary>
    align: AlignValue  option
    /// <summary>
    /// Angle in degrees of title and subtitle text.
    /// </summary>
    angle: NumberValue  option
    /// <summary>
    /// Vertical text baseline for title and subtitle text. One of <c>"alphabetic"</c> (default), <c>"top"</c>, <c>"middle"</c>, <c>"bottom"</c>, <c>"line-top"</c>, or <c>"line-bottom"</c>. The <c>"line-top"</c> and <c>"line-bottom"</c> values operate similarly to <c>"top"</c> and <c>"bottom"</c>, but are calculated relative to the *lineHeight* rather than *fontSize* alone.
    /// </summary>
    baseline: TextBaselineValue  option
    /// <summary>
    /// Delta offset for title and subtitle text x-coordinate.
    /// </summary>
    dx: NumberValue  option
    /// <summary>
    /// Delta offset for title and subtitle text y-coordinate.
    /// </summary>
    dy: NumberValue  option
    /// <summary>
    /// The maximum allowed length in pixels of title and subtitle text.
    /// </summary>
    limit: NumberValue  option
    /// <summary>
    /// Text color for title text.
    /// </summary>
    color: ColorValue  option
    /// <summary>
    /// Font name for title text.
    /// </summary>
    font: StringValue  option
    /// <summary>
    /// Font size in pixels for title text.
    /// </summary>
    fontSize: NumberValue  option
    /// <summary>
    /// Font style for title text.
    /// </summary>
    fontStyle: FontStyleValue  option
    /// <summary>
    /// Font weight for title text.
    /// This can be either a string (e.g <c>"bold"</c>, <c>"normal"</c>) or a number (<c>100</c>, <c>200</c>, <c>300</c>, ..., <c>900</c> where <c>"normal"</c> = <c>400</c> and <c>"bold"</c> = <c>700</c>).
    /// </summary>
    fontWeight: FontWeightValue  option
    /// <summary>
    /// Line height in pixels for multi-line title text or title text with <c>"line-top"</c> or <c>"line-bottom"</c> baseline.
    /// </summary>
    lineHeight: NumberValue  option
    /// <summary>
    /// Text color for subtitle text.
    /// </summary>
    subtitleColor: ColorValue  option
    /// <summary>
    /// Font name for subtitle text.
    /// </summary>
    subtitleFont: StringValue  option
    /// <summary>
    /// Font size in pixels for subtitle text.
    /// </summary>
    subtitleFontSize: NumberValue  option
    /// <summary>
    /// Font style for subtitle text.
    /// </summary>
    subtitleFontStyle: FontStyleValue  option
    /// <summary>
    /// Font weight for subtitle text.
    /// This can be either a string (e.g <c>"bold"</c>, <c>"normal"</c>) or a number (<c>100</c>, <c>200</c>, <c>300</c>, ..., <c>900</c> where <c>"normal"</c> = <c>400</c> and <c>"bold"</c> = <c>700</c>).
    /// </summary>
    subtitleFontWeight: FontWeightValue  option
    /// <summary>
    /// Line height in pixels for multi-line subtitle text.
    /// </summary>
    subtitleLineHeight: NumberValue  option
    /// <summary>
    /// The padding in pixels between title and subtitle text.
    /// </summary>
    subtitlePadding: NumberValue  option
    /// <summary>
    /// The integer z-index indicating the layering of the title group relative to other axis, mark, and legend groups.
    ///
    /// __Default value:__ <c>0</c>.
    /// </summary>
    zindex: float  option
}
type TitleEncode =
    {
    /// <summary>
    /// Custom encoding for the title container group.
    /// </summary>
    group: GuideEncodeEntry<GroupEncodeEntry> option 
    /// <summary>
    /// Custom encoding for the title text.
    /// </summary>
    title: GuideEncodeEntry<TextEncodeEntry> option 
    /// <summary>
    /// Custom encoding for the subtitle text.
    /// </summary>
    subtitle: GuideEncodeEntry<TextEncodeEntry> option 
}

    


type Title =
    {
        /// <summary>
        /// The title text.
        /// </summary>
        text: U2<Text, SignalRef> 
        /// <summary>
        /// The subtitle text.
        /// </summary>
        subtitle: U2<Text, SignalRef> option 
        /// <summary>
        /// A mark name property to apply to the title text mark. (**Deprecated.**)
        /// </summary>
        name: string  option
        /// <summary>
        /// A boolean flag indicating if the title element should respond to input events such as mouse hover. (**Deprecated.**)
        /// </summary>
        interactive: bool  option
        /// <summary>
        /// A mark style property to apply to the title text mark. If not specified, a default style of <c>"group-title"</c> is applied. (**Deprecated**)
        /// </summary>
        style: U2<string, ResizeArray<string>> option
        /// <summary>
        /// Mark definitions for custom title encoding.
        /// </summary>
        encode: U2<TitleEncode, Encode<TextEncodeEntry>> option 
    }

