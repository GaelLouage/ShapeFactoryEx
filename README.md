ShapeFactoryWpfExercise
Overview

The ShapeFactoryWpfExercise is a WPF (Windows Presentation Foundation) application that demonstrates the use of the Factory Design Pattern to create and render various shapes on a canvas. This project is a simple yet effective example of how design patterns can be used to improve the flexibility, maintainability, and testability of code in a .NET environment.
Features

    Factory Design Pattern: Dynamically creates instances of shapes (Circle, Square, Rectangle) based on user input or configuration.
    Dependency Injection: Allows for the injection of the shape factory, improving code modularity and enabling easy testing.
    WPF Canvas Rendering: Shapes are drawn on a WPF canvas, showcasing basic UI interaction and rendering capabilities.

Getting Started
Prerequisites

    .NET SDK (version X.X or higher)
    Visual Studio (recommended) or any preferred C# IDE
    Basic understanding of C# and WPF

Installation

    Clone the Repository:

    bash

git clone https://github.com/yourusername/ShapeFactoryWpfExercise.git

Open the Solution: Open the .sln file in Visual Studio or your preferred C# IDE.

Build the Project: Build the solution to restore the necessary NuGet packages and compile the application.

Run the Application: Press F5 in Visual Studio or use the dotnet CLI to run the project:

bash

    dotnet run

Usage

When the application is launched, it will render a WPF window with a canvas containing various shapes (Circle, Square, Rectangle). These shapes are created using the ShapeFactory class, which implements the Factory Design Pattern to instantiate the appropriate shape based on the specified type.
Code Structure

    MainWindow.xaml.cs: The entry point of the WPF application, responsible for initializing the UI and drawing shapes on the canvas.
    IShape Interface: Defines the contract for shape classes, requiring a Draw method.
    ShapeFactory: Implements the factory pattern to create instances of shapes based on the ShapeType enum.
    ShapeEntity: A model class that holds information about the shape, including its size, type, and position.
    UIElementExtensions: A static class that contains extension methods for drawing shapes on a WPF canvas.
    Enums/ShapeType.cs: Contains the enumeration for different types of shapes.

Example Usage in Code

csharp

public MainWindow() : this(new ShapeFactory())
{
    InitializeComponent();
}

private void Grid_Loaded(object sender, RoutedEventArgs e)
{
    Canvas myCanvas = new Canvas();
    this.Content = myCanvas;

    myCanvas.DrawShape(new ShapeEntity
    {
        Window = this,
        ShapeFactory = _shapeFactory,
        ShapeType = ShapeType.SQUARE,
        XshapeSize = 50,
        YshapeSize = 50,
        WindowHeightPos = 4,
        WindowXWidthPos = 4,
    });

    // Add more shapes as needed...
}

Extending the Project

This project can be easily extended in several ways:

    Add New Shapes: Implement additional shapes by creating new classes that implement the IShape interface.
    Enhance UI: Improve the user interface by adding controls that allow dynamic shape creation, resizing, or changing colors.
    Unit Testing: Add unit tests to ensure the correctness of the factory pattern implementation and the rendering logic.

Contributing

If you would like to contribute to this project, feel free to submit a pull request. Contributions are welcome and encouraged!
How to Contribute

    Fork the repository.
    Create a new branch (git checkout -b feature/YourFeature).
    Commit your changes (git commit -am 'Add YourFeature').
    Push to the branch (git push origin feature/YourFeature).
    Create a new Pull Request.
