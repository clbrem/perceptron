namespace Vega

type SignalValue =
    obj

[<AllowNullLiteral>]
[<Interface>]
type SignalRef =
    abstract member signal: string with get, set

