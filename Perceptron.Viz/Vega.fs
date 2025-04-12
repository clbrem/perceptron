namespace Perceptron.Viz
open System
open System.ComponentModel.DataAnnotations
open Browser.Types
open Fable.Core

module Vega =
    [<Import("Actions", "vega-embed")>]
    type Actions =        
        abstract member export: Nullable<bool>
        abstract member source: Nullable<bool>
        abstract member compiled: Nullable<bool>
        abstract member editor: Nullable<bool>
        
    [<Import("EmbedOptions", "vega-embed")>]
    type EmbedOptions =        
        abstract member bind: U2<HTMLElement, string>
        abstract member actions : U2<bool, Actions>
        abstract member mode: 
        
        
    [<Import("default", "vega-embed")>]
    let embed : System.Func<U2<HTMLElement,string>,U2<obj,string>,unit> = jsNative
    
    