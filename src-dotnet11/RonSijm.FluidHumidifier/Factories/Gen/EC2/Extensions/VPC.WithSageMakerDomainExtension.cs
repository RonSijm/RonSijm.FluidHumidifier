// ReSharper disable InconsistentNaming
// ReSharper disable RedundantUsingDirective
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public static class VPCWithSageMakerDomainExtension
{
    public static CombinedResult<VPCFactory, SageMaker.DomainFactory> WithDomain(this EC2.VPCFactory factory, string resourceName, Action<Humidifier.SageMaker.Domain> action = null)
    {
        var childResourceFactory = factory.CreateSubFactory(() => new SageMaker.DomainFactory(resourceName, action));

        var vpcAction = new Action<Humidifier.EC2.VPC>(_ =>
        {
            var subResource = childResourceFactory.Build();
            subResource.DependsOn = FFn.FFNamedList(factory);
            subResource.VpcId = FFn.FFnREF(factory);
        });

        factory.ExtendedActions.Enqueue(vpcAction);

        return new CombinedResult<VPCFactory, SageMaker.DomainFactory>(factory, childResourceFactory);
    }
}
