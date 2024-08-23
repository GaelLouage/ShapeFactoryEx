using ShapeFactoryWpfExercise.Enums;
using ShapeFactoryWpfExercise.Extensions;
using ShapeFactoryWpfExercise.Factory.Classes;
using ShapeFactoryWpfExercise.Factory.Interfaces;
using ShapeFactoryWpfExercise.Models;
using ShapeFactoryWpfExercise.Services.Classes;
using ShapeFactoryWpfExercise.Services.Interfaces;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShapeFactoryWpfExercise
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IShapeFactory _shapeFactory;
        public MainWindow(IShapeFactory shapeFactory) 
        {
            _shapeFactory = shapeFactory;
        }

        public MainWindow() : this(new ShapeFactory())
        {
            InitializeComponent();
        }
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                Canvas myCanvas = new Canvas();
                this.Content = myCanvas;

                myCanvas.DrawShape(new ShapeEntity
                {
                    Window = this,
                    ShapeFactory = _shapeFactory,
                    ShapeType = Enums.ShapeType.SQUARE,
                    XshapeSize = 50,
                    YshapeSize = 50,
                    WindowHeightPos = 4,
                    WindowXWidthPos = 4,
                });
                myCanvas.DrawShape(new ShapeEntity
                {
                    Window = this,
                    ShapeFactory = _shapeFactory,
                    ShapeType = Enums.ShapeType.CIRCLE,
                    XshapeSize = 50,
                    YshapeSize = 50,
                    WindowHeightPos = 2,
                    WindowXWidthPos = 4,
                });

                myCanvas.DrawShape(new ShapeEntity
                {
                    Window = this,
                    ShapeFactory = _shapeFactory,
                    ShapeType = Enums.ShapeType.RECTANGLE,
                    XshapeSize = 70,
                    YshapeSize = 50,
                    WindowHeightPos = 6,
                    WindowXWidthPos = 2,
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}