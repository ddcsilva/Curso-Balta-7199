using System;

namespace ListaTarefas.Domain.Entities
{
    public class Tarefa : EntityBase
    {
        public Tarefa(string titulo, DateTime dataCriacao, string usuario)
        {
            Titulo = titulo;
            Concluida = false;
            DataCriacao = dataCriacao;
            Usuario = usuario;
        }

        public string Titulo { get; private set; }
        public bool Concluida { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public string Usuario { get; private set; }

        public void MarcarComoConcluida()
        {
            Concluida = true;
        }

        public void MarcarComoNaoConcluida()
        {
            Concluida = false;
        }

        public void AtualizarTitulo(string titulo)
        {
            Titulo = titulo;
        }
    }
}