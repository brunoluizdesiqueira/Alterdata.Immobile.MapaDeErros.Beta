namespace Alterdata.Immobile.MapaDeErros.Domain.Entities.Ocorrencia
{   
    using System;
    using Alterdata.Immobile.MapaDeErros.Domain.Entities.Cliente;
    using Alterdata.Immobile.MapaDeErros.Domain.Entities.Modulo;
    public class Ocorrencia
    {
        public int ID { get; set; }
        public DateTime DataOrigem { get; set; }
        public DateTime DataCorrecao { get; set; }
        public string ProcessoOrigem { get; set; }
        public string ProcessoCorrecao { get; set; }
        public Cliente Cliente { get; set; }
        public Modulo Modulo { get; set; }
        public string RazaoOcorrencia { get; set; }
    }
}