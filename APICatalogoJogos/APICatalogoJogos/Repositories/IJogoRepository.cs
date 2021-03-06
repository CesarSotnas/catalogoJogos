using System;
using System.Collections.Generic;
using APICatalogoJogos.Entities;
using System.Threading.Tasks;

namespace APICatalogoJogos.Repositories
{
    public interface IJogoRepository
    {
        Task<List<Jogo>> Obter(int pagina, int quantidade);
        Task<Jogo> Obter(Guid id);
        Task<List<Jogo>> Obter(string nome, string produtora);
        Task Inserir(Jogo jogo);
        Task Atualizar(Jogo jogo);
        Task Remover(Guid id);
    }
}