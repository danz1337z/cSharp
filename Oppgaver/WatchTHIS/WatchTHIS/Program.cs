using System;

namespace WatchTHIS;


public class hei
{
    public static void Main(String[] args)
    {
        var cm = new CommandManager();

        Console.WriteLine("Enter command.");
        var input = Console.ReadLine();
        cm.Send(input);
    }
}

public class CommandManager
{
    private List<ICommand> _commands = new List<ICommand>();

    public CommandManager()
    {
        _commands.Add(new HelloCommand());
        _commands.Add(new Hello2Command());
        _commands.Add(new Hello3Command()); 
    }

    public void Send(string name)
    {
        ICommand? command = _commands.FirstOrDefault(x => x.Name == name);
        command?.Run();
    }
}



public interface ICommand
{
    public string Name { get; set; }
    void Run();
}

public class HelloCommand : ICommand
{
    public string Name { get; set; } = "hello";

    public void Run()
    {
        Console.WriteLine("Fuck off");
    }
}

public class Hello2Command : ICommand
{
    public string Name { get; set; } = "hello2";

    public void Run()
    {
        Console.WriteLine("oreuhiure");
    }
}

public class Hello3Command : ICommand
{
    public string Name { get; set; } = "hello3";

    public void Run()
    {
        Console.WriteLine("Yoo");
    }
}