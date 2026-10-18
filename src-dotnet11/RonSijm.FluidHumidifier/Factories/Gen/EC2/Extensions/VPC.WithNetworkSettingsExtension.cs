// ReSharper disable InconsistentNaming
// ReSharper disable RedundantUsingDirective
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public static class VPCWithNetworkSettingsExtension
{
    public static CombinedResult<VPCFactory, WorkSpacesWeb.NetworkSettingsFactory> WithNetworkSettings(this EC2.VPCFactory factory, string resourceName, Action<Humidifier.WorkSpacesWeb.NetworkSettings> action = null)
    {
        var childResourceFactory = factory.CreateSubFactory(() => new WorkSpacesWeb.NetworkSettingsFactory(resourceName, action));

        var vpcAction = new Action<Humidifier.EC2.VPC>(_ =>
        {
            var subResource = childResourceFactory.Build();
            subResource.DependsOn = FFn.FFNamedList(factory);
            subResource.VpcId = FFn.FFnREF(factory);
        });

        factory.ExtendedActions.Enqueue(vpcAction);

        return new CombinedResult<VPCFactory, WorkSpacesWeb.NetworkSettingsFactory>(factory, childResourceFactory);
    }
}
