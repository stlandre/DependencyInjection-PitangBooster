using pitang.booster.dependency.injection._1._2.IBusiness;
using pitang.booster.dependency.injection._1._2.Services;

namespace pitang.booster.dependency.injection._1._2.Business
{
    public class ApplicationBusiness: IApplicationBusiness
    {
        private readonly PrimeiroServico _primeiroServico;
        private readonly SegundoServico _segundoServico;
        private readonly TerceiroServico _terceiroServico;
        private readonly TerceiroServico _terceiroServicoNovaInstancia;

        public ApplicationBusiness(
            PrimeiroServico primeiroServico,
            SegundoServico segundoServico,
            TerceiroServico terceiroServico,
            TerceiroServico terceiroServicoNovaInstancia)
        {
            _primeiroServico = primeiroServico;
            _segundoServico = segundoServico;
            _terceiroServico = terceiroServico;
            _terceiroServicoNovaInstancia = terceiroServicoNovaInstancia;
        }

        public object RetornoApplication()
        {
            var requisicao = new
            {
                Id = Guid.NewGuid(),
                PrimeiroServicoId = _primeiroServico.Id,
                SegundoServico = new
                {
                    Id = _segundoServico.Id,
                    PrimeiroServicoId = _segundoServico.IdPrimeiroServico,
                },
                TerceiroServico = new
                {
                    Id = _terceiroServico.Id,
                    PrimeiroServicoId = _terceiroServico.IdPrimeiroServico,
                    SegundoServicoId = _terceiroServico.IdSegundoServico,
                    SegundoServicoNovaInstanciaId = _terceiroServico.IdSegundoServicoNovaInstancia
                },
                TerceiroServicoNovaInstancia = new
                {
                    Id = _terceiroServicoNovaInstancia.Id
                }
            };

            return requisicao;
        }
    }
}
