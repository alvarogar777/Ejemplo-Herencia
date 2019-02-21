namespace Herencia{
    public class Cuadrado : FiguraGeometrica
    {

         public Cuadrado(){

        }

        public Cuadrado(int poscisionX, int poscisionY,string color,string forma) : base(poscisionX,poscisionY,color,forma)
        {

        }
        public override int CalcularArea(){
            return PoscisionX*PoscisionX;
        }

        public override string NombreFigura(){
            return "Cuadrado";
        }

    }
}