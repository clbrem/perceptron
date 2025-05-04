namespace Perceptron.Viz

open Browser.Types
open Fable.Core
open Fable.Core.JS
open Fetch
open Vega

module Vega =
    type Padding =
        U2<int, {| top: int option; right: int option; bottom: int option; left: int option |}>
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
            padding: Padding
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
    module Spec = 
        type AutoSizeType =
            | [<CompiledName("pad")>] Pad
            | [<CompiledName("fit")>] Fit
            | [<CompiledName("fit-x")>] FitX
            | [<CompiledName("fit-y")>] FitY
            | [<CompiledName("none")>] NoneSize
        type AutoSizeContains =
            | [<CompiledName("content")>] Content
            | [<CompiledName("padding")>] Padding
        type AutoSizeRecord =
            {
                [<CompiledName("type")>] autoSizeType: AutoSizeType
                resize: bool option
                contains: AutoSizeContains option
            }
        type AutoSize = U2<AutoSizeType, AutoSizeRecord>
        
        type EventsBind =
            | [<CompiledName("any")>] Any
            | [<CompiledName("container")>] Container
            | [<CompiledName("none")>] BindNone
        type EventType =
            |[<CompiledName("click")>] Click
            |[<CompiledName("dblclick")>] DblClick
            |[<CompiledName("dragenter")>] DragEnter
        
        type DefaultPrevent =
            {
                prevent: U2<bool, EventType []>
            }
        type DefaultAllow = 
            {
                allow: U2<bool, EventType []>
            }
        type ConfigEvents = {
            bind: EventsBind option
            defaults: U2<DefaultPrevent,DefaultAllow> option
            selector: U2<bool, string []> option
            timer: bool option
            view: U2<bool, string []> option
            window: U2<bool, string[]> option
            }
        type NumberLocale = {
            // The decimal separator (e.g., ".")
            decimal: string
            // The grouping separator (e.g., ",")            
            thousands: string
            // The array of group sizes (e.g., [3]), cycled as needed
            grouping: int []
            // The currency prefix and suffix (e.g., ["$", ""])
            currency: Vector.Vec2<string>
            //An array of 10 strings replacing 0-9 
            numerals: Vector.Vec10<string>
        }
        type TimeLocale = {
            dateTime: string
            date: string
            time: string
            periods: Vector.Vec2<string>
            days: Vector.Vec7<string>
            shortDays: Vector.Vec7<string>
            months: Vector.Vec12<string>
            shortMonths: Vector.Vec12<string>
        }
        type Orientation =
            | [<CompiledName("horizontal")>] Horizontal
            | [<CompiledName("vertical")>] Vertical
        type Locale = {
            number: NumberLocale option
            time: TimeLocale option
        }
        type LayoutBounds =
            | [<CompiledName("full")>] Full
            | [<CompiledName("flush")>] Flush
        type TitleAnchor = 
            | [<CompiledName("start")>] Start
            | [<CompiledName("middle")>] Middle
            | [<CompiledName("end")>] End
        type BaseLegendLayout =
            {
              //
              // The anchor point for legend orient group layout.
              //
                anchor: U2<TitleAnchor, SignalRef> option
                // the bounds calculation for use to legend orient group layout
                bounds: U2<LayoutBounds,SignalRef> option
                // a flag to center legends within a shared orient group
                center: U2<bool, SignalRef> option
                // Th elayout direction for legend orient group layout
                direction: U2<Orientation,SignalRef> option
                // The pixel margin between legends within an orient group                
                margin: U2<int, SignalRef>
                offset: U2<int, SignalRef> option
            }

        type LegendLayout = {
                anchor: U2<TitleAnchor, SignalRef> option
                // the bounds calculation for use to legend orient group layout
                bounds: U2<LayoutBounds,SignalRef> option
                // a flag to center legends within a shared orient group
                center: U2<bool, SignalRef> option
                // Th elayout direction for legend orient group layout
                direction: U2<Orientation,SignalRef> option
                // The pixel margin between legends within an orient group                
                margin: U2<int, SignalRef>
                offset: U2<int, SignalRef> option
                left: BaseLegendLayout option
                right: BaseLegendLayout option
                top: BaseLegendLayout option
                bottom: BaseLegendLayout option                
                [<CompiledName("'top-left'")>] topLeft: BaseLegendLayout option
                [<CompiledName("'top-right'")>] topRight: BaseLegendLayout option
                [<CompiledName("'bottom-left'")>] bottomLeft: BaseLegendLayout option
                [<CompiledName("'bottom-right'")>] bottomRight: BaseLegendLayout option
        }
        type LegendConfig = {
 
           //The default direction (`"horizontal"` or `"vertical"`) for gradient legends.           
           //__Default value:__ `"vertical"`.
   
          gradientDirection: Orientation option

          //
           //The maximum allowed length in pixels of color ramp gradient labels.
           //
          gradientLabelLimit: U2<int,SignalRef> option;
        
          //
           //Vertical offset in pixels for color ramp gradient labels.
        
           //__Default value:__ `2`.
           //
          gradientLabelOffset: U2<int,SignalRef> option;
        
          //
           //Default fill color for legend symbols. Only applied if there is no `"fill"` scale color encoding for the legend.
    
           //__Default value:__ `"transparent"`.
           //
          symbolBaseFillColor: U2<Vega.Color, SignalRef> option;
        
          //
           //Default stroke color for legend symbols. Only applied if there is no `"fill"` scale color encoding for the legend.
           
           //__Default value:__ `"gray"`.
           //
          symbolBaseStrokeColor: U2<Vega.Color,SignalRef>;
        
          //
           //The default direction (`"horizontal"` or `"vertical"`) for symbol legends.
           
           //__Default value:__ `"vertical"`.
           //
          symbolDirection: Orientation option;
        
          //
           //Border stroke dash pattern for the full legend.
           //
          strokeDash: U2<int[], SignalRef> option;
        
          //
           //Border stroke width for the full legend.
           //
          strokeWidth: U2<int,SignalRef> option;
        
          //
           //Legend orient group layout parameters.
           //
          layout: LegendLayout option;
        }
        
        type TitleFrame =
            | [<CompiledName("bounds")>] Bounds
            | [<CompiledName("group")>] Group
        type TitleOrient =
            | [<CompiledName("top")>] Top
            | [<CompiledName("bottom")>] Bottom
            | [<CompiledName("left")>] Left
            | [<CompiledName("right")>] Right
            | [<CompiledName("none")>] NoneOrient
        type Align =
            | [<CompiledName("left")>] Left
            | [<CompiledName("center")>] Center
            | [<CompiledName("right")>] Right
        type TextBaseline = 
            | [<CompiledName("alphabetic")>] Alphabetic
            | [<CompiledName("top")>] Top
            | [<CompiledName("middle")>] Middle
            | [<CompiledName("bottom")>] Bottom
            | [<CompiledName("line-top")>] LineTop
            | [<CompiledName("line-bottom")>] LineBottom
        type FontStyle = 
            | [<CompiledName("normal")>] Normal
            | [<CompiledName("italic")>] Italic
            | [<CompiledName("oblique")>] Oblique
        type FontWeight =
            | [<CompiledName("normal")>] Normal
            | [<CompiledName("bold")>] Bold
            | [<CompiledName("bolder")>] Bolder
            | [<CompiledValue(100)>] W100
            | [<CompiledValue(200)>] W200
            | [<CompiledValue(300)>] W300
            | [<CompiledValue(400)>] W400
            | [<CompiledValue(500)>] W500
            | [<CompiledValue(600)>] W600
            | [<CompiledValue(700)>] W700
            | [<CompiledValue(800)>] W800
            | [<CompiledValue(900)>] W900
            
        
        type TitleConfig = {
            
          //
           // The anchor position for placing the title and subtitle text. One of `"start"`, `"middle"`, or `"end"`. For example, with an orientation of top these anchor positions map to a left-, center-, or right-aligned title.
           //
          anchor: U2<TitleAnchor,SignalRef> option;
        
          //
           // The reference frame for the anchor position, one of `"bounds"` (to anchor relative to the full bounding box) or `"group"` (to anchor relative to the group width or height).
           // (Not sure if this is correct!
          frame: U2<TitleFrame,SignalRef> option;
        
          //
           // The orthogonal offset in pixels by which to displace the title group from its position along the edge of the chart.
           //
          offset: U2<int,SignalRef> option;
        
          //
           // Default title orientation (`"top"`, `"bottom"`, `"left"`, or `"right"`)
           //
          orient: U2<TitleOrient, SignalRef> option;
        
          // ---------- ARIA ----------
          //
           // A boolean flag indicating if [ARIA attributes](https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA) should be included (SVG output only).
           // If `false`, the "aria-hidden" attribute will be set on the output SVG group, removing the title from the ARIA accessibility tree.
           //
           // __Default value:__ `true`
           //
          aria: bool option;
        
          // ---------- Shared Text Properties ----------
          //
           // Horizontal text alignment for title text. One of `"left"`, `"center"`, or `"right"`.
           //
          align: U2<Align, SignalRef> option;
        
          //
           // Angle in degrees of title and subtitle text.
           //
          angle: SignalRef option ;
        
          //
           // Vertical text baseline for title and subtitle text. One of `"alphabetic"` (default), `"top"`, `"middle"`, `"bottom"`, `"line-top"`, or `"line-bottom"`. The `"line-top"` and `"line-bottom"` values operate similarly to `"top"` and `"bottom"`, but are calculated relative to the //lineHeight// rather than //fontSize// alone.
           //
          baseline: U2<TextBaseline, SignalRef> option;
        
          //
           // Delta offset for title and subtitle text x-coordinate.
           //
          dx: U2<int, SignalRef> option;
        
          //
           // Delta offset for title and subtitle text y-coordinate.
           //
          dy: U2<int,SignalRef> option;
        
          //
           // The maximum allowed length in pixels of title and subtitle text.
           //
           // @minimum 0
           //
          limit: U2<int,SignalRef> option;
        
          // ---------- Title Text ----------
          //
           // Text color for title text.
           //
          color: U2<Vega.Color,SignalRef> option;
        
          //
           // Font name for title text.
           //
          font: U2<string, SignalRef> option;
        
          //
           // Font size in pixels for title text.
           //
           // @minimum 0
           //
          fontSize: U2<int, SignalRef> option;
        
          //
           // Font style for title text.
           //
          fontStyle: U2<FontStyle, SignalRef> option;
        
          //
           // Font weight for title text.
           // This can be either a string (e.g `"bold"`, `"normal"`) or a number (`100`, `200`, `300`, ..., `900` where `"normal"` = `400` and `"bold"` = `700`).
           //
          fontWeight: U2<FontWeight, SignalRef> option ;
        
          //
           // Line height in pixels for multi-line title text or title text with `"line-top"` or `"line-bottom"` baseline.
           //
          lineHeight: U2<int, SignalRef> option;
        
          // ---------- Subtitle Text ----------
          //
           // Text color for subtitle text.
           //
          subtitleColor: U2<Vega.Color, SignalRef> option
        
          //
           // Font name for subtitle text.
           //
          subtitleFont: U2<string, SignalRef> option;
        
          //
           // Font size in pixels for subtitle text.
           //
           // @minimum 0
           //
          subtitleFontSize: U2<int, SignalRef> option;
        
          //
           // Font style for subtitle text.
           //
          subtitleFontStyle: U2<FontStyle, SignalRef> option;
        
          //
           // Font weight for subtitle text.
           // This can be either a string (e.g `"bold"`, `"normal"`) or a number (`100`, `200`, `300`, ..., `900` where `"normal"` = `400` and `"bold"` = `700`).
           //
          subtitleFontWeight: U2<FontWeight, SignalRef> option;
        
          //
           // Line height in pixels for multi-line subtitle text.
           //
          subtitleLineHeight: U2<int, SignalRef> option;
        
          //
           // The padding in pixels between title and subtitle text.
           //
          subtitlePadding: U2<int, SignalRef> option;
        
          //
           // 	The integer z-index indicating the layering of the title group relative to other axis, mark, and legend groups.
           //
           // __Default value:__ `0`.
           //
           // @TJS-type integer
           // @minimum 0
           //
          zindex: int option
        }
        type ProjectionType = 
          | [<CompiledName("albers")>] Albers
          | [<CompiledName("albersUsa")>] AlbersUsa
          | [<CompiledName("azimuthalEqualArea")>] AzimuthalEqualArea
          | [<CompiledName("azimuthalEquidistant")>] AzimuthalEquidistant
          | [<CompiledName("conicConformal")>] ConicConformal
          | [<CompiledName("conicEqualArea")>] ConicEqualArea
          | [<CompiledName("conicEquidistant")>] ConicEquidistant
          | [<CompiledName("equalEarth")>] EqualEarth
          | [<CompiledName("equirectangular")>] Equirectangular
          | [<CompiledName("gnomonic")>] Gnomonic
          | [<CompiledName("identity")>] Identity
          | [<CompiledName("mercator")>] Mercator
          | [<CompiledName("naturalEarth1")>] NaturalEarth1
          | [<CompiledName("orthographic")>] Orthographic
          | [<CompiledName("stereographic")>] Stereographic
          | [<CompiledName("transverseMercator")>] TransverseMercator
        type Feature =
            | [<CompiledName("Feature")>] Feature
        type FeatureCollection =             
            | [<CompiledName("FeatureCollection")>] FeatureCollection
        type Fit = U3<Feature, FeatureCollection, Feature[]>
            
        type ProjectionConfig =
            {
                //
               //The cartographic projection to use. This value is case-insensitive, for example `"albers"` and `"Albers"` indicate the same projection type.
               
               //__Default value:__ `mercator`
               //
              [<CompiledName("type")>]
              projectionType: U2<ProjectionType, SignalRef> option
            
              //
               //The projection's clipping circle radius to the specified angle in degrees. If `null`, switches to [antimeridian](http://bl.ocks.org/mbostock/3788999) cutting rather than small-circle clipping.
               //
              clipAngle: U2<int,SignalRef> option
            
              //
               //The projection's viewport clip extent to the specified bounds in pixels. The extent bounds are specified as an array `[[x0, y0], [x1, y1]]`, where `x0` is the left-side of the viewport, `y0` is the top, `x1` is the right and `y1` is the bottom. If `null`, no viewport clipping is performed.
               //
              clipExtent: U2<Vector.Vec2<Vector.Vec2<U2<int, SignalRef>>>,SignalRef> option
            
              //
               //The projection’s scale factor. The default scale is projection-specific. The scale factor corresponds linearly to the distance between projected points; however, scale factor values are not equivalent across projections.
               //
              scale: U2<int, SignalRef> option
            
              //
               //The projection's translation offset as a two-element array `[tx, ty]`, defaults to `[480, 250]`. The translation offset determines the pixel coordinates of the projection's center. The default translation offset places (0°,0°) at the center of a 960×500 area.
               //
              translate: U2<Vector.Vec2<U2<int, SignalRef>>,SignalRef> option;
            
              //
               //The projection's center, a two-element array of longitude and latitude in degrees.
               //
               //__Default value:__ `[0, 0]`
               //
              center: U2<Vector.Vec2<U2<int,SignalRef>>, SignalRef> option;
            
              //
               //The projection's three-axis rotation to the specified angles, which must be a two- or three-element array of numbers [`lambda`, `phi`, `gamma`] specifying the rotation angles in degrees about each spherical axis. (These correspond to yaw, pitch and roll.)
               //
               //__Default value:__ `[0, 0, 0]`
               //
              rotate: U3<Vector.Vec2<U2<int, SignalRef>>,  Vector.Vec3<U2<int, SignalRef>>,  SignalRef> option;
            
              //
               //For conic projections, the [two standard parallels](https://en.wikipedia.org/wiki/Map_projection#Conic) that define the map layout. The default depends on the specific conic projection used.
               //
              parallels: U2<U2<int,SignalRef>[],  SignalRef> option;
            
              //
               //The default radius (in pixels) to use when drawing GeoJSON `Point` and `MultiPoint` geometries. This parameter sets a constant default value. To modify the point radius in response to data, see the corresponding parameter of the GeoPath and GeoShape transforms.
               //
               //__Default value:__ `4.5`
               //
              pointRadius: U2<int, SignalRef>;
            
              //
               //The threshold for the projection's [adaptive resampling](http://bl.ocks.org/mbostock/3795544) to the specified value in pixels. This value corresponds to the [Douglas–Peucker distance](http://en.wikipedia.org/wiki/Ramer%E2%80%93Douglas%E2%80%93Peucker_algorithm). If precision is not specified, returns the projection's current resampling precision which defaults to `√0.5 ≅ 0.70710…`.
               //
              precision: U2<int, SignalRef>;
            
              //
               //GeoJSON data to which the projection should attempt to automatically fit the `translate` and `scale` parameters. If object-valued, this parameter should be a GeoJSON Feature or FeatureCollection. If array-valued, each array member may be a GeoJSON Feature, FeatureCollection, or a sub-array of GeoJSON Features.
               //
              fit: U3<Fit, Fit[], SignalRef> option;
            
              //
               //Used in conjunction with fit, provides the pixel area to which the projection should be automatically fit.
               //
              extent: U2<Vector.Vec2<Vector.Vec2<U2<int,SignalRef>>>,  SignalRef> option
            
              //
               //Used in conjunction with fit, provides the width and height in pixels of the area to which the projection should be automatically fit.
               //
              size: U2<Vector.Vec2<U2<int,SignalRef>>,SignalRef> option
            
            
              //
               //The coefficient parameter for the `hammer` projection.
               //
               //__Default value:__ `2`
               //
              coefficient: U2<int, SignalRef>
            
              //
               //For the `satellite` projection, the distance from the center of the
               //sphere to the point of view, as a proportion of the sphere’s radius.
               //The recommended maximum clip angle for a given `distance` is
               //acos(1 / distance) converted to degrees. If tilt is also
               //applied, then more conservative clipping may be necessary.
               //
               //__Default value:__ `2.0`
               //
              distance: U2<float, SignalRef>
            
              //
               //The fraction parameter for the `bottomley` projection.
               //
               //__Default value:__ `0.5`, corresponding to a sin(ψ) where ψ = π/6.
               //
              fraction: U2<float, SignalRef> option
            
              //
               //The number of lobes in projections that support multi-lobe views:
               //`berghaus`, `gingery`, or `healpix`.
               //The default value varies based on the projection type.
               //
              lobes: U2<int, SignalRef> option
            
              //
               //The parallel parameter for projections that support it:
               //`armadillo`, `bonne`, `craig`, `cylindricalEqualArea`,
               //`cylindricalStereographic`, `hammerRetroazimuthal`, `loximuthal`,
               //or `rectangularPolyconic`.
               //The default value varies based on the projection type.
               //
              [<CompiledName("parallel")>]
              projectionParallel: U2<float, SignalRef> option
            
              //
               //The radius parameter for the `airy` or `gingery` projection.
               //The default value varies based on the projection type.
               //
              radius: U2<float, SignalRef> option
            
              //
               //The ratio parameter for the `hill`, `hufnagel`, or `wagner` projections.
               //The default value varies based on the projection type.
               //
              ratio: U2<float, SignalRef> option
            
              //
               //The spacing parameter for the `lagrange` projection.
               //
               //__Default value:__ `0.5`
               //
              spacing: U2<float, SignalRef> option;
            
              //
               //The tilt angle (in degrees) for the `satellite` projection.
               //
               //__Default value:__ `0`.
               //
              tilt: U2<int,  SignalRef> option
            
              //
               //Sets whether the x-dimension is reflected (negated) in the output.
               //
              reflectX: U2< bool,SignalRef> option;
            
              //
               //Sets whether the y-dimension is reflected (negated) in the output.
               //
              reflectY: U2<bool, SignalRef> option;
    
            }
        
        type RangeEnum =
            | [<CompiledName("width")>] Width
            | [<CompiledName("height")>] Height
            | [<CompiledName("symbol")>] Symbol
            | [<CompiledName("category")>] Category
            | [<CompiledName("ordinal")>] Ordinal
            | [<CompiledName("ramp")>] Ramp            
            | [<CompiledName("diverging")>] Diverging
            | [<CompiledName("heatmap")>] Heatmap
        type RangeRawArray = U2<int,SignalRef> []
        [<Erase>]
        type RangeRaw =
            | RangeBool of bool
            | RangeString of string
            | RangeNumber of int
            | RangeSignal of SignalRef
            | RangeRawArray of RangeRawArray
        type RangeObj = {
            scheme : U4<string,string[],ColorScheme,SignalRef>
            count: U2<int,SignalRef> option
            extent: U2<U2<int,SignalRef>[], SignalRef> option
        }
        [<Erase>]
        type RangeScheme =
            | RangeEnum of RangeEnum
            | RangeRaw of RangeRaw
            | RangeSignal of SignalRef
            | RangeObj of RangeObj
        type SymbolShapeNamed =           
          | [<CompiledName("circle")>] Circle
          | [<CompiledName("square")>] Square
          | [<CompiledName("cross")>] Cross
          | [<CompiledName("diamond")>] Diamond
          | [<CompiledName("triangle-up")>] TriangleUp
          | [<CompiledName("triangle-down")>] TriangleDown
          | [<CompiledName("triangle-right")>] TriangleRight
          | [<CompiledName("triangle-left")>] TriangleLeft
          | [<CompiledName("arrow")>] Arrow
          | [<CompiledName("triangle")>] Triangle
          | [<CompiledName("wedge")>] Wedge
          | [<CompiledName("stroke")>] Stroke
        type SymbolShape =  U2<SymbolShapeNamed,string>            
        type RangeConfig = {
            category: U2<RangeScheme, Color[]> option
            diverging: U2<RangeScheme, Color[]> option
            heatmap: U2<RangeScheme, Color[]> option
            ordinal: U2<RangeScheme, Color[]> option
            ramp: U2<RangeScheme, Color[]> option
            symbol: SymbolShape[] option
        }
        
        type Expr = | Todo
        type SignalValue = obj
        type Stream = | Todo        
        type EventSelector = | Todo
        type EventListener = | Todo

        type OnEvent =
            {
                encode: string option
                update: Update option
                events: U2<Events, EventListener[]>
                force: bool option
            }

        
        

        type Binding = | Todo

        type InitSignal =
            {
                name: string
                description: string option
                on: OnEvent[] option
                value: SignalValue option
                init: Expr
                bind: Binding option
            }
        type NewSignal =
            {
                name: string
                description: string option
                on: OnEvent[] option
                value: SignalValue option
                react: bool option
                update: Expr option
                bind: Binding option                
            }
        
                    

    type Spec =
        {
            [<CompiledName("$schema")>] schema: string option
            config: Spec.Config option
            description: string option
            width: U2<int, SignalRef> option
            height: U2<int, SignalRef> option
            padding: U2<Padding , SignalRef> option
            autosize: U2<Spec.AutoSize, SignalRef> option
            background: U2<Vega.Color, SignalRef> option
            style: U2<string, string []> option            
        }
        