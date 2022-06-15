--fibonacci con funciones Temporales lambda
suma=(\(x, y, z) -> x+y+z)
resta=(\x -> x-1)

fibo_r::Integer->Integer
fibo_r  1 = 0
fibo_r  2 = 1
fibo_r  3 = 1
fibo_r  a = suma (fibo_r(resta a), fibo_r(resta (resta a)), fibo_r(resta (resta (resta a))))

fibo_e:: Integer -> Integer
fibo_e a| a==1 = 0 --sin espacio entre la "a" y "|"
        | a==2 = 1
        | a==3 = 1
        | a>3 = suma (fibo_e(resta a), fibo_e(resta (resta a)), fibo_e(resta (resta (resta a))))

for list action=mapM_ action list -- función for. Recibe una lista y una acción

main = do
    putStrLn "====FIBONACCI ESTRUCTURADO Y RECURSIVO CON FUNCIONES TEMPORALES LAMBDA===="
    print "introduzca un numero mayor a 0 "
    numero<-getLine --leemos un numero desde consola
    let num = read numero:: Integer--convertimos a entero el numero leido
    print ("el numero ingresado fue: "++ numero)
    
    print ("numero de secuencia fibonacci Estructurado")
    --print (fibo_estructurado num)
    for[1..num](\i->do --creamos una lista con "num" elementos
        print (fibo_e i) --imprimimos el fibonacci de cada eleemto de la lista
        )

    print ("numero de secuencia fibonacci Recursivo")
    --print (fibo_recursivo num)
    for[1..num](\i->do --creamos una lista con "num" elementos
        print (fibo_r i) --imprimimos el fibonacci de cada elemento de la lista
        )