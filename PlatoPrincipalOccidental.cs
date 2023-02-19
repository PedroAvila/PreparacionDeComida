namespace PreparacionDeComida
{
    public class PlatoPrincipalOccidental : IPlatoPrincipal
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public PlatoPrincipalOccidental(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

        public string ObtenerNombre()
        {
            return Nombre;
        }

        public override string ToString()=> $"{Nombre} Precio: S/ {10.00M}";
    }
}