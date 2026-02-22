using ShapeSystemLib;


ILogger logger = new ConsoleLogger();
ShapeService service = new ShapeService(logger);

Shape circle = new Circle(5);
Shape rectangle = new Rectangle(4, 6);

service.ProcessShape(circle);
service.ProcessShape(rectangle);