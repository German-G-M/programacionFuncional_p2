object fibo{
    def suma (a:Int,b:Int,c:Int):Int={
        a + b + c
    }
    def resta (a:Int):Int={
        a - 1
    }
    def fibo_rec (n:Int):Int={
        if (n==1) 0
        else if (n==2) 1
        else if (n==3) 1
        else suma(fibo_rec(resta(n)),fibo_rec(resta(resta(n))),fibo_rec(resta(resta(resta(n)))))
    }

    def main (args:Array[String]):Unit={
        println("===FUNCIONES DE ORDEN SUPERIOR====")
        println("ingrese un numero mayor a 0")
        val a =scala.io.StdIn.readInt()
        println("el valor ingresado fue: "+a)
        println("la serie fibonacci con función de orden superior es: ")
        for (i <- 1 to a)
        {
            println(fibo_rec(i))
        }
    }
}