namespace AfyaATV1
{
    class ContaCorrente
    {
        private readonly int _numero;
        private string _titular;
        private double _saldo;
        private double _limite;

        public int Numero => _numero;
        public string Titular
        {
            get => _titular;
            set => _titular = value;
        }

        public double Saldo => _saldo;
        public double Limite => _limite;

        public double SaldoTotal => _saldo + _limite;

        public string StatusConta => _saldo < 0 ? "Negativo" : "Positivo";

        public ContaCorrente(int numero, string titular)
        {
            _numero = numero;
            _titular = titular;
            _saldo = 0;
            _limite = 500;
        }

        public bool Depositar(double valor)
        {
            if (valor <= 0)
                return false;

            _saldo += valor;
            return true;
        }

        public bool Sacar(double valor)
        {
            if (valor <= 0 || valor > SaldoTotal)
                return false;

            _saldo -= valor;
            return true;
        }

        public override string ToString()
        {
            return $"Conta: {_numero} | Titular: {_titular} | Saldo: {_saldo} | Limite: {_limite}";
        }
    }
}