namespace Alterdata.Immobile.MapaDeErros.Domain.Entities.Modulo
{
    using System;
    using Alterdata.Immobile.MapaDeErros.Domain.Entities.Projeto;
    public class Modulo
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string CaminhoMenu { get; set; }
        public Projeto Projeto { get; set; }
    }
}