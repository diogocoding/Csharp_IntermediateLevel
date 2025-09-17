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


---

Resumo sobre Manipulação de Valores em C#
A correta manipulação e formatação de valores são essenciais para exibir dados de forma clara e consistente para o usuário. Em C#, isso é feito através de métodos e classes específicas para strings, números e datas.

1. Manipulação de Strings
Existem diversas formas de se trabalhar com textos em C#. As mais comuns são:

Concatenação: Unir duas ou mais strings usando o operador +.

Interpolação: Uma forma mais moderna e legível de embutir variáveis diretamente em uma string, prefixando-a com o símbolo $.

2. Formatação de Números e Moeda
É possível formatar valores numéricos para diferentes representações, como valores monetários, porcentagens ou padrões personalizados.

Valores Monetários: Para garantir a precisão, utiliza-se o tipo decimal. É possível formatá-lo para um padrão numérico com casas decimais, como usar .ToString("N2") para exibir um valor como 1.582,40.

Porcentagens: Valores do tipo double ou decimal podem ser exibidos como porcentagem. Por exemplo, o valor 0.3421 pode ser formatado com .ToString("P") para ser exibido como 34,21%.

Formatação Numérica Personalizada: Você pode aplicar máscaras customizadas. Um número inteiro como 123456 pode ser formatado com .ToString("##-##-##") para ser exibido como 12-34-56.

3. Manipulação de Datas e Horas (DateTime)
O C# oferece ferramentas robustas para formatar e converter (fazer o "parse") de datas e horas.

Formatando Datas: Para exibir um objeto DateTime, utiliza-se o método .ToString() com uma string de formato. Por exemplo, data.ToString("dd/M/yyyy HH:mm") formata a data e hora para o padrão dia/mês/ano e hora:minuto.


Convertendo Strings para DateTime com TryParse: Para converter uma string em um objeto DateTime de forma segura (sem gerar erros que travam o programa), usa-se o método DateTime.TryParseExact. Ele é ideal quando se espera um formato exato para a data na string, como 

"yyyy-MM-dd HH:mm".

Validando a Conversão: O TryParseExact retorna um valor booleano (true ou false) que indica se a conversão foi bem-sucedida. É fundamental sempre verificar esse retorno com uma estrutura if. Se a conversão falhar, a variável de data receberá seu valor padrão, que é 

01/01/0001 00:00:00.

4. A Importância da Cultura (Localization)
A formatação de datas, moedas e números pode variar entre diferentes países e regiões.

Alterando a Cultura: É possível definir uma "cultura" padrão para toda a aplicação. Por exemplo, para usar os padrões brasileiros (como a vírgula para casas decimais), pode-se definir CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR"). Isso garante que a formatação seja consistente e adequada ao público-alvo.
