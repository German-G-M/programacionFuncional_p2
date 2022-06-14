# -*- coding: utf-8 -*-
"""
Created on Tue Jun 14 18:03:18 2022

@author: germa
"""
#fibonacci de orden superior
def suma (a,b,c):
    return a+b+c
def resta (a):
    return a-1        
def fibo(n_terminos):
    if n_terminos==1:return 0
    if n_terminos==2:return 1
    if n_terminos==3:return 1
    return(suma(fibo(resta(n_terminos)),fibo(resta(resta(n_terminos))),fibo(resta(resta(resta(n_terminos))))))

numero=int(input("Por favor ingrese un número entero mayor a cero:"))
print(f'el numero ingresao es: {numero}')
print(f"serie fibonaccide [{numero}] elementos con funciones de orden superior ")
#print (fibo(numero))
for i in range(1,numero+1):
    print(fibo(i))

