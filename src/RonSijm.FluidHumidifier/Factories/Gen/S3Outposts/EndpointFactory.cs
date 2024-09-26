// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3Outposts;

public class EndpointFactory(string resourceName = null, Action<Humidifier.S3Outposts.Endpoint> factoryAction = null) : ResourceFactory<Humidifier.S3Outposts.Endpoint>(resourceName)
{

    internal InnerEndpointFailedReasonFactory FailedReasonFactory { get; set; }

    protected override Humidifier.S3Outposts.Endpoint Create()
    {
        var endpointResult = CreateEndpoint();
        factoryAction?.Invoke(endpointResult);

        return endpointResult;
    }

    private Humidifier.S3Outposts.Endpoint CreateEndpoint()
    {
        var endpointResult = new Humidifier.S3Outposts.Endpoint
        {
            GivenName = InputResourceName,
        };

        return endpointResult;
    }
    public override void CreateChildren(Humidifier.S3Outposts.Endpoint result)
    {
        base.CreateChildren(result);

        result.FailedReason ??= FailedReasonFactory?.Build();
    }

} // End Of Class

public static class EndpointFactoryExtensions
{
    public static CombinedResult<EndpointFactory, InnerEndpointFailedReasonFactory> WithFailedReason(this EndpointFactory parentFactory, Action<Humidifier.S3Outposts.EndpointTypes.FailedReason> subFactoryAction = null)
    {
        parentFactory.FailedReasonFactory = new InnerEndpointFailedReasonFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FailedReasonFactory);
    }

    public static CombinedResult<EndpointFactory, T1, InnerEndpointFailedReasonFactory> WithFailedReason<T1>(this CombinedResult<EndpointFactory, T1> combinedResult, Action<Humidifier.S3Outposts.EndpointTypes.FailedReason> subFactoryAction = null) => new (combinedResult, combinedResult, WithFailedReason(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EndpointFactory, InnerEndpointFailedReasonFactory> WithFailedReason<T1>(this CombinedResult<T1, EndpointFactory> combinedResult, Action<Humidifier.S3Outposts.EndpointTypes.FailedReason> subFactoryAction = null) => new (combinedResult, combinedResult, WithFailedReason(combinedResult.T2, subFactoryAction));
    public static CombinedResult<EndpointFactory, T1, T2, InnerEndpointFailedReasonFactory> WithFailedReason<T1, T2>(this CombinedResult<EndpointFactory, T1, T2> combinedResult, Action<Humidifier.S3Outposts.EndpointTypes.FailedReason> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFailedReason(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EndpointFactory, T2, InnerEndpointFailedReasonFactory> WithFailedReason<T1, T2>(this CombinedResult<T1, EndpointFactory, T2> combinedResult, Action<Humidifier.S3Outposts.EndpointTypes.FailedReason> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFailedReason(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EndpointFactory, InnerEndpointFailedReasonFactory> WithFailedReason<T1, T2>(this CombinedResult<T1, T2, EndpointFactory> combinedResult, Action<Humidifier.S3Outposts.EndpointTypes.FailedReason> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFailedReason(combinedResult.T3, subFactoryAction));
    public static CombinedResult<EndpointFactory, T1, T2, T3, InnerEndpointFailedReasonFactory> WithFailedReason<T1, T2, T3>(this CombinedResult<EndpointFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3Outposts.EndpointTypes.FailedReason> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFailedReason(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EndpointFactory, T2, T3, InnerEndpointFailedReasonFactory> WithFailedReason<T1, T2, T3>(this CombinedResult<T1, EndpointFactory, T2, T3> combinedResult, Action<Humidifier.S3Outposts.EndpointTypes.FailedReason> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFailedReason(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EndpointFactory, T3, InnerEndpointFailedReasonFactory> WithFailedReason<T1, T2, T3>(this CombinedResult<T1, T2, EndpointFactory, T3> combinedResult, Action<Humidifier.S3Outposts.EndpointTypes.FailedReason> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFailedReason(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EndpointFactory, InnerEndpointFailedReasonFactory> WithFailedReason<T1, T2, T3>(this CombinedResult<T1, T2, T3, EndpointFactory> combinedResult, Action<Humidifier.S3Outposts.EndpointTypes.FailedReason> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFailedReason(combinedResult.T4, subFactoryAction));
    public static CombinedResult<EndpointFactory, T1, T2, T3, T4, InnerEndpointFailedReasonFactory> WithFailedReason<T1, T2, T3, T4>(this CombinedResult<EndpointFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3Outposts.EndpointTypes.FailedReason> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFailedReason(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EndpointFactory, T2, T3, T4, InnerEndpointFailedReasonFactory> WithFailedReason<T1, T2, T3, T4>(this CombinedResult<T1, EndpointFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3Outposts.EndpointTypes.FailedReason> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFailedReason(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EndpointFactory, T3, T4, InnerEndpointFailedReasonFactory> WithFailedReason<T1, T2, T3, T4>(this CombinedResult<T1, T2, EndpointFactory, T3, T4> combinedResult, Action<Humidifier.S3Outposts.EndpointTypes.FailedReason> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFailedReason(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EndpointFactory, T4, InnerEndpointFailedReasonFactory> WithFailedReason<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EndpointFactory, T4> combinedResult, Action<Humidifier.S3Outposts.EndpointTypes.FailedReason> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFailedReason(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, EndpointFactory, InnerEndpointFailedReasonFactory> WithFailedReason<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EndpointFactory> combinedResult, Action<Humidifier.S3Outposts.EndpointTypes.FailedReason> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFailedReason(combinedResult.T5, subFactoryAction));
}
