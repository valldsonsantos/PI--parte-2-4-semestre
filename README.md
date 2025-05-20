# **Projeto Integrador - Parte 2 - 4º Semestre**

### **🧠 Objetivo do Projeto**

Desenvolver um aplicativo voltado para a organização da vida acadêmica de estudantes universitários, com foco na gestão de prazos, provas, trabalhos e rotinas de estudo.
A aplicação será composta por um Frontend web e um Backend em C# (.NET Core), com integração futura a um banco de dados.

### **🚀 Tecnologias Utilizadas**

## ✔️ Frontend

- HTML5
- CSS3
- JavaScript (puro)

Esta interface foi desenvolvida com HTML5, CSS3 e JavaScript puro para fornecer uma experiência visual
moderna e responsiva para usuários realizarem login ou cadastro no sistema. O layout é dividido em duas
seções principais: Login e Cadastro, com transições suaves entre os dois modos, garantindo uma experiência
de usuário intuitiva e agradável.

### **_Funcionalidades:_**

- _Animação de Transição:_ alternância dinâmica entre os formulários de login e cadastro utilizando classes CSS e animações com @keyframes.

- Responsividade: design adaptado para dispositivos móveis por meio de media queries, garantindo usabilidade em diferentes resoluções.

### **_Design Agradável e Moderno:_**

- Paleta de cores harmônica com destaque para tons de roxo e branco.

- Fontes importadas do Google Fonts (Open Sans).

- Ícones sociais com interação visual (hover).

- Formulários com Experiência Aprimorada:

- Campos com focus estilizado.

- Suporte a preenchimento automático com estilo (autofill).

- Componentes reutilizáveis com classes bem definidas.

### **_Interatividade:_**

- Botões de "Entrar" e "Cadastrar" alternam os modos de visualização ao manipular a classe do body.

**_Estrutura de Componentes_**

- _container:_ centraliza a tela e define o fundo geral.

- _content:_ componente principal com efeito de sombra e arredondamento de bordas.

- _first-content e .second-content:_ controlam qual conteúdo está visível (login ou cadastro).

- _form:_ contém os campos de entrada dos formulários.

- _btn, .title, .description:_ estilos reutilizáveis para botões, títulos e descrições.

- _social-media:_ exibe ícones de redes sociais (estáticos neste exemplo).

### **_Lógica JavaScript_**

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

## ✔️ Backend

- ASP.NET Core Web API (C#)
- .NET 6 ou superior
- API RESTful com Controllers
- JSON como formato de comunicação

A interface de gestão de tarefas foi criada para oferecer uma experiência acessível, descomplicada e prática, permitindo que o usuário organize suas atividades de forma otimizada e eficaz. Essa interface integra um sistema simples de produtividade pessoal, priorizando a experiência do usuário, a usabilidade e as melhores práticas de desenvolvimento front-end.

### **Funcionalidades Implementadas**

_A interface oferece as seguintes funcionalidades cruciais:_

Listagem de tarefas: O sistema apresenta uma relação de tarefas com nome e opções de controle.

Adição de novas tarefas: O usuário tem a opção de inserir novas tarefas ao clicar no botão "Adicionar Nova Tarefa".

Edição de tarefas: Cada item da lista possui um botão de edição que possibilita modificar o nome da tarefa através de um prompt.

Exclusão de tarefas: Há também a possibilidade de remover tarefas individualmente usando o botão "Excluir".

As tarefas são gerenciadas dinamicamente com JavaScript, garantindo a atualização imediata da lista sem a necessidade de atualizar a página.

### **Responsividade**

A tela foi projetada para ser totalmente responsiva, adaptando-se a diferentes tamanhos de dispositivos, como smartphones, tablets e computadores. Foram utilizadas media queries para ajustar o layout, tamanhos de botões e margens conforme a dimensão da tela. Essa característica é vital para garantir acessibilidade e usabilidade em diferentes cenários de uso.

### **Design da Interface**

_O design foi elaborado com foco na simplicidade, clareza e modernidade. Os principais elementos visuais incluem:_

- Cabeçalho com cor de fundo roxa e fonte branca, realçando o título da aplicação.

- Cartões de tarefa com fundo branco, sombra e bordas arredondadas, proporcionando destaque e separação visual.

- Botões com efeito de transição, sombra e cores contrastantes, aprimorando a identificação das ações.

- A interface também inclui um botão flutuante com aparência destacada para facilitar a adição de novas tarefas.

### **Tipografia e Ícones**

A fonte escolhida para a aplicação é a "Open Sans", importada do Google Fonts, conhecida por sua excelente legibilidade e aspecto moderno. Até o momento, a aplicação não utiliza ícones gráficos, mas a estrutura está preparada para a inclusão futura de bibliotecas como Font Awesome ou Material Icons, o que poderá enriquecer ainda mais a interface e a usabilidade.

### **Interatividade**
A aplicação proporciona um nível básico, porém eficaz, de interatividade com o usuário. O uso de eventos de clique, transições visuais ao passar o mouse (hover) e atualizações dinâmicas da interface asseguram uma experiência fluida. Todas as interações ocorrem diretamente no navegador, sem a necessidade de backend.

### **Lógica JavaScript**

A lógica por trás da aplicação foi implementada com JavaScript puro (vanilla JS), adotando uma abordagem orientada a eventos. A seguir, os principais aspectos da lógica:

### **_Para escolher partes da página, utilize getElementById e querySelector._**

- Para adicionar novas tarefas na lista, crie elementos HTML dinamicamente com createElement.

- Use addEventListener para lidar com os eventos, implementando funções para ajustar ou apagar tarefas.

- Ao editar, deixe o usuário colocar novos nomes para as tarefas usando prompt.

- Quando o botão "Excluir" for clicado, apague elementos do DOM com remove().

- Essas funcionalidades criam uma base forte para a aplicação melhorar, como salvar localmente (localStorage), separar as tarefas por tipo.

### **Considerações Finais**

A tela criada é um bom exemplo de aplicação front-end para organizar tarefas. Misturar HTML bem estruturado, CSS moderno e que se adapta a diferentes telas e JavaScript funcional resulta em algo leve, que funciona bem e é fácil de usar.

## **API de Tarefas**
A API de Tarefas foi desenvolvida em C# com .NET 6, utilizando boas práticas para facilitar a criação, consulta, atualização e exclusão de tarefas no sistema. Essa API é responsável por toda a parte do backend relacionada ao controle de tarefas, além de estar integrada a um banco de dados.

### Funcionalidades:

- Cadastro de Tarefas: Permite registrar novas tarefas no sistema.

- Listagem de Tarefas: Exibe todas as tarefas salvas no banco.

- Edição de Tarefas: Atualiza informações de uma tarefa existente.

- Exclusão de Tarefas: Remove tarefas do sistema.

### **Organização do Projeto**

O projeto foi organizado em três partes principais para manter a estrutura limpa e facilitar a manutenção:

- Controllers: Onde ficam os endpoints (rotas) que o sistema usa para se comunicar com a API.

- Models: Define os dados que cada tarefa deve ter (por exemplo: título, descrição, data).

- Data: Responsável por fazer a ligação entre o sistema e o banco de dados através do DbContext.

### **Integração com o Banco de Dados**
Foi utilizada a ferramenta Entity Framework Core, que permite a criação e manipulação das tabelas do banco de dados de forma automática com base no código. A conexão com o banco é feita através do arquivo appsettings.json.

### _Exemplos de Rotas da API_
GET /api/tarefas → Retorna todas as tarefas.

POST /api/tarefas → Adiciona uma nova tarefa.

PUT /api/tarefas/{id} → Atualiza uma tarefa específica.

DELETE /api/tarefas/{id} → Exclui uma tarefa.

### **Tecnologias Utilizadas**
Linguagem: C#

Framework: .NET 6

ORM: Entity Framework Core

Banco de dados: SQL Server
## ✔️ Banco de Dados

- [A definir: MySQL, SQL Server ou SQLite]
- Tabelas esperadas: Usuarios, Tarefas

### **🛠️ Estrutura do Projeto**


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

### **📡 Endpoints Disponíveis (Backend)**

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

## **👥 Equipe**

**Nome** (Função)

- **Aline Andrade Cintra Camargo**	(Frontend {Tela de Login})

- **Bruno Ruiz Ribeiro Machado**	(Backend {API C# .NET Core})

- **Pedro Henrique Andrade Monteiro**	(Frontend {Dashboard Tarefas})

- **Renan Samuel de Oliveira**	(Backend {Tarefas / Integração BD})

- **Valdson S Almeida**	(Documentação/Markdown)

- **Wellington Correa Ferreira** (Banco de Dados/Vídeo de Apresentação)

### **🎬 Entrega**

- 📅 Data limite: 19/05/2025
- 📂 Repositório GitHub com todos os arquivos organizados por pastas
- 📽️ Vídeo de apresentação de até 1 minuto
- 📄 README.md completo e atualizado

>**📌 Observações**

Este repositório será atualizado conforme os membros forem concluindo suas partes. O foco inicial está na estruturação do back-end e front-end, com integração básica prevista para os próximos dias.


