open Saturn
open Giraffe

let myRouter = router {
    get "/api/foo" (text "Hello")
    get "/api/bar" (json {| Name = "Frodo"; Age = 60 |})
}

let app = application {
    use_router myRouter
}

run app