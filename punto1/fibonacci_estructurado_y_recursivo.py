# -*- coding: utf-8 -*-
"""
Created on Sun Jun 12 21:53:45 2022

@author: germa
"""
#fibonacci de base 3
#entrada: 7
#salida: 0,1,1,2,4,7,13

#fibonacci estructurado
def fibonacci_estructurado(n_terminos):
    n1,n2,n3=-1,1,0
    contador=0
    #generamos la secuencia
    while contador < n_terminos:
        suma=n1+n2+n3
        print(suma)
        #actualizamos los valores
        n1=n2
        n2=n3
        n3=suma
        contador=contador+1

#fibonacci Recursivo
def fibonacci_recursivo(n_terminos):
    if n_terminos==1:return 0
    if n_terminos==2:return 1
    if n_terminos==3:return 1
    return(fibonacci_recursivo(n_terminos-1)+fibonacci_recursivo(n_terminos-2)+fibonacci_recursivo(n_terminos-3))

numero=int(input("Por favor ingrese un número entero mayor a cero:"))
print(f'el numero ingresao es: {numero}')
if(numero<=0):
   print("el numero ingresado fue 0 o menor a cero. Intente nuevamente")
else:
    print(f'fibonacci de {numero} terminos con función estructurada:')
    fibonacci_estructurado(numero)
    print(f'fibonacci de {numero} terminos con función recursiva:')
    for i in range (1,numero+1):
        print (fibonacci_recursivo(i))

    