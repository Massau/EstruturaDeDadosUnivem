public class Aluno {
    string nome;
    double nota;

    public void RecebeDadosAluno() {
        Aluno aluno = new Aluno();
        Console.WriteLine($"Aluno: {aluno.nome}");
    }
}