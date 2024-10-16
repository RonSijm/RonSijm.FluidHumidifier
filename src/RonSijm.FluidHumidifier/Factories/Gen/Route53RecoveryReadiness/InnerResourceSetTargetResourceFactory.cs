// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53RecoveryReadiness;

public class InnerResourceSetTargetResourceFactory(Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.TargetResource> factoryAction = null) : SubResourceFactory<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.TargetResource>
{

    internal InnerResourceSetR53ResourceRecordFactory R53ResourceFactory { get; set; }

    internal InnerResourceSetNLBResourceFactory NLBResourceFactory { get; set; }

    protected override Humidifier.Route53RecoveryReadiness.ResourceSetTypes.TargetResource Create()
    {
        var targetResourceResult = CreateTargetResource();
        factoryAction?.Invoke(targetResourceResult);

        return targetResourceResult;
    }

    private Humidifier.Route53RecoveryReadiness.ResourceSetTypes.TargetResource CreateTargetResource()
    {
        var targetResourceResult = new Humidifier.Route53RecoveryReadiness.ResourceSetTypes.TargetResource();

        return targetResourceResult;
    }
    public override void CreateChildren(Humidifier.Route53RecoveryReadiness.ResourceSetTypes.TargetResource result)
    {
        base.CreateChildren(result);

        result.R53Resource ??= R53ResourceFactory?.Build();
        result.NLBResource ??= NLBResourceFactory?.Build();
    }

} // End Of Class

public static class InnerResourceSetTargetResourceFactoryExtensions
{
    public static CombinedResult<InnerResourceSetTargetResourceFactory, InnerResourceSetR53ResourceRecordFactory> WithR53Resource(this InnerResourceSetTargetResourceFactory parentFactory, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.R53ResourceRecord> subFactoryAction = null)
    {
        parentFactory.R53ResourceFactory = new InnerResourceSetR53ResourceRecordFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.R53ResourceFactory);
    }

    public static CombinedResult<InnerResourceSetTargetResourceFactory, InnerResourceSetNLBResourceFactory> WithNLBResource(this InnerResourceSetTargetResourceFactory parentFactory, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.NLBResource> subFactoryAction = null)
    {
        parentFactory.NLBResourceFactory = new InnerResourceSetNLBResourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.NLBResourceFactory);
    }

    public static CombinedResult<InnerResourceSetTargetResourceFactory, T1, InnerResourceSetR53ResourceRecordFactory> WithR53Resource<T1>(this CombinedResult<InnerResourceSetTargetResourceFactory, T1> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.R53ResourceRecord> subFactoryAction = null) => new (combinedResult, combinedResult, WithR53Resource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceSetTargetResourceFactory, InnerResourceSetR53ResourceRecordFactory> WithR53Resource<T1>(this CombinedResult<T1, InnerResourceSetTargetResourceFactory> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.R53ResourceRecord> subFactoryAction = null) => new (combinedResult, combinedResult, WithR53Resource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerResourceSetTargetResourceFactory, T1, T2, InnerResourceSetR53ResourceRecordFactory> WithR53Resource<T1, T2>(this CombinedResult<InnerResourceSetTargetResourceFactory, T1, T2> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.R53ResourceRecord> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithR53Resource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceSetTargetResourceFactory, T2, InnerResourceSetR53ResourceRecordFactory> WithR53Resource<T1, T2>(this CombinedResult<T1, InnerResourceSetTargetResourceFactory, T2> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.R53ResourceRecord> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithR53Resource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceSetTargetResourceFactory, InnerResourceSetR53ResourceRecordFactory> WithR53Resource<T1, T2>(this CombinedResult<T1, T2, InnerResourceSetTargetResourceFactory> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.R53ResourceRecord> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithR53Resource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerResourceSetTargetResourceFactory, T1, T2, T3, InnerResourceSetR53ResourceRecordFactory> WithR53Resource<T1, T2, T3>(this CombinedResult<InnerResourceSetTargetResourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.R53ResourceRecord> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithR53Resource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceSetTargetResourceFactory, T2, T3, InnerResourceSetR53ResourceRecordFactory> WithR53Resource<T1, T2, T3>(this CombinedResult<T1, InnerResourceSetTargetResourceFactory, T2, T3> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.R53ResourceRecord> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithR53Resource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceSetTargetResourceFactory, T3, InnerResourceSetR53ResourceRecordFactory> WithR53Resource<T1, T2, T3>(this CombinedResult<T1, T2, InnerResourceSetTargetResourceFactory, T3> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.R53ResourceRecord> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithR53Resource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerResourceSetTargetResourceFactory, InnerResourceSetR53ResourceRecordFactory> WithR53Resource<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerResourceSetTargetResourceFactory> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.R53ResourceRecord> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithR53Resource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerResourceSetTargetResourceFactory, T1, T2, T3, T4, InnerResourceSetR53ResourceRecordFactory> WithR53Resource<T1, T2, T3, T4>(this CombinedResult<InnerResourceSetTargetResourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.R53ResourceRecord> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithR53Resource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceSetTargetResourceFactory, T2, T3, T4, InnerResourceSetR53ResourceRecordFactory> WithR53Resource<T1, T2, T3, T4>(this CombinedResult<T1, InnerResourceSetTargetResourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.R53ResourceRecord> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithR53Resource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceSetTargetResourceFactory, T3, T4, InnerResourceSetR53ResourceRecordFactory> WithR53Resource<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerResourceSetTargetResourceFactory, T3, T4> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.R53ResourceRecord> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithR53Resource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerResourceSetTargetResourceFactory, T4, InnerResourceSetR53ResourceRecordFactory> WithR53Resource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerResourceSetTargetResourceFactory, T4> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.R53ResourceRecord> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithR53Resource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerResourceSetTargetResourceFactory, InnerResourceSetR53ResourceRecordFactory> WithR53Resource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerResourceSetTargetResourceFactory> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.R53ResourceRecord> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithR53Resource(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerResourceSetTargetResourceFactory, T1, InnerResourceSetNLBResourceFactory> WithNLBResource<T1>(this CombinedResult<InnerResourceSetTargetResourceFactory, T1> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.NLBResource> subFactoryAction = null) => new (combinedResult, combinedResult, WithNLBResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceSetTargetResourceFactory, InnerResourceSetNLBResourceFactory> WithNLBResource<T1>(this CombinedResult<T1, InnerResourceSetTargetResourceFactory> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.NLBResource> subFactoryAction = null) => new (combinedResult, combinedResult, WithNLBResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerResourceSetTargetResourceFactory, T1, T2, InnerResourceSetNLBResourceFactory> WithNLBResource<T1, T2>(this CombinedResult<InnerResourceSetTargetResourceFactory, T1, T2> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.NLBResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNLBResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceSetTargetResourceFactory, T2, InnerResourceSetNLBResourceFactory> WithNLBResource<T1, T2>(this CombinedResult<T1, InnerResourceSetTargetResourceFactory, T2> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.NLBResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNLBResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceSetTargetResourceFactory, InnerResourceSetNLBResourceFactory> WithNLBResource<T1, T2>(this CombinedResult<T1, T2, InnerResourceSetTargetResourceFactory> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.NLBResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNLBResource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerResourceSetTargetResourceFactory, T1, T2, T3, InnerResourceSetNLBResourceFactory> WithNLBResource<T1, T2, T3>(this CombinedResult<InnerResourceSetTargetResourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.NLBResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNLBResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceSetTargetResourceFactory, T2, T3, InnerResourceSetNLBResourceFactory> WithNLBResource<T1, T2, T3>(this CombinedResult<T1, InnerResourceSetTargetResourceFactory, T2, T3> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.NLBResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNLBResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceSetTargetResourceFactory, T3, InnerResourceSetNLBResourceFactory> WithNLBResource<T1, T2, T3>(this CombinedResult<T1, T2, InnerResourceSetTargetResourceFactory, T3> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.NLBResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNLBResource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerResourceSetTargetResourceFactory, InnerResourceSetNLBResourceFactory> WithNLBResource<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerResourceSetTargetResourceFactory> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.NLBResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNLBResource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerResourceSetTargetResourceFactory, T1, T2, T3, T4, InnerResourceSetNLBResourceFactory> WithNLBResource<T1, T2, T3, T4>(this CombinedResult<InnerResourceSetTargetResourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.NLBResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNLBResource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceSetTargetResourceFactory, T2, T3, T4, InnerResourceSetNLBResourceFactory> WithNLBResource<T1, T2, T3, T4>(this CombinedResult<T1, InnerResourceSetTargetResourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.NLBResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNLBResource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceSetTargetResourceFactory, T3, T4, InnerResourceSetNLBResourceFactory> WithNLBResource<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerResourceSetTargetResourceFactory, T3, T4> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.NLBResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNLBResource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerResourceSetTargetResourceFactory, T4, InnerResourceSetNLBResourceFactory> WithNLBResource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerResourceSetTargetResourceFactory, T4> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.NLBResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNLBResource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerResourceSetTargetResourceFactory, InnerResourceSetNLBResourceFactory> WithNLBResource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerResourceSetTargetResourceFactory> combinedResult, Action<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.NLBResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNLBResource(combinedResult.T5, subFactoryAction));
}
