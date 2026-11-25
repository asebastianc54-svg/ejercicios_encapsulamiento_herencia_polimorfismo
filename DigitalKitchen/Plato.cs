namespace DigitalKitchen
{
    public class Plato
    {
        private string nombrePlato = string.Empty;

        public string NombrePlato
        {
            get => nombrePlato;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El nombre del plato no puede estar vacio.");
                }
                nombrePlato = value.Trim();
            }
        }

        public Plato(string nombrePlato)
        {
            NombrePlato = nombrePlato;
        }

        public virtual string Preparar()
        {
            return $"[{NombrePlato}] Preparando el plato en cocina.";
        }
    }
}
