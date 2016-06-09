// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open System
open System.Net

open Suave
open Suave.Sockets.Control
open Suave.Logging
open Suave.Operators
open Suave.EventSource
open Suave.Filters
open Suave.Writers
open Suave.Files
open Suave.Successful
open Suave.State.CookieStateStore
open System.IO

let app : WebPart =
      choose [ Filters.GET >=> choose [ Filters.path "/" >=> Files.file "index.html"; Files.browseHome ]
               RequestErrors.NOT_FOUND "Page not found." ]

let defaultMimeTypesMap = function
  | ".css" -> mkMimeType "text/css" true
  | ".gif" -> mkMimeType "image/gif" false
  | ".png" -> mkMimeType "image/png" false
  | ".htm"
  | ".html" -> mkMimeType "text/html" true
  | ".jpe"
  | ".jpeg"
  | ".jpg" -> mkMimeType "image/jpeg" false
  | ".js"  -> mkMimeType "application/x-javascript" true
  | _      -> None
                 
[<EntryPoint>]
let main argv = 
    startWebServer { defaultConfig with homeFolder = Some @"..\..\angularjs-quickstart" } app
    printfn "%A" argv
    0 // return an integer exit code
