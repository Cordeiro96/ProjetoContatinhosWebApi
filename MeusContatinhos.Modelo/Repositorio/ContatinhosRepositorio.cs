using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MeusContatinhos.Dominio.Modelo;

namespace MeusContatinhos.Dominio.Repositorio
{
    public class ContatinhosRepositorio
    {
        List<Contato> lstContatos;
        public ContatinhosRepositorio()
        {
            lstContatos = new List<Contato>();
            lstContatos.Add(new Contato() { Id = 1, Idade = 31, Nome = "Thamirys", Telefone = "(11) 98767-1168" });
            lstContatos.Add(new Contato() { Id = 2, Idade = 33, Nome = "Diego", Telefone = "(11) 99999-9999" });
            lstContatos.Add(new Contato() { Id = 3, Idade = 35, Nome = "Tiago", Telefone = "(11) 88888-8888" });
            lstContatos.Add(new Contato() { Id = 4, Idade = 5, Nome = "Joao", Telefone = "(11) 77777-7777" });
            lstContatos.Add(new Contato() { Id = 5, Idade = 96, Nome = "Maria", Telefone = "(11) 66666-6666" });
        }
        public Contato BuscarPorNome(string nome)
        {
            return lstContatos.FirstOrDefault(x => x.Nome.ToLower() == nome.ToLower());
        }

        public Contato BuscarPorTel(string tel)
        {
            return lstContatos.FirstOrDefault(x => x.Telefone == tel);
        }

        public List<Contato> Adicionar(Contato contato)
        {
            lstContatos.Add(contato);
            return lstContatos;
        }

        public List<Contato> Alterar(int id, Contato contato)
        {
            lstContatos.FirstOrDefault(x => x.Id == id).Nome = contato.Nome;
            lstContatos.FirstOrDefault(x => x.Id == id).Telefone = contato.Telefone;
            return lstContatos;
        }

        public List<Contato> Excluir(int id)
        {
            lstContatos.Remove(lstContatos.FirstOrDefault(x => x.Id == id));
            return lstContatos;
        }

        public List<Contato> SelecionarTodos()
        {
            return lstContatos.OrderBy(x => x.Nome).ToList();
        }

        public bool ExisteEstaPessoa(string nome)
        {
            return lstContatos.Any(x => x.Nome.ToLower() == nome.ToLower());
        }

        public bool SaoMaioresDeIdade(string idade)
        {
            try
            {
                idade.ColocarGameiro();                

                if (int.TryParse(idade, out int idadeLimite))
                    return lstContatos.All(x => x.Idade > idadeLimite);
                else
                    return lstContatos.All(x => x.Idade > 18);
            }
            catch (Exception ex)
            {
                throw new Exception($"Nao foi possivel verificar se contatos sao " +
                    $"maiores que a idade {idade}, " +
                    $"{ex.Message}");
            }           
        }

    }
}
