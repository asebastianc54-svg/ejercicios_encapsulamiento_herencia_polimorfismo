namespace NominaCorp
{
    public class Programador : Empleado
    {
        public string LenguajePrincipal { get; set; } = string.Empty;

        public Programador(string idEmpleado, string lenguajePrincipal) : base(idEmpleado)
        {
            LenguajePrincipal = lenguajePrincipal;
        }

        public override string Trabajar()
        {
            return $"[ID {IdEmpleado}] Programador escribiendo y depurando codigo en {LenguajePrincipal}.";
        }
    }
}
