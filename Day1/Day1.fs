namespace WebAPI_FSharp.Day1

module Day1 =
    let Part1(input:string[]):string =
       let mutable text = ""
       for line in input do
            text <- text + line
       text
        