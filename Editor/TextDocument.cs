using System;

namespace HomeWork
{
    internal class TextDocument : Document
    {
        public TextDocument()
        {
            Info();
        }

        public override void Info()
        {
            Console.WriteLine(typeof(TextDocument).Name);
        }
    }
}
