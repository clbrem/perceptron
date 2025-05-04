namespace Vega

open Fable.Core


[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type Categorical =
    | accent
    | category10
    | category20
    | category20b
    | category20c
    | dark2
    | paired
    | pastel1
    | pastel2
    | set1
    | set2
    | set3
    | tableau10
    | tableau20
    | observable10

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type SequentialSingleHue =
    | blues
    | [<CompiledName("tealblues")>] tealBlues
    | teals
    | greens
    | browns
    | greys
    | purples
    | [<CompiledName("warmgreys")>] warmGreys
    | reds
    | oranges

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type SequentialMultiHue =
    | turbo
    | viridis
    | inferno
    | magma
    | plasma
    | cividis
    | bluegreen
    | [<CompiledName("bluegreen-3")>] bluegreen3
    | [<CompiledName("bluegreen-4")>] bluegreen4
    | [<CompiledName("bluegreen-5")>] bluegreen5
    | [<CompiledName("bluegreen-6")>] bluegreen6
    | [<CompiledName("bluegreen-7")>] bluegreen7
    | [<CompiledName("bluegreen-8")>] bluegreen8
    | [<CompiledName("bluegreen-9")>] bluegreen9    
    | bluepurple
    | [<CompiledName("bluepurple-3")>] bluepurple3
    | [<CompiledName("bluepurple-4")>] bluepurple4
    | [<CompiledName("bluepurple-5")>] bluepurple5
    | [<CompiledName("bluepurple-6")>] bluepurple6
    | [<CompiledName("bluepurple-7")>] bluepurple7
    | [<CompiledName("bluepurple-8")>] bluepurple8
    | [<CompiledName("bluepurple-9")>] bluepurple9
    | goldgreen
    | [<CompiledName("goldgreen-3")>] goldgreen3
    | [<CompiledName("goldgreen-4")>] goldgreen4
    | [<CompiledName("goldgreen-5")>] goldgreen5
    | [<CompiledName("goldgreen-6")>] goldgreen6
    | [<CompiledName("goldgreen-7")>] goldgreen7
    | [<CompiledName("goldgreen-8")>] goldgreen8
    | [<CompiledName("goldgreen-9")>] goldgreen9
    | goldorange
    | [<CompiledName("goldorange-3")>] goldorange3
    | [<CompiledName("goldorange-4")>] goldorange4
    | [<CompiledName("goldorange-5")>] goldorange5
    | [<CompiledName("goldorange-6")>] goldorange6
    | [<CompiledName("goldorange-7")>] goldorange7
    | [<CompiledName("goldorange-8")>] goldorange8
    | [<CompiledName("goldorange-9")>] goldorange9
    | goldred
    | [<CompiledName("goldred-3")>] goldred3
    | [<CompiledName("goldred-4")>] goldred4
    | [<CompiledName("goldred-5")>] goldred5
    | [<CompiledName("goldred-6")>] goldred6
    | [<CompiledName("goldred-7")>] goldred7
    | [<CompiledName("goldred-8")>] goldred8
    | [<CompiledName("goldred-9")>] goldred9
    | greenblue
    | [<CompiledName("greenblue-3")>] greenblue3
    | [<CompiledName("greenblue-4")>] greenblue4
    | [<CompiledName("greenblue-5")>] greenblue5
    | [<CompiledName("greenblue-6")>] greenblue6
    | [<CompiledName("greenblue-7")>] greenblue7
    | [<CompiledName("greenblue-8")>] greenblue8
    | [<CompiledName("greenblue-9")>] greenblue9
    | orangered
    | [<CompiledName("orangered-3")>] orangered3
    | [<CompiledName("orangered-4")>] orangered4
    | [<CompiledName("orangered-5")>] orangered5
    | [<CompiledName("orangered-6")>] orangered6
    | [<CompiledName("orangered-7")>] orangered7
    | [<CompiledName("orangered-8")>] orangered8
    | [<CompiledName("orangered-9")>] orangered9
    | purplebluegreen
    | [<CompiledName("purplebluegreen-3")>] purplebluegreen3
    | [<CompiledName("purplebluegreen-4")>] purplebluegreen4
    | [<CompiledName("purplebluegreen-5")>] purplebluegreen5
    | [<CompiledName("purplebluegreen-6")>] purplebluegreen6
    | [<CompiledName("purplebluegreen-7")>] purplebluegreen7
    | [<CompiledName("purplebluegreen-8")>] purplebluegreen8
    | [<CompiledName("purplebluegreen-9")>] purplebluegreen9
    | purpleblue
    | [<CompiledName("purpleblue-3")>] purpleblue3
    | [<CompiledName("purpleblue-4")>] purpleblue4
    | [<CompiledName("purpleblue-5")>] purpleblue5
    | [<CompiledName("purpleblue-6")>] purpleblue6
    | [<CompiledName("purpleblue-7")>] purpleblue7
    | [<CompiledName("purpleblue-8")>] purpleblue8
    | [<CompiledName("purpleblue-9")>] purpleblue9
    | purplered
    | [<CompiledName("purplered-3")>] purplered3
    | [<CompiledName("purplered-4")>] purplered4
    | [<CompiledName("purplered-5")>] purplered5
    | [<CompiledName("purplered-6")>] purplered6
    | [<CompiledName("purplered-7")>] purplered7
    | [<CompiledName("purplered-8")>] purplered8
    | [<CompiledName("purplered-9")>] purplered9
    | redpurple
    | [<CompiledName("redpurple-3")>] redpurple3
    | [<CompiledName("redpurple-4")>] redpurple4
    | [<CompiledName("redpurple-5")>] redpurple5
    | [<CompiledName("redpurple-6")>] redpurple6
    | [<CompiledName("redpurple-7")>] redpurple7
    | [<CompiledName("redpurple-8")>] redpurple8
    | [<CompiledName("redpurple-9")>] redpurple9
    | yellowgreenblue
    | [<CompiledName("yellowgreenblue-3")>] yellowgreenblue3
    | [<CompiledName("yellowgreenblue-4")>] yellowgreenblue4
    | [<CompiledName("yellowgreenblue-5")>] yellowgreenblue5
    | [<CompiledName("yellowgreenblue-6")>] yellowgreenblue6
    | [<CompiledName("yellowgreenblue-7")>] yellowgreenblue7
    | [<CompiledName("yellowgreenblue-8")>] yellowgreenblue8
    | [<CompiledName("yellowgreenblue-9")>] yellowgreenblue9
    | yellowgreen
    | [<CompiledName("yellowgreen-3")>] yellowgreen3
    | [<CompiledName("yellowgreen-4")>] yellowgreen4
    | [<CompiledName("yellowgreen-5")>] yellowgreen5
    | [<CompiledName("yellowgreen-6")>] yellowgreen6
    | [<CompiledName("yellowgreen-7")>] yellowgreen7
    | [<CompiledName("yellowgreen-8")>] yellowgreen8
    | [<CompiledName("yellowgreen-9")>] yellowgreen9
    | yelloworangebrown
    | [<CompiledName("yelloworangebrown-3")>] yelloworangebrown3
    | [<CompiledName("yelloworangebrown-4")>] yelloworangebrown4
    | [<CompiledName("yelloworangebrown-5")>] yelloworangebrown5
    | [<CompiledName("yelloworangebrown-6")>] yelloworangebrown6
    | [<CompiledName("yelloworangebrown-7")>] yelloworangebrown7
    | [<CompiledName("yelloworangebrown-8")>] yelloworangebrown8
    | [<CompiledName("yelloworangebrown-9")>] yelloworangebrown9
    | yelloworangered
    | [<CompiledName("yelloworangered-3")>] yelloworangered3
    | [<CompiledName("yelloworangered-4")>] yelloworangered4
    | [<CompiledName("yelloworangered-5")>] yelloworangered5
    | [<CompiledName("yelloworangered-6")>] yelloworangered6
    | [<CompiledName("yelloworangered-7")>] yelloworangered7
    | [<CompiledName("yelloworangered-8")>] yelloworangered8
    | [<CompiledName("yelloworangered-9")>] yelloworangered9
    | darkblue
    | [<CompiledName("darkblue-3")>] darkblue3
    | [<CompiledName("darkblue-4")>] darkblue4
    | [<CompiledName("darkblue-5")>] darkblue5
    | [<CompiledName("darkblue-6")>] darkblue6
    | [<CompiledName("darkblue-7")>] darkblue7
    | [<CompiledName("darkblue-8")>] darkblue8
    | [<CompiledName("darkblue-9")>] darkblue9
    | darkgold
    | [<CompiledName("darkgold-3")>] darkgold3
    | [<CompiledName("darkgold-4")>] darkgold4
    | [<CompiledName("darkgold-5")>] darkgold5
    | [<CompiledName("darkgold-6")>] darkgold6
    | [<CompiledName("darkgold-7")>] darkgold7
    | [<CompiledName("darkgold-8")>] darkgold8
    | [<CompiledName("darkgold-9")>] darkgold9
    | darkgreen
    | [<CompiledName("darkgreen-3")>] darkgreen3
    | [<CompiledName("darkgreen-4")>] darkgreen4
    | [<CompiledName("darkgreen-5")>] darkgreen5
    | [<CompiledName("darkgreen-6")>] darkgreen6
    | [<CompiledName("darkgreen-7")>] darkgreen7
    | [<CompiledName("darkgreen-8")>] darkgreen8
    | [<CompiledName("darkgreen-9")>] darkgreen9
    | darkmulti
    | [<CompiledName("darkmulti-3")>] darkmulti3
    | [<CompiledName("darkmulti-4")>] darkmulti4
    | [<CompiledName("darkmulti-5")>] darkmulti5
    | [<CompiledName("darkmulti-6")>] darkmulti6
    | [<CompiledName("darkmulti-7")>] darkmulti7
    | [<CompiledName("darkmulti-8")>] darkmulti8
    | [<CompiledName("darkmulti-9")>] darkmulti9
    | darkred
    | [<CompiledName("darkred-3")>] darkred3
    | [<CompiledName("darkred-4")>] darkred4
    | [<CompiledName("darkred-5")>] darkred5
    | [<CompiledName("darkred-6")>] darkred6
    | [<CompiledName("darkred-7")>] darkred7
    | [<CompiledName("darkred-8")>] darkred8
    | [<CompiledName("darkred-9")>] darkred9
    | lightgreyred
    | [<CompiledName("lightgreyred-3")>] lightgreyred3
    | [<CompiledName("lightgreyred-4")>] lightgreyred4
    | [<CompiledName("lightgreyred-5")>] lightgreyred5
    | [<CompiledName("lightgreyred-6")>] lightgreyred6
    | [<CompiledName("lightgreyred-7")>] lightgreyred7
    | [<CompiledName("lightgreyred-8")>] lightgreyred8
    | [<CompiledName("lightgreyred-9")>] lightgreyred9
    | lightgreyteal
    | [<CompiledName("lightgreyteal-3")>] lightgreyteal3
    | [<CompiledName("lightgreyteal-4")>] lightgreyteal4
    | [<CompiledName("lightgreyteal-5")>] lightgreyteal5
    | [<CompiledName("lightgreyteal-6")>] lightgreyteal6
    | [<CompiledName("lightgreyteal-7")>] lightgreyteal7
    | [<CompiledName("lightgreyteal-8")>] lightgreyteal8
    | [<CompiledName("lightgreyteal-9")>] lightgreyteal9
    | lightmulti
    | [<CompiledName("lightmulti-3")>] lightmulti3
    | [<CompiledName("lightmulti-4")>] lightmulti4
    | [<CompiledName("lightmulti-5")>] lightmulti5
    | [<CompiledName("lightmulti-6")>] lightmulti6
    | [<CompiledName("lightmulti-7")>] lightmulti7
    | [<CompiledName("lightmulti-8")>] lightmulti8
    | [<CompiledName("lightmulti-9")>] lightmulti9
    | lightorange
    | [<CompiledName("lightorange-3")>] lightorange3
    | [<CompiledName("lightorange-4")>] lightorange4
    | [<CompiledName("lightorange-5")>] lightorange5
    | [<CompiledName("lightorange-6")>] lightorange6
    | [<CompiledName("lightorange-7")>] lightorange7
    | [<CompiledName("lightorange-8")>] lightorange8
    | [<CompiledName("lightorange-9")>] lightorange9
    | lighttealblue
    | [<CompiledName("lighttealblue-3")>] lighttealblue3
    | [<CompiledName("lighttealblue-4")>] lighttealblue4
    | [<CompiledName("lighttealblue-5")>] lighttealblue5
    | [<CompiledName("lighttealblue-6")>] lighttealblue6
    | [<CompiledName("lighttealblue-7")>] lighttealblue7
    | [<CompiledName("lighttealblue-8")>] lighttealblue8
    | [<CompiledName("lighttealblue-9")>] lighttealblue9

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type Diverging =
    | blueorange
    | [<CompiledName("blueorange-3")>] blueorange3
    | [<CompiledName("blueorange-4")>] blueorange4
    | [<CompiledName("blueorange-5")>] blueorange5
    | [<CompiledName("blueorange-6")>] blueorange6
    | [<CompiledName("blueorange-7")>] blueorange7
    | [<CompiledName("blueorange-8")>] blueorange8
    | [<CompiledName("blueorange-9")>] blueorange9
    | ``blueorange-10``
    | ``blueorange-11``
    | brownbluegreen
    | [<CompiledName("brownbluegreen-3")>] brownbluegreen3
    | [<CompiledName("brownbluegreen-4")>] brownbluegreen4
    | [<CompiledName("brownbluegreen-5")>] brownbluegreen5
    | [<CompiledName("brownbluegreen-6")>] brownbluegreen6
    | [<CompiledName("brownbluegreen-7")>] brownbluegreen7
    | [<CompiledName("brownbluegreen-8")>] brownbluegreen8
    | [<CompiledName("brownbluegreen-9")>] brownbluegreen9
    | ``brownbluegreen-10``
    | ``brownbluegreen-11``
    | purplegreen
    | [<CompiledName("purplegreen-3")>] purplegreen3
    | [<CompiledName("purplegreen-4")>] purplegreen4
    | [<CompiledName("purplegreen-5")>] purplegreen5
    | [<CompiledName("purplegreen-6")>] purplegreen6
    | [<CompiledName("purplegreen-7")>] purplegreen7
    | [<CompiledName("purplegreen-8")>] purplegreen8
    | [<CompiledName("purplegreen-9")>] purplegreen9
    | ``purplegreen-10``
    | ``purplegreen-11``
    | pinkyellowgreen
    | [<CompiledName("pinkyellowgreen-3")>] pinkyellowgreen3
    | [<CompiledName("pinkyellowgreen-4")>] pinkyellowgreen4
    | [<CompiledName("pinkyellowgreen-5")>] pinkyellowgreen5
    | [<CompiledName("pinkyellowgreen-6")>] pinkyellowgreen6
    | [<CompiledName("pinkyellowgreen-7")>] pinkyellowgreen7
    | [<CompiledName("pinkyellowgreen-8")>] pinkyellowgreen8
    | [<CompiledName("pinkyellowgreen-9")>] pinkyellowgreen9
    | ``pinkyellowgreen-10``
    | ``pinkyellowgreen-11``
    | purpleorange
    | [<CompiledName("purpleorange-3")>] purpleorange3
    | [<CompiledName("purpleorange-4")>] purpleorange4
    | [<CompiledName("purpleorange-5")>] purpleorange5
    | [<CompiledName("purpleorange-6")>] purpleorange6
    | [<CompiledName("purpleorange-7")>] purpleorange7
    | [<CompiledName("purpleorange-8")>] purpleorange8
    | [<CompiledName("purpleorange-9")>] purpleorange9
    | ``purpleorange-10``
    | ``purpleorange-11``
    | redblue
    | [<CompiledName("redblue-3")>] redblue3
    | [<CompiledName("redblue-4")>] redblue4
    | [<CompiledName("redblue-5")>] redblue5
    | [<CompiledName("redblue-6")>] redblue6
    | [<CompiledName("redblue-7")>] redblue7
    | [<CompiledName("redblue-8")>] redblue8
    | [<CompiledName("redblue-9")>] redblue9
    | ``redblue-10``
    | ``redblue-11``
    | redgrey
    | [<CompiledName("redgrey-3")>] redgrey3
    | [<CompiledName("redgrey-4")>] redgrey4
    | [<CompiledName("redgrey-5")>] redgrey5
    | [<CompiledName("redgrey-6")>] redgrey6
    | [<CompiledName("redgrey-7")>] redgrey7
    | [<CompiledName("redgrey-8")>] redgrey8
    | [<CompiledName("redgrey-9")>] redgrey9
    | ``redgrey-10``
    | ``redgrey-11``
    | redyellowblue
    | [<CompiledName("redyellowblue-3")>] redyellowblue3
    | [<CompiledName("redyellowblue-4")>] redyellowblue4
    | [<CompiledName("redyellowblue-5")>] redyellowblue5
    | [<CompiledName("redyellowblue-6")>] redyellowblue6
    | [<CompiledName("redyellowblue-7")>] redyellowblue7
    | [<CompiledName("redyellowblue-8")>] redyellowblue8
    | [<CompiledName("redyellowblue-9")>] redyellowblue9
    | ``redyellowblue-10``
    | ``redyellowblue-11``
    | redyellowgreen
    | [<CompiledName("redyellowgreen-3")>] redyellowgreen3
    | [<CompiledName("redyellowgreen-4")>] redyellowgreen4
    | [<CompiledName("redyellowgreen-5")>] redyellowgreen5
    | [<CompiledName("redyellowgreen-6")>] redyellowgreen6
    | [<CompiledName("redyellowgreen-7")>] redyellowgreen7
    | [<CompiledName("redyellowgreen-8")>] redyellowgreen8
    | [<CompiledName("redyellowgreen-9")>] redyellowgreen9
    | ``redyellowgreen-10``
    | ``redyellowgreen-11``
    | spectral
    | [<CompiledName("spectral-3")>] spectral3
    | [<CompiledName("spectral-4")>] spectral4
    | [<CompiledName("spectral-5")>] spectral5
    | [<CompiledName("spectral-6")>] spectral6
    | [<CompiledName("spectral-7")>] spectral7
    | [<CompiledName("spectral-8")>] spectral8
    | [<CompiledName("spectral-9")>] spectral9
    | ``spectral-10``
    | ``spectral-11``

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type Cyclical =
    | rainbow
    | sinebow

[<RequireQualifiedAccess>]
[<StringEnum(CaseRules.None)>]
type ColorScheme =
    | accent
    | category10
    | category20
    | category20b
    | category20c
    | dark2
    | paired
    | pastel1
    | pastel2
    | set1
    | set2
    | set3
    | tableau10
    | tableau20
    | observable10
    | blues
    | tealblues
    | teals
    | greens
    | browns
    | greys
    | purples
    | warmgreys
    | reds
    | oranges
    | turbo
    | viridis
    | inferno
    | magma
    | plasma
    | cividis
    | bluegreen
    | [<CompiledName("bluegreen-3")>] bluegreen3
    | [<CompiledName("bluegreen-4")>] bluegreen4
    | [<CompiledName("bluegreen-5")>] bluegreen5
    | [<CompiledName("bluegreen-6")>] bluegreen6
    | [<CompiledName("bluegreen-7")>] bluegreen7
    | [<CompiledName("bluegreen-8")>] bluegreen8
    | [<CompiledName("bluegreen-9")>] bluegreen9
    | bluepurple
    | [<CompiledName("bluepurple-3")>] bluepurple3
    | [<CompiledName("bluepurple-4")>] bluepurple4
    | [<CompiledName("bluepurple-5")>] bluepurple5
    | [<CompiledName("bluepurple-6")>] bluepurple6
    | [<CompiledName("bluepurple-7")>] bluepurple7
    | [<CompiledName("bluepurple-8")>] bluepurple8
    | [<CompiledName("bluepurple-9")>] bluepurple9
    | goldgreen
    | [<CompiledName("goldgreen-3")>] goldgreen3
    | [<CompiledName("goldgreen-4")>] goldgreen4
    | [<CompiledName("goldgreen-5")>] goldgreen5
    | [<CompiledName("goldgreen-6")>] goldgreen6
    | [<CompiledName("goldgreen-7")>] goldgreen7
    | [<CompiledName("goldgreen-8")>] goldgreen8
    | [<CompiledName("goldgreen-9")>] goldgreen9
    | goldorange
    | [<CompiledName("goldorange-3")>] goldorange3
    | [<CompiledName("goldorange-4")>] goldorange4
    | [<CompiledName("goldorange-5")>] goldorange5
    | [<CompiledName("goldorange-6")>] goldorange6
    | [<CompiledName("goldorange-7")>] goldorange7
    | [<CompiledName("goldorange-8")>] goldorange8
    | [<CompiledName("goldorange-9")>] goldorange9
    | goldred
    | [<CompiledName("goldred-3")>] goldred3
    | [<CompiledName("goldred-4")>] goldred4
    | [<CompiledName("goldred-5")>] goldred5
    | [<CompiledName("goldred-6")>] goldred6
    | [<CompiledName("goldred-7")>] goldred7
    | [<CompiledName("goldred-8")>] goldred8
    | [<CompiledName("goldred-9")>] goldred9
    | greenblue
    | [<CompiledName("greenblue-3")>] greenblue3
    | [<CompiledName("greenblue-4")>] greenblue4
    | [<CompiledName("greenblue-5")>] greenblue5
    | [<CompiledName("greenblue-6")>] greenblue6
    | [<CompiledName("greenblue-7")>] greenblue7
    | [<CompiledName("greenblue-8")>] greenblue8
    | [<CompiledName("greenblue-9")>] greenblue9
    | orangered
    | [<CompiledName("orangered-3")>] orangered3
    | [<CompiledName("orangered-4")>] orangered4
    | [<CompiledName("orangered-5")>] orangered5
    | [<CompiledName("orangered-6")>] orangered6
    | [<CompiledName("orangered-7")>] orangered7
    | [<CompiledName("orangered-8")>] orangered8
    | [<CompiledName("orangered-9")>] orangered9
    | purplebluegreen
    | [<CompiledName("purplebluegreen-3")>] purplebluegreen3
    | [<CompiledName("purplebluegreen-4")>] purplebluegreen4
    | [<CompiledName("purplebluegreen-5")>] purplebluegreen5
    | [<CompiledName("purplebluegreen-6")>] purplebluegreen6
    | [<CompiledName("purplebluegreen-7")>] purplebluegreen7
    | [<CompiledName("purplebluegreen-8")>] purplebluegreen8
    | [<CompiledName("purplebluegreen-9")>] purplebluegreen9
    | purpleblue
    | [<CompiledName("purpleblue-3")>] purpleblue3
    | [<CompiledName("purpleblue-4")>] purpleblue4
    | [<CompiledName("purpleblue-5")>] purpleblue5
    | [<CompiledName("purpleblue-6")>] purpleblue6
    | [<CompiledName("purpleblue-7")>] purpleblue7
    | [<CompiledName("purpleblue-8")>] purpleblue8
    | [<CompiledName("purpleblue-9")>] purpleblue9
    | purplered
    | [<CompiledName("purplered-3")>] purplered3
    | [<CompiledName("purplered-4")>] purplered4
    | [<CompiledName("purplered-5")>] purplered5
    | [<CompiledName("purplered-6")>] purplered6
    | [<CompiledName("purplered-7")>] purplered7
    | [<CompiledName("purplered-8")>] purplered8
    | [<CompiledName("purplered-9")>] purplered9
    | redpurple
    | [<CompiledName("redpurple-3")>] redpurple3
    | [<CompiledName("redpurple-4")>] redpurple4
    | [<CompiledName("redpurple-5")>] redpurple5
    | [<CompiledName("redpurple-6")>] redpurple6
    | [<CompiledName("redpurple-7")>] redpurple7
    | [<CompiledName("redpurple-8")>] redpurple8
    | [<CompiledName("redpurple-9")>] redpurple9
    | yellowgreenblue
    | [<CompiledName("yellowgreenblue-3")>] yellowgreenblue3
    | [<CompiledName("yellowgreenblue-4")>] yellowgreenblue4
    | [<CompiledName("yellowgreenblue-5")>] yellowgreenblue5
    | [<CompiledName("yellowgreenblue-6")>] yellowgreenblue6
    | [<CompiledName("yellowgreenblue-7")>] yellowgreenblue7
    | [<CompiledName("yellowgreenblue-8")>] yellowgreenblue8
    | [<CompiledName("yellowgreenblue-9")>] yellowgreenblue9
    | yellowgreen
    | [<CompiledName("yellowgreen-3")>] yellowgreen3
    | [<CompiledName("yellowgreen-4")>] yellowgreen4
    | [<CompiledName("yellowgreen-5")>] yellowgreen5
    | [<CompiledName("yellowgreen-6")>] yellowgreen6
    | [<CompiledName("yellowgreen-7")>] yellowgreen7
    | [<CompiledName("yellowgreen-8")>] yellowgreen8
    | [<CompiledName("yellowgreen-9")>] yellowgreen9
    | yelloworangebrown
    | [<CompiledName("yelloworangebrown-3")>] yelloworangebrown3
    | [<CompiledName("yelloworangebrown-4")>] yelloworangebrown4
    | [<CompiledName("yelloworangebrown-5")>] yelloworangebrown5
    | [<CompiledName("yelloworangebrown-6")>] yelloworangebrown6
    | [<CompiledName("yelloworangebrown-7")>] yelloworangebrown7
    | [<CompiledName("yelloworangebrown-8")>] yelloworangebrown8
    | [<CompiledName("yelloworangebrown-9")>] yelloworangebrown9
    | yelloworangered
    | [<CompiledName("yelloworangered-3")>] yelloworangered3
    | [<CompiledName("yelloworangered-4")>] yelloworangered4
    | [<CompiledName("yelloworangered-5")>] yelloworangered5
    | [<CompiledName("yelloworangered-6")>] yelloworangered6
    | [<CompiledName("yelloworangered-7")>] yelloworangered7
    | [<CompiledName("yelloworangered-8")>] yelloworangered8
    | [<CompiledName("yelloworangered-9")>] yelloworangered9
    | darkblue
    | [<CompiledName("darkblue-3")>] darkblue3
    | [<CompiledName("darkblue-4")>] darkblue4
    | [<CompiledName("darkblue-5")>] darkblue5
    | [<CompiledName("darkblue-6")>] darkblue6
    | [<CompiledName("darkblue-7")>] darkblue7
    | [<CompiledName("darkblue-8")>] darkblue8
    | [<CompiledName("darkblue-9")>] darkblue9
    | darkgold
    | [<CompiledName("darkgold-3")>] darkgold3
    | [<CompiledName("darkgold-4")>] darkgold4
    | [<CompiledName("darkgold-5")>] darkgold5
    | [<CompiledName("darkgold-6")>] darkgold6
    | [<CompiledName("darkgold-7")>] darkgold7
    | [<CompiledName("darkgold-8")>] darkgold8
    | [<CompiledName("darkgold-9")>] darkgold9
    | darkgreen
    | [<CompiledName("darkgreen-3")>] darkgreen3
    | [<CompiledName("darkgreen-4")>] darkgreen4
    | [<CompiledName("darkgreen-5")>] darkgreen5
    | [<CompiledName("darkgreen-6")>] darkgreen6
    | [<CompiledName("darkgreen-7")>] darkgreen7
    | [<CompiledName("darkgreen-8")>] darkgreen8
    | [<CompiledName("darkgreen-9")>] darkgreen9
    | darkmulti
    | [<CompiledName("darkmulti-3")>] darkmulti3
    | [<CompiledName("darkmulti-4")>] darkmulti4
    | [<CompiledName("darkmulti-5")>] darkmulti5
    | [<CompiledName("darkmulti-6")>] darkmulti6
    | [<CompiledName("darkmulti-7")>] darkmulti7
    | [<CompiledName("darkmulti-8")>] darkmulti8
    | [<CompiledName("darkmulti-9")>] darkmulti9
    | darkred
    | [<CompiledName("darkred-3")>] darkred3
    | [<CompiledName("darkred-4")>] darkred4
    | [<CompiledName("darkred-5")>] darkred5
    | [<CompiledName("darkred-6")>] darkred6
    | [<CompiledName("darkred-7")>] darkred7
    | [<CompiledName("darkred-8")>] darkred8
    | [<CompiledName("darkred-9")>] darkred9
    | lightgreyred
    | [<CompiledName("lightgreyred-3")>] lightgreyred3
    | [<CompiledName("lightgreyred-4")>] lightgreyred4
    | [<CompiledName("lightgreyred-5")>] lightgreyred5
    | [<CompiledName("lightgreyred-6")>] lightgreyred6
    | [<CompiledName("lightgreyred-7")>] lightgreyred7
    | [<CompiledName("lightgreyred-8")>] lightgreyred8
    | [<CompiledName("lightgreyred-9")>] lightgreyred9
    | lightgreyteal
    | [<CompiledName("lightgreyteal-3")>] lightgreyteal3
    | [<CompiledName("lightgreyteal-4")>] lightgreyteal4
    | [<CompiledName("lightgreyteal-5")>] lightgreyteal5
    | [<CompiledName("lightgreyteal-6")>] lightgreyteal6
    | [<CompiledName("lightgreyteal-7")>] lightgreyteal7
    | [<CompiledName("lightgreyteal-8")>] lightgreyteal8
    | [<CompiledName("lightgreyteal-9")>] lightgreyteal9
    | lightmulti
    | [<CompiledName("lightmulti-3")>] lightmulti3
    | [<CompiledName("lightmulti-4")>] lightmulti4
    | [<CompiledName("lightmulti-5")>] lightmulti5
    | [<CompiledName("lightmulti-6")>] lightmulti6
    | [<CompiledName("lightmulti-7")>] lightmulti7
    | [<CompiledName("lightmulti-8")>] lightmulti8
    | [<CompiledName("lightmulti-9")>] lightmulti9
    | lightorange
    | [<CompiledName("lightorange-3")>] lightorange3
    | [<CompiledName("lightorange-4")>] lightorange4
    | [<CompiledName("lightorange-5")>] lightorange5
    | [<CompiledName("lightorange-6")>] lightorange6
    | [<CompiledName("lightorange-7")>] lightorange7
    | [<CompiledName("lightorange-8")>] lightorange8
    | [<CompiledName("lightorange-9")>] lightorange9
    | lighttealblue
    | [<CompiledName("lighttealblue-3")>] lighttealblue3
    | [<CompiledName("lighttealblue-4")>] lighttealblue4
    | [<CompiledName("lighttealblue-5")>] lighttealblue5
    | [<CompiledName("lighttealblue-6")>] lighttealblue6
    | [<CompiledName("lighttealblue-7")>] lighttealblue7
    | [<CompiledName("lighttealblue-8")>] lighttealblue8
    | [<CompiledName("lighttealblue-9")>] lighttealblue9
    | blueorange
    | [<CompiledName("blueorange-3")>] blueorange3
    | [<CompiledName("blueorange-4")>] blueorange4
    | [<CompiledName("blueorange-5")>] blueorange5
    | [<CompiledName("blueorange-6")>] blueorange6
    | [<CompiledName("blueorange-7")>] blueorange7
    | [<CompiledName("blueorange-8")>] blueorange8
    | [<CompiledName("blueorange-9")>] blueorange9
    | ``blueorange-10``
    | ``blueorange-11``
    | brownbluegreen
    | [<CompiledName("brownbluegreen-3")>] brownbluegreen3
    | [<CompiledName("brownbluegreen-4")>] brownbluegreen4
    | [<CompiledName("brownbluegreen-5")>] brownbluegreen5
    | [<CompiledName("brownbluegreen-6")>] brownbluegreen6
    | [<CompiledName("brownbluegreen-7")>] brownbluegreen7
    | [<CompiledName("brownbluegreen-8")>] brownbluegreen8
    | [<CompiledName("brownbluegreen-9")>] brownbluegreen9
    | ``brownbluegreen-10``
    | ``brownbluegreen-11``
    | purplegreen
    | [<CompiledName("purplegreen-3")>] purplegreen3
    | [<CompiledName("purplegreen-4")>] purplegreen4
    | [<CompiledName("purplegreen-5")>] purplegreen5
    | [<CompiledName("purplegreen-6")>] purplegreen6
    | [<CompiledName("purplegreen-7")>] purplegreen7
    | [<CompiledName("purplegreen-8")>] purplegreen8
    | [<CompiledName("purplegreen-9")>] purplegreen9
    | ``purplegreen-10``
    | ``purplegreen-11``
    | pinkyellowgreen
    | [<CompiledName("pinkyellowgreen-3")>] pinkyellowgreen3
    | [<CompiledName("pinkyellowgreen-4")>] pinkyellowgreen4
    | [<CompiledName("pinkyellowgreen-5")>] pinkyellowgreen5
    | [<CompiledName("pinkyellowgreen-6")>] pinkyellowgreen6
    | [<CompiledName("pinkyellowgreen-7")>] pinkyellowgreen7
    | [<CompiledName("pinkyellowgreen-8")>] pinkyellowgreen8
    | [<CompiledName("pinkyellowgreen-9")>] pinkyellowgreen9
    | ``pinkyellowgreen-10``
    | ``pinkyellowgreen-11``
    | purpleorange
    | [<CompiledName("purpleorange-3")>] purpleorange3
    | [<CompiledName("purpleorange-4")>] purpleorange4
    | [<CompiledName("purpleorange-5")>] purpleorange5
    | [<CompiledName("purpleorange-6")>] purpleorange6
    | [<CompiledName("purpleorange-7")>] purpleorange7
    | [<CompiledName("purpleorange-8")>] purpleorange8
    | [<CompiledName("purpleorange-9")>] purpleorange9
    | ``purpleorange-10``
    | ``purpleorange-11``
    | redblue
    | [<CompiledName("redblue-3")>] redblue3
    | [<CompiledName("redblue-4")>] redblue4
    | [<CompiledName("redblue-5")>] redblue5
    | [<CompiledName("redblue-6")>] redblue6
    | [<CompiledName("redblue-7")>] redblue7
    | [<CompiledName("redblue-8")>] redblue8
    | [<CompiledName("redblue-9")>] redblue9
    | ``redblue-10``
    | ``redblue-11``
    | redgrey
    | [<CompiledName("redgrey-3")>] redgrey3
    | [<CompiledName("redgrey-4")>] redgrey4
    | [<CompiledName("redgrey-5")>] redgrey5
    | [<CompiledName("redgrey-6")>] redgrey6
    | [<CompiledName("redgrey-7")>] redgrey7
    | [<CompiledName("redgrey-8")>] redgrey8
    | [<CompiledName("redgrey-9")>] redgrey9
    | ``redgrey-10``
    | ``redgrey-11``
    | redyellowblue
    | [<CompiledName("redyellowblue-3")>] redyellowblue3
    | [<CompiledName("redyellowblue-4")>] redyellowblue4
    | [<CompiledName("redyellowblue-5")>] redyellowblue5
    | [<CompiledName("redyellowblue-6")>] redyellowblue6
    | [<CompiledName("redyellowblue-7")>] redyellowblue7
    | [<CompiledName("redyellowblue-8")>] redyellowblue8
    | [<CompiledName("redyellowblue-9")>] redyellowblue9
    | ``redyellowblue-10``
    | ``redyellowblue-11``
    | redyellowgreen
    | [<CompiledName("redyellowgreen-3")>] redyellowgreen3
    | [<CompiledName("redyellowgreen-4")>] redyellowgreen4
    | [<CompiledName("redyellowgreen-5")>] redyellowgreen5
    | [<CompiledName("redyellowgreen-6")>] redyellowgreen6
    | [<CompiledName("redyellowgreen-7")>] redyellowgreen7
    | [<CompiledName("redyellowgreen-8")>] redyellowgreen8
    | [<CompiledName("redyellowgreen-9")>] redyellowgreen9
    | ``redyellowgreen-10``
    | ``redyellowgreen-11``
    | spectral
    | [<CompiledName("spectral-3")>] spectral3
    | [<CompiledName("spectral-4")>] spectral4
    | [<CompiledName("spectral-5")>] spectral5
    | [<CompiledName("spectral-6")>] spectral6
    | [<CompiledName("spectral-7")>] spectral7
    | [<CompiledName("spectral-8")>] spectral8
    | [<CompiledName("spectral-9")>] spectral9
    | ``spectral-10``
    | ``spectral-11``
    | rainbow
    | sinebow
