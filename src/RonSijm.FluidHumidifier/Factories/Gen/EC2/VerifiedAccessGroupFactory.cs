// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class VerifiedAccessGroupFactory(string resourceName = null, Action<Humidifier.EC2.VerifiedAccessGroup> factoryAction = null) : ResourceFactory<Humidifier.EC2.VerifiedAccessGroup>(resourceName)
{

    internal InnerVerifiedAccessGroupSseSpecificationFactory SseSpecificationFactory { get; set; }

    protected override Humidifier.EC2.VerifiedAccessGroup Create()
    {
        var verifiedAccessGroupResult = CreateVerifiedAccessGroup();
        factoryAction?.Invoke(verifiedAccessGroupResult);

        return verifiedAccessGroupResult;
    }

    private Humidifier.EC2.VerifiedAccessGroup CreateVerifiedAccessGroup()
    {
        var verifiedAccessGroupResult = new Humidifier.EC2.VerifiedAccessGroup
        {
            GivenName = InputResourceName,
        };

        return verifiedAccessGroupResult;
    }
    public override void CreateChildren(Humidifier.EC2.VerifiedAccessGroup result)
    {
        base.CreateChildren(result);

        result.SseSpecification ??= SseSpecificationFactory?.Build();
    }

} // End Of Class

public static class VerifiedAccessGroupFactoryExtensions
{
    public static CombinedResult<VerifiedAccessGroupFactory, InnerVerifiedAccessGroupSseSpecificationFactory> WithSseSpecification(this VerifiedAccessGroupFactory parentFactory, Action<Humidifier.EC2.VerifiedAccessGroupTypes.SseSpecification> subFactoryAction = null)
    {
        parentFactory.SseSpecificationFactory = new InnerVerifiedAccessGroupSseSpecificationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SseSpecificationFactory);
    }

    public static CombinedResult<VerifiedAccessGroupFactory, T1, InnerVerifiedAccessGroupSseSpecificationFactory> WithSseSpecification<T1>(this CombinedResult<VerifiedAccessGroupFactory, T1> combinedResult, Action<Humidifier.EC2.VerifiedAccessGroupTypes.SseSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithSseSpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VerifiedAccessGroupFactory, InnerVerifiedAccessGroupSseSpecificationFactory> WithSseSpecification<T1>(this CombinedResult<T1, VerifiedAccessGroupFactory> combinedResult, Action<Humidifier.EC2.VerifiedAccessGroupTypes.SseSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithSseSpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<VerifiedAccessGroupFactory, T1, T2, InnerVerifiedAccessGroupSseSpecificationFactory> WithSseSpecification<T1, T2>(this CombinedResult<VerifiedAccessGroupFactory, T1, T2> combinedResult, Action<Humidifier.EC2.VerifiedAccessGroupTypes.SseSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSseSpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VerifiedAccessGroupFactory, T2, InnerVerifiedAccessGroupSseSpecificationFactory> WithSseSpecification<T1, T2>(this CombinedResult<T1, VerifiedAccessGroupFactory, T2> combinedResult, Action<Humidifier.EC2.VerifiedAccessGroupTypes.SseSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSseSpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VerifiedAccessGroupFactory, InnerVerifiedAccessGroupSseSpecificationFactory> WithSseSpecification<T1, T2>(this CombinedResult<T1, T2, VerifiedAccessGroupFactory> combinedResult, Action<Humidifier.EC2.VerifiedAccessGroupTypes.SseSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSseSpecification(combinedResult.T3, subFactoryAction));
    public static CombinedResult<VerifiedAccessGroupFactory, T1, T2, T3, InnerVerifiedAccessGroupSseSpecificationFactory> WithSseSpecification<T1, T2, T3>(this CombinedResult<VerifiedAccessGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.VerifiedAccessGroupTypes.SseSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSseSpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VerifiedAccessGroupFactory, T2, T3, InnerVerifiedAccessGroupSseSpecificationFactory> WithSseSpecification<T1, T2, T3>(this CombinedResult<T1, VerifiedAccessGroupFactory, T2, T3> combinedResult, Action<Humidifier.EC2.VerifiedAccessGroupTypes.SseSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSseSpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VerifiedAccessGroupFactory, T3, InnerVerifiedAccessGroupSseSpecificationFactory> WithSseSpecification<T1, T2, T3>(this CombinedResult<T1, T2, VerifiedAccessGroupFactory, T3> combinedResult, Action<Humidifier.EC2.VerifiedAccessGroupTypes.SseSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSseSpecification(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, VerifiedAccessGroupFactory, InnerVerifiedAccessGroupSseSpecificationFactory> WithSseSpecification<T1, T2, T3>(this CombinedResult<T1, T2, T3, VerifiedAccessGroupFactory> combinedResult, Action<Humidifier.EC2.VerifiedAccessGroupTypes.SseSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSseSpecification(combinedResult.T4, subFactoryAction));
    public static CombinedResult<VerifiedAccessGroupFactory, T1, T2, T3, T4, InnerVerifiedAccessGroupSseSpecificationFactory> WithSseSpecification<T1, T2, T3, T4>(this CombinedResult<VerifiedAccessGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.VerifiedAccessGroupTypes.SseSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSseSpecification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, VerifiedAccessGroupFactory, T2, T3, T4, InnerVerifiedAccessGroupSseSpecificationFactory> WithSseSpecification<T1, T2, T3, T4>(this CombinedResult<T1, VerifiedAccessGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.VerifiedAccessGroupTypes.SseSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSseSpecification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, VerifiedAccessGroupFactory, T3, T4, InnerVerifiedAccessGroupSseSpecificationFactory> WithSseSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, VerifiedAccessGroupFactory, T3, T4> combinedResult, Action<Humidifier.EC2.VerifiedAccessGroupTypes.SseSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSseSpecification(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, VerifiedAccessGroupFactory, T4, InnerVerifiedAccessGroupSseSpecificationFactory> WithSseSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, VerifiedAccessGroupFactory, T4> combinedResult, Action<Humidifier.EC2.VerifiedAccessGroupTypes.SseSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSseSpecification(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, VerifiedAccessGroupFactory, InnerVerifiedAccessGroupSseSpecificationFactory> WithSseSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, VerifiedAccessGroupFactory> combinedResult, Action<Humidifier.EC2.VerifiedAccessGroupTypes.SseSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSseSpecification(combinedResult.T5, subFactoryAction));
}
