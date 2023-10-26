namespace Gaspar{
    public class Invertebrado: Animal{
        public TipoInvertebrado? tipo;
        public bool? tienePatas;
        public int? numeroPatas;
        public bool? tieneConcha;

        public Invertebrado(string nombre,
                          Color color,
                          string tamano,
                          string familia,
                          TipoInvertebrado tipo,
                          bool tienePatas,
                          int numeroPatas,
                          bool tieneConcha)
        {
           this.nombre = nombre;
            this.color = color;
            this.tamano = tamano;
            this.familia = familia;
            this.tipo = tipo;
            this.tienePatas = tienePatas;
            this.numeroPatas = numeroPatas;
            this.tieneConcha = tieneConcha;                       
        }

        public void imprimir(){
            Console.WriteLine(@$"INVERTEBRADO
            Nombre: {nombre}
            Color:  {color}
            Tamano: {tamano}
            Familia:{familia}
            Detalles:
               tipo:         {tipo}
               tiene patas:  {tienePatas}
               numero patas: {numeroPatas}
               tiene concha: {tieneConcha}               
            "
            );
        }

    }
}
