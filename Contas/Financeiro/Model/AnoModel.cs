using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Financeiro.Entidades;
using Financeiro.Controller;

namespace Financeiro.Model
{
    public class AnoModel
    {
        public static int Inserir(Anos obj)
        {
            return new AnoController().Inserir(obj);
        }

        public List<Anos> Buscar(Anos obj)
        {
            return new AnoController().Buscar(obj);
        }

        private object AnoController()
        {
            throw new NotImplementedException();
        }

        public List<Anos> Listar()
        {
            return new AnoController().Listar();
        }
        public static int Editar(Anos obj)
        {
            return new AnoController().Editar(obj);
        }
        public static int Deletar(Anos obj)
        {
            return new AnoController().Deletar(obj);
        }
    }
}
