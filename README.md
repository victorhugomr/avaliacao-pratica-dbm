# Prova Prática de Desenvolvimento IA 🖥️

## Descrição do Projeto
Prova prática de desenvolvimento IA realizada pela dbm - Contact Center como teste técnico para vaga de Desenvolvedor Júnior.

<img src="https://img.shields.io/static/v1?label=csharp&message=Python&color=7159c1&style=for-the-badge&logo=ghost"/>

A aplicação em C# importa dados de um arquivo CSV para um banco de dados SQL Server e fornece um endpoint para consulta desses dados em formato JSON. A aplicação em Python consome a primeira API, processa as informações e exibe os dados de forma categorizada ao usuário.

Tabela de Conteúdos
=================
<!--ts-->
   * [Sobre](#descrição-do-projeto)
   * [Objetivo do projeto](#objetivo-do-projeto)
   * [Features](#features)
   * [Como usar](#como-usar)
      * [Pré-requisitos](#pré-requisitos)
      * [Passos para executar a API em C#](#passos-para-executar-a-api-em-C#)
      * [Passos para executar o cliente em Python](#passos-para-executar-o-cliente-em-Python)
   * [Exemplo de chamadas e respostas da API](#exemplo)
   * [Tecnologias](#tecnologias)
   * [Autor](#autor)
<!--te-->

<h4 align="center"> 
	✨  Prova Prática de Desenvolvimento IA  ✨
</h4>

## Objetivo do projeto

O candidato deve desenvolver um sistema em C# que importe dados de um arquivo CSV para um banco de dados SQL Server e forneça um endpoint para consulta desses dados em formato JSON. Em seguida, deve desenvolver um segundo sistema em Python que consuma essa API, processe as informações e exiba os dados de forma categorizada ao usuário.

## Features

- [x] Função importar dados de um .csv
- [x] Função expotar para um database SQL Server
- [x] Endpoint para consulta de dados

- [x] Função consumir API
- [x] Função processar informações
- [x] Função exibir os dados categorizados

## Como usar

## Pré-requisitos

Antes de começar, você vai precisar ter instalado em sua máquina as seguintes ferramentas:
[VS Code](https://code.visualstudio.com/download), [C# para VS Code](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp) e [SDK 8.0.406](https://dotnet.microsoft.com/en-us/download/dotnet/8.0).

# Clonar este repositório

```bash
$ git clone <https://github.com/victorhugomr/avaliacao-pratica-dbm.git>
```

## Passos para executar a API em C#

# Instalar o SDK do .NET 8 (SDK 8.0.406)
[Download .NET 8](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)

# Restaurar Dependências
```bash
$ dotnet restore
```

# Remover a pasta Migrations e aplicar migrações do banco de dados (caso necessário)
```bash
$ dotnet ef migrations add InitialCreate
$ dotnet ef database update
```

# Build
```bash
$ dotnet build
```

# Executar a API
```bash
$ dotnet run
```

## Passos para executar o cliente em Python

# Instalar o Python 3 (Python 3.13.2)
[Download Python 3](https://www.python.org/downloads/)

# Instalar os requisitos
```bash
$ pip install -r requirements.txt
```

# Executar o cliente
```bash
$ python main.py
```


## Tecnologias 🛠

As seguintes ferramentas foram usadas na construção do projeto:

- [.NET 8.0](https://dotnet.microsoft.com/en-us/)
- [Python 3](https://www.python.org/)
- 

## Autor
---

<a href="https://github.com/victorhugomr">
 <img style="border-radius: 50%;" src="https://avatars.githubusercontent.com/u/22302873?v=4" width="100px;" alt=""/>
 <br />
 <sub><b>Victor Hugo</b></sub></a> <a href="https://github.com/victorhugomr">😎💻</a>

Feito por Victor Hugo 👋🏽
