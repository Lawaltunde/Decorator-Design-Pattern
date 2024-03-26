
using DecoratorAssigment;

IComponent<string> concreteComponent = new ConcreteComponent();
IComponent<string> upperCaseDecorator = new UpperCaseDecorator(concreteComponent);
IComponent<string> plainDecorator = new PlainDecorator(concreteComponent);
IComponent<string> colorDecorator = new ColorDecorator(concreteComponent);

Console.WriteLine(concreteComponent.GetText());
Console.WriteLine(upperCaseDecorator.GetText());
Console.WriteLine(plainDecorator.GetText());
Console.WriteLine(colorDecorator.GetText());