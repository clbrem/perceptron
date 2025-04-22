namespace Vega


open Fable.Core
open Fable.Core.JsInterop
open System


[<AllowNullLiteral>]
[<Interface>]
type Locale =
    abstract member number: NumberLocale option with get, set
    abstract member time: TimeLocale option with get, set

[<AllowNullLiteral>]
[<Interface>]
type NumberLocale =
    /// <summary>
    /// The decimal point (e.g., ".").
    /// </summary>
    abstract member decimal: string with get, set
    /// <summary>
    /// The group separator (e.g., ",").
    /// </summary>
    abstract member thousands: string with get, set
    /// <summary>
    /// The array of group sizes (e.g., [3]), cycled as needed.
    /// </summary>
    abstract member grouping: ResizeArray<float> with get, set
    /// <summary>
    /// The currency prefix and suffix (e.g., ["$", ""]).
    /// </summary>
    abstract member currency: Vector2<string> with get, set
    /// <summary>
    /// An array of ten strings to replace the numerals 0-9.
    /// </summary>
    abstract member numerals: Vector10<string> option with get, set
    /// <summary>
    /// The percent sign (defaults to "%").
    /// </summary>
    abstract member percent: string option with get, set
    /// <summary>
    /// The minus sign (defaults to hyphen-minus, "-").
    /// </summary>
    abstract member minus: string option with get, set
    /// <summary>
    /// The not-a-number value (defaults to "NaN").
    /// </summary>
    abstract member nan: string option with get, set

[<AllowNullLiteral>]
[<Interface>]
type TimeLocale =
    /// <summary>
    /// The date and time (%c) format specifier (e.g., "%a %b %e %X %Y").
    /// </summary>
    abstract member dateTime: string with get, set
    /// <summary>
    /// The date (%x) format specifier (e.g., "%m/%d/%Y").
    /// </summary>
    abstract member date: string with get, set
    /// <summary>
    /// The time (%X) format specifier (e.g., "%H:%M:%S").
    /// </summary>
    abstract member time: string with get, set
    /// <summary>
    /// The A.M. and P.M. equivalents (e.g., ["AM", "PM"]).
    /// </summary>
    abstract member periods: Vector2<string> with get, set
    /// <summary>
    /// The full names of the weekdays, starting with Sunday.
    /// </summary>
    abstract member days: Vector7<string> with get, set
    /// <summary>
    /// The abbreviated names of the weekdays, starting with Sunday.
    /// </summary>
    abstract member shortDays: Vector7<string> with get, set
    /// <summary>
    /// The full names of the months (starting with January).
    /// </summary>
    abstract member months: Vector12<string> with get, set
    /// <summary>
    /// The abbreviated names of the months (starting with January).
    /// </summary>
    abstract member shortMonths: Vector12<string> with get, set
