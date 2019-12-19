// Learn more about F# at http://fsharp.org

open System

let rec factorial n =
    match n with
    | 0 -> 1
    | 1 -> 1
    | 2 -> 2
    | _ -> n * factorial (n - 1)

let calcTerm x n = 
    Math.Pow(x, n |> float) / (factorial n |> float)
    
let calcExp x =
    Seq.init 10 (fun i -> i)
    |> Seq.map (calcTerm x)
    |> Seq.reduce (+)

[<EntryPoint>]
let main argv =
    let N = Console.ReadLine() |> int
    let cases = Seq.init N (fun _ -> Console.ReadLine() |> double) |> Seq.toList
    List.map calcExp cases |> List.iter (printfn "%f")
    0 // return an integer exit code
