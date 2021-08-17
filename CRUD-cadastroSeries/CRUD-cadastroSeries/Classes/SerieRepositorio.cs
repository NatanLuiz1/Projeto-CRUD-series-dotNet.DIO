using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_cadastroSeries.Interfaces;

namespace CRUD_cadastroSeries.Classes
{
    class SerieRepositorio : IRepositorio<Serie>
    {

        private List<Serie> listaSerie = new List<Serie>();
        public void Atualiza(int id, Serie idObjeto)
        {
            listaSerie[id] = idObjeto;
        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }

        public void Insere(Serie idObjeto)
        {
            listaSerie.Add(idObjeto);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}
