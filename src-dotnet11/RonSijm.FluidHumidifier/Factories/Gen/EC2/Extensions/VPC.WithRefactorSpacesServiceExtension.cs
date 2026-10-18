// ReSharper disable InconsistentNaming
// ReSharper disable RedundantUsingDirective
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public static class VPCWithRefactorSpacesServiceExtension
{
    public static CombinedResult<VPCFactory, RefactorSpaces.ServiceFactory> WithService(this EC2.VPCFactory factory, string resourceName, Action<Humidifier.RefactorSpaces.Service> action = null)
    {
        var childResourceFactory = factory.CreateSubFactory(() => new RefactorSpaces.ServiceFactory(resourceName, action));

        var vpcAction = new Action<Humidifier.EC2.VPC>(_ =>
        {
            var subResource = childResourceFactory.Build();
            subResource.DependsOn = FFn.FFNamedList(factory);
            subResource.VpcId = FFn.FFnREF(factory);
        });

        factory.ExtendedActions.Enqueue(vpcAction);

        return new CombinedResult<VPCFactory, RefactorSpaces.ServiceFactory>(factory, childResourceFactory);
    }
}
