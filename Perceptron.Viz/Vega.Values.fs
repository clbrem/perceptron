namespace Vega

open Fable.Core
open Fable.Core.JsInterop
open System





type NumberValue =
    U2<float, NumericValueRef>

type FontWeightValue =
    U2<FontWeight, FontWeightValueRef>

type FontStyleValue =
    U2<FontStyle, FontStyleValueRef>

type StringValue =
    U2<string, StringValueRef>

type ColorValue =
    U2<Color, ColorValueRef> option

type AlignValue =
    U2<Align, AlignValueRef>

type StrokeCapValue =
    U2<StrokeCap, StrokeCapValueRef>

type TextBaselineValue =
    U2<TextBaseline, TextBaselineValueRef>

type SymbolShapeValue =
    U2<SymbolShape, SymbolShapeValueRef>

type BooleanValue =
    U2<bool, BooleanValueRef>

type DashArrayValue =
    U2<ResizeArray<float>, ArrayValueRef>

type AnchorValue =
    U2<TitleAnchor, AnchorValueRef>

type OrientValue =
    U2<Orient, OrientValueRef>
