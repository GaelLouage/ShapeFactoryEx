using ShapeFactoryWpfExercise.Enums;
using ShapeFactoryWpfExercise.Factory.Classes;
using ShapeFactoryWpfExercise.Factory.Interfaces;
using ShapeFactoryWpfExercise.Services.Interfaces;

namespace ShapeFactoryWpfExercise.Services.Classes
{
    public class ShapeFactory : IShapeFactory
    {
        public IShape GetShape(ShapeType shapeType)
        {
            return shapeType switch
            {
                ShapeType.RECTANGLE => new Rectangle(),
                ShapeType.SQUARE => new Square(),
                ShapeType.CIRCLE => new Circle(),
                _ => throw new NotSupportedException("No such shape!")
            };
        }
    }
}
