// Learn more about F# at http://fsharp.org

open System

(*USER CODE BEGIN*)
let f arr = 
    List.filter (fun x -> match x % 2 with | 0 -> false | _ -> true) arr
    |> List.reduce (+)
(*USER CODE END*)

let read_and_parse()=
    let mutable arr = []
    let mutable buff = Console.ReadLine()
    while buff <> null do
            arr <- Int32.Parse(buff)::arr
            buff <- Console.ReadLine()
    arr

let main =    
    let arr = read_and_parse()
    printf "%A" <| f arr