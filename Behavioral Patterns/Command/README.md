# Команда (Command)

![command](command.png)

Паттерн "Команда" (Command) позволяет инкапсулировать запрос на выполнение определенного действия в виде отдельного объекта. Этот объект запроса на действие и называется командой. При этом объекты, инициирующие запросы на выполнение действия, отделяются от объектов, которые выполняют это действие.

Команды могут использовать параметры, которые передают ассоциированную с командой информацию. Кроме того, команды могут ставиться в очередь и также могут быть отменены.

> ## Когда использовать команды?
> * Когда надо передавать в качестве параметров определенные действия, вызываемые в ответ на другие действия. То есть когда необходимы функции обратного действия в ответ на определенные действия.
>
> * Когда необходимо обеспечить выполнение очереди запросов, а также их возможную отмену.
>
> * Когда надо поддерживать логгирование изменений в результате запросов. Использование логов может помочь восстановить состояние системы - для этого необходимо будет использовать последовательность запротоколированных команд.

## Abstract example
```csharp
class Program
{
	static void Main(string[] args)
	{
		Invoker invoker = new Invoker();
        Receiver receiver = new Receiver();
		ConcreteCommand command = new ConcreteCommand(receiver);

        invoker.SetCommand(command);
        invoker.Run();
	}
}
```
### Receiver
```csharp
public class Receiver
{
    public void Operation()
    {}
}
```
### Abstract command
```csharp
public abstract class Command
{
    public abstract void Execute();
    public abstract void Undo();
}
```
### Concrete command
```csharp
public class ConcreteCommand : Command
{
    private readonly Receiver receiver;

    public ConcreteCommand(Receiver receiver)
    {
        this.receiver = receiver;
    }

    public override void Execute()
    {
        receiver.Operation();
    }
 
    public override void Undo()
    {}
}
```
```csharp
public class Invoker
{
    private Command command;

    public void SetCommand(Command command)
    {
    	this.command = command;
    }

    public void Run()
    {
        command.Execute();
    }

    public void Cancel()
    {
        command.Undo();
    }
}

