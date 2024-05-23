namespace SegundoParcial
{
    public class Revistas : Libros
    {
        public string Volumen {  get; set; }

        public string NumEjem {  get; set; }

        public Revistas()
        {
            Volumen = string.Empty; 
            NumEjem = string.Empty; 
        }

    }
}
