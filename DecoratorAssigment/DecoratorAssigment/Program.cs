
using DecoratorAssigment;

IComponent<string> concreteComponent = new ConcreteComponent();
IComponent<string> upperCaseDecorator = new UpperCaseDecorator(concreteComponent);

Console.WriteLine(concreteComponent.GetText());
Console.WriteLine(upperCaseDecorator.GetText());    