using System;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var textEditor = new TextEditor("Text Editor");
            textEditor.Create();
            textEditor.Open();
            textEditor.Close();
            textEditor.Print();
            textEditor.SavingNewName();
            textEditor.Save();

            Console.WriteLine();

            var graphicEditor = new GraphicEditor("Graphic Editor");
            graphicEditor.Create();
            graphicEditor.Open();
            graphicEditor.Close();
            graphicEditor.Print();
            graphicEditor.SavingNewName();
            graphicEditor.Save();

            Console.WriteLine();
        }
    }
}
