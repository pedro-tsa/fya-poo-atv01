namespace AfyaATV1
{
    class Lampada
    {
        private string _marca;
        private readonly Tecnologias _tecnologia;
        private bool _ligada;
        private int _brilho;

        public string Marca => _marca;
        public Tecnologias Tecnologia => _tecnologia;
        public bool Ligada => _ligada;

        public int Brilho
        {
            get => _brilho;
            private set => _brilho = Math.Clamp(value, 0, 100);
        }

        public Lampada(string marca, Tecnologias tecnologia)
        {
            _marca = marca;
            _tecnologia = tecnologia;
            _ligada = false;
            Brilho = 100;
        }

        public void Alternar()
        {
            _ligada = !_ligada;
        }

        public void AjustarBrilho(int novoBrilho)
        {
            if (!_ligada) return;

            Brilho = novoBrilho;
        }

        public override string ToString()
        {
            return $"Marca: {_marca}, Tecnologia: {_tecnologia}, Ligada: {_ligada}, Brilho: {_brilho}";
        }
    }
}