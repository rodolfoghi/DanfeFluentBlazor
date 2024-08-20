# DanfeFluentBlazor

[![Build and deploy ASP.Net Core app to Azure Web App - DanfeFluentBlazor](https://github.com/rodolfoghi/DanfeFluentBlazor/actions/workflows/main_danfefluentblazor.yml/badge.svg)](https://github.com/rodolfoghi/DanfeFluentBlazor/actions/workflows/main_danfefluentblazor.yml)
![License](https://img.shields.io/github/license/rodolfoghi/DanfeFluentBlazor)
![Last Commit](https://img.shields.io/github/last-commit/rodolfoghi/DanfeFluentBlazor)
![Issues](https://img.shields.io/github/issues/rodolfoghi/DanfeFluentBlazor)

## Descrição

O `DanfeFluentBlazor` é uma aplicação web desenvolvida em C# e Blazor que permite aos usuários visualizar, baixar e imprimir o Documento Auxiliar da Nota Fiscal Eletrônica (DANFE) a partir de um arquivo XML de NF-e. A interface é intuitiva, permitindo que o usuário arraste ou selecione o arquivo XML e, em seguida, visualize o DANFE em formato PDF.

## Funcionalidades

- **Visualização de DANFE**: Exiba o DANFE em formato PDF a partir de um arquivo XML de NF-e.
- **Download de PDF**: Baixe o DANFE gerado como um arquivo PDF.
- **Impressão**: Imprima diretamente o DANFE a partir da aplicação.
- **Interface Intuitiva**: Arraste ou selecione facilmente o arquivo XML para gerar o DANFE.

## Como Usar

1. Acesse a aplicação web hospedada ou execute localmente.
2. Arraste ou selecione o arquivo XML da NFe que deseja visualizar.
3. A aplicação gerará o DANFE correspondente em formato PDF.
4. Você pode baixar ou imprimir o DANFE diretamente pela interface.

## Requisitos

- .NET 8.0 ou superior

## Executando Localmente

Para executar a aplicação localmente, siga os passos abaixo:

1. Clone o repositório:

    ```bash
    git clone https://github.com/rodolfoghi/DanfeFluentBlazor.git
    ```

2. Navegue até o diretório do projeto:

    ```bash
    cd DanfeFluentBlazor
    ```

3. Restaure as dependências e execute o projeto:

    ```bash
    dotnet restore
    dotnet run --project .\DanfeFluentBlazor\DanfeFluentBlazor\
    ```

4. Acesse a aplicação no navegador em `http://localhost:5082`.

## Contribuição

Contribuições são bem-vindas! Siga os passos abaixo para contribuir:

1. Fork o repositório.
2. Crie uma branch para sua feature (`git checkout -b feature/nova-feature`).
3. Faça commit das suas alterações (`git commit -m 'Adiciona nova feature'`).
4. Faça push para a branch (`git push origin feature/nova-feature`).
5. Abra um Pull Request.

## Licença

Este projeto está licenciado sob a licença MIT - veja o arquivo [LICENSE](LICENSE) para mais detalhes.

## Contato

Para dúvidas ou suporte, você pode abrir uma [issue](https://github.com/rodolfoghi/DanfeFluentBlazor/issues) ou entrar em contato diretamente.
