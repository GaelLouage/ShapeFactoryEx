using System.Windows;
using System.Windows.Media;

namespace ShapeFactoryWpfExercise.Factory.Interfaces
{
    public interface IShape
    {
        public UIElement Draw(int width, int height, Brush brush);
    }
}
