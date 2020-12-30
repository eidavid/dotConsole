using System.Collections.Concurrent;
using System;
using dotConsole.Data;
using MySqlConnector;
using dotConsole.Contracts;
using dotConsole.BusinessLogic;

namespace dotConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize Log
            var env = new Env();
            var log = new Log(env);

            //Initialize connection
            var connection = new MySqlConnection();
            var data = new TableDao(log, connection);

            IProcess process = new WorkFlow(log, data);

            log.Info("Init Process.");
            process.Execute();
            log.Info("Finished Process.");
            
        }
    }
}
