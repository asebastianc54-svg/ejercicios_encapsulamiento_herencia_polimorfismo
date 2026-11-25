namespace CitadelDefense
{
    public class Lanzamisiles : Torreta
    {
        public int MunicionRestante { get; set; }

        public Lanzamisiles(string ubicacion, int municionRestante) : base(ubicacion)
        {
            MunicionRestante = municionRestante;
        }

        public override string Disparar()
        {
            return $"[{Ubicacion}] Lanza un misil defensivo (municion restante: {MunicionRestante}).";
        }
    }
}
