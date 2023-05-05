using AgendaWeb.Infra.Data.Entities;
using AgendaWeb.Infra.Data.Interfaces;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaWeb.Infra.Data.Repositories
{/// <summary>
/// Classe para implementar as operações de banco de dados para Evento
/// </summary>
    public class EventoRepository : IEventoRepository
    {
        //Atributo 
        private readonly string _connectionString;       

        //método construtor utilizado para que possamos passar
        //o valor da connectionString para a classe de repositorio
        public EventoRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Create(Evento obj)
        {
            var query = @"INSERT INTO EVENTO(ID, NOME, DATA, HORA, DESCRICAO, PRIORIDADE, DATAINCLUSAO, DATAALTERACAO, ATIVO) 
                          VALUES (@Id, @Nome, @Data, @Hora, @Descricao, @Prioridade, @DataInclusao, @DataAlteracao, 1)";
            //conectando no banco de dados
            using (var connection = new SqlConnection(_connectionString))
            {
                //executando a gravação do evento na base de dados 
                connection.Execute(query, obj);
            }

        }

        public void Delete(Evento entity)
        {
            throw new NotImplementedException();
        }

        public List<Evento> GetAll()
        {
            throw new NotImplementedException();
        }


        public Evento GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Evento entity)
        {
            throw new NotImplementedException();
        }
        public List<Evento> GetByDatas(DateTime dataMIN, DateTime dataMAX)
        {
            throw new NotImplementedException();
        }
    }
}