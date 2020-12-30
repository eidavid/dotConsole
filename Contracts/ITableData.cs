using System.Collections.Generic;
using Entities;

namespace dotConsole.Contracts
{
    public interface ITableData
    {
        IEnumerable<Table> GetList();

        int Add(Table tbl);

        int Update(Table tbl);
    }
}