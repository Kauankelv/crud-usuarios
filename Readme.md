# CRUD Usuários - ASP.NET Core

![Badge em Desenvolvimento](https://img.shields.io/badge/status-em%20desenvolvimento-yellow)
![.NET Version](https://img.shields.io/badge/.NET-6.0-purple)
![License](https://img.shields.io/badge/license-MIT-blue)

> Projeto acadêmico de CRUD completo para gerenciamento de usuários, utilizando ASP.NET Core MVC e MySQL

## 📌 Visão Geral

Sistema de gerenciamento de usuários com operações básicas de CRUD (Create, Read, Update, Delete) desenvolvido como projeto acadêmico para demonstrar habilidades em desenvolvimento back-end com ASP.NET Core.

## 🚀 Tecnologias Usadas

- **Back-end**:
  - ASP.NET Core MVC (.NET 6+)
  - Entity Framework Core (opcional)
  - MySQL Database

- **Front-end**:
  - Razor Views
  - Bootstrap 4
  - jQuery (para validações)

- **Ferramentas**:
  - Visual Studio / VS Code
  - Git e GitHub

## 🎯 Funcionalidades Principais

✅ **CRUD Completo**:
- Listagem paginada de usuários
- Criação de novos usuários com validação
- Edição de registros existentes
- Exclusão segura com confirmação

✅ **Recursos Adicionais**:
- Validação de formulários no client-side e server-side
- Design responsivo com Bootstrap
- Tratamento de erros personalizado

## 📁 Estrutura do Projeto

/CRUD-Usuarios
│
├── Controllers/
│ └── UsuarioController.cs # Lógica principal do CRUD
│
├── Models/
│ └── Usuario.cs # Modelo de dados
│
├── Views/Usuario/
│ ├── Index.cshtml # Listagem de usuários
│ ├── Criar.cshtml # Formulário de criação
│ └── Editar.cshtml # Formulário de edição
│
├── wwwroot/ # Arquivos estáticos
│
├── appsettings.json # Configurações
└── README.md # Documentação

## ⚙️ Pré-requisitos

Antes de começar, você precisará ter instalado:

- [.NET 6 SDK](https://dotnet.microsoft.com/download)
- [MySQL Server](https://dev.mysql.com/downloads/) ou Docker para container MySQL
- IDE de sua preferência (VS Code, Visual Studio, Rider)

## 🛠️ Configuração do Ambiente

1. Clone o repositório:
```bash
git clone https://github.com/KauanKelv/Crud-C#.git
cd Crud-C#

Configure o banco de dados:

CREATE DATABASE crud_usuarios;
USE crud_usuarios;

CREATE TABLE usuario (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(100) NOT NULL UNIQUE,
    senha VARCHAR(255) NOT NULL,
    data_criacao DATETIME DEFAULT CURRENT_TIMESTAMP
);

Atualize a connection string no appsettings.json:

"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=crud_usuarios;Uid=root;Pwd=sua_senha;"
}

Execute a aplicação:

dotnet run

Acesse no navegador:

http://localhost:5006/Usuario
```

📚 Documentação Adicional

-[Entity Framework Core](https://learn.microsoft.com/pt-br/ef/core/)

-[ASP.NET Core MVC](https://learn.microsoft.com/pt-br/aspnet/core/mvc/overview?view=aspnetcore-6.0)

-[Bootstrap 4 Documentation](https://getbootstrap.com/docs/4.6/getting-started/introduction/)

🤝 Como Contribuir
Faça um fork do projeto

Crie uma branch para sua feature (git checkout -b feature/AmazingFeature)

Commit suas mudanças (git commit -m 'Add some AmazingFeature')

Push para a branch (git push origin feature/AmazingFeature)

Abra um Pull Request

📞 Contato
Kauan Kelvin

GitHub: @KauanKelv

Email: kauanhemaldo88@gmail.com
