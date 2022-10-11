namespace Inmobiliaria.Clases
{
    public class Inmueble
    {
        public Inmueble()
        {

        }
        protected string TipoInmueble { get; set; }
        public string Direccion { get; set; }
        protected float Area { get; set; }
        public int Habitaciones { get; set; }
        public decimal Precio { get; set; }
        public string Saludo { get; set; }


        public bool Vender()
        {
            return true;
        }

        public bool Arrendar()
        {
            return true;
        }

        public static void Registar()
        {
            
        }

    }
}
