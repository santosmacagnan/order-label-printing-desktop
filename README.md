📦 Order Label Printing System
📦 Sistema de Impressão de Etiquetas de Pedidos

## Objetivo do Projeto
Aplicação desktop desenvolvida para otimizar o processo logístico de impressão de etiquetas de pedidos, integrando base de dados Oracle e impressoras industriais.
O sistema automatiza a consulta de pedidos em aberto, organização e geração de etiquetas, reduzindo os erros manuais e aumentando a confiabilidade operacional

## Project Overview
Desktop application developed to optimize the logistics process of order label printing, integrating an Oracle database with industrial label printers.

The system automates open order retrieval, item grouping, and label generation, reducing manual errors and improving operational reliability.

## Funcionalidades/Features

- Listagem automática de pedidos abertos
- Atualização periódica da lista (30 min)
- Agrupamento de itens por etiqueta via drag-and-drop
- Geração de múltiplas etiquetas por volume
- Monitoramento em tempo real da conexão com banco
- Impressão via template `.lbx`
- Aba dedicada para etiquetas de amostra

- Automatic retrieval of open orders
- Automatic refresh every 30 minutes
- Drag-and-drop item grouping per label
- Multi-volume label generation
- Real-time database connection monitoring
- Printing via .lbx templates
- Dedicated tab for sample labels

## Arquitetura/Architecture
A aplicação segue uma estrutura em camadas visando organização e manutenibilidade:
- Camada de Apresentação – Interface WinForms
- Camada de Acesso a Dados – Integração com Oracle
- Camada de Configuração – Arquivo JSON externo
- Integração com Hardware – SDK Brother bpac
- Boas práticas aplicadas:
- Separação de responsabilidades
- Configuração externalizada
- Modularização da lógica de agrupamento
- Atualização automática via mecanismo temporizado

The application follows a layered structure to improve organization and maintainability:
- Presentation Layer – WinForms UI
- Data Access Layer – Oracle integration
- Configuration Layer – External JSON configuration
- Hardware Integration – Brother bpac SDK
- Applied practices:
- Separation of concerns
- Externalized configuration
- Modularized grouping logic
- Timed background refresh mechanism

## Tecnologias/Tecnologies
- .NET 8
- C# 12
- Windows Forms
- Oracle Database
- Oracle.ManagedDataAccess.Client
- Brother bpac SDK
- Visual Studio

## Requisitos/Tech Stack
- .NET 8 SDK
- Acesso ao banco Oracle
- Driver da impressora Brother instalado
- Template .lbx válido

- .NET 8 SDK
- Oracle database access
- Brother printer driver installed
- Valid .lbx template

## Configuração/Configuration
Criar arquivo appconfig.json na pasta do executável:

Create an appconfig.json file in the executable directory:
<pre>```json
{
  "ConnectionStrings": {
    "OracleDb": "User Id=ADM;Password=adm;Data Source=//HOST:1521/XE"
  },
  "Printers": {
    "DefaultPrinter": "QL-700"
  }
}
</pre>
## Executar/Runnig the Application

1. Clonar o repositório
2. Configurar `appconfig.json`
3. Instalar driver da impressora
4. Executar pelo Visual Studio ou terminal

1. Clone the repository
2. Configure appconfig.json
3. Install printer driver
4. Run via Visual Studio or terminal:

## Melhorias Implementadas/Implemented Improvements
- Refatoração da lógica de agrupamento de etiquetas
- Substituição de busca manual por seleção interativa (ComboBox)
- Implementação de atualização automática de pedidos
- Melhoria do fluxo para geração de múltiplas etiquetas
- Implementação de atalho de teclado
- Monitoramento em tempo real da conexão com banco

- Refactored label grouping logic
- Replaced manual search with interactive order selection
- Implemented automatic order refresh mechanism
- Improved multi-label generation workflow
- Added keyboard shortcut for deletion
- Implemented real-time database connection monitoring