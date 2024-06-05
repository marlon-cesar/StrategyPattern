# Payment Module using Strategy Pattern

Este projeto implementa um módulo de pagamento em C# utilizando o padrão de projeto Strategy. O módulo de pagamento oferece suporte a diferentes métodos de pagamento, como cartão de crédito, cartão de débito, PIX e boleto, cada um implementado como uma estratégia separada.

## Visão Geral

O padrão Strategy é um padrão de design comportamental que permite definir uma família de algoritmos, encapsular cada um deles e torná-los intercambiáveis. No contexto deste projeto, o padrão Strategy permite que diferentes métodos de pagamento sejam implementados como estratégias separadas, com uma interface comum, tornando-os intercambiáveis no módulo de pagamento.

## Funcionamento do Programa

O programa permite que o usuário selecione o método de pagamento desejado a partir de um menu. Uma vez selecionado, o serviço de pagamento correspondente é identificado e a função para processar o pagamento é chamada.

## Executando o Projeto

Para executar o projeto, siga estas etapas:

1. Clone o repositório:

    ```bash
    git clone https://github.com/marlon-cesar/StrategyPattern
    ```

2. Navegue até o diretório do projeto:

    ```bash
    cd StrategyPattern
    ```

3. Execute o programa:

    ```bash
    dotnet run
    ```

Isso irá compilar e executar o programa, exibindo o menu para seleção do método de pagamento e processando o pagamento de acordo com a escolha do usuário.

## Contribuindo

Sinta-se à vontade para contribuir com melhorias para este exemplo. Basta abrir uma issue ou enviar uma pull request.
