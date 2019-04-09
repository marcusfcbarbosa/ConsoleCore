using GameTop.Interface;
using System;

namespace GameTop
{
    public class jogoFoda
    {
        private readonly IJogador _iJogador;
        private readonly IJogador _iJogador2;
        public jogoFoda(IJogador iJogador, IJogador iJogador2)
        {
            _iJogador = iJogador;
            _iJogador2 = iJogador2;
        }
        public void IniciarJogo()
        {

            Console.Write(_iJogador.Corre());
            Console.Write(_iJogador.chuta());
            Console.Write(_iJogador.Pase());
            //
            Console.Write(_iJogador2.Corre());
            Console.Write(_iJogador2.chuta());
            Console.Write(_iJogador2.Pase());
        }

    }
}