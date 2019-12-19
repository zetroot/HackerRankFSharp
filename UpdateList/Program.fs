// Learn more about F# at http://fsharp.org

open System

let abs x =
    match x with
    | x when x < 0  -> -1*x
    | x -> x

let f arr = 
    List.map abs arr

//----------------DON'T MODIFY---------------

let input = 
    stdin.ReadToEnd().Split '\n' 
    |> Array.map(fun x -> int(x)) 
    |> Array.toList
    
let print_out (data:int list) = List.iter (fun x -> printfn "%A" x) data



[<EntryPoint>]
let main argv =
    print_out (f(input))
    0 // return an integer exit code
