// See https://aka.ms/new-console-template for more information



 
using System.Reflection;
using Utilities;

var assembly = Assembly.Load("Utilities");
var assemblyTypes= assembly.GetTypes();
//var assembly = Assembly.LoadFrom(@"D:\MySamples\ReflectionPractice\Utilities\bin\Debug\net7.0\Utilities.dll");



foreach (var type in assemblyTypes)
{
   if (type.Name == "VandarService")
    {
        Console.WriteLine(type.Name);
        Console.WriteLine("================");

        var properties = type.GetProperties();
        var fields = type.GetFields(BindingFlags.NonPublic
                                            | BindingFlags.Instance
                                            | BindingFlags.DeclaredOnly);

        var methods=type.GetMethods(BindingFlags.Public | BindingFlags.Instance );
        var methodsWithDeclared=type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly );

        foreach (var field in fields)
        {
            Console.WriteLine($"field is {field.Name}");
        }


        foreach (var method in methodsWithDeclared)
        {
            Console.WriteLine($"method is {method.Name}");
        }

        foreach (var property in properties)
        {
            if (property.PropertyType.IsEnum)
                Console.WriteLine($"my enum is {property.Name}");

            else
                Console.WriteLine($"property : {property.Name}");
        }
    }




}
