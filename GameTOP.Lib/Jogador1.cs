using GameTOP.Interface;

namespace GameTOP.Lib
{
   
    public class Jogador1 : iJogador
    {
        public readonly string _Nome;

        public Jogador1(string nome = "Deach")
        {
            _Nome = nome;
        }

        public string Passa()
        {
            return $"{_Nome} está passando\n";
        }

        public string Chora()
        {
            return $"{_Nome} está chorando\n";
        }

        public string Rope()
        {
            return $"{_Nome} está dando rope\n";
        }
    }
}