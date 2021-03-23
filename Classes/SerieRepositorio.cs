using System.Collections.Generic;
using DIO.Series.interfaces;


namespace DIO.Series
{
    public class SerieRepositorio : IRepositorio<Serie>
    {//criamos um repositorio que será a lista serie    



        private List<Serie> listaSerie = new List<Serie>();

        public void Atualizar(int id, Serie objeto) //vai passar como um objeto
        {
            listaSerie[id] = objeto;
        }

    
        public void Excluir(int id)
        {
            listaSerie[id].Excluir();
            //implemento o envio de email
        }

        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto);
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