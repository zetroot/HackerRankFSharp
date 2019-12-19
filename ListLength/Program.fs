// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    Seq.initInfinite (fun _ -> Console.ReadLine())
    |> Seq.takeWhile(String.IsNullOrWhiteSpace >> not)
    |> Seq.map (fun _ -> 1)
    |> Seq.reduce (+)
    |> printfn "%d"
    0 // return an integer exit code
