// Learn more about F# at http://fsharp.org

open System

let elemToList x =
    List.init 1 (fun _ -> x)

let rec reverse x =
    match x with
    | list when List.length list > 1 -> List.head x |> elemToList |> List.append (List.tail x |> reverse)
    |_ -> x

[<EntryPoint>]
let main argv =
    let list =
        Seq.initInfinite(fun _ -> Console.ReadLine())
        |> Seq.takeWhile(String.IsNullOrWhiteSpace >> not)
        |> Seq.toList
    
    reverse list |> List.iter (printfn "%s")    
    0 // return an integer exit code
