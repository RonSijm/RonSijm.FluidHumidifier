// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsGuru;

public class ResourceCollectionFactory(string resourceName = null, Action<Humidifier.DevOpsGuru.ResourceCollection> factoryAction = null) : ResourceFactory<Humidifier.DevOpsGuru.ResourceCollection>(resourceName)
{

    internal InnerResourceCollectionResourceCollectionFilterFactory ResourceCollectionFilterFactory { get; set; }

    protected override Humidifier.DevOpsGuru.ResourceCollection Create()
    {
        var resourceCollectionResult = CreateResourceCollection();
        factoryAction?.Invoke(resourceCollectionResult);

        return resourceCollectionResult;
    }

    private Humidifier.DevOpsGuru.ResourceCollection CreateResourceCollection()
    {
        var resourceCollectionResult = new Humidifier.DevOpsGuru.ResourceCollection
        {
            GivenName = InputResourceName,
        };

        return resourceCollectionResult;
    }
    public override void CreateChildren(Humidifier.DevOpsGuru.ResourceCollection result)
    {
        base.CreateChildren(result);

        result.ResourceCollectionFilter ??= ResourceCollectionFilterFactory?.Build();
    }

} // End Of Class

public static class ResourceCollectionFactoryExtensions
{
    public static CombinedResult<ResourceCollectionFactory, InnerResourceCollectionResourceCollectionFilterFactory> WithResourceCollectionFilter(this ResourceCollectionFactory parentFactory, Action<Humidifier.DevOpsGuru.ResourceCollectionTypes.ResourceCollectionFilter> subFactoryAction = null)
    {
        parentFactory.ResourceCollectionFilterFactory = new InnerResourceCollectionResourceCollectionFilterFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ResourceCollectionFilterFactory);
    }

    public static CombinedResult<ResourceCollectionFactory, T1, InnerResourceCollectionResourceCollectionFilterFactory> WithResourceCollectionFilter<T1>(this CombinedResult<ResourceCollectionFactory, T1> combinedResult, Action<Humidifier.DevOpsGuru.ResourceCollectionTypes.ResourceCollectionFilter> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceCollectionFilter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResourceCollectionFactory, InnerResourceCollectionResourceCollectionFilterFactory> WithResourceCollectionFilter<T1>(this CombinedResult<T1, ResourceCollectionFactory> combinedResult, Action<Humidifier.DevOpsGuru.ResourceCollectionTypes.ResourceCollectionFilter> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceCollectionFilter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ResourceCollectionFactory, T1, T2, InnerResourceCollectionResourceCollectionFilterFactory> WithResourceCollectionFilter<T1, T2>(this CombinedResult<ResourceCollectionFactory, T1, T2> combinedResult, Action<Humidifier.DevOpsGuru.ResourceCollectionTypes.ResourceCollectionFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceCollectionFilter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResourceCollectionFactory, T2, InnerResourceCollectionResourceCollectionFilterFactory> WithResourceCollectionFilter<T1, T2>(this CombinedResult<T1, ResourceCollectionFactory, T2> combinedResult, Action<Humidifier.DevOpsGuru.ResourceCollectionTypes.ResourceCollectionFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceCollectionFilter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ResourceCollectionFactory, InnerResourceCollectionResourceCollectionFilterFactory> WithResourceCollectionFilter<T1, T2>(this CombinedResult<T1, T2, ResourceCollectionFactory> combinedResult, Action<Humidifier.DevOpsGuru.ResourceCollectionTypes.ResourceCollectionFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceCollectionFilter(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ResourceCollectionFactory, T1, T2, T3, InnerResourceCollectionResourceCollectionFilterFactory> WithResourceCollectionFilter<T1, T2, T3>(this CombinedResult<ResourceCollectionFactory, T1, T2, T3> combinedResult, Action<Humidifier.DevOpsGuru.ResourceCollectionTypes.ResourceCollectionFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceCollectionFilter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResourceCollectionFactory, T2, T3, InnerResourceCollectionResourceCollectionFilterFactory> WithResourceCollectionFilter<T1, T2, T3>(this CombinedResult<T1, ResourceCollectionFactory, T2, T3> combinedResult, Action<Humidifier.DevOpsGuru.ResourceCollectionTypes.ResourceCollectionFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceCollectionFilter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ResourceCollectionFactory, T3, InnerResourceCollectionResourceCollectionFilterFactory> WithResourceCollectionFilter<T1, T2, T3>(this CombinedResult<T1, T2, ResourceCollectionFactory, T3> combinedResult, Action<Humidifier.DevOpsGuru.ResourceCollectionTypes.ResourceCollectionFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceCollectionFilter(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ResourceCollectionFactory, InnerResourceCollectionResourceCollectionFilterFactory> WithResourceCollectionFilter<T1, T2, T3>(this CombinedResult<T1, T2, T3, ResourceCollectionFactory> combinedResult, Action<Humidifier.DevOpsGuru.ResourceCollectionTypes.ResourceCollectionFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceCollectionFilter(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ResourceCollectionFactory, T1, T2, T3, T4, InnerResourceCollectionResourceCollectionFilterFactory> WithResourceCollectionFilter<T1, T2, T3, T4>(this CombinedResult<ResourceCollectionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsGuru.ResourceCollectionTypes.ResourceCollectionFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceCollectionFilter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResourceCollectionFactory, T2, T3, T4, InnerResourceCollectionResourceCollectionFilterFactory> WithResourceCollectionFilter<T1, T2, T3, T4>(this CombinedResult<T1, ResourceCollectionFactory, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsGuru.ResourceCollectionTypes.ResourceCollectionFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceCollectionFilter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ResourceCollectionFactory, T3, T4, InnerResourceCollectionResourceCollectionFilterFactory> WithResourceCollectionFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, ResourceCollectionFactory, T3, T4> combinedResult, Action<Humidifier.DevOpsGuru.ResourceCollectionTypes.ResourceCollectionFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceCollectionFilter(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ResourceCollectionFactory, T4, InnerResourceCollectionResourceCollectionFilterFactory> WithResourceCollectionFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ResourceCollectionFactory, T4> combinedResult, Action<Humidifier.DevOpsGuru.ResourceCollectionTypes.ResourceCollectionFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceCollectionFilter(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ResourceCollectionFactory, InnerResourceCollectionResourceCollectionFilterFactory> WithResourceCollectionFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ResourceCollectionFactory> combinedResult, Action<Humidifier.DevOpsGuru.ResourceCollectionTypes.ResourceCollectionFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceCollectionFilter(combinedResult.T5, subFactoryAction));
}
