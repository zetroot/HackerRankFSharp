// Learn more about F# at http://fsharp.org

open System

let rec fib n =
    match n with
    | 1 -> 0
    | 2 -> 1
    | x -> fib (x-1) + fib (x-2)

[<EntryPoint>]
let main argv =
    let n = Console.ReadLine() |> int
    let result = fib n
    printfn "%d" result
    0 // return an integer exit code
