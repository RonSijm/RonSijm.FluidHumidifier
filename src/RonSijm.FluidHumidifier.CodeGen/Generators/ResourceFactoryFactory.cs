using System.Threading.Tasks;
using Humidifier.CodeGen.Lib.Features.JsonToModels.Models;
using RonSijm.FluidHumidifier.CodeGen.CLI.Helpers;

namespace RonSijm.FluidHumidifier.CodeGen.CLI.Generators
{
    public class ResourceFactoryFactory
    {
        public HashSet<string> GeneratedResources = new();

        public async Task Create(Specification specification, IClassType resource, string serviceName, bool isResource)
        {
            // Preventing a stack overflow with recursive resources.
            var resourceName = $"{serviceName}{isResource}{resource.Group}.{resource.ClassName}";

            if (!GeneratedResources.Add(resourceName))
            {
                return;
            }

            Console.WriteLine($"Generated: {isResource} {serviceName} {resource.ClassName}");


            var outputPath = CodeGenSettings.OutputPath;

            var bob = new StringBuilder();

            var name = isResource ? resource.ClassName : $"Inner{serviceName}{resource.ClassName}";

            var singularClassTypes = new List<Property>();
            var listClassTypes = new List<Property>();

            string fullyQuantifiedClassName;

            if (isResource)
            {
                fullyQuantifiedClassName = $"Humidifier.{resource.Group}.{resource.ClassName}";
            }
            else
            {
                fullyQuantifiedClassName = $"Humidifier.{resource.Group}.{serviceName}Types.{resource.ClassName}";
            }

            var subTypeNamespace = $"Humidifier.{resource.Group}.{serviceName}Types.";

            if (resource.Properties != null)
            {
                var allSingularClassTypes = resource.Properties.Where(x => x.PrimitiveType != "String" && x.PrimitiveType != "Boolean" && x.PrimitiveType != "Integer" && x.Type != "List").ToList();
                singularClassTypes = allSingularClassTypes.Where(classType => specification.PropertyTypes.Any(x => x.Group == resource.Group && x.ResourceClassName == serviceName && x.ClassName == classType.Type)).ToList();

                var allListClassTypes = resource.Properties.Where(x => x.PrimitiveType != "String" && x.PrimitiveType != "Boolean" && x.PrimitiveType != "Integer" && x.Type == "List").ToList();
                listClassTypes = allListClassTypes.Where(listClassType => specification.PropertyTypes.Any(x => x.Group == resource.Group && x.ResourceClassName == resource.ClassName && x.ClassName == listClassType.ItemType)).ToList();
            }

            bob.AppendLine("// ReSharper disable InconsistentNaming");
            bob.AppendLine("// ReSharper disable UnusedMember.Global");
            bob.AppendLine("// ReSharper disable RedundantNameQualifier");
            bob.AppendLine($"");
            bob.AppendLine($"namespace RonSijm.FluidHumidifier.Factories.{resource.Group};");
            bob.AppendLine($"");

            if (isResource)
            {
                bob.AppendLine($"public class {name}Factory(string resourceName = null, Action<{fullyQuantifiedClassName}> factoryAction = null) : ResourceFactory<{fullyQuantifiedClassName}>(resourceName)");
            }
            else
            {
                bob.AppendLine($"public class {name}Factory(Action<{fullyQuantifiedClassName}> factoryAction = null) : SubResourceFactory<{fullyQuantifiedClassName}>");
            }

            bob.AppendLine($"{{");

            foreach (var listClassType in listClassTypes)
            {
                bob.AppendLine($"");
                bob.AppendLine($"    internal List<Inner{serviceName}{listClassType.ItemType}Factory> {listClassType.Name}Factories {{ get; set; }} = [];");
            }

            foreach (var classType in singularClassTypes)
            {
                bob.AppendLine($"");
                bob.AppendLine($"    internal Inner{serviceName}{classType.Type}Factory {classType.Name}Factory {{ get; set; }}");
            }

            var hasChildResources = listClassTypes.Any() || singularClassTypes.Any();

            // Adding "Result" to the variable name to prevent naming conflicts with the properties, and reserved names like "Attibutes" or "Namespace"
            var variableName = $"{resource.ClassName.FirstCharToLower()}Result";

            bob.AppendLine($"");
            bob.AppendLine($"    protected override {fullyQuantifiedClassName} Create()");
            bob.AppendLine($"    {{");
            bob.AppendLine($"        var {variableName} = Create{resource.ClassName}();");
            bob.AppendLine($"        factoryAction?.Invoke({variableName});");
            bob.AppendLine($"");
            bob.AppendLine($"        return {variableName};");
            bob.AppendLine($"    }}");
            bob.AppendLine($"");
            bob.AppendLine($"    private {fullyQuantifiedClassName} Create{resource.ClassName}()");
            bob.AppendLine($"    {{");
            bob.Append($"        var {variableName} = new {fullyQuantifiedClassName}");

            if (isResource)
            {
                bob.AppendLine();
                bob.AppendLine($"        {{");
            }
            else
            {
                bob.AppendLine($"();");
            }

            if (isResource)
            {
                bob.AppendLine($"            GivenName = InputResourceName,");
                bob.AppendLine($"        }};");
            }

            bob.AppendLine($"");
            bob.AppendLine($"        return {variableName};");
            bob.AppendLine($"    }}");

            if (hasChildResources)
            {
                bob.AppendLine($"    public override void CreateChildren({fullyQuantifiedClassName} result)");
                bob.AppendLine($"    {{");
                bob.AppendLine($"        base.CreateChildren(result);");
                bob.AppendLine();

                foreach (var listClassType in listClassTypes)
                {
                    bob.AppendLine($"        result.{listClassType.Name} = {listClassType.Name}Factories.Any() ? {listClassType.Name}Factories.Select(x => x.Build()).ToList() : null;");
                }

                foreach (var classType in singularClassTypes)
                {
                    bob.AppendLine($"        result.{classType.Name} ??= {classType.Name}Factory?.Build();");
                }

                bob.AppendLine($"    }}");
            }

            bob.AppendLine($"");
            bob.AppendLine($"}} // End Of Class");

            bob.AppendLine($"");
            bob.AppendLine($"public static class {name}FactoryExtensions");
            bob.AppendLine($"{{");

            var maxDepth = 4;

            foreach (var listClassType in listClassTypes)
            {
                ListClassMethods(bob, name, serviceName, listClassType.ItemType, listClassType.Name, subTypeNamespace);
            }

            foreach (var classType in singularClassTypes)
            {
                SingleClassMethods(bob, name, serviceName, classType.Type, classType.Name, subTypeNamespace);
            }

            foreach (var listClassType in listClassTypes)
            {
                for (var depth = 1; depth <= maxDepth; depth++)
                {
                    GenerateOverloadMethods(depth, bob, name, serviceName, listClassType.ItemType, listClassType.Name, subTypeNamespace);
                }
            }

            foreach (var classType in singularClassTypes)
            {
                for (var depth = 1; depth <= maxDepth; depth++)
                {
                    GenerateOverloadMethods(depth, bob, name, serviceName, classType.Type, classType.Name, subTypeNamespace);
                }
            }

            bob.AppendLine($"}}");
            var result = bob.ToString();

            var directory = $"{outputPath}\\{resource.Group}\\";

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            var file = $"{directory}\\{name}Factory.cs";

            await File.WriteAllTextAsync(file, result);

            // TODO: Unify properties that are the same classes

            foreach (var listClassType in listClassTypes)
            {
                var innerResource = specification.PropertyTypes.SingleOrDefault(x => x.Group == resource.Group && x.ResourceClassName == resource.ClassName && x.ClassName == listClassType.ItemType);

                if (innerResource == null)
                {

                }

                await Create(specification, innerResource, serviceName, false);
            }

            foreach (var classType in singularClassTypes)
            {
                var innerResourcesService = specification.PropertyTypes.Where(x => x.Group == resource.Group && x.ResourceClassName == serviceName && x.ClassName == classType.Type).ToList();
                var innerResources = specification.PropertyTypes.Where(x => x.Group == resource.Group && x.ClassName == classType.Type).ToList();

                var innerResource = specification.PropertyTypes.SingleOrDefault(x => x.Group == resource.Group && x.ResourceClassName == serviceName && x.ClassName == classType.Type);

                if (innerResource == null)
                {

                }

                await Create(specification, innerResource, serviceName, false);
            }
        }

        public static void ListClassMethods(StringBuilder bob, string name, string serviceName, string classType, string className, string subTypeNamespace)
        {
            bob.AppendLine($"    public static CombinedResult<{name}Factory, Inner{serviceName}{classType}Factory> With{className}(this {name}Factory parentFactory, Action<{subTypeNamespace}{classType}> subFactoryAction = null)");
            bob.AppendLine($"    {{");
            bob.AppendLine($"        var factory = new Inner{serviceName}{classType}Factory(subFactoryAction);");
            bob.AppendLine($"        parentFactory.{className}Factories.Add(factory);");
            bob.AppendLine($"        return CombinedResultFactory.Create(parentFactory, factory);");
            bob.AppendLine($"    }}");
        }


        public static void SingleClassMethods(StringBuilder bob, string name, string serviceName, string classType, string className, string subTypeNamespace)
        {
            bob.AppendLine($"    public static CombinedResult<{name}Factory, Inner{serviceName}{classType}Factory> With{className}(this {name}Factory parentFactory, Action<{subTypeNamespace}{classType}> subFactoryAction = null)");
            bob.AppendLine($"    {{");
            bob.AppendLine($"        parentFactory.{className}Factory = new Inner{serviceName}{classType}Factory(subFactoryAction);");
            bob.AppendLine($"        return CombinedResultFactory.Create(parentFactory, parentFactory.{className}Factory);");
            bob.AppendLine($"    }}");
            bob.AppendLine();
        }

        private static void GenerateOverloadMethods(int depth, StringBuilder bob, string name, string serviceName, string classType, string className, string subTypeNamespace)
        {
            for (var factoryPosition = 1; factoryPosition <= depth + 1; factoryPosition++)
            {
                var methodGenericTypes = Enumerable.Range(1, depth - 1).Select(i => $"T{i}").ToList();

                var genericTypes = Enumerable.Range(1, depth).Select(i => $"T{i}").ToList();
                var resultIdentifier = string.Join(", ", genericTypes);

                var methodGenerics = $"<{resultIdentifier}>";
                var parentFactory = $"combinedResult.T{factoryPosition}";
                var actionParam = $"Action<{subTypeNamespace}{classType}> subFactoryAction = null";

                var inputType = CreateInputType(depth, name, factoryPosition, genericTypes, resultIdentifier);
                var methodParameters = $"(this {inputType} combinedResult, {actionParam})";

                var subFactoryInvocation = $"With{className}(combinedResult.T{factoryPosition}, subFactoryAction)";

                var resultTypes = string.Join(", ", Enumerable.Range(1, depth + 1).Select(_ => $"combinedResult").ToList());

                var returnType = inputType[..^1] + $", Inner{serviceName}{classType}Factory>";

                bob.AppendLine($"    public static {returnType} With{className}<{resultIdentifier}>{methodParameters} => new ({resultTypes}, {subFactoryInvocation});");
            }
        }

        private static string CreateInputType(int depth, string name, int factoryPosition, List<string> genericTypes, string resultIdentifier)
        {
            string inputType;
            if (factoryPosition <= depth)
            {
                var tempTypes = genericTypes.ToList();
                tempTypes.Insert(factoryPosition - 1, $"{name}Factory");
                inputType = $"CombinedResult<{string.Join(", ", tempTypes)}>";
            }
            else
            {
                inputType = $"CombinedResult<{resultIdentifier}, {name}Factory>";
            }

            return inputType;
        }
    }
}