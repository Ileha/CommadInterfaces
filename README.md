### About  
This project can help writing command interface for program

### How to use  
For create command interface you should write code like this:  
*This is very simple example*
```cs
int count = 0;
bool execute = true;
CommandArray array = new CommandArray();
array.AddCommand(c => {
    c.Name = () => "hello";//name of command
    c.ArgumentsCount = () => 1;//count of arguments in input
    c.MyData = () => null;//specific data of command
    c.Execute = (object[] arguments) => Console.WriteLine("Hello {0}!!!", arguments[0].ToString());//executable code
});
array.AddCommand(c => {
    c.Name = () => "add";
    c.ArgumentsCount = () => 0;
    c.MyData = () => 100;//adding any data
    c.Execute = (object[] arguments) => {
        int i = c.GetCommandData<int>();
        i++;
        Console.WriteLine(i);
        c.SetData(i);
    };
});
array.AddCommand(c => {
    c.Name = () => "set_count";
    c.ArgumentsCount = () => 1;
    c.MyData = () => null;
    c.Execute = (object[] arguments) => count = Convert.ToInt32(arguments[0]);
});
array.AddCommand(c => {
    c.Name = () => "get_count";
    c.ArgumentsCount = () => 0;
    c.MyData = () => null;
    c.Execute = (object[] arguments) => Console.WriteLine("data count {0}", count);
});
array.AddCommand(c => {
    c.Name = () => "exit";
    c.ArgumentsCount = () => 0;
    c.MyData = () => null;
    c.Execute = (object[] arguments) => execute = false;
});

while (execute) {//this is code parse input data from console and invoke array.Execute with this data
    Console.WriteLine("Enter command");
    string name = Console.ReadLine();
    string[] splited = name.Split(' ');
    string[] args = new string[splited.Length - 1];
    Array.Copy(splited, 1, args, 0, splited.Length - 1);
    array.Execute(splited[0], args);
}
```   
