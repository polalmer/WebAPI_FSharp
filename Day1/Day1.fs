namespace WebAPI_FSharp.Days

module Day1 =

    let Part1(input:string[]):string =
        input
            |> 
            Array.fold (fun acc line ->
                let first = 
                    line
                    |> Seq.filter System.Char.IsDigit
                    |> Seq.head
                    |> string

                let last = 
                    line
                    |> Seq.filter System.Char.IsDigit
                    |> Seq.last
                    |> string

                let number = 
                    (first + last)
                    |> int

                acc + number) 0
        |> string
            
        