using Alterdata.Immobile.MapaDeErros.Domain.Entities.Colaborador;
using Alterdata.Immobile.MapaDeErros.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Alterdata.Immobile.MapaDeErros.Tests.Entities
{
    [TestClass]
    public class ColaboradorTests
    {
        //Red, Green, Refector
        [TestMethod]
        public void DeveRetornarFalhaQuandoNomeForInvalido()
        {            
            var colaborador = new Colaborador(1, new Nome("Br", "Siqueira"));
            Assert.IsTrue(colaborador.Invalid);
        }

        [TestMethod]
        public void DeveRetornarSucessoQuandoNomeForValido()
        {            
            var colaborador = new Colaborador(1, new Nome("Bru", "Siqueira"));
            Assert.IsTrue(colaborador.Valid);
        }

       [TestMethod]
        public void DeveRetornarFalhaQuandoSobreNomeForInvalido()
        {            
            var colaborador = new Colaborador(1, new Nome("Bruno", "Si"));
            Assert.IsTrue(colaborador.Invalid);
        }

        [TestMethod]
        public void DeveRetornarFalhaQuandoSobreNomeForValido()
        {            
           Assert.Fail();
        }
    }
}