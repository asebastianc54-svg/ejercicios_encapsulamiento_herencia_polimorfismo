namespace GrimorioMagico
{
    public class EscudoHielo : Hechizo
    {
        public int GrosorCapas { get; set; }

        public EscudoHielo(string encantamiento, int grosorCapas) : base(encantamiento)
        {
            GrosorCapas = grosorCapas;
        }

        public override string Lanzar()
        {
            return $"[{Encantamiento}] Invoca una barrera cristalina de {GrosorCapas} capas de hielo.";
        }
    }
}
