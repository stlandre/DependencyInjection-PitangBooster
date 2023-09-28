namespace pitang.booster.dependency.injection._1._2.Services
{
    public class TerceiroServico
    {
        private readonly PrimeiroServico _primeiroServico;
        private readonly SegundoServico _segundoServico;
        private readonly SegundoServico _segundoServicoNovaInstancia;

        public TerceiroServico(
            PrimeiroServico primeiroServico, 
            SegundoServico segundoServico, 
            SegundoServico segundoServicoNovaInstancia)
        {
            _primeiroServico = primeiroServico;
            _segundoServico = segundoServico;
            _segundoServicoNovaInstancia = segundoServicoNovaInstancia;
        }

        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid IdPrimeiroServico => _primeiroServico.Id;
        public Guid IdSegundoServico => _segundoServico.Id;
        public Guid IdSegundoServicoNovaInstancia => _segundoServicoNovaInstancia.Id;
    }
}
