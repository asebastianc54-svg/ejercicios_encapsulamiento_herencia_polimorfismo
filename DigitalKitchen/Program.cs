using DigitalKitchen;

List<Plato> platos = new List<Plato>
{
    new Pizza("Muzzarella", "A la piedra"),
    new Ensalada("Caesar", "Cesar clasico"),
    new Plato("Sopa del dia")
};

foreach (Plato plato in platos)
{
    Console.WriteLine(plato.Preparar());
}
