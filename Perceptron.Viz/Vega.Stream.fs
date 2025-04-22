namespace Vega
module rec Stream = 
    
    open Fable.Core
    open Fable.Core.JsInterop
    open System
    
    
    type EventSource =
        obj
    
    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type EventType =
        | click
        | dblclick
        | dragenter
        | dragleave
        | dragover
        | keydown
        | keypress
        | keyup
        | mousedown
        | mousemove
        | mouseout
        | mouseover
        | mouseup
        | mousewheel
        | pointerdown
        | pointermove
        | pointerout
        | pointerover
        | pointerup
        | timer
        | touchend
        | touchmove
        | touchstart
        | wheel
    
    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type WindowEventType =
        | click
        | dblclick
        | dragenter
        | dragleave
        | dragover
        | keydown
        | keypress
        | keyup
        | mousedown
        | mousemove
        | mouseout
        | mouseover
        | mouseup
        | mousewheel
        | pointerdown
        | pointermove
        | pointerout
        | pointerover
        | pointerup
        | timer
        | touchend
        | touchmove
        | touchstart
        | wheel
    
    [<AllowNullLiteral>]
    [<Interface>]
    type StreamParameters =
        abstract member between: ResizeArray<Stream> option with get, set
        abstract member marktype: MarkType option with get, set
        abstract member markname: string option with get, set
        abstract member filter: U2<Expr, ResizeArray<Expr>> option with get, set
        abstract member throttle: float option with get, set
        abstract member debounce: float option with get, set
        abstract member consume: bool option with get, set
    [<RequireQualifiedAccess>]
    [<StringEnum(CaseRules.None)>]
    type EventStreamSource =
        | view
        | scope
        | window
        // Note: this uses some weird algebraic types in the original. Maybe this should be addressed...
    [<AllowNullLiteral>]
    [<Interface>]
    type EventStream =
        abstract member between: ResizeArray<Stream> option with get, set
        abstract member marktype: MarkType option with get, set
        abstract member markname: string option with get, set
        abstract member filter: U2<Expr, ResizeArray<Expr>> option with get, set
        abstract member throttle: float option with get, set
        abstract member debounce: float option with get, set
        abstract member consume: bool option with get, set
        abstract member source: EventStreamSource option with get, set                
        abstract member ``type``: U2<WindowEventType, EventType> with get, set
    
    [<AllowNullLiteral>]
    [<Interface>]
    type DerivedStream =
        inherit StreamParameters
        abstract member stream: Stream with get, set
    
    [<AllowNullLiteral>]
    [<Interface>]
    type MergedStream =
        inherit StreamParameters
        abstract member merge: ResizeArray<Stream> with get, set
    
    type Stream =
        U3<EventStream, DerivedStream, MergedStream>
    
    module EventStream =
    
        [<RequireQualifiedAccess>]
        [<StringEnum(CaseRules.None)>]
        type source =
            | view
            | scope
