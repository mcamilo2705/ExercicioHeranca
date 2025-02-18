//Crie uma **classe base** chamada `Funcionario` com atributos `Nome` e `Salario`, e um método para exibir essas informações.
//Depois, crie uma **subclasse** chamada `Gerente` que tenha um atributo adicional `Bonus` e um método para exibir o salário total
//do gerente.

//### 🔹 **Requisitos**:

//- Criar a classe `Funcionario` com atributos `Nome` e `Salario`.
//- Criar um método `ExibirDados()`.
//- Criar a subclasse `Gerente` que herda `Funcionario` e adiciona `Bonus`.
//- Criar um método que exiba o salário total (`Salario + Bonus`).


using System.Runtime.InteropServices;

Funcionario f = new Funcionario();
f.Nome = "Marcos";
f.Salario = 1000;
f.ExibirDados();

Gerente gerente = new Gerente();
gerente.Nome = "Marcos";
gerente.Salario = 1000;
gerente.ExibirSalarioTotal();
gerente.Bonus = 500;

//double calc = gerente.Salario + gerente.Bonus;

//Console.WriteLine("Total de salario e bonus: " + calc);



public class Funcionario
{
    public string Nome;
    public double Salario;

    public void ExibirDados()
    {
        Console.WriteLine($"Nome: {Nome}, salario: {Salario}");
    }
}

public class Gerente : Funcionario
{
    public double Bonus;

    public void ExibirSalarioTotal()
    {
        Console.WriteLine(Salario + Bonus); 
    }
}