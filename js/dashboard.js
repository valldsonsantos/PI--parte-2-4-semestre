// Seleciona o botão de adicionar tarefa e a lista de tarefas
const addTaskButton = document.getElementById('add-task-btn');
const taskList = document.getElementById('task-list');

// Função para criar um elemento de tarefa
function criarTarefa(nome = "Nova Tarefa") {
    const newTask = document.createElement('div');
    newTask.classList.add('task-item');
    newTask.innerHTML = `
    <span>${nome}</span>
    <div>
        <button class="btn btn-primary btn-editar">Editar</button>
        <button class="btn btn-primary btn-excluir">Excluir</button>
    </div>
    `;
    // btn de excluir
    newTask.querySelector('.btn-excluir').addEventListener('click', () => {
        newTask.remove();
    });
    // btn de editar
    newTask.querySelector('.btn-editar').addEventListener('click', () => {
        const novoNome = prompt("Novo nome da tarefa:", nome);
        if (novoNome) {
            newTask.querySelector('span').textContent = novoNome;
        }
    });
    return newTask;
}

// Adiciona evento ao botão de adicionar tarefa
addTaskButton.addEventListener('click', () => {
    const tarefa = criarTarefa();
    taskList.appendChild(tarefa);
});

// Adiciona eventos aos botões já existentes
document.querySelectorAll('.task-item').forEach(item => {
    item.querySelector('.btn-excluir').addEventListener('click', () => {
        item.remove();
    });
    item.querySelector('.btn-editar').addEventListener('click', () => {
        const nomeAtual = item.querySelector('span').textContent;
        const novoNome = prompt("Novo nome da tarefa:", nomeAtual);
        if (novoNome) {
            item.querySelector('span').textContent = novoNome;
        }
    });
});