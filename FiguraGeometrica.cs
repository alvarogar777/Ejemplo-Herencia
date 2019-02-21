namespace Herencia{

    public abstract class  FiguraGeometrica : ICalculadora
    {
        private int poscisionX;
        private int poscisionY;
        private string color;
        private string forma;

        public FiguraGeometrica(){

        }

        public FiguraGeometrica(int poscisionX, int poscisionY)
        {
            PoscisionX=poscisionX;
            PoscisionY=poscisionY;
        }

        public FiguraGeometrica(int poscisionX, int poscisionY,string color,string forma)
        {
            PoscisionX=poscisionX;
            PoscisionY=poscisionY;
            Color=color;
            Forma=forma;
        }


        public int PoscisionX
        {
            get{return poscisionX;}
            set{poscisionX=value;}
        }

        public int PoscisionY
        {
            get{return poscisionY;}
            set{poscisionY=value;}
        }

        public string Color
        {
            get{return color;}
            set{color=value;}
        }

        public string Forma
        {
            get{return forma;}
            set{forma=value;}
        }

        public void mostrarResultado(FiguraGeometrica figura){}
   
        public abstract int CalcularArea();
        public abstract string NombreFigura();
    }
}