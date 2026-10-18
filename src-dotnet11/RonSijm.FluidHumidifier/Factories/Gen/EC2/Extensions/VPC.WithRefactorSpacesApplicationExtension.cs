// ReSharper disable InconsistentNaming
// ReSharper disable RedundantUsingDirective
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public static class VPCWithRefactorSpacesApplicationExtension
{
    public static CombinedResult<VPCFactory, RefactorSpaces.ApplicationFactory> WithApplication(this EC2.VPCFactory factory, string resourceName, Action<Humidifier.RefactorSpaces.Application> action = null)
    {
        var childResourceFactory = factory.CreateSubFactory(() => new RefactorSpaces.ApplicationFactory(resourceName, action));

        var vpcAction = new Action<Humidifier.EC2.VPC>(_ =>
        {
            var subResource = childResourceFactory.Build();
            subResource.DependsOn = FFn.FFNamedList(factory);
            subResource.VpcId = FFn.FFnREF(factory);
        });

        factory.ExtendedActions.Enqueue(vpcAction);

        return new CombinedResult<VPCFactory, RefactorSpaces.ApplicationFactory>(factory, childResourceFactory);
    }
}
