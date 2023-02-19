namespace PreparacionDeComida
{
    public interface IFabricaDeComida
    {
        IPlatoPrincipal PrepararPlatoPrincipal(string nombre, decimal precio);
        IPostre PrepararPostre(string nombre, decimal precio);
    }
}
