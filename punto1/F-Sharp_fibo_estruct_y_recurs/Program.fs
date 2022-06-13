// Learn more about F# at http://fsharp.org

open System
//función estructurada
let fibonacci_estructurado n =
    let mutable n1 = -1
    let mutable n2 = 1
    let mutable n3 = 0
    let mutable contador=0
    for i in 1..(n) do
        let suma =n1+n2+n3
        printf "%d" suma
        //actualizamos los valores
        n1<-n2
        n2<-n3
        n3<-suma
        contador<-contador+1


//función recursiva
let rec fibonacci_recursivo n =
    match n with
    | 1 -> 0
    | 2 -> 1
    | 3 -> 1
    | n -> fibonacci_recursivo (n-1) + fibonacci_recursivo (n-2) + fibonacci_recursivo (n-3)


[<EntryPoint>]
let main argv =
    Console.WriteLine ("=====SECUENCIAS FIBONACCI====")
    Console.WriteLine ("ingrese un número mayor a 0")
    let numero = System.Console.ReadLine()
    let num =int numero //convertimos a entero
    printfn "Fibonacci con fon función  estructurada"
    fibonacci_estructurado num
    Console.WriteLine()
    printfn "Fibonacci con fon función  recursiva"
    Console.WriteLine()
    let mutable result = 0 
    for i in 1 .. num do
        result <- fibonacci_recursivo i
        printf  "%d" result 
    let tecla = Console.ReadKey()
    0 // return an integer exit code
