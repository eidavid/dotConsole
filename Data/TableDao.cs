using System.Collections.Generic;
using System.Data;
using Dapper;
using dotConsole.Contracts;
using Entities;

namespace dotConsole.Data
{
    internal class TableDao : ITableData
    {
        const string SCRIPT_ADD = "INSERT INTO [TABLE] (Id,Name) values (@Id,Name);";

        const string SCRIPT_UPDATE = "UPDATE [TABLE] SET Name=@Name WHERE Id=@Id;";

        const string SCRIPT_GETLIST = "SELECT * FROM [TABLE];";

        Log _log;
        IDbConnection _connection;
        public TableDao(Log log, IDbConnection connection)
        {
            _log = log;
            
            _connection = connection;
        }

        public int Add(Table tbl)
        {
            var result = _connection.Execute(SCRIPT_ADD);
            
            return result;
        }

        public IEnumerable<Table> GetList()
        {
            var result = _connection.Query<Table>(SCRIPT_GETLIST);

            return result;
        }

        public int Update(Table tbl)
        {
            var result = _connection.Execute(SCRIPT_UPDATE);

            return result;
        }
    }
}