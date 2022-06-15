# -*- coding: utf-8 -*-
"""
Created on Tue Jun 14 23:37:35 2022

@author: germa
"""

#fibocci con funciones temporales (lambda)
suma=lambda a,b,c:a+b+c
resta=lambda a:a-1
fibo= lambda n_terminos:(
    0 if(n_terminos==1) else
    1 if(n_terminos==2) else
    1 if(n_terminos==3) else
    suma(fibo(resta(n_terminos)),fibo(resta(resta(n_terminos))),fibo(resta(resta(resta(n_terminos)))))
    )
    
numero=int(input("Por favor ingrese un número entero mayor a cero:"))
print(f'el numero ingresao es: {numero}')
print(f"serie fibonacci de [{numero}] elementos con funciones temporales")
#print (fibo(numero))
for i in range(1,numero+1):
    print(fibo(i))