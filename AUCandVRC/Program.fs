// Learn more about F# at http://fsharp.org

open System

let polynom a b x =
    List.map2 (fun an bn -> an * Math.Pow(x, bn)) a b
    |> List.reduce (+)

let initDiscreteLine (step:double) (L:double) (R:double) =
    Seq.initInfinite(fun i -> L + step * ( i+1 |> double)) |> Seq.takeWhile (fun x -> x <= R) |> Seq.map double |> Seq.toList

let calcAUC (poly: double -> double) (discrets : double list) (step : double) =
    let deltaS x = step * poly x
    discrets |> List.map deltaS |> List.reduce (+)

let calcVRC (poly: double -> double) (discrets : double list) (step : double) =
    let deltaV x = Math.PI * step * Math.Pow(poly x, 2.0)
    discrets |> List.map deltaV |> List.reduce (+)

[<EntryPoint>]
let main argv =
    let a = Console.ReadLine().Split(' ') |> Array.map double |> Array.toList
    let b = Console.ReadLine().Split(' ') |> Array.map double |> Array.toList
    let lr_list = Console.ReadLine().Split(' ') |> Array.map double |> Array.toList
    let l = List.head lr_list
    let r = List.skip 1 lr_list |> List.head
    let step = 0.001

    let auc = calcAUC (polynom a b) (initDiscreteLine step l r) (step)
    let vrc = calcVRC (polynom a b) (initDiscreteLine step l r) (step)

    printfn "%f" auc
    printfn "%f" vrc
    0 // return an integer exit code
