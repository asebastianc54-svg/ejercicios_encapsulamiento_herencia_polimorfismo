using AutoDrive;

List<Vehiculo> vehiculos = new List<Vehiculo>
{
    new AutoElectrico("Tesla", 480),
    new Camioneta("Toyota", true),
    new Vehiculo("Ford")
};

foreach (Vehiculo vehiculo in vehiculos)
{
    Console.WriteLine(vehiculo.Arrancar());
}
