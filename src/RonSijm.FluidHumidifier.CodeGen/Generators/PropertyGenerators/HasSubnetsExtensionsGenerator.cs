using Humidifier.CodeGen.Lib.Features.JsonToModels.Models;

namespace RonSijm.FluidHumidifier.CodeGen.CLI.Generators.PropertyGenerators
{
    public class HasSubnetsExtensionsGenerator : BaseExtensionsGenerator
    {
        protected override string Parent => "VPC";
        protected override string ParentGroup => "EC2";

        protected override string FileNameAppendage => "WithSubnetGroupAndSubnets";

        protected override bool CanHandle(ResourceType resource)
        {
            return resource.Properties.Any(x => x.Name == "SubnetIds");
        }

        protected override string GenerateCode(string resourceName, ResourceType resource)
        {
            var bob = new StringBuilder();

            bob.AppendLine($"// ReSharper disable InconsistentNaming");
            bob.AppendLine($"// ReSharper disable RedundantUsingDirective");
            bob.AppendLine($"// ReSharper disable UnusedType.Global");
            bob.AppendLine($"");
            bob.AppendLine($"using Humidifier.EC2;");
            bob.AppendLine($"using Humidifier.Interfaces;");
            bob.AppendLine($"using RonSijm.FluidHumidifier.Factories.{resource.Group};");
            bob.AppendLine($"using RonSijm.FluidHumidifier.Factories.Custom.SubnetFactories;");
            bob.AppendLine($"");
            bob.AppendLine($"namespace RonSijm.FluidHumidifier.Factories.{ParentGroup};");
            bob.AppendLine($"");

            var name = $"{resource.Group}{resource.ClassName}";
            if (!name.EndsWith("SubnetGroup"))
            {
                name += "SubnetGroup";
            }

            bob.AppendLine($"public static class {name}WithSubnetsExtension");
            bob.AppendLine($"{{");
            bob.AppendLine($"    public static {resource.ClassName}Factory With{name}AndSubnets(this VPCFactory factory, string subnetName, Action<SubnetFactoryConfig> config)");
            bob.AppendLine($"    {{");
            bob.AppendLine($"        var subnets = new List<IResultFactory>();");
            bob.AppendLine($"        var dbSubnetGroupFactory = factory.CreateSubFactory(() => new {resource.ClassName}Factory($\"{{subnetName}} Subnet Group\", x =>");
            bob.AppendLine($"        {{");
            bob.AppendLine($"            x.SubnetIds = FFn.FFnREFList(subnets);");
            bob.AppendLine($"            x.DependsOn = FFn.FFNamedList(subnets);");

            if (resource.Properties.Any(x => x.Name == "Description"))
            {
                bob.AppendLine($"            x.Description = \"Default Subnet Group for {resource.Group}\";");
            }

            bob.AppendLine($"        }}));");
            bob.AppendLine($"");
            bob.AppendLine($"        factory.WithSubnets(subnetName, config, subnets, () => dbSubnetGroupFactory.Build());");
            bob.AppendLine($"");
            bob.AppendLine($"        factory.ExtendedSubFactories.Add(dbSubnetGroupFactory);");
            bob.AppendLine($"");
            bob.AppendLine($"        return dbSubnetGroupFactory;");
            bob.AppendLine($"    }}");
            bob.AppendLine($"}}");

            var result = bob.ToString();

            return result;
        }
    }
}