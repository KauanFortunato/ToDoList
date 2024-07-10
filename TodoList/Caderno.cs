using System.Collections.Generic;

namespace TodoList
{
    internal class Caderno
    {
        private List<string> tarefas = new List<string>();

        public Caderno() { }

        public List<string> Tarefas
        {
            get { return tarefas; }
            set { tarefas = value; }
        }

        public void AddTarefa(string tarefa)
        {
            Tarefas.Add(tarefa);
        }
    }
}
