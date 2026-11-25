using QuickDrop;

List<Envio> envios = new List<Envio>
{
    new EnvioExpress("Av. Rivadavia 4500", 4),
    new EnvioFragil("Calle Lavalle 1230", "Pluriball y espuma"),
    new Envio("Av. Corrientes 2100")
};

foreach (Envio envio in envios)
{
    Console.WriteLine(envio.ProcesarEntrega());
}
