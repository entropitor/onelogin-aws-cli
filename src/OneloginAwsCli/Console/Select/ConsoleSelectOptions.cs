using System;
using System.Collections.Generic;

namespace OneloginAwsCli.Console.Select
{
    public class ConsoleSelectOptions<T> where T : class
    {
        public string Message { get; set; }
        public IReadOnlyList<T> Items { get; set; }
        public Func<T, bool, string> OnRenderItem { get; set; }
        public int Indent { get; set; } = 2;
        public int DefaultSelectedItem { get; set; } = 0;
        public bool CleanUp { get; set; } = true;
    }
}
