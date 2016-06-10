namespace FSharp.QuickStart.AngularJS2.Web

open System;
open System.Web.Http;

type Hero = { id: int; name: string; }

type NotificationController() =
        inherit ApiController()

        [<HttpGet>]
        [<Route("api/heroes")>]
        member this.GetHeroes() : IHttpActionResult = 
//                  let heroes = [ {id= 11; name="Mr. Nice" };
//                                 {id= 12; name="Narco" };
//                                 {id= 13; name="Bombasto" };
//                                 {id= 14; name="Celeritas" };
//                                 {id= 15; name="Magneta" };
//                                 {id= 16; name="RubberMan" };
//                                 {id= 17; name="Dynama" };
//                                 {id= 18; name="Dr IQ" };
//                                 {id= 19; name="Magma" };
//                                 {id= 20; name="Tornado" };
//                                 {id= 20; name="Stuart" }; ]

                  let heroes = [ {id= 11; name="Mr. Nice" };
                                 {id= 12; name="Narco" };
                                 {id= 13; name="Bombasto" }; ]
        
                  this.Ok(heroes) :> IHttpActionResult


