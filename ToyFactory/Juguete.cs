namespace ToyFactory
{
    public class Juguete
    {
        private string numeroSerie = string.Empty;

        public string NumeroSerie
        {
            get => numeroSerie;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El numero de serie no puede estar vacio.");
                }
                numeroSerie = value.Trim();
            }
        }

        public Juguete(string numeroSerie)
        {
            NumeroSerie = numeroSerie;
        }

        public virtual string ProbarJuguete()
        {
            return $"[SN {NumeroSerie}] Ejecutando prueba estandar de calidad del juguete.";
        }
    }
}
