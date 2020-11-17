let isOpposite = function
    | "NORTH", "SOUTH"
    | "SOUTH", "NORTH"
    | "EAST", "WEST"
    | "WEST", "EAST" -> true
    | _ -> false

let folder state dir =
    match state with
    | x :: tail when isOpposite (x, dir) -> tail
    | _ -> dir :: state

let reduceDir ls = ls |> Seq.fold folder [] |> List.rev
