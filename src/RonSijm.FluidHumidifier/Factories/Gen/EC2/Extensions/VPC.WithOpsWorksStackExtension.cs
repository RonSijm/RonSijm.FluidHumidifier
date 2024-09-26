// ReSharper disable InconsistentNaming
// ReSharper disable RedundantUsingDirective
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public static class VPCWithOpsWorksStackExtension
{
    public static CombinedResult<VPCFactory, OpsWorks.StackFactory> WithStack(this EC2.VPCFactory factory, string resourceName, Action<Humidifier.OpsWorks.Stack> action = null)
    {
        var childResourceFactory = factory.CreateSubFactory(() => new OpsWorks.StackFactory(resourceName, action));

        var vpcAction = new Action<Humidifier.EC2.VPC>(_ =>
        {
            var subResource = childResourceFactory.Build();
            subResource.DependsOn = FFn.FFNamedList(factory);
            subResource.VpcId = FFn.FFnREF(factory);
        });

        factory.ExtendedActions.Enqueue(vpcAction);

        return new CombinedResult<VPCFactory, OpsWorks.StackFactory>(factory, childResourceFactory);
    }
}
