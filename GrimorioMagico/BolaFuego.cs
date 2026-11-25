namespace GrimorioMagico
{
    public class BolaFuego : Hechizo
    {
        public int TemperaturaC { get; set; }

        public BolaFuego(string encantamiento, int temperaturaC) : base(encantamiento)
        {
            TemperaturaC = temperaturaC;
        }

        public override string Lanzar()
        {
            return $"[{Encantamiento}] Arroja una esfera ignea a {TemperaturaC} grados C.";
        }
    }
}
