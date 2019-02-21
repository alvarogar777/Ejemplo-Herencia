using System;
namespace Herencia{
    public class Triangulo : FiguraGeometrica
    {

        public Triangulo(){
            
            Console.WriteLine("Se ha creado un nuevo triangulo");
        }

        public Triangulo(int poscisionX, int poscisionY,string color,string forma) : base(poscisionX,poscisionY,color,forma)
        {
            
        }
        public override int CalcularArea(){
            return (PoscisionX*PoscisionY)/2;
        }

        public override string NombreFigura()
        {
            return "Triangulo";
        }
    }
}