# C#_IntermediateLevel
Estou evoluindo no C#. Agora, no nível intermediário, vou fazer um repositório de caderno pessoal. Pois provavelmente irei precisar consultar esses conhecimentos no futuro

# Resumo de Conceitos de C#: Classes, Propriedades e Encapsulamento

Este documento utiliza a classe `Pessoa` como exemplo para explicar conceitos fundamentais da Programação Orientada a Objetos em C#.

---

## 1. Modificadores de Acesso (`public` vs `private`)

Os modificadores de acesso definem **quem pode ver e usar** os membros de uma classe.

### `public` (Acesso Público)

- **O que é:** Um membro `public` pode ser acessado de qualquer lugar do seu código, tanto de dentro quanto de fora da classe.
- **Exemplo:** A classe `Pessoa` e suas propriedades `Nome` e `Idade` são `public`. Isso permite que criemos um objeto `Pessoa` e acessemos seu nome e idade de outro arquivo, como o `Program.cs`.

### `private` (Acesso Privado)

- **O que é:** Um membro `private` só pode ser acessado **de dentro da própria classe** onde foi declarado.
- **Exemplo:** Os campos `_nome` e `_idade` são `private`. O código fora da classe `Pessoa` não pode vê-los ou modificá-los diretamente.
- **Por que usar?** O principal motivo é o **Encapsulamento**: proteger os dados internos e forçar que qualquer modificação passe por uma validação, como veremos nos `setters`.

---

## 2. Campos vs. Propriedades

A principal diferença está na capacidade de executar lógica ao acessar os dados.

### Campo (Field)

É uma variável que **apenas armazena** um dado. Não possui lógica associada. É o "cofre" dos dados.

```csharp
private string _nome; // Isto é um campo.

Propriedade (Property)

É um membro que controla o acesso a um campo. Utiliza os acessadores get e set para definir a lógica de leitura e escrita. É o "porteiro" do cofre.

public string Nome { get; set; } // Isto é uma propriedade.

3. Acessadores get e set

Eles são o coração das propriedades e nos dão controle total sobre os dados.

get (Leitura)

Quando executa: Toda vez que o valor da propriedade é lido.

Função: Retorna o valor do campo privado associado. Pode também transformar o dado antes de retorná-lo.

Exemplo: O get da propriedade Nome retorna _nome em letras maiúsculas:

get
{
    return _nome.ToUpper();
}

set (Escrita)

Quando executa: Toda vez que um novo valor é atribuído à propriedade.

Função: Recebe um novo valor (através da palavra-chave value) e o atribui ao campo privado. Ideal para validações.

Exemplo: O set da propriedade Idade valida se o valor está dentro de um intervalo aceitável:

set
{
    if (value < 0 || value > 200)
    {
        throw new ArgumentException("Idade inválida");
    }
    _idade = value;
}

4. Representação Visual no VS Code

O Visual Studio Code usa ícones para nos ajudar a identificar rapidamente os tipos de membros de uma classe:

🟪 Métodos: Funções como Apresentar() são representadas por um cubo roxo.

🔧 Propriedades: Membros com get/set, como Nome e Idade, são representados por uma chave inglesa.

🔒 Campos: Variáveis internas como _nome e _idade são representadas por um cadeado, indicando que são private.

5. Código de Exemplo Completo
namespace Csharp_IntermediateLevel.Models
{
    public class Pessoa
    {
        // Campos Privados (armazenamento)
        private string _nome;
        private int _idade;

        // Propriedade Pública para Nome (com formatação no get e validação no set)
        public string Nome
        {
            get => _nome.ToUpper();
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O nome não pode ser vazio.");
                }
                _nome = value;
            }
        }

        // Propriedade Pública para Idade (com validação no set)
        public int Idade
        {
            get => _idade;
            set
            {
                if (value <= 0 || value > 120)
                {
                    throw new ArgumentException("Idade inválida.");
                }
                _idade = value;
            }
        }

        // Método Público
        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome} - Idade: {Idade}");
        }
    }
}


✅ Agora você tem um guia completo, didático e formatado corretamente para explicar conceitos essenciais de C# com foco em POO, encapsulamento e propriedades.
