﻿module Entry


open System
open Browser
open FSharp.Data.Adaptive

[<EntryPoint>]
let main argv =
    let c = cval 10

    document.write (sprintf "c: %A" (AVal.force c))
    0 // return an integer exit code
