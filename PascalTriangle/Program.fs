// Learn more about F# at http://fsharp.org

open System

let factorial n = 
    match n with
    | 0 -> 1
    | _ -> Seq.initInfinite (fun x -> x+1) |> Seq.take n |> Seq.reduce (*)

let triangleMember n r =
    (factorial n)/((factorial r)*(factorial (n-r)))
    
let genRow k =
    let s = Seq.initInfinite (fun x -> x) |> Seq.take (k+1) 
    Seq.map (fun x -> triangleMember k x) s

[<EntryPoint>]
let main argv =
    let K = Console.ReadLine() |> int |> fun x -> x-1
    Seq.init K (fun x -> x) |> Seq.map genRow |> Seq.iter (fun x -> x |> Seq.map string |> Seq.reduce (fun a b -> (a + " " + b)) |> printfn "%s")
    genRow K |> Seq.iter (printf "%d ")
    0 // return an integer exit code
