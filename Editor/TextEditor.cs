using System;

namespace HomeWork
{
    internal class TextEditor : Editor
    {
        public TextEditor(string name) : base(name)
        {
            new TextDocument();
            Console.WriteLine();
        }

        public override Document DocumentCreate()
        {
            return new TextDocument();
        }
    }
}
