namespace GrimorioMagico
{
    public class Hechizo
    {
        private string encantamiento = string.Empty;

        public string Encantamiento
        {
            get => encantamiento;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El encantamiento no puede estar vacio.");
                }
                encantamiento = value.Trim();
            }
        }

        public Hechizo(string encantamiento)
        {
            Encantamiento = encantamiento;
        }

        public virtual string Lanzar()
        {
            return $"[{Encantamiento}] Conjuro arcano liberado.";
        }
    }
}
