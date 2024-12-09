
namespace PracticaLibro
{
    public class Libro
    {
        // PROPIEDADES
        public string Titulo {  get; set; }
        public string Autor {  get; set; }
        public int Paginas {  get; set; }

        // CONSTRUCTOR QUE INICIA LAS PROPIEDADES
        public Libro (string titulo, string autor, int paginas)
        {
            Titulo = titulo;
            Autor = autor;
            Paginas = paginas;
        }

        // METODO PARA MOSTRAR LOS DATOS DEL LIBRO
        public void mostrarInformacion()
        {
            Console.WriteLine($"Titulo: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Paginas: {Paginas}");
        }

        // METODO PARA VERIFICAR LARGO DEL LIBRO
        public bool esLargo()
        {
            return Paginas > 500;
        }
    }
}
