// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class SpotInstancesRequestFactory(string resourceName = null, Action<Humidifier.EC2.SpotInstancesRequest> factoryAction = null) : ResourceFactory<Humidifier.EC2.SpotInstancesRequest>(resourceName)
{

    internal InnerSpotInstancesRequestLaunchSpecificationFactory LaunchSpecificationFactory { get; set; }

    protected override Humidifier.EC2.SpotInstancesRequest Create()
    {
        var spotInstancesRequestResult = CreateSpotInstancesRequest();
        factoryAction?.Invoke(spotInstancesRequestResult);

        return spotInstancesRequestResult;
    }

    private Humidifier.EC2.SpotInstancesRequest CreateSpotInstancesRequest()
    {
        var spotInstancesRequestResult = new Humidifier.EC2.SpotInstancesRequest
        {
            GivenName = InputResourceName,
        };

        return spotInstancesRequestResult;
    }
    public override void CreateChildren(Humidifier.EC2.SpotInstancesRequest result)
    {
        base.CreateChildren(result);

        result.LaunchSpecification ??= LaunchSpecificationFactory?.Build();
    }

} // End Of Class

public static class SpotInstancesRequestFactoryExtensions
{
    public static CombinedResult<SpotInstancesRequestFactory, InnerSpotInstancesRequestLaunchSpecificationFactory> WithLaunchSpecification(this SpotInstancesRequestFactory parentFactory, Action<Humidifier.EC2.SpotInstancesRequestTypes.LaunchSpecification> subFactoryAction = null)
    {
        parentFactory.LaunchSpecificationFactory = new InnerSpotInstancesRequestLaunchSpecificationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LaunchSpecificationFactory);
    }

    public static CombinedResult<SpotInstancesRequestFactory, T1, InnerSpotInstancesRequestLaunchSpecificationFactory> WithLaunchSpecification<T1>(this CombinedResult<SpotInstancesRequestFactory, T1> combinedResult, Action<Humidifier.EC2.SpotInstancesRequestTypes.LaunchSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithLaunchSpecification(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SpotInstancesRequestFactory, InnerSpotInstancesRequestLaunchSpecificationFactory> WithLaunchSpecification<T1>(this CombinedResult<T1, SpotInstancesRequestFactory> combinedResult, Action<Humidifier.EC2.SpotInstancesRequestTypes.LaunchSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, WithLaunchSpecification(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<SpotInstancesRequestFactory, T1, T2, InnerSpotInstancesRequestLaunchSpecificationFactory> WithLaunchSpecification<T1, T2>(this CombinedResult<SpotInstancesRequestFactory, T1, T2> combinedResult, Action<Humidifier.EC2.SpotInstancesRequestTypes.LaunchSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLaunchSpecification(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SpotInstancesRequestFactory, T2, InnerSpotInstancesRequestLaunchSpecificationFactory> WithLaunchSpecification<T1, T2>(this CombinedResult<T1, SpotInstancesRequestFactory, T2> combinedResult, Action<Humidifier.EC2.SpotInstancesRequestTypes.LaunchSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLaunchSpecification(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SpotInstancesRequestFactory, InnerSpotInstancesRequestLaunchSpecificationFactory> WithLaunchSpecification<T1, T2>(this CombinedResult<T1, T2, SpotInstancesRequestFactory> combinedResult, Action<Humidifier.EC2.SpotInstancesRequestTypes.LaunchSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLaunchSpecification(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<SpotInstancesRequestFactory, T1, T2, T3, InnerSpotInstancesRequestLaunchSpecificationFactory> WithLaunchSpecification<T1, T2, T3>(this CombinedResult<SpotInstancesRequestFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.SpotInstancesRequestTypes.LaunchSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchSpecification(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SpotInstancesRequestFactory, T2, T3, InnerSpotInstancesRequestLaunchSpecificationFactory> WithLaunchSpecification<T1, T2, T3>(this CombinedResult<T1, SpotInstancesRequestFactory, T2, T3> combinedResult, Action<Humidifier.EC2.SpotInstancesRequestTypes.LaunchSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchSpecification(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SpotInstancesRequestFactory, T3, InnerSpotInstancesRequestLaunchSpecificationFactory> WithLaunchSpecification<T1, T2, T3>(this CombinedResult<T1, T2, SpotInstancesRequestFactory, T3> combinedResult, Action<Humidifier.EC2.SpotInstancesRequestTypes.LaunchSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchSpecification(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SpotInstancesRequestFactory, InnerSpotInstancesRequestLaunchSpecificationFactory> WithLaunchSpecification<T1, T2, T3>(this CombinedResult<T1, T2, T3, SpotInstancesRequestFactory> combinedResult, Action<Humidifier.EC2.SpotInstancesRequestTypes.LaunchSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchSpecification(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<SpotInstancesRequestFactory, T1, T2, T3, T4, InnerSpotInstancesRequestLaunchSpecificationFactory> WithLaunchSpecification<T1, T2, T3, T4>(this CombinedResult<SpotInstancesRequestFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.SpotInstancesRequestTypes.LaunchSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchSpecification(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SpotInstancesRequestFactory, T2, T3, T4, InnerSpotInstancesRequestLaunchSpecificationFactory> WithLaunchSpecification<T1, T2, T3, T4>(this CombinedResult<T1, SpotInstancesRequestFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.SpotInstancesRequestTypes.LaunchSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchSpecification(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SpotInstancesRequestFactory, T3, T4, InnerSpotInstancesRequestLaunchSpecificationFactory> WithLaunchSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, SpotInstancesRequestFactory, T3, T4> combinedResult, Action<Humidifier.EC2.SpotInstancesRequestTypes.LaunchSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchSpecification(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SpotInstancesRequestFactory, T4, InnerSpotInstancesRequestLaunchSpecificationFactory> WithLaunchSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SpotInstancesRequestFactory, T4> combinedResult, Action<Humidifier.EC2.SpotInstancesRequestTypes.LaunchSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchSpecification(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, SpotInstancesRequestFactory, InnerSpotInstancesRequestLaunchSpecificationFactory> WithLaunchSpecification<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SpotInstancesRequestFactory> combinedResult, Action<Humidifier.EC2.SpotInstancesRequestTypes.LaunchSpecification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLaunchSpecification(combinedResult.T5, subFactoryAction).T2);
}
