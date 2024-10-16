// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElasticLoadBalancingV2;

public class TrustStoreRevocationFactory(string resourceName = null, Action<Humidifier.ElasticLoadBalancingV2.TrustStoreRevocation> factoryAction = null) : ResourceFactory<Humidifier.ElasticLoadBalancingV2.TrustStoreRevocation>(resourceName)
{

    internal List<InnerTrustStoreRevocationRevocationContentFactory> RevocationContentsFactories { get; set; } = [];

    protected override Humidifier.ElasticLoadBalancingV2.TrustStoreRevocation Create()
    {
        var trustStoreRevocationResult = CreateTrustStoreRevocation();
        factoryAction?.Invoke(trustStoreRevocationResult);

        return trustStoreRevocationResult;
    }

    private Humidifier.ElasticLoadBalancingV2.TrustStoreRevocation CreateTrustStoreRevocation()
    {
        var trustStoreRevocationResult = new Humidifier.ElasticLoadBalancingV2.TrustStoreRevocation
        {
            GivenName = InputResourceName,
        };

        return trustStoreRevocationResult;
    }
    public override void CreateChildren(Humidifier.ElasticLoadBalancingV2.TrustStoreRevocation result)
    {
        base.CreateChildren(result);

        result.RevocationContents = RevocationContentsFactories.Any() ? RevocationContentsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class TrustStoreRevocationFactoryExtensions
{
    public static CombinedResult<TrustStoreRevocationFactory, InnerTrustStoreRevocationRevocationContentFactory> WithRevocationContents(this TrustStoreRevocationFactory parentFactory, Action<Humidifier.ElasticLoadBalancingV2.TrustStoreRevocationTypes.RevocationContent> subFactoryAction = null)
    {
        var factory = new InnerTrustStoreRevocationRevocationContentFactory(subFactoryAction);
        parentFactory.RevocationContentsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<TrustStoreRevocationFactory, T1, InnerTrustStoreRevocationRevocationContentFactory> WithRevocationContents<T1>(this CombinedResult<TrustStoreRevocationFactory, T1> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TrustStoreRevocationTypes.RevocationContent> subFactoryAction = null) => new (combinedResult, combinedResult, WithRevocationContents(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TrustStoreRevocationFactory, InnerTrustStoreRevocationRevocationContentFactory> WithRevocationContents<T1>(this CombinedResult<T1, TrustStoreRevocationFactory> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TrustStoreRevocationTypes.RevocationContent> subFactoryAction = null) => new (combinedResult, combinedResult, WithRevocationContents(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TrustStoreRevocationFactory, T1, T2, InnerTrustStoreRevocationRevocationContentFactory> WithRevocationContents<T1, T2>(this CombinedResult<TrustStoreRevocationFactory, T1, T2> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TrustStoreRevocationTypes.RevocationContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRevocationContents(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TrustStoreRevocationFactory, T2, InnerTrustStoreRevocationRevocationContentFactory> WithRevocationContents<T1, T2>(this CombinedResult<T1, TrustStoreRevocationFactory, T2> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TrustStoreRevocationTypes.RevocationContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRevocationContents(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TrustStoreRevocationFactory, InnerTrustStoreRevocationRevocationContentFactory> WithRevocationContents<T1, T2>(this CombinedResult<T1, T2, TrustStoreRevocationFactory> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TrustStoreRevocationTypes.RevocationContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRevocationContents(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TrustStoreRevocationFactory, T1, T2, T3, InnerTrustStoreRevocationRevocationContentFactory> WithRevocationContents<T1, T2, T3>(this CombinedResult<TrustStoreRevocationFactory, T1, T2, T3> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TrustStoreRevocationTypes.RevocationContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRevocationContents(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TrustStoreRevocationFactory, T2, T3, InnerTrustStoreRevocationRevocationContentFactory> WithRevocationContents<T1, T2, T3>(this CombinedResult<T1, TrustStoreRevocationFactory, T2, T3> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TrustStoreRevocationTypes.RevocationContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRevocationContents(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TrustStoreRevocationFactory, T3, InnerTrustStoreRevocationRevocationContentFactory> WithRevocationContents<T1, T2, T3>(this CombinedResult<T1, T2, TrustStoreRevocationFactory, T3> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TrustStoreRevocationTypes.RevocationContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRevocationContents(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TrustStoreRevocationFactory, InnerTrustStoreRevocationRevocationContentFactory> WithRevocationContents<T1, T2, T3>(this CombinedResult<T1, T2, T3, TrustStoreRevocationFactory> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TrustStoreRevocationTypes.RevocationContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRevocationContents(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TrustStoreRevocationFactory, T1, T2, T3, T4, InnerTrustStoreRevocationRevocationContentFactory> WithRevocationContents<T1, T2, T3, T4>(this CombinedResult<TrustStoreRevocationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TrustStoreRevocationTypes.RevocationContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRevocationContents(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TrustStoreRevocationFactory, T2, T3, T4, InnerTrustStoreRevocationRevocationContentFactory> WithRevocationContents<T1, T2, T3, T4>(this CombinedResult<T1, TrustStoreRevocationFactory, T2, T3, T4> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TrustStoreRevocationTypes.RevocationContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRevocationContents(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TrustStoreRevocationFactory, T3, T4, InnerTrustStoreRevocationRevocationContentFactory> WithRevocationContents<T1, T2, T3, T4>(this CombinedResult<T1, T2, TrustStoreRevocationFactory, T3, T4> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TrustStoreRevocationTypes.RevocationContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRevocationContents(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TrustStoreRevocationFactory, T4, InnerTrustStoreRevocationRevocationContentFactory> WithRevocationContents<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TrustStoreRevocationFactory, T4> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TrustStoreRevocationTypes.RevocationContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRevocationContents(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TrustStoreRevocationFactory, InnerTrustStoreRevocationRevocationContentFactory> WithRevocationContents<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TrustStoreRevocationFactory> combinedResult, Action<Humidifier.ElasticLoadBalancingV2.TrustStoreRevocationTypes.RevocationContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRevocationContents(combinedResult.T5, subFactoryAction));
}
