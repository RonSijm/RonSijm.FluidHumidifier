using Humidifier.CodeGen.Lib.Features.JsonToModels.Models;

namespace RonSijm.FluidHumidifier.CodeGen.CLI.Generators.PropertyGenerators
{
    public class VPCIdExtensionsGenerator : BaseExtensionsGenerator
    {
        protected override string Parent => "VPC";
        protected override string ParentGroup => "EC2";

        protected override bool CanHandle(ResourceType resource)
        {
            return resource.Name != "AWS::EC2::VPC" && resource.Properties.Any(x => x.Name == "VpcId");
        }

        protected override string GenerateCode(string resourceName, ResourceType resource)
        {
            var bob = new StringBuilder();

            bob.AppendLine("// ReSharper disable InconsistentNaming");
            bob.AppendLine("// ReSharper disable RedundantUsingDirective");
            bob.AppendLine("// ReSharper disable RedundantNameQualifier");
            //bob.AppendLine($"");
            //bob.AppendLine($"using Humidifier.{resource.Group};");
            bob.AppendLine($"");
            bob.AppendLine($"namespace RonSijm.FluidHumidifier.Factories.{ParentGroup};");
            bob.AppendLine($"");
            bob.AppendLine($"public static class {Parent}With{resourceName}Extension");
            bob.AppendLine($"{{");
            bob.AppendLine($"    public static CombinedResult<VPCFactory, {resource.Group}.{resource.ClassName}Factory> With{resource.ClassName}(this EC2.VPCFactory factory, string resourceName, Action<Humidifier.{resource.Group}.{resource.ClassName}> action = null)");
            bob.AppendLine($"    {{");
            bob.AppendLine($"        var childResourceFactory = factory.CreateSubFactory(() => new {resource.Group}.{resource.ClassName}Factory(resourceName, action));");
            bob.AppendLine($"");
            bob.AppendLine($"        var vpcAction = new Action<Humidifier.EC2.VPC>(_ =>");
            bob.AppendLine($"        {{");
            bob.AppendLine($"            var subResource = childResourceFactory.Build();");
            bob.AppendLine($"            subResource.DependsOn = FFn.FFNamedList(factory);");
            bob.AppendLine($"            subResource.VpcId = FFn.FFnREF(factory);");
            bob.AppendLine($"        }});");
            bob.AppendLine($"");
            bob.AppendLine($"        factory.ExtendedActions.Enqueue(vpcAction);");
            bob.AppendLine($"");
            bob.AppendLine($"        return new CombinedResult<VPCFactory, {resource.Group}.{resource.ClassName}Factory>(factory, childResourceFactory);");
            bob.AppendLine($"    }}");
            bob.AppendLine($"}}");

            var result = bob.ToString();

            return result;
        }
    }
}