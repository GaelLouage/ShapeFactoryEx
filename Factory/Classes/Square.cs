using ShapeFactoryWpfExercise.Factory.Interfaces;
using System.Windows;
using System.Windows.Media;
using RectangleShape = System.Windows.Shapes.Rectangle;

namespace ShapeFactoryWpfExercise.Factory.Classes
{
    public class Square : IShape
    {
        public UIElement Draw(int width, int height, Brush brush)
        {
            if(height != width)
            {
                throw new ArgumentException("Width and height must be the same value!");
            }
            return  new RectangleShape
            {
                Width = width,
                Height = height,
                Fill = brush
            };
        }
    }
}
