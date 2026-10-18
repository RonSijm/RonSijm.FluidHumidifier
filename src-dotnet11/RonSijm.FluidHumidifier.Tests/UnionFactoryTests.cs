using Humidifier;
using Humidifier.Json.Serializer;
using Newtonsoft.Json.Linq;
using RonSijm.FluidHumidifier.Factories;
using RonSijm.FluidHumidifier.Factories.Lambda;
using RonSijm.FluidHumidifier.Factories.Base;
using RonSijm.FluidHumidifier.Features.Consumer;
using RonSijm.FluidHumidifier.Features.Factories.Base;
using RonSijm.FluidHumidifier.Features.Helpers;

namespace RonSijm.FluidHumidifier.Tests;

public class UnionFactoryTests
{
    [Fact]
    public void GeneratedFactoriesBuildNestedObjectsListsAndDeferredReferences()
    {
        var environment = new EnvironmentFactory(new EnvironmentConfig("dev", "1234", "eu-central-1"))
        {
            Decorator = new DecoratorOrchestrator([])
        };
        var stack = environment.AddStack("Functions");
        var role = stack.WithRole("ExecutionRole");
        var function = stack.WithLambdaFunction("Handler", value =>
        {
            value.Timeout = 30;
            value.Role = role.FFnGetAtt("Arn");
        });
        function.WithCode(value => value.ZipFile = "source");
        function.WithVpcConfig(value =>
            value.SubnetIds = new Union<string, BaseFunction>[] { "subnet-a", Fn.Ref("SubnetB") });
        function.WithFileSystemConfigs(value =>
        {
            value.Arn = Fn.Ref("FileSystemArn");
            value.LocalMountPath = "/mnt/data";
        });

        var json = JObject.Parse(new JsonStackSerializer().Serialize(environment.Build().Single()));
        var properties = json["Resources"]![function.Result.ResourceName]!["Properties"]!;
        Assert.Equal(30, (int)properties["Timeout"]!);
        Assert.Equal("source", (string)properties["Code"]!["ZipFile"]!);
        Assert.Equal("SubnetB", (string)properties["VpcConfig"]!["SubnetIds"]![1]!["Ref"]!);
        Assert.Equal("/mnt/data", (string)properties["FileSystemConfigs"]![0]!["LocalMountPath"]!);
        Assert.Equal(role.Result.ResourceName, (string)properties["Role"]!["Fn::GetAtt"]![0]!);
        Assert.Equal("Handler", stack.Decorator.Variables["Lambda_Function"]);
    }

    [Fact]
    public void CollectionHelpersPreserveLiteralAndExpressionEntries()
    {
        var config = new Humidifier.Lambda.FunctionTypes.VpcConfig { SubnetIds = new[] { "a", "b" } };
        Assert.Equal("a", UnionValue.Unwrap(config.SubnetIds.GetItems()[0]));

        var reference = Fn.Ref("SubnetB");
        config.SubnetIds = new Union<string, BaseFunction>[] { "a", reference };
        Assert.Same(reference, UnionValue.Unwrap(config.SubnetIds.GetItems()[1]));
        config.SubnetIds = Fn.Ref("AllSubnets");
        Assert.Throws<InvalidOperationException>(() => config.SubnetIds.GetItems());
        config.SubnetIds = null;
        Assert.Empty(config.SubnetIds.GetItems());
    }

    [Fact]
    public void LiteralAccessRejectsDeferredAndUnsetValues()
    {
        var function = new Humidifier.Lambda.Function { Timeout = 30 };
        Assert.Equal(30, function.Timeout.GetLiteral());
        function.Timeout = Fn.Ref("Timeout");
        Assert.Throws<InvalidOperationException>(() => function.Timeout.GetLiteral());
        function.Timeout = null;
        Assert.Throws<InvalidOperationException>(() => function.Timeout.GetLiteral());
    }
}
