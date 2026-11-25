namespace OrquestaVirtual
{
    public class Guitarra : Instrumento
    {
        public int NumeroCuerdas { get; set; }

        public Guitarra(string modelo, int numeroCuerdas) : base(modelo)
        {
            NumeroCuerdas = numeroCuerdas;
        }

        public override string TocarNota()
        {
            return $"[{Modelo}] Guitarra de {NumeroCuerdas} cuerdas hace sonar un acorde de La menor.";
        }
    }
}
