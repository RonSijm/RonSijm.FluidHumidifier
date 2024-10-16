// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53RecoveryReadiness;

public class InnerResourceSetDNSTargetResourceFactory(Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.DNSTargetResource> factoryAction = null) : SubResourceFactory<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.DNSTargetResource>
{

    internal InnerResourceSetTargetResourceFactory TargetResourceFactory { get; set; }

    protected override Humidifier.Route53RecoveryReadiness.ResourceSetTypes.DNSTargetResource Create()
    {
        var dNSTargetResourceResult = CreateDNSTargetResource();
        factoryAction?.Invoke(dNSTargetResourceResult);

        return dNSTargetResourceResult;
    }

    private Humidifier.Route53RecoveryReadiness.ResourceSetTypes.DNSTargetResource CreateDNSTargetResource()
    {
        var dNSTargetResourceResult = new Humidifier.Route53RecoveryReadiness.ResourceSetTypes.DNSTargetResource();

        return dNSTargetResourceResult;
    }
    public override void CreateChildren(Humidifier.Route53RecoveryReadiness.ResourceSetTypes.DNSTargetResource result)
    {
        base.CreateChildren(result);

        result.TargetResource ??= TargetResourceFactory?.Build();
    }

} // End Of Class

public static class InnerResourceSetDNSTargetResourceFactoryExtensions
{
    public static CombinedResult<InnerResourceSetDNSTargetResourceFactory, InnerResourceSetTargetResourceFactory> WithTargetResource(this InnerResourceSetDNSTargetResourceFactory parentFactory, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.TargetResource> subFactoryAction = null)
    {
        parentFactory.TargetResourceFactory = new InnerResourceSetTargetResourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TargetResourceFactory);
    }

    public static CombinedResult<InnerResourceSetDNSTargetResourceFactory, T1, InnerResourceSetTargetResourceFactory> WithTargetResource<T1>(this CombinedResult<InnerResourceSetDNSTargetResourceFactory, T1> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.TargetResource> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargetResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceSetDNSTargetResourceFactory, InnerResourceSetTargetResourceFactory> WithTargetResource<T1>(this CombinedResult<T1, InnerResourceSetDNSTargetResourceFactory> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.TargetResource> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargetResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerResourceSetDNSTargetResourceFactory, T1, T2, InnerResourceSetTargetResourceFactory> WithTargetResource<T1, T2>(this CombinedResult<InnerResourceSetDNSTargetResourceFactory, T1, T2> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.TargetResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceSetDNSTargetResourceFactory, T2, InnerResourceSetTargetResourceFactory> WithTargetResource<T1, T2>(this CombinedResult<T1, InnerResourceSetDNSTargetResourceFactory, T2> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.TargetResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceSetDNSTargetResourceFactory, InnerResourceSetTargetResourceFactory> WithTargetResource<T1, T2>(this CombinedResult<T1, T2, InnerResourceSetDNSTargetResourceFactory> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.TargetResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetResource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerResourceSetDNSTargetResourceFactory, T1, T2, T3, InnerResourceSetTargetResourceFactory> WithTargetResource<T1, T2, T3>(this CombinedResult<InnerResourceSetDNSTargetResourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.TargetResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceSetDNSTargetResourceFactory, T2, T3, InnerResourceSetTargetResourceFactory> WithTargetResource<T1, T2, T3>(this CombinedResult<T1, InnerResourceSetDNSTargetResourceFactory, T2, T3> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.TargetResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceSetDNSTargetResourceFactory, T3, InnerResourceSetTargetResourceFactory> WithTargetResource<T1, T2, T3>(this CombinedResult<T1, T2, InnerResourceSetDNSTargetResourceFactory, T3> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.TargetResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetResource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerResourceSetDNSTargetResourceFactory, InnerResourceSetTargetResourceFactory> WithTargetResource<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerResourceSetDNSTargetResourceFactory> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.TargetResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetResource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerResourceSetDNSTargetResourceFactory, T1, T2, T3, T4, InnerResourceSetTargetResourceFactory> WithTargetResource<T1, T2, T3, T4>(this CombinedResult<InnerResourceSetDNSTargetResourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.TargetResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceSetDNSTargetResourceFactory, T2, T3, T4, InnerResourceSetTargetResourceFactory> WithTargetResource<T1, T2, T3, T4>(this CombinedResult<T1, InnerResourceSetDNSTargetResourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.TargetResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceSetDNSTargetResourceFactory, T3, T4, InnerResourceSetTargetResourceFactory> WithTargetResource<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerResourceSetDNSTargetResourceFactory, T3, T4> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.TargetResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetResource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerResourceSetDNSTargetResourceFactory, T4, InnerResourceSetTargetResourceFactory> WithTargetResource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerResourceSetDNSTargetResourceFactory, T4> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.TargetResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetResource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerResourceSetDNSTargetResourceFactory, InnerResourceSetTargetResourceFactory> WithTargetResource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerResourceSetDNSTargetResourceFactory> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.TargetResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetResource(combinedResult.T5, subFactoryAction));
}
