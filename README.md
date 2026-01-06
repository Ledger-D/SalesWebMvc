# 💻 Projeto Web C# Orientado a Objetos - Sales web mvc.
## 📜 Descrição do Projeto

Este repositório contém o código-fonte desenvolvido como parte do curso de **C# Orientado a Objetos** na plataforma Udemy.

O projeto é uma aplicação web completa, desenvolvida utilizando a tecnologia **ASP.NET Core** (ou .NET) e implementando o padrão **Entity Framework Core** para o gerenciamento e persistência de dados. O foco foi a aplicação prática dos conceitos de Orientação a Objetos (POO) em um ambiente de desenvolvimento web.

## 🎓 Curso e Instrutor

* **Plataforma:** Udemy
* **Curso:** C# Orientado a Objetos
* **Professor:** Nelio Alves

## 🛠️ Tecnologias Utilizadas

* **Linguagem:** C#
* **Framework:** ASP.NET Core (Web)
* **ORM (Mapeamento Objeto-Relacional):** Entity Framework Core
* **Banco de Dados:** MySql.

## 🚀 Como Executar o Projeto Localmente

Siga os passos abaixo para clonar o repositório e executar a aplicação em sua máquina:

1.  **Clone o Repositório:**
    ```bash
    git clone https://github.com/Ledger-D/SalesWebMvc
    cd ../SalesWebMvc
    ```

2.  **Restaure os Pacotes NuGet:**
    ```bash
    dotnet restore
    ```

3.  **Aplicar Migrations do Banco de Dados:**
    * *Se estiver usando Entity Framework Code First, execute:*
    ```bash
    dotnet ef database update
    ```
    
4.  **Execute a Aplicação:**
    ```bash
    dotnet run
    ```
    A aplicação estará disponível em `http://localhost:[PORTA]` (a porta será exibida no terminal).
