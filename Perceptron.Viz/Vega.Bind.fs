namespace Vega

open Fable.Core

open Browser.Types


type Element =
    string

module BindRadioSelect =

    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type input =
        | radio
        | select

[<AllowNullLiteral>]
[<Interface>]
type BindBase =
    /// <summary>
    /// An optional CSS selector string indicating the parent element to which
    /// the input element should be added. By default, all input elements are
    /// added within the parent container of the Vega view.
    /// </summary>
    abstract member element: Element option with get, set
    /// <summary>
    /// If defined, delays event handling until the specified milliseconds have
    /// elapsed since the last event was fired.
    /// </summary>
    abstract member debounce: float option with get, set
    /// <summary>
    /// By default, the signal name is used to label input elements.
    /// This <c>name</c> property can be used instead to specify a custom
    /// label for the bound signal.
    /// </summary>
    abstract member name: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type BindInput =
    inherit BindBase
    /// <summary>
    /// The type of input element to use.
    /// The valid values are <c>"checkbox"</c>, <c>"radio"</c>, <c>"range"</c>, <c>"select"</c>,
    /// and any other legal [HTML form input type](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input).
    /// </summary>
    abstract member input: string option with get, set
    /// <summary>
    /// Text that appears in the form control when it has no value set.
    /// </summary>
    abstract member placeholder: string option with get, set
    /// <summary>
    /// A hint for form autofill.
    /// See the [HTML autocomplete attribute](https://developer.mozilla.org/en-US/docs/Web/HTML/Attributes/autocomplete) for additional information.
    /// </summary>
    abstract member autocomplete: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type BindCheckbox =
    inherit BindBase
    abstract member input: string with get, set

[<AllowNullLiteral>]
[<Interface>]
type BindRadioSelect =
    inherit BindBase
    abstract member input: BindRadioSelect.input with get, set
    /// <summary>
    /// An array of options to select from.
    /// </summary>
    abstract member options: ResizeArray<obj> with get, set
    /// <summary>
    /// An array of label strings to represent the <c>options</c> values. If
    /// unspecified, the <c>options</c> value will be coerced to a string and
    /// used as the label.
    /// </summary>
    abstract member labels: ResizeArray<string> option with get, set

[<AllowNullLiteral>]
[<Interface>]
type BindRange =
    inherit BindBase
    abstract member input: string with get, set
    /// <summary>
    /// Sets the minimum slider value. Defaults to the smaller of the signal value and <c>0</c>.
    /// </summary>
    abstract member min: float option with get, set
    /// <summary>
    /// Sets the maximum slider value. Defaults to the larger of the signal value and <c>100</c>.
    /// </summary>
    abstract member max: float option with get, set
    /// <summary>
    /// Sets the minimum slider increment. If undefined, the step size will be
    /// automatically determined based on the <c>min</c> and <c>max</c> values.
    /// </summary>
    abstract member step: float option with get, set

[<AllowNullLiteral>]
[<Interface>]
type BindDirect =
    /// <summary>
    /// An input element that exposes a _value_ property and supports the
    /// [EventTarget](https://developer.mozilla.org/en-US/docs/Web/API/EventTarget)
    /// interface, or a CSS selector string to such an element. When the element
    /// updates and dispatches an event, the _value_ property will be used as the
    /// new, bound signal value. When the signal updates independent of the
    /// element, the _value_ property will be set to the signal value and a new
    /// event will be dispatched on the element.
    /// </summary>
    abstract member element: U2<Element, EventTarget> with get, set
    /// <summary>
    /// The event (default <c>"input"</c>) to listen for to track changes on the
    /// external element.
    /// </summary>
    abstract member event: string option with get, set
    /// <summary>
    /// If defined, delays event handling until the specified milliseconds have
    /// elapsed since the last event was fired.
    /// </summary>
    abstract member debounce: float option with get, set

type Binding =
    U5<BindCheckbox, BindRadioSelect, BindRange, BindInput, BindDirect>



module Binding =

    module U5 =

        module Case2 =

            module BindRadioSelect =

                [<RequireQualifiedAccess>]
                [<StringEnum(CaseRules.None)>]
                type input =
                    | radio
                    | select
