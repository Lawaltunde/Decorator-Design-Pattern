
using DecoratorAssigment;
using DecoratorAssigment.Decorators;

//instance of ConcreteComponent
IComponent<string> concreteComponent = new ConcreteComponent();

//instance of UpperCaseDecorator

IComponent<string> upperCaseDecorator = new UpperCaseDecorator(concreteComponent);

//instance of PlainDecorator

IComponent<string> plainDecorator = new PlainDecorator(concreteComponent);

//instance of ColorDecorator

IComponent<string> colorDecorator = new ColorDecorator(concreteComponent);

//calling GetTextMoth on concreteComponent class
Console.WriteLine(concreteComponent.GetText());

//calling GetTextMoth on upperCaseDecorator class

Console.WriteLine(upperCaseDecorator.GetText());

//calling GetTextMoth on plainDecorator class

Console.WriteLine(plainDecorator.GetText());

//calling GetTextMoth on colorDecorator class

Console.WriteLine(colorDecorator.GetText());