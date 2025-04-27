namespace Vega
module Vector =
    type Vec2<'T> = private | Vec2 of 'T []
    type Vec3<'T> = private | Vec3 of 'T []
    type Vec7<'T> = private | Vec7 of 'T []
    type Vec10<'T> = private | Vec10 of 'T []
    type Vec12<'T> = private | Vec12 of 'T []
    
    let vec2 (x: 'T, y: 'T) = Vec2 [| x; y |]
    let vec7 (x: 'T, y: 'T, z: 'T, w: 'T, u: 'T, v: 'T, t: 'T) = Vec7 [| x; y; z; w; u; v; t |]
    let vec10 (x: 'T, y: 'T, z: 'T, w: 'T, u: 'T, v: 'T, t: 'T, a: 'T, b: 'T, c: 'T) = Vec10 [| x; y; z; w; u; v; t; a; b; c |]
    let vec12 (x: 'T, y: 'T, z: 'T, w: 'T, u: 'T, v: 'T, t: 'T, a: 'T, b: 'T, c: 'T, d: 'T, e: 'T) = Vec12 [| x; y; z; w; u; v; t; a; b; c; d; e |]


