namespace OrquestaVirtual
{
    public class Instrumento
    {
        private string modelo = string.Empty;

        public string Modelo
        {
            get => modelo;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El modelo no puede estar vacio.");
                }
                modelo = value.Trim();
            }
        }

        public Instrumento(string modelo)
        {
            Modelo = modelo;
        }

        public virtual string TocarNota()
        {
            return $"[{Modelo}] Emite una nota musical.";
        }
    }
}
