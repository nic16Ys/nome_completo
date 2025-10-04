Console.Clear();
Console.WriteLine("digite seu primeiro nome:");
string nome = Console.ReadLine();
Console.WriteLine("digite seu sobrenome:");
string sobrenome = Console.ReadLine();
Console.WriteLine($"nome completo:{nome} {sobrenome}");
Console.WriteLine($"nome catalogo: {sobrenome.ToUpper()} , {nome} ");
