**Projeto Integrador - Parte 2 - 4º Semestre**

**🧠 Objetivo do Projeto**

Desenvolver um aplicativo voltado para a organização da vida acadêmica de estudantes universitários, com foco na gestão de prazos, provas, trabalhos e rotinas de estudo.
A aplicação será composta por um Frontend web e um Backend em C# (.NET Core), com integração futura a um banco de dados.

**🚀 Tecnologias Utilizadas**

✔️ Frontend (em desenvolvimento)
- HTML5
- CSS3
- JavaScript (puro)
- [Espaço reservado para a Aline documentar a parte do Frontend]

✔️ Backend
- ASP.NET Core Web API (C#)
- .NET 6 ou superior
- API RESTful com Controllers
- JSON como formato de comunicação

✔️ Banco de Dados
- [A definir: MySQL, SQL Server ou SQLite]
- Tabelas esperadas: Usuarios, Tarefas

**🛠️ Estrutura do Projeto**


PI--parte-2-4-semestre/

├── backend/

│   ├── Controllers/

│   │   └── LoginController.cs

│   ├── Models/

│   │   └── LoginRequest.cs

│   ├── Program.cs

│   └── appsettings.json

├── frontend/

│   ├── index.html
![image]()

│   ├── login.html

│   └── style.css

├── README.md

**📡 Endpoints Disponíveis (Backend)**

**_POST /login_**

Recebe os dados de login do usuário.

**_Exemplo de Requisição:_**

{
  
  "username": "admin",
  
  "password": "1234"
  
}

**_Respostas possíveis:_**
- ✅ 200 OK → Login realizado com sucesso
- ❌ 401 Unauthorized → Usuário ou senha inválidos

Obs.: Neste momento a validação é estática para testes.

**⚙️ Como Executar o Projeto**

**_🔧 Requisitos:_**

- Visual Studio 2022 ou superior
- .NET SDK 6 ou superior

**_🔄 Clonar o repositório_**

git clone https://github.com/valldosnsonsantos/PI--parte-2-4-semestre.git
cd PI--parte-2-4-semestre

**_▶️ Executar o backend (API C#)_**

1. Abra a solução no Visual Studio
2. Pressione F5 para rodar
3. Acesse o Swagger ou use Postman para testar: http://localhost:5000/login

**👥 Equipe**

**Nome** (Função)

**Bruno Ruiz Ribeiro Machado**	(Backend {API C# .NET Core})

**Aline Andrade Cintra Camargo**	(Frontend {Tela de Login})

**Pedro Henrique Andrade Monteiro**	(Frontend {Dashboard Tarefas})

**Renan Samuel de Oliveira**	(Backend {Tarefas / Integração BD})

**Valdson S Almeida**	(Documentação / Vídeo de Apresentação)

**Wellington Correa Ferreira** (Banco de Dados {Tabelas e scripts})

**🎬 Entrega**

- 📅 Data limite: 19/05/2025
- 📂 Repositório GitHub com todos os arquivos organizados por pastas
- 📽️ Vídeo de apresentação de até 1 minuto
- 📄 README.md completo e atualizado

**📌 Observações**

Este repositório será atualizado conforme os membros forem concluindo suas partes. O foco inicial está na estruturação do back-end e front-end, com integração básica prevista para os próximos dias.


