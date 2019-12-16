// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let x = Console.ReadLine() |> int
    let list = Seq.initInfinite (fun _ -> Console.ReadLine() ) |> Seq.takeWhile (String.IsNullOrWhiteSpace >> not) |> Seq.map(fun x -> x |> int) |> Seq.toList
    List.filter ((>) x) list |> List.iter (printfn "%d")
    0 // return an integer exit code
