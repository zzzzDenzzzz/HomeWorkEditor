using System;

namespace HomeWork
{
    internal class GraphicDocument : Document
    {
        public GraphicDocument()
        {
            Info();
        }

        public override void Info()
        {
            Console.WriteLine(typeof(GraphicDocument).Name);
        }
    }
}
