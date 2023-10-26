namespace Gaspar{
    public class Vertebrado: Animal{
        public TipoVerdebrado? tipo;
        public bool? tienePatas;
        public bool? esDomestico;
        public bool? esHerbivoro;
        public bool? esCarnivoro;

        public Vertebrado(string nombre,
                          Color color,
                          string tamano,
                          string familia,
                          TipoVerdebrado tipo,
                          bool tienePatas,
                          bool esDomestico,
                          bool esHerbivoro,
                          bool esCarnivoro)
        {
           this.nombre = nombre;
            this.color = color;
            this.tamano = tamano;
            this.familia = familia;
            this.tipo = tipo;
            this.tienePatas = tienePatas;
            this.esDomestico = esDomestico;
            this.esHerbivoro = esHerbivoro;
            this.esCarnivoro = esCarnivoro;
            
        }

        public void imprimir(){
            Console.WriteLine(@$"VERTEBRADO
            Nombre: {nombre}
            Color:  {color}
            Tamano: {tamano}
            Familia:{familia}
            Detalles:
               tipo:         {tipo}
               tiene patas:  {tienePatas}
               es domestico: {esDomestico}
               es herviboro: {esHerbivoro}
               es carnivoro: {esCarnivoro}
            "
            );
        }

    }
}
