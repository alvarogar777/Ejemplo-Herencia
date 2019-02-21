using System;
using System.Collections.Generic;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            FiguraGeometrica cuadrado = new Cuadrado();
            FiguraGeometrica circulo = new Circulo();
            FiguraGeometrica triangulo = new Triangulo();

            List<FiguraGeometrica> lista = new List<FiguraGeometrica>();
            lista.Add(cuadrado);
            lista.Add(circulo);
            lista.Add(triangulo);

            foreach(FiguraGeometrica elemento in lista){                
                //bool dt = (bool)Convert.ChangeType(elemento, typeof(Triangulo));                
                
                if(elemento==circulo)
                {   
                    ((Circulo)elemento).Radio=9;
                    Console.WriteLine("Ingrese radio  del {0}",elemento.NombreFigura());
                    ((Circulo)elemento).Radio=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("El area de: {0} es de: {1}",elemento.NombreFigura(),elemento.CalcularArea());
                }
                else
                {       
                    Console.WriteLine("Ingrese poscicion en X del {0}",elemento.NombreFigura());
                    elemento.PoscisionX = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese poscicion en Y del {0}",elemento.NombreFigura());
                    elemento.PoscisionY = Convert.ToInt32(Console.ReadLine());             
                    Console.WriteLine("El area de: {0} es de: {1}",elemento.NombreFigura(),elemento.CalcularArea());
                }
            } 

           
        }
    }
}
