using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;
using ShapeFactoryWpfExercise.Models;

namespace ShapeFactoryWpfExercise.Extensions
{
    public static class UIElementExtensions
    {
        public static UIElement DrawShape(this Canvas canvas, ShapeEntity shape)
        {
            var shapeToDraw = shape.ShapeFactory.GetShape(shape.ShapeType)
                                 .Draw(shape.XshapeSize, shape.YshapeSize, Brushes.Blue);
            Canvas.SetLeft(shapeToDraw, shape.Window.Width / shape.WindowXWidthPos);
            Canvas.SetTop(shapeToDraw, shape.Window.Height / shape.WindowHeightPos);
            canvas.Children.Add(shapeToDraw);
            return shapeToDraw;
        }
    }
}
