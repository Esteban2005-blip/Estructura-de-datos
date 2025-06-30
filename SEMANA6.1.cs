class Program
{
    static void Main()
    {
        ListaEnlazada lista = new ListaEnlazada();
        lista.Agregar(10);
        lista.Agregar(20);
        lista.Agregar(30);

        Console.WriteLine("Número de elementos: " + lista.ContarElementos());
    }
}





