using System;
using System.Collections.Generic;
using System.Text;

namespace MeusContatinhos.Dominio
{
    static class Auxiliar
    {
        public static string ColocarGameiro(this string nome)
        {
            return nome + " Gameiro";
        }

        public static int AddIdade(this string nome)
        {
            return 30;
        }

        public static int SomaMais5(this int numero)
        {
            return numero + 5;
        }

        public static bool EhPar(this int numero)
        {
            return numero % 2 == 0;
        }
    }
}
