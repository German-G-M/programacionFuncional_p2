object fibo{
    def fibo_estr(n:Int):Unit={
       var a = -1
       var b = 1
       var c = 0
       var contador = 0
       while(contador < n){
           val suma = a + b + c
           println(suma)
           a = b
           b = c
           c = suma
           contador = contador + 1
       }
    }

    def fibo_rec(n:Int):Int={
        if (n==1) 0
        else if (n==2) 1
        else if (n==3) 1
        else fibo_rec(n-1)+fibo_rec(n-2)+fibo_rec(n-3)
    }

    def main (args:Array[String]):Unit={
        println("ingrese un numero mayor a 0")
        val a =scala.io.StdIn.readInt()
        println("el valor ingresado fue: "+a)
        println("la serie fibonacci con función estructurada es es: ")
        fibo_estr(a)
        println("la serie fibonacci con función recursiva es es: ")
        for (i <- 1 to a)
        {
            println(fibo_rec(i))
        }
    }
}