namespace Vega


open Fable.Core
open Fable.Core.JsInterop
open System
open Vector

type NumberLocale = {
    // The decimal separator (e.g., ".")
    decimal: string
    // The grouping separator (e.g., ",")            
    thousands: string
    // The array of group sizes (e.g., [3]), cycled as needed
    grouping: int []
    // The currency prefix and suffix (e.g., ["$", ""])
    currency: Vec2<string>
    //An array of 10 strings replacing 0-9 
    numerals: Vec10<string>
}
type TimeLocale = {
    dateTime: string
    date: string
    time: string
    periods: Vec2<string>
    days: Vec7<string>
    shortDays: Vec7<string>
    months: Vec12<string>
    shortMonths: Vec12<string>
}
type Locale = {
    number: NumberLocale option
    time: TimeLocale option
}
