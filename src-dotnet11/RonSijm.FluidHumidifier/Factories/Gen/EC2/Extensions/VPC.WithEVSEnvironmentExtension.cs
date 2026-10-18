// ReSharper disable InconsistentNaming
// ReSharper disable RedundantUsingDirective
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public static class VPCWithEVSEnvironmentExtension
{
    public static CombinedResult<VPCFactory, EVS.EnvironmentFactory> WithEnvironment(this EC2.VPCFactory factory, string resourceName, Action<Humidifier.EVS.Environment> action = null)
    {
        var childResourceFactory = factory.CreateSubFactory(() => new EVS.EnvironmentFactory(resourceName, action));

        var vpcAction = new Action<Humidifier.EC2.VPC>(_ =>
        {
            var subResource = childResourceFactory.Build();
            subResource.DependsOn = FFn.FFNamedList(factory);
            subResource.VpcId = FFn.FFnREF(factory);
        });

        factory.ExtendedActions.Enqueue(vpcAction);

        return new CombinedResult<VPCFactory, EVS.EnvironmentFactory>(factory, childResourceFactory);
    }
}
