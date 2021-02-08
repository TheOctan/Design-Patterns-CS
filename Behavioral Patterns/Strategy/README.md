# Стратегия (Strategy)

![strategy](strategy.png)

Паттерн Стратегия (Strategy) представляет шаблон проектирования, который определяет набор алгоритмов, инкапсулирует каждый из них и обеспечивает их взаимозаменяемость. В зависимости от ситуации мы можем легко заменить один используемый алгоритм другим. При этом замена алгоритма происходит независимо от объекта, который использует данный алгоритм.

> ## Когда использовать стратегию?
> * Когда есть несколько родственных классов, которые отличаются поведением. Можно задать один основной класс, а разные варианты поведения вынести в отдельные классы и при необходимости их применять
>
> * Когда необходимо обеспечить выбор из нескольких вариантов алгоритмов, которые можно легко менять в зависимости от условий
>
> * Когда необходимо менять поведение объектов на стадии выполнения программы
>
> * Когда класс, применяющий определенную функциональность, ничего не должен знать о ее реализации

## Example
```csharp
class Program
{
	static void Main(string[] args)
	{
		LogSystem logger = new LogSystem();
		logger.Printer = new ConsolePrinter();

		logger.Log("Hello Wolrd");
	}
}
```

### Context
```csharp
public class LogSystem
{
	public IPrinter Printer { get; set; }

	public void Log(string message)
	{
		printer?.Print(message);
	}
}
```

### Interface definitions
```csharp
public interface IPrinter
{
	void Print(string message);
}
```

### Concerete strategy
```csharp
public class ConsolePrinter : IPrinter
{
	public void Print(string message);
	{
		Console.WriteLine(message);
	}
}
```