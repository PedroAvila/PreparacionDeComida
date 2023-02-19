namespace PreparacionDeComida
{
    public class FabricaComidaOccidental : IFabricaDeComida
    {
        public IPlatoPrincipal PrepararPlatoPrincipal(string nombre, decimal precio)
        {
            return new PlatoPrincipalOccidental(nombre, precio);
        }

        public IPostre PrepararPostre(string nombre, decimal precio)
        {
            return new PostreOccidental();
        }
    }
}
