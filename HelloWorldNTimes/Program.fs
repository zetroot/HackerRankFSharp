// Learn more about F# at http://fsharp.org

open System


let repeatTimes n f =
    List.init n f    

let printFunc x =
    printfn "Hello World"

[<EntryPoint>]
let main argv =
    let n = Console.ReadLine() |> int
    repeatTimes n printFunc |> ignore
    0 // return an integer exit code
