// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    Seq.initInfinite (fun _ -> Console.ReadLine() ) 
    |> Seq.takeWhile (String.IsNullOrWhiteSpace >> not) 
    |> Seq.mapi (fun x n -> (x,n)) 
    |> Seq.filter (fun (i,n) -> i % 2 <> 0)
    |> Seq.map (fun (i,n) -> n)
    |> Seq.iter (fun x -> printfn "%s" x)
    0 // return an integer exit code
