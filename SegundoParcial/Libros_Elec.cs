namespace SegundoParcial
{
    public class Libros_Elec : Libros
    {
        public string Formato {  get; set; }

        public string Tamanio { get; set; }

        public Libros_Elec()
        {
            Formato = string.Empty;
            Tamanio = string.Empty;
        }
    }
}
