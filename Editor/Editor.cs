using System;

namespace HomeWork
{
    abstract class Editor : IEditor
    {
        public string Name { get; set; }

        public Editor(string name)
        {
            Name = name;
        }

        public void Close()
        {
            Console.WriteLine("Document close");
        }

        public void Create()
        {
            Console.WriteLine("Document create");
        }

        public void Open()
        {
            Console.WriteLine("Document open");
        }

        public void Print()
        {
            Console.WriteLine("Document print");
        }

        public void Save()
        {
            Console.WriteLine("Document save");
        }

        public void SavingNewName()
        {
            Console.WriteLine("Document saving new name");
        }

        public abstract Document DocumentCreate();
    }
}
