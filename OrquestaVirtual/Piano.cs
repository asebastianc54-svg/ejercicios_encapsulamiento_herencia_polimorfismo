namespace OrquestaVirtual
{
    public class Piano : Instrumento
    {
        public int NumeroTeclas { get; set; }

        public Piano(string modelo, int numeroTeclas) : base(modelo)
        {
            NumeroTeclas = numeroTeclas;
        }

        public override string TocarNota()
        {
            return $"[{Modelo}] Piano de {NumeroTeclas} teclas ejecuta una nota Do central.";
        }
    }
}
