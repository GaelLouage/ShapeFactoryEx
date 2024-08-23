using System.Windows.Controls;
using System.Windows;
using ShapeFactoryWpfExercise.Enums;
using ShapeFactoryWpfExercise.Services.Classes;
using ShapeFactoryWpfExercise.Services.Interfaces;

namespace ShapeFactoryWpfExercise.Models
{
    public class ShapeEntity
    {
        public Window Window { get; set; }
        public IShapeFactory ShapeFactory { get; set; }
        public ShapeType ShapeType { get; set; }
        public int XshapeSize { get; set; }
        public int YshapeSize { get; set; }
        public int WindowXWidthPos { get; set; }
        public int WindowHeightPos { get; set; }
    }
}
