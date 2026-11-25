namespace DigitalKitchen
{
    public class Ensalada : Plato
    {
        public string TipoAderezo { get; set; } = string.Empty;

        public Ensalada(string nombrePlato, string tipoAderezo) : base(nombrePlato)
        {
            TipoAderezo = tipoAderezo;
        }

        public override string Preparar()
        {
            return $"[{NombrePlato}] Lavando vegetales frescos y mezclando con aderezo {TipoAderezo}.";
        }
    }
}
