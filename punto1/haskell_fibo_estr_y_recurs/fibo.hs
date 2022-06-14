
fibo_recursivo::Integer->Integer
fibo_recursivo  1 = 0
fibo_recursivo  2 = 1
fibo_recursivo  3 = 1
fibo_recursivo  a = fibo_recursivo(a-1)+fibo_recursivo(a-2)+fibo_recursivo(a-3)

fibo_estructurado:: Integer -> Integer
fibo_estructurado a| a==1 = 0 --sin espacio entre la "a" y "|"
                    | a==2 = 1
                    | a==3 = 1
                    | a>3 = fibo_estructurado(a-1)+fibo_estructurado(a-2)+fibo_estructurado(a-3)

for list action=mapM_ action list -- función for. Recibe una lista y una acción

main = do
    putStrLn "====FIBONACCI ESTRUCTURADO Y RECURSIVO===="
    print "introduzca un numero mayor a 0 "
    numero<-getLine --leemos un numero desde consola
    let num = read numero:: Integer--convertimos a entero el numero leido
    print ("el numero ingresado fue: "++ numero)
    
    print ("numero de secuencia fibonacci Estructurado")
    --print (fibo_estructurado num)
    for[1..num](\i->do --creamos una lista con "num" elementos
        print (fibo_estructurado i) --imprimimos el fibonacci de cada eleemto de la lista
        )

    print ("numero de secuencia fibonacci Recursivo")
    --print (fibo_recursivo num)
    for[1..num](\i->do --creamos una lista con "num" elementos
        print (fibo_recursivo i) --imprimimos el fibonacci de cada elemento de la lista
        )
    