public class Aluno
{
    public int Matricula { get; set; }

    public string Nome { get; set; }

    public string Cpf { get; set; }

    public DateOnly DataNascimento { get; set; }

    public Aluno()
    {

    }

    public Aluno(int Matricula, string Nome, string Cpf, DateOnly DataNascimento)
    {
        this.Matricula = Matricula;
        this.Nome = Nome;
        this.Cpf = Cpf;
        this.DataNascimento = DataNascimento;
    }
}