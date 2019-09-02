open Saturn
open Giraffe

type Person = { Name : string; Age : int }

let routes = router {
    get "/api/foo" (json { Name = "Isaac"; Age = 39 })
}

let app = application {
    use_router routes
}

run app