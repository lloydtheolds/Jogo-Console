using System;
using GameTOP.Interface;

namespace GameTOP
{
    class JogoFODA{

        private readonly iJogador _jogador1;

        private readonly iJogador _jogador2;

        public JogoFODA(iJogador jogador1, iJogador jogador2)
        {
            _jogador1 = jogador1;
            _jogador2 = jogador2;
        }


        public void IniciarJogo()
        {
            Console.Write(_jogador1.Chora());
            Console.Write(_jogador1.Passa());
            Console.Write(_jogador1.Rope());

            Console.Write("\n Proximo Jogador: \n");

            Console.Write(_jogador2.Rope());
            Console.Write(_jogador2.Chora());
            Console.Write(_jogador2.Passa());
        }
    }
}