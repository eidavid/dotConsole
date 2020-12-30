using System;

namespace dotConsole
{
    /// <summary>
    /// Write log in console
    /// </summary>
    internal class Log
    {
        private readonly Env _env;
        public Log(Env env)
        {
            _env = env;
        }
        public void Info(string message)
        {
            if (_env.Log)
                Console.WriteLine(message);
        }

        public void Error(string message, Exception ex)
        {
            Console.WriteLine($"Error ::: {message} | {ex.Message} || {ex.InnerException}");
        }
    }
}