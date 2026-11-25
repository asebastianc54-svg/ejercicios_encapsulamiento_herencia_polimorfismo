using NominaCorp;

List<Empleado> empleados = new List<Empleado>
{
    new Programador("EMP-101", "C#"),
    new Diseñador("EMP-102", "Figma"),
    new Empleado("EMP-103")
};

foreach (Empleado empleado in empleados)
{
    Console.WriteLine(empleado.Trabajar());
}
