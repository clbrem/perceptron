module rec Glutinum

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

[<AllowNullLiteral>]
[<Interface>]
type Title =
    inherit BaseTitle
    /// <summary>
    /// The title text.
    /// </summary>
    abstract member text: U2<Text, SignalRef> with get, set
    /// <summary>
    /// The subtitle text.
    /// </summary>
    abstract member subtitle: U2<Text, SignalRef> option with get, set
    /// <summary>
    /// A mark name property to apply to the title text mark. (**Deprecated.**)
    /// </summary>
    abstract member name: string option with get, set
    /// <summary>
    /// A boolean flag indicating if the title element should respond to input events such as mouse hover. (**Deprecated.**)
    /// </summary>
    abstract member interactive: bool option with get, set
    /// <summary>
    /// A mark style property to apply to the title text mark. If not specified, a default style of <c>"group-title"</c> is applied. (**Deprecated**)
    /// </summary>
    abstract member style: U2<string, ResizeArray<string>> option with get, set
    /// <summary>
    /// Mark definitions for custom title encoding.
    /// </summary>
    abstract member encode: U2<TitleEncode, Encode<TextEncodeEntry>> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type TitleEncode =
    /// <summary>
    /// Custom encoding for the title container group.
    /// </summary>
    abstract member group: GuideEncodeEntry<GroupEncodeEntry> option with get, set
    /// <summary>
    /// Custom encoding for the title text.
    /// </summary>
    abstract member title: GuideEncodeEntry<TextEncodeEntry> option with get, set
    /// <summary>
    /// Custom encoding for the subtitle text.
    /// </summary>
    abstract member subtitle: GuideEncodeEntry<TextEncodeEntry> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type BaseTitle =
    /// <summary>
    /// The anchor position for placing the title and subtitle text. One of <c>"start"</c>, <c>"middle"</c>, or <c>"end"</c>. For example, with an orientation of top these anchor positions map to a left-, center-, or right-aligned title.
    /// </summary>
    abstract member anchor: AnchorValue option with get, set
    /// <summary>
    /// The reference frame for the anchor position, one of <c>"bounds"</c> (to anchor relative to the full bounding box) or <c>"group"</c> (to anchor relative to the group width or height).
    /// </summary>
    abstract member frame: BaseTitle.frame option with get, set
    /// <summary>
    /// The orthogonal offset in pixels by which to displace the title group from its position along the edge of the chart.
    /// </summary>
    abstract member offset: NumberValue option with get, set
    /// <summary>
    /// Default title orientation (<c>"top"</c>, <c>"bottom"</c>, <c>"left"</c>, or <c>"right"</c>)
    /// </summary>
    abstract member orient: BaseTitle.orient option with get, set
    /// <summary>
    /// A boolean flag indicating if [ARIA attributes](https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA) should be included (SVG output only).
    /// If <c>false</c>, the "aria-hidden" attribute will be set on the output SVG group, removing the title from the ARIA accessibility tree.
    ///
    /// __Default value:__ <c>true</c>
    /// </summary>
    abstract member aria: bool option with get, set
    /// <summary>
    /// Horizontal text alignment for title text. One of <c>"left"</c>, <c>"center"</c>, or <c>"right"</c>.
    /// </summary>
    abstract member align: AlignValue option with get, set
    /// <summary>
    /// Angle in degrees of title and subtitle text.
    /// </summary>
    abstract member angle: NumberValue option with get, set
    /// <summary>
    /// Vertical text baseline for title and subtitle text. One of <c>"alphabetic"</c> (default), <c>"top"</c>, <c>"middle"</c>, <c>"bottom"</c>, <c>"line-top"</c>, or <c>"line-bottom"</c>. The <c>"line-top"</c> and <c>"line-bottom"</c> values operate similarly to <c>"top"</c> and <c>"bottom"</c>, but are calculated relative to the *lineHeight* rather than *fontSize* alone.
    /// </summary>
    abstract member baseline: TextBaselineValue option with get, set
    /// <summary>
    /// Delta offset for title and subtitle text x-coordinate.
    /// </summary>
    abstract member dx: NumberValue option with get, set
    /// <summary>
    /// Delta offset for title and subtitle text y-coordinate.
    /// </summary>
    abstract member dy: NumberValue option with get, set
    /// <summary>
    /// The maximum allowed length in pixels of title and subtitle text.
    /// </summary>
    abstract member limit: NumberValue option with get, set
    /// <summary>
    /// Text color for title text.
    /// </summary>
    abstract member color: ColorValue option with get, set
    /// <summary>
    /// Font name for title text.
    /// </summary>
    abstract member font: StringValue option with get, set
    /// <summary>
    /// Font size in pixels for title text.
    /// </summary>
    abstract member fontSize: NumberValue option with get, set
    /// <summary>
    /// Font style for title text.
    /// </summary>
    abstract member fontStyle: FontStyleValue option with get, set
    /// <summary>
    /// Font weight for title text.
    /// This can be either a string (e.g <c>"bold"</c>, <c>"normal"</c>) or a number (<c>100</c>, <c>200</c>, <c>300</c>, ..., <c>900</c> where <c>"normal"</c> = <c>400</c> and <c>"bold"</c> = <c>700</c>).
    /// </summary>
    abstract member fontWeight: FontWeightValue option with get, set
    /// <summary>
    /// Line height in pixels for multi-line title text or title text with <c>"line-top"</c> or <c>"line-bottom"</c> baseline.
    /// </summary>
    abstract member lineHeight: NumberValue option with get, set
    /// <summary>
    /// Text color for subtitle text.
    /// </summary>
    abstract member subtitleColor: ColorValue option with get, set
    /// <summary>
    /// Font name for subtitle text.
    /// </summary>
    abstract member subtitleFont: StringValue option with get, set
    /// <summary>
    /// Font size in pixels for subtitle text.
    /// </summary>
    abstract member subtitleFontSize: NumberValue option with get, set
    /// <summary>
    /// Font style for subtitle text.
    /// </summary>
    abstract member subtitleFontStyle: FontStyleValue option with get, set
    /// <summary>
    /// Font weight for subtitle text.
    /// This can be either a string (e.g <c>"bold"</c>, <c>"normal"</c>) or a number (<c>100</c>, <c>200</c>, <c>300</c>, ..., <c>900</c> where <c>"normal"</c> = <c>400</c> and <c>"bold"</c> = <c>700</c>).
    /// </summary>
    abstract member subtitleFontWeight: FontWeightValue option with get, set
    /// <summary>
    /// Line height in pixels for multi-line subtitle text.
    /// </summary>
    abstract member subtitleLineHeight: NumberValue option with get, set
    /// <summary>
    /// The padding in pixels between title and subtitle text.
    /// </summary>
    abstract member subtitlePadding: NumberValue option with get, set
    /// <summary>
    /// The integer z-index indicating the layering of the title group relative to other axis, mark, and legend groups.
    ///
    /// __Default value:__ <c>0</c>.
    /// </summary>
    abstract member zindex: float option with get, set

module Title =

    module BaseTitle =

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type frame =
            | bounds
            | group

        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type orient =
            | none
            | left
            | right
            | top
            | bottom

module BaseTitle =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type frame =
        | bounds
        | group

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type orient =
        | none
        | left
        | right
        | top
        | bottom
