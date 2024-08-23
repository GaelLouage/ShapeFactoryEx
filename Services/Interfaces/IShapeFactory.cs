using ShapeFactoryWpfExercise.Enums;
using ShapeFactoryWpfExercise.Factory.Interfaces;

namespace ShapeFactoryWpfExercise.Services.Interfaces
{
    public interface IShapeFactory
    {
        IShape GetShape(ShapeType shapeType);
    }
}