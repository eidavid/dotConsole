using System;
using dotConsole.Contracts;

namespace dotConsole.BusinessLogic
{
    internal class WorkFlow : IProcess
    {
        Log _log;
        ITableData _tableData;
        public WorkFlow(Log log, ITableData tableData)
        {
            _log = log;

            _tableData = tableData;
        }
        public void Execute()
        {
            try
            {

            }
            catch (Exception ex)
            {
                _log.Error("Error at execute process.", ex);
            }
        }
    }
}