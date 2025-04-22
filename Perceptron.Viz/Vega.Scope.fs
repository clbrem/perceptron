namespace Vega

open Fable.Core



[<AllowNullLiteral>]
[<Interface>]
type Scope =
    abstract member title: U2<string, Title> option with get, set
    abstract member layout: Layout option with get, set
    abstract member signals: ResizeArray<Signal> option with get, set
    abstract member projections: ResizeArray<Projection> option with get, set
    abstract member data: ResizeArray<Data> option with get, set
    abstract member scales: ResizeArray<Scale> option with get, set
    abstract member axes: ResizeArray<Axis> option with get, set
    abstract member legends: ResizeArray<Legend> option with get, set
    abstract member marks: ResizeArray<Mark> option with get, set
    abstract member usermeta: obj option with get, set
