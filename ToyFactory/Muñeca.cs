namespace ToyFactory
{
    public class Muñeca : Juguete
    {
        public string MaterialCabello { get; set; } = string.Empty;

        public Muñeca(string numeroSerie, string materialCabello) : base(numeroSerie)
        {
            MaterialCabello = materialCabello;
        }

        public override string ProbarJuguete()
        {
            return $"[SN {NumeroSerie}] Verificando articulaciones y cepillado de cabello de {MaterialCabello}.";
        }
    }
}
