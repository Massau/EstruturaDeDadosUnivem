# EstruturaDeDadosUnivem
Este repositório tem como objetivo aglomerar os conteúdos disponibilizados em aula pelo UNIVEM - Centro Universitário Eurípides de Marília 2º ano


### Código para criar arquivo C# no terminal
    dotnet new console -o nomeDoDiretorio

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
