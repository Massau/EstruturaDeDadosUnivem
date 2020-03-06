# EstruturaDeDadosUnivem
Este repositório tem como objetivo aglomerar os conteúdos disponibilizados em aula pelo UNIVEM - Centro Universitário Eurípides de Marília 2º ano

- Estrutura De Dados [Estrutura De Dados](https://github.com/Massau/EstruturaDeDadosUnivem/EstruturaDeDados "Estrutura De Dados")

### Código para criar arquivo C# no terminal
    dotnet new console -o nomeDoDiretorio

### Atribuir valor à atributos da classe
No exemplo, atribuimos ao atributo "nome" o valor digitado pelo usuário no console
    Aluno novoAluno = new Aluno();
    novoAluno.nome = Console.ReadLine();

### Palavras chave na iteração
- break
- continue

### Quebrar linha da string usando @
    string textoExemplo = @"Lorem ipsum dolor sit amet,
    consectetur adipiscing elit. Fusce tincidunt 
    aliquet ante eget luctus";

### Concatenar
    string textoExemplo = string.Concat(unidade, "\\", diretorio, "\\", pasta);

### Máscara de caracteres
- Defino como # quando haver uma informação ali é opcional
- Defino como 0 quando haver uma informação ali é obrigatória
- Onde insiro , vira .
- Onde insiro . vira ,
    Console.WriteLine(string.Format("Salário {0,0:(0##) ##}", salario));

=============

## Vetor

### Declaração do vetor
    int[] array = new int[10];

    int[] array = new int[]; {1, 2, 3}

Sem definir valor
    int[] array;


=============

## Estrutura De Dados

Aula 05/03/2020

Exercício 3

- Crie uma classe aluno que tem como propriedades nome e nota
- Crie uma função (RecebeDadosAluno) que ao ser chamada lê do teclado nome e nota e retorna um objeto aluno instanciado com esses valores
- Na função Main, crie um vetor de 3 alunos e use a função RecebeDadosAluno para instanciar e ler os dados desses alunos
- Na função Main, calcule e imprima a média da nota dos alunos, e imprima do aluno com a maior nota