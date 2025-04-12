namespace Perceptron.Viz
open System

open Browser.Types
open Fable.Core

module Vega =
// https://github.com/vega/vega-tooltip/blob/0356dfdcb61c31ccb082423698ddfa5ec606e2dc/src/defaults.ts#L8
//     export interface Options {
//   /**
//    * X offset.
//    */
//   offsetX?: number;
//
//   /**
//    * Y offset.
//    */
//   offsetY?: number;
//
//   /**
//    * ID of the tooltip element.
//    */
//   id?: string;
//
//   /**
//    * ID of the tooltip CSS style.
//    */
//   styleId?: string;
//
//   /**
//    * The name of the theme. You can use the CSS class called [THEME]-theme to style the tooltips.
//    *
//    * There are two predefined themes: "light" (default) and "dark".
//    */
//   theme?: string;
//
//   /**
//    * Do not use the default styles provided by Vega Tooltip. If you enable this option, you need to use your own styles. It is not necessary to disable the default style when using a custom theme.
//    */
//   disableDefaultStyle?: boolean;
//
//   /**
//    * HTML sanitizer function that removes dangerous HTML to prevent XSS.
//    *
//    * This should be a function from string to string. You may replace it with a formatter such as a markdown formatter.
//    */
//   sanitize?: (value: any) => string;
//
//   /**
//    * The maximum recursion depth when printing objects in the tooltip.
//    */
//   maxDepth?: number;
//
//   /**
//    * A function to customize the rendered HTML of the tooltip.
//    * @param value A value string, or object of value strings keyed by field
//    * @param sanitize The `sanitize` function from `options.sanitize`
//    * @param baseURL The `baseURL` from `options.baseURL`
//    * @returns {string} The returned string will become the `innerHTML` of the tooltip element
//    */
//   formatTooltip?: (value: any, valueToHtml: (value: any) => string, maxDepth: number, baseURL: string) => string;
//
//   /**
//    * The baseurl to use in image paths.
//    */
//   baseURL?: string;
//
//   /**
//    * The snap reference for the tooltip.
//    */
//   anchor?: 'cursor' | 'mark';
//
//   /**
//    * The position of the tooltip relative to the anchor.
//    *
//    * Only valid when `anchor` is set to 'mark'.
//    */
//   position?: Position | Position[];
// }
    type TooltipOptions = {
        offsetX: int option
        offsetY: int option
        id: string option
        styleId: string option
        theme: string option
        disableDefaultStyle: bool option
        sanitize: System.Func<obj, string> option
        maxDepth: int option
        formatTooltip: System.Func<obj, System.Func<obj, string>, int, string, string> option
        baseUrl: string option
        anchor: U2<string, string> option
        position: U2<string, string> option
    }
    
    type Mode =
        | [<CompiledName("vega")>] Vega
        | [<CompiledName("vega-lite")>] VegaLite
    type Renderers =
        | [<CompiledName("canvas")>] Canvas
        | [<CompiledName("svg")>] Svg
        | [<CompiledName("hybrid")>] Webgl
        | [<CompiledName("none")>] NoRender
        
    // From github.com/vega 
    // https://github.com/vega/vega/blob/7d99ab02cb44552fb07ed8d95bfbbcd7c99a9384/packages/vega-typings/types/runtime/index.d.ts#L259
    // export type TooltipHandler = (handler: any, event: MouseEvent, item: Item, value: any) => void;
    type TooltipHandler =
        System.Func<obj, MouseEvent, obj, obj, unit>
        
    type Actions = {
        export: U2<bool, {|svg: bool option; png: bool option|}> option
        source: bool option
        editor: bool option
        compiled: bool option
    }
    type EmbedOptions = {
        bind: U2<HTMLElement, string> option
        actions: U2<bool, Actions> option
        mode: Mode option
        theme: string option
        defaultStyle: U2<bool,string> option
        logLevel: int option
        
    }
        
    [<Import("default", "vega-embed")>]
    let embed : System.Func<U2<HTMLElement,string>,U2<obj,string>,unit> = jsNative
    
    