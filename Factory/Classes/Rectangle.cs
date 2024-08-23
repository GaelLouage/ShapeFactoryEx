using ShapeFactoryWpfExercise.Factory.Interfaces;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using  RectangleShape = System.Windows.Shapes.Rectangle;
namespace ShapeFactoryWpfExercise.Factory.Classes
{
    public class Rectangle : IShape
    {
        public UIElement Draw(int width, int height, Brush brush)
        {
            return new RectangleShape
            {
                Width = width,
                Height = height,
                Fill = brush
            };
        }
    }
}
