using CP1_DOTNET.Models;

Console.WriteLine("Testando a classe Medicamento:");
for (int i = 1; i <= 2; i++)
{
    Medicamento medicamento = new Medicamento($"Medicamento {i}", $"Descrição do Medicamento {i}", 10.0m * i, 50 * i);
    Console.WriteLine($"Nome: {medicamento.Nome}, Preço: {medicamento.Preco}, Quantidade em Estoque: {medicamento.QuantidadeEmEstoque}");
}

// Testando a classe Estoque
Console.WriteLine("\nTestando a classe Estoque:");
List<Medicamento> listaMedicamentos = new List<Medicamento>();
for (int i = 1; i <= 2; i++)
{
    Medicamento medicamento = new Medicamento($"Medicamento {i}", $"Descrição do Medicamento {i}", 10.0m * i, 50 * i);
    listaMedicamentos.Add(medicamento);
}
Estoque estoque = new Estoque(listaMedicamentos);
foreach (var item in estoque.Medicamentos)
{
    Console.WriteLine($"Nome: {item.Nome}, Preço: {item.Preco}, Quantidade em Estoque: {item.QuantidadeEmEstoque}");
}

// Testando a classe Funcionario
Console.WriteLine("\nTestando a classe Funcionario:");
for (int i = 1; i <= 2; i++)
{
    Funcionario funcionario = new Funcionario($"Funcionário {i}", $"Cargo {i}");
    Console.WriteLine($"Nome: {funcionario.Nome}, Cargo: {funcionario.Cargo}");
    if (i % 2 == 0)
    {
        funcionario.RegistrarEntrada();
    }
}

// Testando a classe Cliente
Console.WriteLine("\nTestando a classe Cliente:");
for (int i = 1; i <= 2; i++)
{
    Cliente cliente = new Cliente($"Cliente {i}", $"Endereço {i}");
    Console.WriteLine($"Nome: {cliente.Nome}, Endereço: {cliente.Endereco}");
}

// Testando a classe Venda
Console.WriteLine("\nTestando a classe Venda:");
Cliente clienteVenda = new Cliente("Cliente de Teste", "Endereço de Teste");
List<Medicamento> itensVenda = new List<Medicamento>();
for (int i = 1; i <= 2; i++)
{
    Medicamento medicamento = new Medicamento($"Medicamento {i}", $"Descrição do Medicamento {i}", 10.0m * i, 50 * i);
    itensVenda.Add(medicamento);
}
Venda venda = new Venda(clienteVenda, itensVenda, 30.0m);
Console.WriteLine($"Cliente: {venda.Cliente.Nome}, Total: {venda.Total}");