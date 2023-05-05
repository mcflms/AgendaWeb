using AgendaWeb.Infra.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaWeb.Infra.Data.Interfaces
{
    /// <summary>
    /// Interface de repositorio para entidade evento
    /// </summary>
    public interface IEventoRepository : IBaseRepository<Evento>
    {/// <summary>
    /// Método para retornar todos os eventos dentro de um periodo de datas 
    /// </summary>
    /// <param name="dataMIN">Data de Inicio do Periodo </param>
    /// <param name="dataMAX">Data de termino do Periodo</param>
    /// <returns>Lista de Eventos</returns>
        List<Evento> GetByDatas(DateTime dataMIN, DateTime dataMAX);
    }
}
