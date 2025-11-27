class Colaborador : Pessoa
{
    private string? _cargo;
    private double _salario;

    public Colaborador(string nome, int idade , string cargo, double salario) : base(nome , idade)
    {
        _cargo = cargo;
        _salario = salario;

        ApresentarPessoa();
        ApresentarColaborador();
    }
    private void ApresentarColaborador()
    {
        Console.WriteLine($"cargo: {_cargo}");
        Console.WriteLine($"salario: {_salario}");
    }
}