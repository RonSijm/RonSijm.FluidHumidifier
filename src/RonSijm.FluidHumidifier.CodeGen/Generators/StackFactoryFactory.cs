using System.Threading.Tasks;
using Humidifier.CodeGen.Lib.Features.JsonToModels.Models;

namespace RonSijm.FluidHumidifier.CodeGen.CLI.Generators
{
    public class StackFactoryFactory
    {
        public async Task Create(List<(string name, ResourceType re)> namedResources)
        {
            var outputPath = CodeGenSettings.OutputPath;

            var bob = new StringBuilder();

            var name = "Stack";


            var fullyQuantifiedClassName = $"Stack";

            bob.AppendLine("using RonSijm.FluidHumidifier.Features.Decorating.ReflectionHelpers;");
            bob.AppendLine("using RonSijm.FluidHumidifier.Features.Factories.Interfaces;");
            bob.AppendLine($"");

            bob.AppendLine($"namespace RonSijm.FluidHumidifier.Factories;");
            bob.AppendLine($"");

            bob.AppendLine($"public class StackFactory : Features.Factories.Base.BaseFactory<Stack>, IHaveStack");
            bob.AppendLine($"{{");

            bob.AppendLine($"    public StackFactory(string stackName = null, Action<Stack> factoryAction = null)");
            bob.AppendLine($"    {{");
            bob.AppendLine($"        var stack = new Stack();");
            bob.AppendLine($"        factoryAction?.Invoke(stack);");
            bob.AppendLine($"");
            bob.AppendLine($"        Stack = stack;");
            bob.AppendLine($"    }}");

            bob.AppendLine($"    public Stack Stack {{ get; set; }}");

            foreach (var (resourceName, resourceType) in namedResources)
            {
                bob.AppendLine($"    private List<{resourceType.Group}.{resourceType.ClassName}Factory> {resourceName}Factories {{ get; set; }} = [];");
                bob.AppendLine($"");
            }

            bob.AppendLine($"    protected override {fullyQuantifiedClassName} Create()");
            bob.AppendLine($"    {{");
            bob.AppendLine($"        WireChildStack(Stack);");
            bob.AppendLine($"        return Stack;");
            bob.AppendLine($"    }}");
            bob.AppendLine($"");


            foreach (var (resourceName, resourceType) in namedResources)
            {
                bob.AppendLine($"    public {resourceType.Group}.{resourceType.ClassName}Factory With{resourceName}(string resourceName = null, Action<Humidifier.{resourceType.Group}.{resourceType.ClassName}> resourceFactoryAction = null)");
                bob.AppendLine($"    {{");
                bob.AppendLine($"        var factory = this.CreateSubFactory(() => new {resourceType.Group}.{resourceType.ClassName}Factory(resourceName, resourceFactoryAction));");
                bob.AppendLine($"        {resourceName}Factories.Add(factory);");
                bob.AppendLine($"        return factory;");
                bob.AppendLine($"    }}");
                bob.AppendLine($"");
            }

            foreach (var (resourceName, resourceType) in namedResources)
            {
                bob.AppendLine($"    public {resourceType.Group}.{resourceType.ClassName}Factory With{resourceName}(Action<Humidifier.{resourceType.Group}.{resourceType.ClassName}> resourceFactoryAction = null, string resourceName = null)");
                bob.AppendLine($"    {{");
                bob.AppendLine($"        var factory = this.CreateSubFactory(() => new {resourceType.Group}.{resourceType.ClassName}Factory(resourceName, resourceFactoryAction));");
                bob.AppendLine($"        {resourceName}Factories.Add(factory);");
                bob.AppendLine($"        return factory;");
                bob.AppendLine($"    }}");
                bob.AppendLine($"");
            }

            bob.AppendLine($"    public override void CreateChildren(Stack result)");
            bob.AppendLine($"    {{");
            bob.AppendLine($"        this.DoForAllProperties<IStackFactory>(childFactory =>");
            bob.AppendLine($"        {{");
            bob.AppendLine($"            childFactory.InvokeBuild();");
            bob.AppendLine($"        }});");
            bob.AppendLine($"    }}");

            bob.AppendLine($"");
            bob.AppendLine($"}}");

            var result = bob.ToString();

            var directory = $"{outputPath}\\";

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            var file = $"{directory}\\{name}Factory.cs";

            await File.WriteAllTextAsync(file, result);
        }
    }
}