namespace AfyaATV1
{
    class Personagem
    {
        private string _nome;
        private string _classe;
        private int _nivel;
        private double _vidaAtual;
        private double _vidaMaxima;

        public string Nome => _nome;
        public string Classe => _classe;
        public int Nivel => _nivel;
        public double VidaAtual => _vidaAtual;
        public double VidaMaxima => _vidaMaxima;

        public bool EstaVivo => _vidaAtual > 0;

        public Personagem(string nome, string classe)
        {
            _nome = nome;
            _classe = classe;
            _nivel = 1;

            if (classe == "Guerreiro")
                _vidaMaxima = 150;
            else if (classe == "Mago")
                _vidaMaxima = 80;

            _vidaAtual = _vidaMaxima;
        }

        public void ReceberDano(double pontos)
        {
            if (!EstaVivo || pontos <= 0)
                return;

            _vidaAtual -= pontos;

            if (_vidaAtual < 0)
                _vidaAtual = 0;
        }

        public void Curar(double pontos)
        {
            if (!EstaVivo || pontos <= 0)
                return;

            _vidaAtual += pontos;

            if (_vidaAtual > _vidaMaxima)
                _vidaAtual = _vidaMaxima;
        }

        public void SubirNivel()
        {
            if (!EstaVivo || _nivel >= 99)
                return;

            _nivel++;
            _vidaMaxima += _vidaMaxima * 0.10;
            _vidaAtual = _vidaMaxima;
        }

        public void Ressuscitar()
        {
            if (EstaVivo)
                return;

            _vidaAtual = _vidaMaxima;
        }

        public override string ToString()
        {
            return $"{_nome} ({_classe}) - Lvl {_nivel} - HP: {_vidaAtual}/{_vidaMaxima}";
        }
    }
}