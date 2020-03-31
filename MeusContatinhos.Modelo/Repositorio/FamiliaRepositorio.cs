using System;
using System.Collections.Generic;
using System.Text;

namespace MeusContatinhos.Dominio.Repositorio
{
    class FamiliaRepositorio
    {
        public string NomeMinhaMae { get; set; }
        public int Idade { get; set; }

        private void DarNome()
        {
            NomeMinhaMae.AddIdade();
            Idade.SomaMais5();
            Idade.EhPar();
        }
    }
}
