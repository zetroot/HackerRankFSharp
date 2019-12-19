// Learn more about F# at http://fsharp.org

open System

let hasDoubledTuples (tupleList:list<int*int>) = 
    tupleList 
    |> List.map fst 
    |> List.countBy (fun x -> x) 
    |> List.map (fun x -> match snd x with | 0 | 1 -> false | _ -> true)
    |> List.reduce (fun x y -> x || y)


[<EntryPoint>]
let main argv =
    let T = Console.ReadLine() |> int
    let N = Console.ReadLine() |> int
    let tuplesArr =
        Seq.init N (fun _ -> 
            let doubledArr = Console.ReadLine().Split(' ') |> Array.map int
            let a = Array.head doubledArr
            let b = Array.skip 1 doubledArr |> Array.head
            (a, b)
            )
        |> Seq.toList

    0 // return an integer exit code
