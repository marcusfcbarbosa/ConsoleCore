﻿using System;
using GameTop.Lib;

namespace GameTop
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new jogoFoda(new Jogador("Marcus"),
            new Jogador2());
            jogo.IniciarJogo();
        }
    }

    
}
