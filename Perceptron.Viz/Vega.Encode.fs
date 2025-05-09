namespace Vega
open Fable.Core
// import { SignalRef } from '../index.js';
// import { Color } from './color.js';
// import { Cursor, StrokeCap, StrokeJoin } from './config.d.js';
// import { TitleAnchor } from './title.js';
[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type Baseline =
    |top | middle | bottom

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type TextBaseline =
    | alphabetic
    | top
    | middle
    | bottom
    | lineTop
    | lineBottom
//
// export type Field = string | SignalRef | DatumFieldRef | GroupFieldRef | ParentFieldRef;
//
type FieldRef =
    {
        signal: string option // from SignalRef
        datum: Field option // from DatumFieldRef
        group: Field option // from GroupFieldRef
        parent: Field option // from ParentFieldRef
        level: int option // from GroupFieldRef and ParentFieldRef
    }
and Field =
    U2<string, FieldRef>
    
type BaseValueRef<'T> =
    {
        signal: string option
        value: 'T option
        field: Field option
    }


//
// export type ScaledValueRef<T> =
//   | BaseValueRef<T>
//   | {
//       scale: Field;
//       value: boolean | number | string | null;
//     }
//   | {
//       scale: Field;
//       field: Field;
//     }
//   | {
//       scale: Field;
//       band: boolean | number;
//     }
//   | {
//       scale: Field;
//       range: number | boolean;
//     };
type ScaledValueRef<'T> =
    {
        signal: string option
        value: 'T option
        field: Field option
        scale: Field option
        band: U2<bool,int> option
        range: U2<bool,int> option
    }

      
//
// export type NumericValueRef = (ScaledValueRef<number> | {}) & {
//   exponent?: number | NumericValueRef;
//   mult?: number | NumericValueRef;
//   offset?: number | NumericValueRef;
//   round?: boolean;
//   extra?: boolean;
// };
type NumericValueRef =
    {
        signal: string option
        value: int option
        field: Field option
        scale: Field option
        band: U2<bool,int> option
        range: U2<bool,int> option
        exponent: U2<int,NumericValueRef> option
        mult: U2<int,NumericValueRef> option
        offset: U2<int,NumericValueRef> option
        round: bool option
        extra: bool option
    }
    

    

//
// export type StringValueRef = ScaledValueRef<string>;
type StringValueRef = ScaledValueRef<string>


// export type FontWeightValueRef = ScaledValueRef<FontWeight>;


// export type AlignValueRef = ScaledValueRef<Align>;
//
// export type StrokeCapValueRef = ScaledValueRef<StrokeCap>;
// export type AnchorValueRef = ScaledValueRef<TitleAnchor>;
// export type OrientValueRef = ScaledValueRef<Orient>;
type TextBaselineValueRef = ScaledValueRef<TextBaseline>

// export type TextValueRef = ScaledValueRef<Text>;
// export type BooleanValueRef = ScaledValueRef<boolean>;
type BooleanValueRef = ScaledValueRef<bool>
// export type ArrayValueRef = ScaledValueRef<any[]>;
type ArrayValueRef = ScaledValueRef<obj[]>
// export type ArbitraryValueRef = NumericValueRef | ColorValueRef | ScaledValueRef<any>;
//
// export interface ColorRGB {
//   r: NumericValueRef;
//   g: NumericValueRef;
//   b: NumericValueRef;
// }
type ColorRGB = 
    {
        r: NumericValueRef
        g: NumericValueRef
        b: NumericValueRef
    }
// export interface ColorHSL {
//   h: NumericValueRef;
//   s: NumericValueRef;
//   l: NumericValueRef;
// }
type ColorHSL = 
    {
        h: NumericValueRef
        s: NumericValueRef
        l: NumericValueRef
    }
// export interface ColorLAB {
//   l: NumericValueRef;
//   a: NumericValueRef;
//   b: NumericValueRef;
// }
type ColorLAB = 
    {
        l: NumericValueRef
        a: NumericValueRef
        b: NumericValueRef
    }
// export interface ColorHCL {
//   h: NumericValueRef;
//   c: NumericValueRef;
//   l: NumericValueRef;
// }
type ColorHCL = 
    {
        h: NumericValueRef
        c: NumericValueRef
        l: NumericValueRef
    }
//
// export interface BaseGradient {
//   /**
//    * The type of gradient.
//    */
//   gradient: 'linear' | 'radial';
// }


//
// export interface GradientStop {
//   /**
//    * The offset fraction for the color stop, indicating its position within the gradient.
//    */
//   offset: number;
//   /**
//    * The color value at this point in the gradient.
//    */
//   color: Color;
// }
//
type GradientStop =
    {
        offset: int
        color: Color
    }
//
// export interface LinearGradient extends BaseGradient {
//   /**
//    * The type of gradient. Use `"linear"` for a linear gradient.
//    */
//   gradient: 'linear';
//   /**
//    * An array of gradient stops defining the gradient color sequence.
//    */
//   stops: GradientStop[];
//   id?: string;
//   /**
//    * The starting x-coordinate, in normalized [0, 1] coordinates, of the linear gradient.
//    *
//    * __Default value:__ `0`
//    */
//   x1?: number;
//   /**
//    * The starting y-coordinate, in normalized [0, 1] coordinates, of the linear gradient.
//    *
//    * __Default value:__ `0`
//    */
//   y1?: number;
//   /**
//    * The ending x-coordinate, in normalized [0, 1] coordinates, of the linear gradient.
//    *
//    * __Default value:__ `1`
//    */
//   x2?: number;
//   /**
//    * The ending y-coordinate, in normalized [0, 1] coordinates, of the linear gradient.
//    *
//    * __Default value:__ `0`
//    */
//   y2?: number;
// }
type LinearGradient =
    { stops: GradientStop[]
      id: string option
      x1: int option
      y1: int option
      x2: int option
      y2: int option
      }
//
// export interface RadialGradient extends BaseGradient {
//    * The type of gradient. Use `"radial"` for a radial gradient.
//   gradient: 'radial';
//    * An array of gradient stops defining the gradient color sequence.
//   stops: GradientStop[];
//   id?: string;
//    * The x-coordinate, in normalized [0, 1] coordinates, for the center of the inner circle for the gradient.
//    * __Default value:__ `0.5`
//   x1?: number;
//    * The y-coordinate, in normalized [0, 1] coordinates, for the center of the inner circle for the gradient.
//    * __Default value:__ `0.5`
//   y1?: number;
//    * The radius length, in normalized [0, 1] coordinates, of the inner circle for the gradient.
//    * __Default value:__ `0`
//   r1?: number;
//    * The x-coordinate, in normalized [0, 1] coordinates, for the center of the outer circle for the gradient.
//    * __Default value:__ `0.5`
//   x2?: number;
//    * The y-coordinate, in normalized [0, 1] coordinates, for the center of the outer circle for the gradient.
//    * __Default value:__ `0.5`
//   y2?: number;
//    * The radius length, in normalized [0, 1] coordinates, of the outer circle for the gradient.
//    * __Default value:__ `0.5`
//   r2?: number;
// }
type RadialGradient = 
    { stops: GradientStop[]
      id: string option
      x1: int option
      y1: int option
      r1: int option
      x2: int option
      y2: int option
      r2: int option
      }
// export type Gradient = LinearGradient | RadialGradient;
[<TypeScriptTaggedUnion("gradient")>]
[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type Gradient =
    | linear of LinearGradient
    | radial of RadialGradient
//
// export type ColorValueRef =
//   | ScaledValueRef<Color>
//   | { value: LinearGradient | RadialGradient }
//   | {
//       gradient: Field;
//       start?: number[];
//       stop?: number[];
//       count?: number;
//     }
//   | {
//       color: ColorRGB | ColorHSL | ColorLAB | ColorHCL;
//     };

type ColorValueRef =    
    {
        signal: string option
        value: U2<Color, Gradient> option
        field: Field option
        scale: Field option
        band: U2<bool,int> option
        range: U2<bool,int> option
        gradient: Field option
        start: int[] option
        stop: int[] option
        count: int
        color: U3<ColorRGB, ColorHSL, ColorLAB> option
    }
type ProductionRule = obj

[<RequireQualifiedAccess>]
type Blend =  
  | [<CompiledName("multiply")>] multiply
  | [<CompiledName("screen")>] screen
  | [<CompiledName("overlay")>] overlay
  | [<CompiledName("darken")>] darken
  | [<CompiledName("lighten")>] lighten
  | [<CompiledName("color-dodge")>] colorDodge
  | [<CompiledName("color-burn")>] colorBurn
  | [<CompiledName("hard-light")>] hardLight
  | [<CompiledName("soft-light")>] softLight
  | [<CompiledName("difference")>] difference
  | [<CompiledName("exclusion")>] exclusion
  | [<CompiledName("hue")>] hue
  | [<CompiledName("saturation")>] saturation
  | [<CompiledName("color")>] color
  | [<CompiledName("luminosity")>] luminosity
//
type EncodeEntry = obj
//
[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type Align =
    | left
    | center
    | right
// export type AlignValueRef = ScaledValueRef<Align>;
type AlignValueRef =
    ScaledValueRef<Align>
// export interface AlignProperty {
//   align?: ProductionRule<ScaledValueRef<Align>>;
// }
//
// export type Orient = 'left' | 'right' | 'top' | 'bottom';
//
// export interface DefinedProperty {
//   defined: ProductionRule
// }
//
// export interface ThetaProperty {
//   theta: ProductionRule
// }
//
// export interface ArcEncodeEntry extends EncodeEntry {
//   startAngle: ProductionRule
//   endAngle: ProductionRule
//   padAngle: ProductionRule
//   innerRadius: ProductionRule
//   outerRadius: ProductionRule
//   cornerRadius: ProductionRule
// }
//
[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type Orientation =
    |horizontal
    | vertical
//
// export interface AreaEncodeEntry extends LineEncodeEntry {
//   orient?: ProductionRule<ScaledValueRef<Orientation>>;
// }
//
// export interface RectEncodeEntry extends EncodeEntry {
//   cornerRadius: ProductionRule
//   cornerRadiusTopLeft: ProductionRule
//   cornerRadiusTopRight: ProductionRule
//   cornerRadiusBottomRight: ProductionRule
//   cornerRadiusBottomLeft: ProductionRule
// }
type GroupEncodeEntry  = obj
//
// export type Baseline = 'top' | 'middle' | 'bottom';
//
// export interface ImageEncodeEntry extends EncodeEntry, AlignProperty {
//   url: ProductionRule
//   aspect: ProductionRule
//   baseline?: ProductionRule<ScaledValueRef<Baseline>>;
//   smooth: ProductionRule
// }
//
[<RequireQualifiedAccess>]
type Interpolate =
  | [<CompiledName("basis")>] basis
  | [<CompiledName("basis-open")>] basisOpen
  | [<CompiledName("basis-closed")>] basisClosed
  | [<CompiledName("bundle")>] bundle
  | [<CompiledName("cardinal")>] cardinal
  | [<CompiledName("cardinal-open")>] cardinalOpen
  | [<CompiledName("cardinal-closed")>] cardinalClosed
  | [<CompiledName("catmull-rom")>] catmullRom
  | [<CompiledName("linear")>] linear
  | [<CompiledName("linear-closed")>] linearClosed
  | [<CompiledName("monotone")>] monotone
  | [<CompiledName("natural")>] natural
  | [<CompiledName("step")>] step
  | [<CompiledName("step-before")>] stepBefore
  | [<CompiledName("step-after")>] stepAfter
//
// export interface LineEncodeEntry extends EncodeEntry, DefinedProperty {
//   interpolate?: ProductionRule<ScaledValueRef<Interpolate>>;
//   tension: ProductionRule
// }
//
// export interface PathEncodeEntry extends EncodeEntry {
//   path: ProductionRule
//   angle: ProductionRule
//   scaleX: ProductionRule
//   scaleY: ProductionRule
// }
//

//
// export type RuleEncodeEntry = EncodeEntry;
//
// export interface ShapeEncodeEntry extends EncodeEntry {
//   shape: ProductionRule
// }
//
// export type SymbolShape =
//   | 'circle'
//   | 'square'
//   | 'cross'
//   | 'diamond'
//   | 'triangle-up'
//   | 'triangle-down'
//   | 'triangle-right'
//   | 'triangle-left'
//   | 'arrow'
//   | 'triangle'
//   | 'wedge'
//   | 'stroke'
//   | string;
[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type SymbolShape =
    | circle
    | square
    | cross
    | diamond
    | [<CompiledName("triangle-up")>] triangleUp
    | [<CompiledName("triangle-down")>] triangleDown
    | [<CompiledName("triangle-right")>] triangleRight
    | [<CompiledName("triangle-left")>] triangleLeft
    | arrow
    | triangle
    | wedge
    | stroke    
type SymbolShapeValueRef = ScaledValueRef<SymbolShape>
//
// export interface SymbolEncodeEntry extends EncodeEntry {
//   size: ProductionRule
//   shape?: ProductionRule<ScaledValueRef<SymbolShape>>;
//   angle: ProductionRule
// }
//
type Text = U2<string, string[]>



//
[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type TextDirection =
    | ltr
    | rtl
//
// export type FontWeight =
//   | 'normal'
//   | 'bold'
//   | 'lighter'
//   | 'bolder'
//   | 100
//   | 200
//   | 300
//   | 400
//   | 500
//   | 600
//   | 700
//   | 800
//   | 900;

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type FontWeight =
    | normal
    | bold
    | lighter
    | bolder    
    | [<CompiledName("100")>] x100
    | [<CompiledName("200")>] x200
    | [<CompiledName("300")>] x300
    | [<CompiledName("400")>] x400
    | [<CompiledName("500")>] x500
    | [<CompiledName("600")>] x600
    | [<CompiledName("700")>] x700
    | [<CompiledName("800")>] x800
    | [<CompiledName("900")>] x900
    
type FontWeightValueRef = ScaledValueRef<FontWeight>    
// |'normal' | 'italic' | 'oblique' | string;
// // see https://developer.mozilla.org/en-US/docs/Web/CSS/font-style#Values
[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type FontStyleEnum =
    | normal
    | italic
    | oblique    
type FontStyle =
    U2<FontStyleEnum,string>
// export type FontStyleValueRef = ScaledValueRef<FontStyle>;    
type FontStyleValueRef = ScaledValueRef<FontStyle>
//
// export interface TextEncodeEntry extends EncodeEntry, AlignProperty, ThetaProperty {
//   text: ProductionRule
//   angle: ProductionRule
//   baseline: ProductionRule
//   dir?: ProductionRule<ScaledValueRef<TextDirection>>;
//   dx: ProductionRule
//   dy: ProductionRule
//   ellipsis: ProductionRule
//   font: ProductionRule
//   fontSize: ProductionRule
//   fontWeight: ProductionRule
//   fontStyle: ProductionRule
//   limit: ProductionRule
//   lineBreak: ProductionRule
//
//   /**
//    * The height, in pixels, of each line of text in a multi-line text mark or a text mark with `"line-top"` or `"line-bottom"` baseline.
//    */
//   lineHeight: ProductionRule
//   radius: ProductionRule
// }
//
// export interface TrailEncodeEntry extends EncodeEntry, DefinedProperty {}
//
// export interface Encodable<T> {
//   encode?: Encode<T>;
// }
//
// export type Encode<T> = Partial<Record<EncodeEntryName, T>>;
//
// export type EncodeEntryName =
//   | 'enter'
//   | 'update'
//   | 'exit'
//   | 'hover'
//   | 'leave'
//   | 'select'
//   | 'release';

