# EstruturaDeDadosUnivem
Este repositório tem como objetivo aglomerar os conteúdos disponibilizados em aula pelo UNIVEM - Centro Universitário Eurípides de Marília 2º ano

- [Repositório Estrutura De Dados](https://github.com/Massau/EstruturaDeDadosUnivem/tree/master/disciplinaCSharp "Repositório Estrutura De Dados")

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

### Count ou Length ?
Count é usado apenas para pilhas, em Estrutura de Dados. Quando precisamos contar de uma string seu tamanho, usamos o Lenght

=============

## Vetor

### Declaração do vetor
    int[] array = new int[10];

    int[] array = new int[]; {1, 2, 3}

Sem definir valor
    int[] array;

