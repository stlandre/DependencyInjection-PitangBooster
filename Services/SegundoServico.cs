namespace pitang.booster.dependency.injection._1._2.Services
{
    public class SegundoServico
    {
        private readonly PrimeiroServico _primeiroServico;

        public SegundoServico(PrimeiroServico primeiroServico)
        {
            _primeiroServico = primeiroServico;
        }

        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid IdPrimeiroServico => _primeiroServico.Id;
    }
}
