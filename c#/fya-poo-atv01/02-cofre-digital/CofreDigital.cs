namespace AfyaATV1
{
    class CofreDigital
    {
        private string _dono;
        private string _senha;
        private bool _estaAberto;
        private int _tentativasErradas;


        public string Dono => _dono;
        public bool EstaAberto => _estaAberto;
        public int TentativasErradas => _tentativasErradas;

        public CofreDigital(string dono, string senha)
        {
            _dono = dono;
            _senha = senha;
            _estaAberto = false;
            _tentativasErradas = 0;
        }

        public string Abrir(string senhaInformada)
        {
            if (_tentativasErradas >= 3)
                return "Cofre Bloqueado";

            if (senhaInformada == _senha)
            {
                _estaAberto = true;
                _tentativasErradas = 0;
                return "Cofre aberto com sucesso";
            }
            else
            {
                _tentativasErradas++;
                return "Senha incorreta";
            }
        }

        public void Fechar()
        {
            _estaAberto = false;
        }

        public string AlterarSenha(string senhaAntiga, string novaSenha)
        {
            if (!_estaAberto)
                return "Cofre precisa estar aberto";

            if (senhaAntiga != _senha)
                return "Senha antiga incorreta";

            _senha = novaSenha;
            return "Senha alterada com sucesso";
        }

        public void ResetarTentativas()
        {
            _tentativasErradas = 0;
        }

        public override string ToString()
        {
            return $"Dono: {_dono}, Aberto: {_estaAberto}, Tentativas: {_tentativasErradas}";
        }
    }
}