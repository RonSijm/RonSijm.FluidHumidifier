// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerCapabilityArgoCdFactory(Action<Humidifier.EKS.CapabilityTypes.ArgoCd> factoryAction = null) : SubResourceFactory<Humidifier.EKS.CapabilityTypes.ArgoCd>
{

    internal InnerCapabilityNetworkAccessFactory NetworkAccessFactory { get; set; }

    internal InnerCapabilityAwsIdcFactory AwsIdcFactory { get; set; }

    protected override Humidifier.EKS.CapabilityTypes.ArgoCd Create()
    {
        var argoCdResult = CreateArgoCd();
        factoryAction?.Invoke(argoCdResult);

        return argoCdResult;
    }

    private Humidifier.EKS.CapabilityTypes.ArgoCd CreateArgoCd()
    {
        var argoCdResult = new Humidifier.EKS.CapabilityTypes.ArgoCd();

        return argoCdResult;
    }
    public override void CreateChildren(Humidifier.EKS.CapabilityTypes.ArgoCd result)
    {
        base.CreateChildren(result);

        result.NetworkAccess ??= NetworkAccessFactory?.Build();
        result.AwsIdc ??= AwsIdcFactory?.Build();
    }

} // End Of Class

public static class InnerCapabilityArgoCdFactoryExtensions
{
    public static CombinedResult<InnerCapabilityArgoCdFactory, InnerCapabilityNetworkAccessFactory> WithNetworkAccess(this InnerCapabilityArgoCdFactory parentFactory, Action<Humidifier.EKS.CapabilityTypes.NetworkAccess> subFactoryAction = null)
    {
        parentFactory.NetworkAccessFactory = new InnerCapabilityNetworkAccessFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.NetworkAccessFactory);
    }

    public static CombinedResult<InnerCapabilityArgoCdFactory, InnerCapabilityAwsIdcFactory> WithAwsIdc(this InnerCapabilityArgoCdFactory parentFactory, Action<Humidifier.EKS.CapabilityTypes.AwsIdc> subFactoryAction = null)
    {
        parentFactory.AwsIdcFactory = new InnerCapabilityAwsIdcFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AwsIdcFactory);
    }

    public static CombinedResult<InnerCapabilityArgoCdFactory, T1, InnerCapabilityNetworkAccessFactory> WithNetworkAccess<T1>(this CombinedResult<InnerCapabilityArgoCdFactory, T1> combinedResult, Action<Humidifier.EKS.CapabilityTypes.NetworkAccess> subFactoryAction = null) => new (combinedResult, combinedResult, WithNetworkAccess(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCapabilityArgoCdFactory, InnerCapabilityNetworkAccessFactory> WithNetworkAccess<T1>(this CombinedResult<T1, InnerCapabilityArgoCdFactory> combinedResult, Action<Humidifier.EKS.CapabilityTypes.NetworkAccess> subFactoryAction = null) => new (combinedResult, combinedResult, WithNetworkAccess(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerCapabilityArgoCdFactory, T1, T2, InnerCapabilityNetworkAccessFactory> WithNetworkAccess<T1, T2>(this CombinedResult<InnerCapabilityArgoCdFactory, T1, T2> combinedResult, Action<Humidifier.EKS.CapabilityTypes.NetworkAccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkAccess(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCapabilityArgoCdFactory, T2, InnerCapabilityNetworkAccessFactory> WithNetworkAccess<T1, T2>(this CombinedResult<T1, InnerCapabilityArgoCdFactory, T2> combinedResult, Action<Humidifier.EKS.CapabilityTypes.NetworkAccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkAccess(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCapabilityArgoCdFactory, InnerCapabilityNetworkAccessFactory> WithNetworkAccess<T1, T2>(this CombinedResult<T1, T2, InnerCapabilityArgoCdFactory> combinedResult, Action<Humidifier.EKS.CapabilityTypes.NetworkAccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNetworkAccess(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerCapabilityArgoCdFactory, T1, T2, T3, InnerCapabilityNetworkAccessFactory> WithNetworkAccess<T1, T2, T3>(this CombinedResult<InnerCapabilityArgoCdFactory, T1, T2, T3> combinedResult, Action<Humidifier.EKS.CapabilityTypes.NetworkAccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkAccess(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCapabilityArgoCdFactory, T2, T3, InnerCapabilityNetworkAccessFactory> WithNetworkAccess<T1, T2, T3>(this CombinedResult<T1, InnerCapabilityArgoCdFactory, T2, T3> combinedResult, Action<Humidifier.EKS.CapabilityTypes.NetworkAccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkAccess(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCapabilityArgoCdFactory, T3, InnerCapabilityNetworkAccessFactory> WithNetworkAccess<T1, T2, T3>(this CombinedResult<T1, T2, InnerCapabilityArgoCdFactory, T3> combinedResult, Action<Humidifier.EKS.CapabilityTypes.NetworkAccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkAccess(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCapabilityArgoCdFactory, InnerCapabilityNetworkAccessFactory> WithNetworkAccess<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCapabilityArgoCdFactory> combinedResult, Action<Humidifier.EKS.CapabilityTypes.NetworkAccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkAccess(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerCapabilityArgoCdFactory, T1, T2, T3, T4, InnerCapabilityNetworkAccessFactory> WithNetworkAccess<T1, T2, T3, T4>(this CombinedResult<InnerCapabilityArgoCdFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EKS.CapabilityTypes.NetworkAccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkAccess(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCapabilityArgoCdFactory, T2, T3, T4, InnerCapabilityNetworkAccessFactory> WithNetworkAccess<T1, T2, T3, T4>(this CombinedResult<T1, InnerCapabilityArgoCdFactory, T2, T3, T4> combinedResult, Action<Humidifier.EKS.CapabilityTypes.NetworkAccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkAccess(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCapabilityArgoCdFactory, T3, T4, InnerCapabilityNetworkAccessFactory> WithNetworkAccess<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCapabilityArgoCdFactory, T3, T4> combinedResult, Action<Humidifier.EKS.CapabilityTypes.NetworkAccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkAccess(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCapabilityArgoCdFactory, T4, InnerCapabilityNetworkAccessFactory> WithNetworkAccess<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCapabilityArgoCdFactory, T4> combinedResult, Action<Humidifier.EKS.CapabilityTypes.NetworkAccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkAccess(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerCapabilityArgoCdFactory, InnerCapabilityNetworkAccessFactory> WithNetworkAccess<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCapabilityArgoCdFactory> combinedResult, Action<Humidifier.EKS.CapabilityTypes.NetworkAccess> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNetworkAccess(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerCapabilityArgoCdFactory, T1, InnerCapabilityAwsIdcFactory> WithAwsIdc<T1>(this CombinedResult<InnerCapabilityArgoCdFactory, T1> combinedResult, Action<Humidifier.EKS.CapabilityTypes.AwsIdc> subFactoryAction = null) => new (combinedResult, combinedResult, WithAwsIdc(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCapabilityArgoCdFactory, InnerCapabilityAwsIdcFactory> WithAwsIdc<T1>(this CombinedResult<T1, InnerCapabilityArgoCdFactory> combinedResult, Action<Humidifier.EKS.CapabilityTypes.AwsIdc> subFactoryAction = null) => new (combinedResult, combinedResult, WithAwsIdc(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerCapabilityArgoCdFactory, T1, T2, InnerCapabilityAwsIdcFactory> WithAwsIdc<T1, T2>(this CombinedResult<InnerCapabilityArgoCdFactory, T1, T2> combinedResult, Action<Humidifier.EKS.CapabilityTypes.AwsIdc> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAwsIdc(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCapabilityArgoCdFactory, T2, InnerCapabilityAwsIdcFactory> WithAwsIdc<T1, T2>(this CombinedResult<T1, InnerCapabilityArgoCdFactory, T2> combinedResult, Action<Humidifier.EKS.CapabilityTypes.AwsIdc> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAwsIdc(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCapabilityArgoCdFactory, InnerCapabilityAwsIdcFactory> WithAwsIdc<T1, T2>(this CombinedResult<T1, T2, InnerCapabilityArgoCdFactory> combinedResult, Action<Humidifier.EKS.CapabilityTypes.AwsIdc> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAwsIdc(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerCapabilityArgoCdFactory, T1, T2, T3, InnerCapabilityAwsIdcFactory> WithAwsIdc<T1, T2, T3>(this CombinedResult<InnerCapabilityArgoCdFactory, T1, T2, T3> combinedResult, Action<Humidifier.EKS.CapabilityTypes.AwsIdc> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAwsIdc(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCapabilityArgoCdFactory, T2, T3, InnerCapabilityAwsIdcFactory> WithAwsIdc<T1, T2, T3>(this CombinedResult<T1, InnerCapabilityArgoCdFactory, T2, T3> combinedResult, Action<Humidifier.EKS.CapabilityTypes.AwsIdc> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAwsIdc(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCapabilityArgoCdFactory, T3, InnerCapabilityAwsIdcFactory> WithAwsIdc<T1, T2, T3>(this CombinedResult<T1, T2, InnerCapabilityArgoCdFactory, T3> combinedResult, Action<Humidifier.EKS.CapabilityTypes.AwsIdc> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAwsIdc(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCapabilityArgoCdFactory, InnerCapabilityAwsIdcFactory> WithAwsIdc<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCapabilityArgoCdFactory> combinedResult, Action<Humidifier.EKS.CapabilityTypes.AwsIdc> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAwsIdc(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerCapabilityArgoCdFactory, T1, T2, T3, T4, InnerCapabilityAwsIdcFactory> WithAwsIdc<T1, T2, T3, T4>(this CombinedResult<InnerCapabilityArgoCdFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EKS.CapabilityTypes.AwsIdc> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsIdc(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerCapabilityArgoCdFactory, T2, T3, T4, InnerCapabilityAwsIdcFactory> WithAwsIdc<T1, T2, T3, T4>(this CombinedResult<T1, InnerCapabilityArgoCdFactory, T2, T3, T4> combinedResult, Action<Humidifier.EKS.CapabilityTypes.AwsIdc> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsIdc(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerCapabilityArgoCdFactory, T3, T4, InnerCapabilityAwsIdcFactory> WithAwsIdc<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCapabilityArgoCdFactory, T3, T4> combinedResult, Action<Humidifier.EKS.CapabilityTypes.AwsIdc> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsIdc(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerCapabilityArgoCdFactory, T4, InnerCapabilityAwsIdcFactory> WithAwsIdc<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCapabilityArgoCdFactory, T4> combinedResult, Action<Humidifier.EKS.CapabilityTypes.AwsIdc> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsIdc(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerCapabilityArgoCdFactory, InnerCapabilityAwsIdcFactory> WithAwsIdc<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCapabilityArgoCdFactory> combinedResult, Action<Humidifier.EKS.CapabilityTypes.AwsIdc> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAwsIdc(combinedResult.T5, subFactoryAction).T2);
}
