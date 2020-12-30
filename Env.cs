using System;

namespace dotConsole
{
    /// <summary>
    /// Environment vars, if you need load different way they vars, create other or replace constructor with the implementation necessary
    /// </summary>
    internal class Env
    {
        public Env()
        {
            Log = Environment.GetEnvironmentVariable("LOG") == "1";

            Connection = Environment.GetEnvironmentVariable("CONNECTION");
        }
        public readonly bool Log;

        public readonly string Connection;
    }
}