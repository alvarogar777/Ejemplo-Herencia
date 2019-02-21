using System;
namespace Herencia
{
    public class Circulo : FiguraGeometrica
    {
        private int radio;

        public Circulo(){}

        public Circulo(int poscisionX, int poscisionY,string color,string forma, int radio) : base(poscisionX,poscisionY,color,forma)
        {
            Radio=radio;
        }

        public int Radio
        {
            get{return radio;}
            set{radio=value;}
        }
        public override int CalcularArea(){
            return Convert.ToInt32( (Math.PI*Math.PI) * Radio);        
        }

        public override string NombreFigura()
        {
            return "Circulo";
        }
    }
}