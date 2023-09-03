
//proyecto donde vamos a utilizar refactorizacion y redundancia de comentarios entre otras
//este proyecto sera desarrollado por Milton Arita en la clase de ingenieria de software 

//-----------------------------------------------------------------------------------------



public class ejercicio3sucio
{
     public static void sucio()
    {
        int op = 1;
        //este codigo esta malo no se esta utilizando sangria 
        //refactorizamos un codigo donde teniamos bueno a algo que se ve feo y no estamos utilizando buenas practicas
        Console.WriteLine("Calculadora");
        //mal nombramiento
        if (op==1)
        {
            Console.WriteLine("Sumando numeros");
        }
                else if (op==2) 
                {
                    Console.WriteLine("Restando Numeros");
                }
                        else if(op==3) 
                        {
                            Console.WriteLine("Multiplicando Numeros");             //estamos haciendo sangria y codigo flecha
                        }
        else
        { Console.WriteLine("Agregue opcion valida"); }
        
    }

}



