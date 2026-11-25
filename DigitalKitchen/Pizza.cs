namespace DigitalKitchen
{
    public class Pizza : Plato
    {
        public string TipoMasa { get; set; } = string.Empty;

        public Pizza(string nombrePlato, string tipoMasa) : base(nombrePlato)
        {
            TipoMasa = tipoMasa;
        }

        public override string Preparar()
        {
            return $"[{NombrePlato}] Estirando masa {TipoMasa} y horneando la pizza.";
        }
    }
}
