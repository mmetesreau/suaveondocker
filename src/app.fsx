#r "../packages/Suave/lib/net40/Suave.dll"

open System

open Suave
open Suave.Filters
open Suave.Operators

let port = 8080

let app = 
    choose [
        GET >=> choose [
                path "/" >=> Successful.OK "hello world"
                path "/ping" >=> Successful.OK "ping"
            ]
    ]

startWebServer { defaultConfig with bindings = [ HttpBinding.createSimple HTTP "0.0.0.0" port ] } app

