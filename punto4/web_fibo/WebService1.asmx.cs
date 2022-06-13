using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;

namespace web_fibo
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class Fibo
    {
        public string prueba_secuencia(int a)//no devuelve nada
        {
            //aqui probamos el fibonacci estructurado
            int n1 = -1;
            int n2 = 1;
            int n3 = 0;
            int contador = 0;
            string serie = "";
            int suma = 0;
            for (int i = 1; i <= a; i++)
            {
                suma = n1 + n2 + n3;
                serie = serie + suma + " ";
                n1 = n2;
                n2 = n3;
                n3 = suma;
                contador++;
            }
                
            return serie;
        }
        public int prueba_secuencia2(int a)//no devuelve nada
        {
            //aqui probamos el fibonaci recursivo
            if (a == 1)
            {
                return 0;
            }
            if (a==2 || a == 3)
            {
                return 1;
            }
            return (prueba_secuencia2(a - 1) + prueba_secuencia2(a - 2) + prueba_secuencia2(a - 3));

        }
    }

    public class WebService1 : System.Web.Services.WebService
    {
        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        [WebMethod]
        public string fibo_estructurado(int a) //no devuelve nada
        {
            //ClassLibrary.Fibonacci fbr = new ClassLibrary.Fibonacci();
            Fibo f = new Fibo();
            return f.prueba_secuencia(a);
            //return "Esto es el fibo estructurado";
            //return fbr.fibonacci_estructurado(a);
        }
        [WebMethod]
        public string fibo_recursivo(int a)
        {
            //ClassLibrary.Fibonacci fbr = new ClassLibrary.Fibonacci();
            Fibo f = new Fibo();
            string serie = "";
            int s = 0;
            for (int i = 1; i <= a; i++)
                s = f.prueba_secuencia2(i);
                //s=fbr.fibonacci_estructurado(a);
                serie = serie + s + "";
            return serie;
            
        }
    }
}
