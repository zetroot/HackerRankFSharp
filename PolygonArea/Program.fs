// Learn more about F# at http://fsharp.org

open System

let buildTuple arr =
    let a = Array.head arr
    let b = Array.tail arr |> Array.head
    (a, b)

let calcSeqMember (a:(float*float)) (b:(float*float)) =
    ((fst a)*(snd b) - (snd a)*(fst b))/2.0

[<EntryPoint>]
let main argv =
    let N = Console.ReadLine() |> int
    let points = 
        Seq.init N (fun _ -> Console.ReadLine().Split(' ') |> Array.map (fun x -> x |> float)) 
        |> Seq.map buildTuple
        |> Seq.toList
    let pointsBiased = 
        let newTail = List.init 1 (fun _ -> List.head points)
        List.append (List.tail points) (newTail)
    List.map2 calcSeqMember pointsBiased points |> List.reduce (+) |> Math.Abs |> printfn "%f"
    0 // return an integer exit code