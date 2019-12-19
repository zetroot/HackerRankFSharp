// Learn more about F# at http://fsharp.org

open System

let checkIsFunction kvPairs =
    kvPairs
    |> Map.ofList
    |> Map.toSeq
    |> Seq.length
    |> (=) kvPairs.Length

let boolToStr b = match b with | true -> "YES" | false -> "NO"

let checkTestCase () =
    let N = Console.ReadLine() |> int
    let tuplesArr =
        Seq.init N (fun _ -> 
            let doubledArr = Console.ReadLine().Split(' ') |> Array.map int
            let a = Array.head doubledArr
            let b = Array.skip 1 doubledArr |> Array.head
            (a, b)
            )
        |> Seq.toList
    tuplesArr |> checkIsFunction |> boolToStr

let printResult x =
    printfn "%s" x

[<EntryPoint>]
let main argv =
    let T = Console.ReadLine() |> int
    Seq.init T (fun unit -> 1) |> Seq.iter (fun _ -> () |> checkTestCase |> printfn "%s")
    0 // return an integer exit code
