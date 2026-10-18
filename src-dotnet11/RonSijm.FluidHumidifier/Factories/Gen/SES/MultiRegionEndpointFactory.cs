// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class MultiRegionEndpointFactory(string resourceName = null, Action<Humidifier.SES.MultiRegionEndpoint> factoryAction = null) : ResourceFactory<Humidifier.SES.MultiRegionEndpoint>(resourceName)
{

    internal InnerMultiRegionEndpointDetailsFactory DetailsFactory { get; set; }

    protected override Humidifier.SES.MultiRegionEndpoint Create()
    {
        var multiRegionEndpointResult = CreateMultiRegionEndpoint();
        factoryAction?.Invoke(multiRegionEndpointResult);

        return multiRegionEndpointResult;
    }

    private Humidifier.SES.MultiRegionEndpoint CreateMultiRegionEndpoint()
    {
        var multiRegionEndpointResult = new Humidifier.SES.MultiRegionEndpoint
        {
            GivenName = InputResourceName,
        };

        return multiRegionEndpointResult;
    }
    public override void CreateChildren(Humidifier.SES.MultiRegionEndpoint result)
    {
        base.CreateChildren(result);

        result.Details ??= DetailsFactory?.Build();
    }

} // End Of Class

public static class MultiRegionEndpointFactoryExtensions
{
    public static CombinedResult<MultiRegionEndpointFactory, InnerMultiRegionEndpointDetailsFactory> WithDetails(this MultiRegionEndpointFactory parentFactory, Action<Humidifier.SES.MultiRegionEndpointTypes.Details> subFactoryAction = null)
    {
        parentFactory.DetailsFactory = new InnerMultiRegionEndpointDetailsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DetailsFactory);
    }

    public static CombinedResult<MultiRegionEndpointFactory, T1, InnerMultiRegionEndpointDetailsFactory> WithDetails<T1>(this CombinedResult<MultiRegionEndpointFactory, T1> combinedResult, Action<Humidifier.SES.MultiRegionEndpointTypes.Details> subFactoryAction = null) => new (combinedResult, combinedResult, WithDetails(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MultiRegionEndpointFactory, InnerMultiRegionEndpointDetailsFactory> WithDetails<T1>(this CombinedResult<T1, MultiRegionEndpointFactory> combinedResult, Action<Humidifier.SES.MultiRegionEndpointTypes.Details> subFactoryAction = null) => new (combinedResult, combinedResult, WithDetails(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<MultiRegionEndpointFactory, T1, T2, InnerMultiRegionEndpointDetailsFactory> WithDetails<T1, T2>(this CombinedResult<MultiRegionEndpointFactory, T1, T2> combinedResult, Action<Humidifier.SES.MultiRegionEndpointTypes.Details> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDetails(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MultiRegionEndpointFactory, T2, InnerMultiRegionEndpointDetailsFactory> WithDetails<T1, T2>(this CombinedResult<T1, MultiRegionEndpointFactory, T2> combinedResult, Action<Humidifier.SES.MultiRegionEndpointTypes.Details> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDetails(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, MultiRegionEndpointFactory, InnerMultiRegionEndpointDetailsFactory> WithDetails<T1, T2>(this CombinedResult<T1, T2, MultiRegionEndpointFactory> combinedResult, Action<Humidifier.SES.MultiRegionEndpointTypes.Details> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDetails(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<MultiRegionEndpointFactory, T1, T2, T3, InnerMultiRegionEndpointDetailsFactory> WithDetails<T1, T2, T3>(this CombinedResult<MultiRegionEndpointFactory, T1, T2, T3> combinedResult, Action<Humidifier.SES.MultiRegionEndpointTypes.Details> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDetails(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MultiRegionEndpointFactory, T2, T3, InnerMultiRegionEndpointDetailsFactory> WithDetails<T1, T2, T3>(this CombinedResult<T1, MultiRegionEndpointFactory, T2, T3> combinedResult, Action<Humidifier.SES.MultiRegionEndpointTypes.Details> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDetails(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, MultiRegionEndpointFactory, T3, InnerMultiRegionEndpointDetailsFactory> WithDetails<T1, T2, T3>(this CombinedResult<T1, T2, MultiRegionEndpointFactory, T3> combinedResult, Action<Humidifier.SES.MultiRegionEndpointTypes.Details> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDetails(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, MultiRegionEndpointFactory, InnerMultiRegionEndpointDetailsFactory> WithDetails<T1, T2, T3>(this CombinedResult<T1, T2, T3, MultiRegionEndpointFactory> combinedResult, Action<Humidifier.SES.MultiRegionEndpointTypes.Details> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDetails(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<MultiRegionEndpointFactory, T1, T2, T3, T4, InnerMultiRegionEndpointDetailsFactory> WithDetails<T1, T2, T3, T4>(this CombinedResult<MultiRegionEndpointFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SES.MultiRegionEndpointTypes.Details> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDetails(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MultiRegionEndpointFactory, T2, T3, T4, InnerMultiRegionEndpointDetailsFactory> WithDetails<T1, T2, T3, T4>(this CombinedResult<T1, MultiRegionEndpointFactory, T2, T3, T4> combinedResult, Action<Humidifier.SES.MultiRegionEndpointTypes.Details> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDetails(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, MultiRegionEndpointFactory, T3, T4, InnerMultiRegionEndpointDetailsFactory> WithDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, MultiRegionEndpointFactory, T3, T4> combinedResult, Action<Humidifier.SES.MultiRegionEndpointTypes.Details> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDetails(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, MultiRegionEndpointFactory, T4, InnerMultiRegionEndpointDetailsFactory> WithDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MultiRegionEndpointFactory, T4> combinedResult, Action<Humidifier.SES.MultiRegionEndpointTypes.Details> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDetails(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, MultiRegionEndpointFactory, InnerMultiRegionEndpointDetailsFactory> WithDetails<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MultiRegionEndpointFactory> combinedResult, Action<Humidifier.SES.MultiRegionEndpointTypes.Details> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDetails(combinedResult.T5, subFactoryAction).T2);
}
