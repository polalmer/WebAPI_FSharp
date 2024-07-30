namespace WebAPI_FSharp.Days

module Day1 =

    let Part1(input:string[]):string =
        let mutable result = 0 
        for line in input do

            let first = 
                line
                |> Seq.filter System.Char.IsDigit
                |> Seq.head

            let last = 
                line
                |> Seq.filter System.Char.IsDigit
                |> Seq.last

            let number = 
                (first + last)
                |> int

            result <- result + number
        result|>string
            
        