// Learn more about F# at http://fsharp.org

open System

let reduplicate list n =
    List.collect (fun x -> List.replicate n x) list

[<EntryPoint>]
let main argv =
    let s = Console.ReadLine() |> int
    let list = Seq.initInfinite (fun _ -> Console.ReadLine()) |> Seq.takeWhile(String.IsNullOrWhiteSpace >> not) |> Seq.toList
    List.iter (printfn "%s") (reduplicate list s)    
    0 // return an integer exit code
