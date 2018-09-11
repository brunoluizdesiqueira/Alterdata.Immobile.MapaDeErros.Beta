namespace Alterdata.Immobile.MapaDeErros.Domain.Entities.Colaborador
{
    using System;
    using Alterdata.Immobile.MapaDeErros.Domain.ValueObjects;
    using Alterdata.Immobile.MapaDeErros.Shared.Entities;

    public class Colaborador : Entity
    {
        public Nome Nome { get; private set; } 

        public DateTime? DataDesativacao { get; private set; }

        public Colaborador(int id, Nome nome) : base(id)
        {
            this.Nome = nome;   
            AddNotifications(Nome);      
        }

        public void Inativar()
        {
            this.DataDesativacao = DateTime.Now;
        }
    }
}