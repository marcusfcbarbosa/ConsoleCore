using System;
using GameTop.Interface;

namespace GameTop.Lib
{
   public class Jogador : IJogador
    {
        public readonly string _Nome;
        public Jogador(string nome)
        {
            this._Nome = nome;
        }

        public string chuta()
        {
            return $"{_Nome} esta chutando \n";
        }

        public string Corre()
        {
           return $"{_Nome} esta correndo \n";
        }

        public string Pase()
        {
            return $"{_Nome} esta passando \n";
        }

        
    }
}