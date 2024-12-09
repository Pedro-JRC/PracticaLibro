namespace PracticaLibro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // VARIABLES
                string titulo;
                string autor;
                string paginasDigita;
                int paginas;

                // SOLICITA EL TITULO
                Console.Write("Favor ingrese el titulo del libro: ");
                titulo = Console.ReadLine();

                // SOLICITA EL AUTOR
                Console.Write("Favor ingrese el autor: ");
                autor = Console.ReadLine();

                // SOLICITA LA CANTIDAD DE PAGINAS
                Console.Write("Favor indique la cantidad de paginas: ");
                paginasDigita = Console.ReadLine();


                // VALIDACIONES
                if (int.TryParse(paginasDigita, out paginas))
                {
                    // OBJETO LIBRO
                    Libro libro = new Libro(titulo, autor, paginas);

                    // MUETSRA LA INFORMACION DEL LIBRO
                    Console.WriteLine("\nInformacion del libro:");
                    libro.mostrarInformacion();

                    // INFORMACION DEL LARGO DEL LIBRO
                    Console.WriteLine("\nLargo?:");

                    // VERIFICA SI EL LIBRO ES LARGO
                    if (libro.esLargo())
                    {
                        Console.WriteLine("El libro es largo.");
                    }
                    else
                    {
                        Console.WriteLine("El libro no es largo.");
                    }



                }
                else
                {
                    // MENSAE DE ERROR SI SE DIGITA UN DATO INVALIDO
                    Console.WriteLine("ERROR: Favor ingrese un numero entero.");
                }



            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}.");
            }
        }
    }
}
