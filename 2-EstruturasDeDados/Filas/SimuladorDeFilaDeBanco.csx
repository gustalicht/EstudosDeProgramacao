Console.WriteLine("Simulador de Fila de Banco");

var filaBanco = new Queue<string>();

filaBanco.Enqueue("Cliente 1");
filaBanco.Enqueue("Cliente 2");
filaBanco.Enqueue("Cliente 3");
Console.WriteLine("Clientes na fila:");
foreach (var cliente in filaBanco)
{
    Console.WriteLine(cliente);
}

var atendido = filaBanco.Dequeue();
Console.WriteLine($"\nAtendendo: {atendido}");
Console.WriteLine("Clientes restantes na fila:");
foreach (var cliente in filaBanco)
{
    Console.WriteLine(cliente);
}
