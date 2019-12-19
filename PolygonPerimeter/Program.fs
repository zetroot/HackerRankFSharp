// Learn more about F# at http://fsharp.org

open System

let buildTuple arr =
    let a = Array.head arr
    let b = Array.tail arr |> Array.head
    (a, b)

let calcDistance (a:(double*double)) (b:(double*double)) =
    let dx2 = Math.Pow((fst a) - (fst b), 2.0)
    let dy2 = Math.Pow((snd a) - (snd b), 2.0)
    Math.Sqrt(dx2 + dy2)

[<EntryPoint>]
let main argv =
    let N = Console.ReadLine() |> int
    let points = 
        Seq.init N (fun _ -> Console.ReadLine().Split(' ') |> Array.map (fun x -> x |> double)) 
        |> Seq.map buildTuple
        |> Seq.toList
    let pointsBiased = 
        let newTail = List.init 1 (fun _ -> List.head points)
        List.append (List.tail points) (newTail)
    List.map2 calcDistance pointsBiased points |> List.reduce (+) |> printfn "%f"
    0 // return an integer exit code
