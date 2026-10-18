using AppleStore.AWS.NimbusFactory.CLI.Features.OTAPAccounts.StacksForOTAP.ECSServicesStack;
using AppleStore.AWS.NimbusFactory.Tests.Base;
using Humidifier.Helpers;
using RonSijm.FluidHumidifier.Factories.ElasticLoadBalancingV2;
using RonSijm.FluidHumidifier.Factories.IAM;
using RonSijm.FluidHumidifier.Features.Consumer;
using RonSijm.FluidHumidifier.Features.Factories.Base;

namespace AppleStore.AWS.NimbusFactory.Tests.Stacks;

public class TestCreateECSServicesStackFactoryWithInjectedProperty : BaseBuilderBuilderTest<ECSServiceStackComposer>
{
    protected override Task<Stack> BuildStack()
    {
        var roleFactory = new RoleFactory("RF")
        {
            Decorator = new DecoratorOrchestrator([]),
            Stack = new Stack()
        };
        roleFactory.Build();

        var ecsServiceStackConfig = new ECSServiceStackConfig()
        {
            AssetsAccountId = "111111111111",
            LoadBalancer = new WithFallback<StringValue>("LB"),
            DockerSubnets = new WithFallback<StringListValue>(Fn.Literal("DSB")),
            TaskRole = new WithFallback<RoleFactory>(roleFactory),
            CreateServices = true,
        };

        var result = SUT.Create(ecsServiceStackConfig);

        var stack = result.Stack;

        return Task.FromResult(stack);
    }
}

public class TestCreateECSServicesStackFactoryWithImportedTargetGroupProperty : BaseBuilderBuilderTest<ECSServiceStackComposer>
{
    protected override Task<Stack> BuildStack()
    {
        var decoratorOrchestrator = new DecoratorOrchestrator([]);
        var stack = new Stack();

        var roleFactory = new RoleFactory("RF")
        {
            Decorator = decoratorOrchestrator,
            Stack = stack
        };

        roleFactory.Build();

        var ecsTargetGroup = new TargetGroupFactory("AppleStore-Puma-LB-dev-LB-TG")
        {
            Stack = stack,
            Decorator = decoratorOrchestrator
        };

        var targetGroup = ecsTargetGroup.Build();

        var ecsServiceStackConfig = new ECSServiceStackConfig()
        {
            AssetsAccountId = "111111111111",
            Import = new ImportModel(ecsTargetGroup),
            DockerSubnets = new WithFallback<StringListValue>(Fn.Literal("DSB")),
            TaskRole = new WithFallback<RoleFactory>(roleFactory)
        };

        var result = SUT.Create(ecsServiceStackConfig);

        var resultStack = result.Stack;

        return Task.FromResult(resultStack);
    }
}
