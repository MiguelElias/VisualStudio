using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Financeiro.Entidades;
using Financeiro.Controller;

namespace Financeiro.Model
{
    public class LancModel
    {
        public static int Inserir(Lancamento obj)
        {
            return new LancController().Inserir(obj);
        }
        public List<Lancamento> Buscar(Lancamento obj)
        {
            return new LancController().Buscar(obj);
        }

        public List<Lancamento> BuscarTipo(Lancamento obj)
        {
            return new LancController().BuscarTipo(obj);
        }
        public List<Lancamento> Listar()
        {
            return new LancController().Listar();
        }
        public static int Editar(Lancamento obj)
        {
            return new LancController().Editar(obj);
        }
        public static int Excluir(Lancamento obj)
        {
            return new LancController().Excluir(obj);
        }
        public List<Lancamento> BuscarDataTipoEntrada(Lancamento obj)
        {
            return new LancController().BuscarDataTipoEntrada(obj);
        }
        public List<Lancamento> BuscarDataTipoSaida(Lancamento obj)
        {
            return new LancController().BuscarDataTipoSaida(obj);
        }
    }
}
