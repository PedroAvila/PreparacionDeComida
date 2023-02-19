namespace PreparacionDeComida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Restaurante Ají Picante!");
            Console.WriteLine("============================================");
            Console.WriteLine("");
            RegistrarPlatoPrincipalOccidental(new FabricaComidaOccidental());
            Console.ReadLine();
        }

        static void RegistrarPlatoPrincipalOccidental(IFabricaDeComida fabricaDeComida)
        {
            IPlatoPrincipal platoPrincipal = fabricaDeComida.PrepararPlatoPrincipal("Arroz con Pollo", 10.00M);
            Console.WriteLine($"Nombre de plato: {platoPrincipal}");
        }
    }
}