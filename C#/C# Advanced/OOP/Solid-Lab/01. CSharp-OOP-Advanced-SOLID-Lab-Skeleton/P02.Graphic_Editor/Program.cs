using System;

namespace P02.Graphic_Editor
{
    class Program
    {
        static void Main()
        {
            Circle circle = new Circle();

            GraphicEditor graphEditor = new GraphicEditor();

            graphEditor.DrawShape(circle);
        }
    }
}
