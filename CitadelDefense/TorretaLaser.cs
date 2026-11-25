namespace CitadelDefense
{
    public class TorretaLaser : Torreta
    {
        public int CargaBateria { get; set; }

        public TorretaLaser(string ubicacion, int cargaBateria) : base(ubicacion)
        {
            CargaBateria = cargaBateria;
        }

        public override string Disparar()
        {
            return $"[{Ubicacion}] Dispara pulso laser (bateria al {CargaBateria}%).";
        }
    }
}
