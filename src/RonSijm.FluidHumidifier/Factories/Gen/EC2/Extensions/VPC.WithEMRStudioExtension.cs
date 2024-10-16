// ReSharper disable InconsistentNaming
// ReSharper disable RedundantUsingDirective
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public static class VPCWithEMRStudioExtension
{
    public static CombinedResult<VPCFactory, EMR.StudioFactory> WithStudio(this EC2.VPCFactory factory, string resourceName, Action<Humidifier.EMR.Studio> action = null)
    {
        var childResourceFactory = factory.CreateSubFactory(() => new EMR.StudioFactory(resourceName, action));

        var vpcAction = new Action<Humidifier.EC2.VPC>(_ =>
        {
            var subResource = childResourceFactory.Build();
            subResource.DependsOn = FFn.FFNamedList(factory);
            subResource.VpcId = FFn.FFnREF(factory);
        });

        factory.ExtendedActions.Enqueue(vpcAction);

        return new CombinedResult<VPCFactory, EMR.StudioFactory>(factory, childResourceFactory);
    }
}
