namespace Perceptron.Viz
open System

open Browser.Types
open Fable.Core
open Fable.Core.JS
open Fetch

module Vega =
    type SignalRef =
        {
            signal: string
        }
    module Embed = 
        
        type I18N = {
            [<CompiledName("CLICK_TO_VIEW_ACTIONS")>] ClickToViewActions: string
            [<CompiledName("COMPILED_ACTION")>] CompiledAction: string
            [<CompiledName("EDITOR_ACTION")>] EditorAction: string
            [<CompiledName("PNG_ACTION")>] PngAction: string
            [<CompiledName("SOURCE_ACTION")>] SourceAction: string
            [<CompiledName("SVG_ACTION")>] SvgAction: string
        } with 
            static member Default =
                {
                    ClickToViewActions = "Click to view actions"
                    CompiledAction = "View Compiled Vega"
                    EditorAction = "Open in Vega Editor"
                    PngAction = "Save as PNG"
                    SourceAction = "View Source"
                    SvgAction = "Save as SVG"
                }
    
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
        type UriContext =
                | [<CompiledName("href")>] Href
                | [<CompiledName("image")>] Image
        type DataFlowContext =
            | [<CompiledName("dataflow")>] Dataflow
        type UriLoader =
            {
                baseUrl: string
                mode: string
                defaultProtocol: string
                target: string
                rel: string
                http: RequestInit
                crossorigin: string
                context: UriContext
            }
        type DataFlowLoader =
            {
                context: DataFlowContext
                response: string
            }
            
            
        
        type LoaderOptionsWithContext =
            U2<UriLoader, DataFlowLoader>
        
        type Loader = {
            load: System.Func<string, LoaderOptionsWithContext option, Promise<string>>
            sanitize: System.Func<string, LoaderOptionsWithContext option, Promise<{|href: string|}>>
            http: System.Func<string, RequestInit, Promise<string>>
            file: System.Func<string, Promise<string>>
            }
        type LoaderOptions =
            {
                baseURL: string option
                mode: string option
                defaultProtocol: string option
                target: string option
                http: RequestInit option
            }
        
            
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
            loader: U2<Loader,LoaderOptions> option
            renderer: Renderers option
            tooltip: U3<TooltipHandler, TooltipOptions, bool> option
            // Kind of punting on this one
            patch:  string option
            width: int option
            height: int option
            padding: U2<int, {|top: int; right: int; bottom: int; left: int|}> option
            scaleFactor: U2<int, {|svg: int; png: int |}> option
            // Should include Config type
            config: string option
            sourceHeader: string option
            sourceFooter: string option
            editorUrl: string option
            // add Hover class
            hover: bool option
            i18n: I18N option
            downloadFileName: string option
            formatLocale: obj option
            timeFormatLocale: obj option
            expressionFunctions: obj option //later        
            ast: bool option
            expr: obj option //later
            viewClass: obj option //later
            forceActionsMenu: bool option
        }
        
            
        [<Import("default", "vega-embed")>]
        let _embed : System.Func<U2<HTMLElement,string>,U2<obj,string>,EmbedOptions option, obj> = jsNative
        
        let embed = _embed.Invoke
        
    type Spec =
        {
            [<CompiledName("$schema")>] schema: string option
            config: Config option
            description: string option
            width: U2<int, SignalRef> option
            height: U2<int, SignalRef> option
            padding: U3<int, {|top: int; right: int; bottom: int; left: int|}, SignalRef> option
            autosize: U2<AutoSize, SignalRef> option
            background: U2<Vega.Color, SignalRef> option
            style: U2<string, string []> option
            
        }
        