using ShapeSystemLib;
using ShapeSystemLib;

namespace ShapeSystemLib;

public class ShapeService
{
    private readonly ILogger _logger;

    public ShapeService(ILogger logger)
    {
        _logger = logger;
    }

    public void ProcessShape(Shape shape)
    {
        double area = shape.CalculateArea();

        string report =
            $"Shape: {shape.GetType().Name}, Area: {area}, Date: {DateTime.Now}";

        _logger.Log(report);
    }
}
