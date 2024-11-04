# B3 Calculadora de Juros Compostos

## Descri��o
Este projeto � uma aplica��o web para calcular o investimento com base em juros compostos. A aplica��o permite que o usu�rio informe um valor monet�rio positivo e um prazo em meses (maior que 1) para resgate da aplica��o. Ap�s solicitar o c�lculo do investimento, a aplica��o exibe o resultado bruto e o resultado l�quido.

## Estrutura do Projeto
Para tornar o c�digo modular e extens�vel, o projeto implementa diversos padr�es de design e pr�ticas de boas pr�ticas, incluindo:

- **Factory Method**: Seguindo o padr�o GoF (Gang of Four), utilizamos o Factory Method para o c�lculo de impostos. Esse padr�o facilita a separa��o dos c�lculos de impostos em classes distintas, tornando o c�digo modular e mais f�cil de manter.
  
- **Dictionary para C�lculos de Impostos**: Em vez de utilizar estruturas condicionais (`if` ou `switch`) para decidir qual c�lculo de imposto aplicar, utilizamos um `Dictionary` para configurar os diferentes tipos de c�lculo de imposto. Essa abordagem permite a adi��o e manuten��o de novos tipos de impostos de maneira simplificada e extens�vel.

- **FluentValidation para Valida��o de Entrada**: Para garantir a qualidade e a manuten��o do c�digo, utilizamos a biblioteca **FluentValidation** para validar os valores de entrada. Com essa biblioteca, as regras de valida��o de campos est�o separadas das regras de neg�cios, facilitando a manuten��o e a legibilidade do c�digo.

## Princ�pios SOLID
Este projeto segue os princ�pios do **SOLID** para garantir uma arquitetura robusta e escal�vel:

1. **S - Princ�pio da Responsabilidade �nica**: Cada classe ou m�dulo tem uma �nica responsabilidade, tornando o c�digo mais organizado e menos suscet�vel a erros.
2. **O - Princ�pio do Aberto/Fechado**: O c�digo � projetado para ser aberto para extens�o, mas fechado para modifica��o. O uso de `Dictionary` e `Factory Method` permite que novos tipos de c�lculo sejam adicionados sem modificar o c�digo existente.
3. **L - Princ�pio de Substitui��o de Liskov**: Implementa��es de classes podem substituir suas classes base sem alterar o comportamento desejado.
4. **I - Princ�pio de Segrega��o de Interface**: As interfaces s�o projetadas para que os m�dulos dependam apenas dos m�todos necess�rios.
5. **D - Princ�pio de Invers�o de Depend�ncia**: O projeto utiliza inje��o de depend�ncia para desacoplar classes e facilitar testes e manuten��o.

## Tecnologias
- **Back-end**: C#
- **Front-end**: Angular

## Instala��o
Para configurar e rodar o projeto localmente, siga as etapas abaixo:

1. **Baixar o Visual Studio**: [Visual Studio](https://visualstudio.microsoft.com/).
2. **Instalar o Angular CLI**: Execute o comando abaixo no terminal para instalar o Angular CLI.
    ```bash
    npm install -g @angular/cli
    ```
3. **Clonar o reposit�rio**:
    ```bash
    git clone <URL_DO_REPOSITORIO>
    ```
4. **Configurar o projeto**: Abra o projeto no Visual Studio e siga as instru��es de configura��o.

## Uso
Ap�s configurar o ambiente, inicie o servidor e o cliente para acessar a aplica��o e calcular o retorno de investimento.

## Contribui��o
Este projeto foi criado por **Tarcizio Junior**. Contribui��es s�o bem-vindas.

## Licen�a
Este projeto � licenciado sob a licen�a MIT.
