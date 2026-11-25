namespace NominaCorp
{
    public class Diseñador : Empleado
    {
        public string HerramientaFavorita { get; set; } = string.Empty;

        public Diseñador(string idEmpleado, string herramientaFavorita) : base(idEmpleado)
        {
            HerramientaFavorita = herramientaFavorita;
        }

        public override string Trabajar()
        {
            return $"[ID {IdEmpleado}] Diseñador creando interfaces y piezas en {HerramientaFavorita}.";
        }
    }
}
