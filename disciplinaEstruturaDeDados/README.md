# Estrutura De Dados

- Posta aulas no Google ClassRoom

## índice
- [Programa 03 - Aula 05/03/2020](https://github.com/Massau/EstruturaDeDadosUnivem#estrutura-de-dados "Programa 03 - Aula 05/03/2020")
- [Criando Pilha - Aula 11/03/2020](https://github.com/Massau/EstruturaDeDadosUnivem#estrutura-de-dados "Criando Pilha - Aula 11/03/2020")

=============

- *Tipo abstrato de dados* é um conjunto de dados que pode ser manipulado somente usando operadores


### Push: Colocando elementos na pilha
- É adequado que tenhamos um *Vetor para trabalhar com a lista*, uma *varíavel para identificar o topo* e uma variável *quantidade* para que saibamos o tamanho do vetor
+ Primeira linha, confere se valor do topo é -1. Não há como um vetor ter essa posição, vai dar erro, visto que o vetor inicia-se em zero
    + Adiciona +1 à posição do vetor
+ Não utilizo *for* em pilhas e sim o *while*, pois não sei quantas posições preciso até chegar à uma opção específica
+ Para adicionar elementos ao topo
```
class Pilha {
    string [] elementos;
    int topo = -1;

    /*  Adicionar elementos ao topo
        elementos[0] = "A";
        elementos[topo] = "";
    */
}
```

+ Antes de inserir na pilha é importante verificar se já está cheia para não estourar a pilha
    + Cria verificação de pilha cheia
    ```
    If(Cheia()) {
        return ...;
    }
+ Para funcionar o método Push, é preciso criar o método que verifica se pilha está Cheia(), para que não haja o estouro da pilha

### Pop: Retirando elementos da pilha

=============

#### Aula 05/03/2020
#### Programa 3

- Crie uma classe aluno que tem como propriedades nome e nota
- Crie uma função (RecebeDadosAluno) que ao ser chamada lê do teclado nome e nota e retorna um objeto aluno instanciado com esses valores
- Na função Main, crie um vetor de 3 alunos e use a função RecebeDadosAluno para instanciar e ler os dados desses alunos
- Na função Main, calcule e imprima a média da nota dos alunos, e imprima do aluno com a maior nota

=============

#### Aula 2: Exercícios Pilha

#### TRANSFERE ELEMENTOS DE UMA PILHA PARA OUTRA
Desenvolva um algoritmo para transferir todos os elementos de uma Pilha P1 para uma Pilha P2. 
Considere que as Pilhas P1 e P2 já existem, ou seja, não precisam ser criadas. 
Para elaborar esse algoritmo, use os operadores definidos na Figura 2.5.
Considere que as Pilhas P1 e P2 possuem elementos do tipo inteiro. 
Você terá que elaborar esse algoritmo sem saber como o Tipo Abstrato de Dados Pilha é efetivamente implementado. 
É assim que desenvolvemos habilidade para manipular Pilhas (e outras estruturas) pelos seus Operadores.

#### MAIS ELEMENTOS?
Desenvolva um algoritmo para testar se uma Pilha P1 tem mais elementos do que uma Pilha P2. 
Considere que as Pilhas P1 e P2 já existem e são passadas como parâmetro. 
Considere também que as Pilhas P1 e P2 possuem elementos do tipo Inteiro. 
Você pode criar Pilhas auxiliares, se necessário. 
Você deve preservar os dados de P1 e P2. Ou seja, ao final da execução dessa operação, P1 e P2 precisam conter exatamente os mesmos elementos que continham no início da operação, e na mesma sequência.

#### ALGUM ELEMENTO IGUAL A X?
Desenvolva um algoritmo para verificar se uma Pilha P possui algum elemento igual a um valor X. 
P e X são passados como parâmetros. 
Considere que a Pilha P possui elementos do tipo Inteiro. 
Você pode criar Pilhas auxiliares, se necessário.

#### AS PILHAS SÃO IGUAIS?
Desenvolva um algoritmo para testar se duas Pilhas P1 e P2 são iguais. 
Duas Pilhas são iguais se possuem os mesmos elementos, exatamente na mesma ordem. 
Para propor sua solução, você pode utilizar Pilhas auxiliares, se necessário.
Considere que as Pilhas P1 e P2 já existem e são passadas
como parâmetro. 
Considere que as Pilhas P1 e P2 possuem
elementos do tipo Inteiro.

#### REMOVE ELEMENTO X DA PILHA
Utilizando as operações de manipulação de pilhas vistas em sala, uma pilha auxiliar e uma variável do tipo Tipo Item, escreva um procedimento que remove um item com chave c de uma posição qualquer de uma pilha. 
Note que você não tem acesso à estrutura interna da pilha (topo, item, etc), apenas às operações de manipulação.

#### INVERSO DOS CARACTERES
Escreva uma função para determinar se uma cadeia de caracteres (string) é da forma: x * y onde x e y são cadeias de caracteres compostas por letras ‘A’ e/ou ‘B’, e y é o inverso de x. 
Isto é, se x = “BANANA”, y deve equivaler a “ANANAB”.
Em cada ponto, você só poderá ler o próximo caractere da cadeia (é mandatório o uso de pilha).

#### LETRA D LETRA
Escreva uma função para determinar se uma cadeia de caracteres (string) é da forma: a * b * c * ... * z onde cada cadeia de caracteres, a, b, ..., z, é da forma do exercício descrito acima. 
Portanto, uma cadeia de caracteres estará no formato correto se consistir em qualquer número de cadeias deste tipo ( x C y ), separadas pelo caractere ‘D’. 
Em cada ponto, você só poderá ler o próximo caractere da cadeia (é mandatório o uso de pilha).

#### ESTACIONAMENTO
Considero que um estacionamento da Rua Direita, em Ouro Preto, é composto por uma única alameda que guarda até dez carros. 
Existe apenas uma entrada/saída no estacionamento, e esta extremidade da alameda dá acesso justamente à Rua Direita. 
Se chegar um cliente para retirar um carro que não seja o mais próximo da saída, todos os carros bloqueando seu caminho sairão do estacionamento. 
O carro do cliente será manobrado para fora do estacionamento, e os outros carros voltarão a ocupar a mesma sequência inicial. Escreva um programa que processe um grupo de linhas de entrada. Cada linha de entrada contém um ‘E’, de entrada, ou um ‘S’ de saída, e o número da placa do carro. 
Presume-se que os carros cheguem e partam na mesma ordem que entraram no estacionamento. 
O programa deve imprimir uma mensagem sempre que um carro chegar ou sair. 
Quando um carro chegar, a mensagem deve especificar se existe ou não vaga para o carro no estacionamento. 
Se não houver vaga, o carro partirá sem entrar no estacionamento. Quando um carro sair do estacionamento, a mensagem deverá incluir o número de vezes em que o carro foi manobrado para fora do estacionamento para permitir que os outros carros saíssem.

=============

#### Criando Pilha - Aula 11/03/2020
+ Cria arquivo c#
+ Cria classe
    + Cria 
+ Passo como parâmetro apenas elemento que vou empilhar