using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea7
{
    internal class Calculadora
    {
        private int numero1;
        private string numero2;


        public Calculadora(int a, string b) 
        {
            this.numero1 = a;
            this.numero2 = b;

        } 
        //ventana rota estamos tratando de sumar un entenero con un texto 
        static int sumando(int numero1, string numero2)
        {
            //favor revisar este error 
            return numero1 + numero2;//asegurar que la suma sea correcta 
        }
        //mensaje del error 
        //si seguimos asi solo haremos cosechar malas practicas
    }
}
