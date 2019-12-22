// Learn more about F# at http://fsharp.org

open System

let rec gcd (x:int) (y:int) = 
    match x = y with
    | true -> x
    | false -> gcd (Math.Max(x, y) - Math.Min(x,y)) (Math.Min(x, y))

[<EntryPoint>]
let main argv =
    let input = Console.ReadLine().Split(" ") |> Array.map int
    let res = gcd input.[0] input.[1]
    printfn "%d" res
    0 // return an integer exit code
