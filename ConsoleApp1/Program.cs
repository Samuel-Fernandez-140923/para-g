using ConsoleApp1;

internal class Program
{
    private static void Main(string[] args)
    {
        int res;
        int res2;
        do
        {
            Console.WriteLine("Ingresa [1] para comezar el prgrama");
            res=int.Parse(Console.ReadLine());
         } while (res!=1);

        int posicion = 0;

        Datos datos = new Datos();
        /////////////////////////////////////
        string[] arregloNombre=new string[res];
        int[] arregloEdad=new int[res]; 
        double[] arregloTamaño = new double[res];
       
        do
        {
            Console.WriteLine("[1] Para ingresar datos");
            Console.WriteLine("[2] Para finalizar");
             res2=int.Parse(Console.ReadLine());
            switch (res2) 
            { 
             case 1:
                    Console.WriteLine("Ingrsa el nombre de la persona:");
                    datos.Nombre = Console.ReadLine();
                    arregloNombre[posicion] = datos.Nombre;
                    Console.WriteLine("Ingrsa edad de la persona:");
                    datos.Edad = int.Parse(Console.ReadLine());
                    arregloEdad[posicion] = datos.Edad;
                    Console.WriteLine("Ingrsa la estatura de la persona:");
                    datos.Estatura = double.Parse(Console.ReadLine());
                    arregloTamaño[posicion] = datos.Estatura;


                    break;
            
            
            }
        }
        while (res2!=2);
    }
}