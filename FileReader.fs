namespace WebAPI_FSharp

open System.IO

module FileReader =
    let readFile (folderFilePath: string) : string[] =
        let fullPath = Path.Combine(Directory.GetCurrentDirectory(), folderFilePath)
        File.ReadAllLines(fullPath)