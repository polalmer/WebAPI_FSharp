namespace WebAPI_FSharp.Controllers

open Microsoft.AspNetCore.Mvc
open Microsoft.Extensions.Logging
open WebAPI_FSharp
open WebAPI_FSharp.Days

type DataType = 
    |Test = 1
    |Real = 2

type Task = 
    |Part1 = 1
    |Part2 = 2

[<ApiController>]
[<Route("[controller]")>]
type AOC2023Controller (logger : ILogger<AOC2023Controller>) =
    inherit ControllerBase()

    [<HttpGet("{task}/data/{dataType}")>]
    member _.Day1(task:Task,dataType:DataType) =
        let input = FileReader.readFile($"Day1\{task.ToString()}.{dataType.ToString()}.txt")
        Day1.Part1(input)