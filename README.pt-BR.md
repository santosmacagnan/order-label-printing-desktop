# 📦 Sistema de Impressão de Etiquetas de Pedidos

![.NET](https://img.shields.io/badge/.NET-8-512BD4?style=flat&logo=dotnet&logoColor=white)
![C%23](https://img.shields.io/badge/C%23-12-239120?style=flat&logo=csharp&logoColor=white)
![WinForms](https://img.shields.io/badge/UI-WinForms-0078D6?style=flat&logo=windows&logoColor=white)
![Oracle](https://img.shields.io/badge/Database-Oracle-F80000?style=flat&logo=oracle&logoColor=white)

🌐 [Read in English](README.md)

## Objetivo do Projeto

Aplicação desktop desenvolvida para otimizar o processo logístico de impressão de etiquetas de pedidos, integrando banco de dados Oracle e impressoras industriais. O sistema automatiza a consulta de pedidos em aberto, a organização e a geração de etiquetas, reduzindo erros manuais e aumentando a confiabilidade operacional.

## Destaques

- Arquitetura em camadas separando interface, acesso a dados, configuração e integração com hardware
- Integração direta com banco de dados Oracle via `Oracle.ManagedDataAccess.Client`
- Integração com hardware via SDK Brother bpac para impressão real de etiquetas
- Mecanismo de atualização automática via temporizador em segundo plano
- UX de agrupamento por drag-and-drop para montar etiquetas multi-item e multi-volume

## Capturas de Tela

### Tela Principal
![Tela principal](https://github.com/santosmacagnan/order-label-printing-desktop/blob/fe47ec7a83339d5062b00dc1ec960605e49828b5/ScreenShots/Main%20Screen.png)

### Tela Preenchida
![Tela preenchida](https://github.com/santosmacagnan/order-label-printing-desktop/blob/fe47ec7a83339d5062b00dc1ec960605e49828b5/ScreenShots/Main%20screen%20populated.png)

### Tela de Itens Avulsos
![Tela de itens avulsos](https://github.com/santosmacagnan/order-label-printing-desktop/blob/fe47ec7a83339d5062b00dc1ec960605e49828b5/ScreenShots/Individual%20items%20screen.png)

## Funcionalidades

- Listagem automática de pedidos abertos 
- Atualização periódica da lista (30 min)
- Agrupamento de itens por etiqueta via drag-and-drop
- Geração de múltiplas etiquetas por volume
- Monitoramento em tempo real da conexão com o banco
- Impressão via template `.lbx`
- Aba dedicada para itens avulsos

## Arquitetura

A aplicação segue uma estrutura em camadas visando organização e manutenibilidade:

- **Camada de Apresentação** – Interface WinForms
- **Camada de Acesso a Dados** – Integração com Oracle
- **Camada de Configuração** – Arquivo JSON externo
- **Integração com Hardware** – SDK Brother bpac

Boas práticas aplicadas:

- Separação de responsabilidades
- Configuração externalizada
- Modularização da lógica de agrupamento
- Atualização automática via mecanismo temporizado

## Tecnologias Utilizadas

- .NET 8
- C# 12
- Windows Forms
- Oracle Database
- Oracle.ManagedDataAccess.Client
- Brother bpac SDK
- Visual Studio

## Pré-requisitos

- .NET 8 SDK instalado
- Acesso a um banco de dados Oracle
- Driver da impressora Brother instalado
- Um template `.lbx` válido

## Configuração

Crie um arquivo `appconfig.json` na pasta do executável:

```json
{
  "ConnectionStrings": {
    "OracleDb": "User Id=<usuario>;Password=<senha>;Data Source=//HOST:1521/XE"
  },
  "Printers": {
    "DefaultPrinter": "QL-700"
  }
}
```

## Executando a Aplicação

1. Clone o repositório
2. Configure o `appconfig.json`
3. Instale o driver da impressora
4. Execute pelo Visual Studio ou terminal

## Melhorias Implementadas

- Refatoração da lógica de agrupamento de etiquetas
- Substituição de busca manual por seleção interativa (ComboBox)
- Implementação de atualização automática de pedidos
- Melhoria do fluxo para geração de múltiplas etiquetas
- Implementação de atalho de teclado
- Monitoramento em tempo real da conexão com o banco
- Substituição da aba de Amostras pela aba de Itens Avulsos, unificando itens trazidos pelo sistema (agrupados) e itens avulsos no mesmo grupo de etiquetas
- Atualização automática dos pedidos abertos a cada uso da caixa de pesquisa
- Adição de campo de nome do cliente para geração de etiquetas avulsas

## Contato

- GitHub: [@santosmacagnan](https://github.com/santosmacagnan)
- LinkedIn: [Santo S. Macagnan](https://www.linkedin.com/in/santo-segundo-macagnan-74b38643/)
- Portfólio: `<adicione seu link, se tiver>`
