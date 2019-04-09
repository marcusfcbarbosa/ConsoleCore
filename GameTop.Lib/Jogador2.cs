using System;
using GameTop.Interface;

namespace GameTop.Lib
{
    public class Jogador2 : IJogador
    {

        public Jogador2() { }
        public string chuta()
        {
            return "Maradonas estas chutando \n";
        }

        public string Corre()
        {
            return "Maradonas estas corriendo \n";
        }

        public string Pase()
        {
            return "Maradonas estas pasadno \n";
        }
    }
}