open System

// earth radius in meters
let earthRadius = 6_371_000.0

let calculateDeviation (sectionLength, radius) =
    let quarterCircleLength = Math.PI * radius / 2.0
    let angle = (sectionLength / quarterCircleLength) * (Math.PI / 2.0)
    let leg = radius * Math.Cos(angle)
    radius - leg

// get section length from input argument and parse it as float
let sectionLengthInMeters = Environment.GetCommandLineArgs().[1] |> float

let deviation = calculateDeviation(sectionLengthInMeters, earthRadius)

printfn $"Deviation: {deviation,10:F2} m"
