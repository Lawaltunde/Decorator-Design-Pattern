

using Learning_Decorator_Pattern;

ConcreteComponent concrete = new ConcreteComponent();
ColorDecorator colorDecorator = new ColorDecorator(concrete);
PlainDecorator plainDecorator = new PlainDecorator(concrete);
UpperCaseDecorator upperCaseDecorator = new UpperCaseDecorator(concrete);


Console.WriteLine(colorDecorator.GetText());
Console.WriteLine(plainDecorator.GetText());
Console.WriteLine(upperCaseDecorator.GetText());
