using System;

namespace HomeWork
{
    internal class GraphicEditor : Editor
    {
        public GraphicEditor(string name) : base(name)
        {
            new GraphicDocument();
            Console.WriteLine();
        }

        public override Document DocumentCreate()
        {
            return new GraphicDocument();
        }
    }
}
