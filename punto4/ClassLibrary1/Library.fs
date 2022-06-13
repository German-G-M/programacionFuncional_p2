namespace ClassLibrary1

module Say =
    let hello name =
        printfn "Hello %s" name

module Fibonacci=
    let fibonacci_estructurado n =
        let mutable n1 = -1
        let mutable n2 = 1
        let mutable n3 = 0
        let mutable contador=0
        //almacenamos en una alista los resultados
        let mutable serie =[]
        for i in 1..(n) do
            let suma =n1+n2+n3
            let list_suma=[suma]
            //printf "%d" suma //en lugar de imprimir, guardamos en la lista
            serie<-list_suma //vamos a ver si funciona
            //actualizamos los valores
            n1<-n2
            n2<-n3
            n3<-suma
            contador<-contador+1
        serie //retornamos la lista serie (a ver si funciona)

    let rec fibonacci_recursivo n =
        match n with
        | 1 -> 0
        | 2 -> 1
        | 3 -> 1
        | n -> fibonacci_recursivo (n-1) + fibonacci_recursivo (n-2) + fibonacci_recursivo (n-3)
