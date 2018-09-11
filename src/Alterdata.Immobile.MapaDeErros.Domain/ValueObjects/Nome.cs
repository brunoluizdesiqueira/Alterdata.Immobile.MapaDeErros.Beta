using Alterdata.Immobile.MapaDeErros.Shared.ValueObjects;
using Flunt.Validations;

namespace Alterdata.Immobile.MapaDeErros.Domain.ValueObjects
{
    public class Nome : ValueObject
    {
        public string PrimeiroNome { get; private set; }
        public string SobreNome { get; private set; }

        public Nome(string primeiroNome, string sobreNome)
        {
            PrimeiroNome = primeiroNome;
            SobreNome = sobreNome;

            if (string.IsNullOrEmpty(PrimeiroNome))
                AddNotification("Nome.PrimeiroNome", "Nome invalido");

            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(PrimeiroNome, 3, "Nome.PrimeiroNome", "Nome deve conter pelo menos 3 caracteres")
                .HasMaxLen(PrimeiroNome, 40, "Nome.PrimeiroNome", "Nome deve conter até 40 caracteres")
                .HasMinLen(SobreNome, 3, "Nome.SobreNome", "Sobre nome deve conter pelo menos 3 caracteres")
                .HasMaxLen(SobreNome, 40, "Nome.SobreNome", "Sobre nome deve conter até 40 caracteres")
            );    
        }
        
    }
}