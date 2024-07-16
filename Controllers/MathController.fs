namespace WebAPI_FSharp.Controllers

open Microsoft.AspNetCore.Mvc
open Microsoft.Extensions.Logging

[<ApiController>]
[<Route("[controller]")>]
type MathController (logger : ILogger<MathController>) =
    inherit ControllerBase()

    [<HttpPost("Plus")>]
    member _.Plus(a:float,b:float) =
        a + b

    [<HttpPost("Minus")>]
    member _.Minus(a:float,b:float) =
        a - b

    [<HttpPost("multiplikation")>]
    member _.Multiplikation(a:float,b:float) =
        a * b

    [<HttpPost("division")>]
    member _.Division(a:float,b:float) =
        a / b
