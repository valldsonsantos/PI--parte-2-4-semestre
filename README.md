**Projeto Integrador - Parte 2 - 4º Semestre**
---------------------------------------------------
**🧠 Objetivo do Projeto**

Desenvolver um aplicativo voltado para a organização da vida acadêmica de estudantes universitários, com foco na gestão de prazos, provas, trabalhos e rotinas de estudo.
A aplicação será composta por um Frontend web e um Backend em C# (.NET Core), com integração futura a um banco de dados.

**🚀 Tecnologias Utilizadas**

✔️ Frontend
- HTML5
- CSS3
- JavaScript (puro)


Esta interface foi desenvolvida com HTML5, CSS3 e JavaScript puro para fornecer uma experiência visual
moderna e responsiva para usuários realizarem login ou cadastro no sistema. O layout é dividido em duas
seções principais: Login e Cadastro, com transições suaves entre os dois modos, garantindo uma experiência
de usuário intuitiva e agradável.

**_Funcionalidades:_**

- _Animação de Transição:_ alternância dinâmica entre os formulários de login e cadastro utilizando classes CSS e animações com @keyframes.

- Responsividade: design adaptado para dispositivos móveis por meio de media queries, garantindo usabilidade em diferentes resoluções.

**_Design Agradável e Moderno:_**

- Paleta de cores harmônica com destaque para tons de roxo e branco.

- Fontes importadas do Google Fonts (Open Sans).

- Ícones sociais com interação visual (hover).

- Formulários com Experiência Aprimorada:

- Campos com focus estilizado.

- Suporte a preenchimento automático com estilo (autofill).

- Componentes reutilizáveis com classes bem definidas.

**_Interatividade:_**

- Botões de "Entrar" e "Cadastrar" alternam os modos de visualização ao manipular a classe do body.

**_Estrutura de Componentes_**

- _container:_ centraliza a tela e define o fundo geral.

- _content:_ componente principal com efeito de sombra e arredondamento de bordas.

- _first-content e .second-content:_ controlam qual conteúdo está visível (login ou cadastro).

- _form:_ contém os campos de entrada dos formulários.

- _btn, .title, .description:_ estilos reutilizáveis para botões, títulos e descrições.

- _social-media:_ exibe ícones de redes sociais (estáticos neste exemplo).

**_Lógica JavaScript_**

var btnSignin = document.querySelector("#signin");

var btnSignup = document.querySelector("#signup");

var body = document.querySelector("body");

btnSignin.addEventListener("click", function () {
   body.className = "sign-in-js"; 
});

btnSignup.addEventListener("click", function () {
    body.className = "sign-up-js";
});

_Esse script manipula a classe do < body > para alternar entre os modos de login e cadastro, ativando as animações CSS associadas._

![Image](https://github.com/user-attachments/assets/5bc7df59-28da-498b-8394-4f8829c66311)

![Image](https://github.com/user-attachments/assets/697de7dc-96df-4a68-88f8-2b0439a7d7e7)

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

|| |── **Backend/**

|| |── **Controllers/**

||── _LoginController.cs_

|| |── **Models/**

||─── _LoginRequest.cs_

||── _Program.cs_

||── _appsettings.json_

|| |── **Frontend/**

||── _index.html_

||── _login.html_

||── _style.css_

|| |─── **README.md**

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

- **Bruno Ruiz Ribeiro Machado**	(Backend {API C# .NET Core})

- **Aline Andrade Cintra Camargo**	(Frontend {Tela de Login})

- **Pedro Henrique Andrade Monteiro**	(Frontend {Dashboard Tarefas})

- **Renan Samuel de Oliveira**	(Backend {Tarefas / Integração BD})

- **Valdson S Almeida**	(Documentação / Vídeo de Apresentação)

- **Wellington Correa Ferreira** (Banco de Dados {Tabelas e scripts})

**🎬 Entrega**

- 📅 Data limite: 19/05/2025
- 📂 Repositório GitHub com todos os arquivos organizados por pastas
- 📽️ Vídeo de apresentação de até 1 minuto
- 📄 README.md completo e atualizado

>**📌 Observações**

Este repositório será atualizado conforme os membros forem concluindo suas partes. O foco inicial está na estruturação do back-end e front-end, com integração básica prevista para os próximos dias.


