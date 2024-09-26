// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsGuru;

public class InnerResourceCollectionResourceCollectionFilterFactory(Action<Humidifier.DevOpsGuru.ResourceCollectionTypes.ResourceCollectionFilter> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsGuru.ResourceCollectionTypes.ResourceCollectionFilter>
{

    internal InnerResourceCollectionCloudFormationCollectionFilterFactory CloudFormationFactory { get; set; }

    protected override Humidifier.DevOpsGuru.ResourceCollectionTypes.ResourceCollectionFilter Create()
    {
        var resourceCollectionFilterResult = CreateResourceCollectionFilter();
        factoryAction?.Invoke(resourceCollectionFilterResult);

        return resourceCollectionFilterResult;
    }

    private Humidifier.DevOpsGuru.ResourceCollectionTypes.ResourceCollectionFilter CreateResourceCollectionFilter()
    {
        var resourceCollectionFilterResult = new Humidifier.DevOpsGuru.ResourceCollectionTypes.ResourceCollectionFilter();

        return resourceCollectionFilterResult;
    }
    public override void CreateChildren(Humidifier.DevOpsGuru.ResourceCollectionTypes.ResourceCollectionFilter result)
    {
        base.CreateChildren(result);

        result.CloudFormation ??= CloudFormationFactory?.Build();
    }

} // End Of Class

public static class InnerResourceCollectionResourceCollectionFilterFactoryExtensions
{
    public static CombinedResult<InnerResourceCollectionResourceCollectionFilterFactory, InnerResourceCollectionCloudFormationCollectionFilterFactory> WithCloudFormation(this InnerResourceCollectionResourceCollectionFilterFactory parentFactory, Action<Humidifier.DevOpsGuru.ResourceCollectionTypes.CloudFormationCollectionFilter> subFactoryAction = null)
    {
        parentFactory.CloudFormationFactory = new InnerResourceCollectionCloudFormationCollectionFilterFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CloudFormationFactory);
    }

    public static CombinedResult<InnerResourceCollectionResourceCollectionFilterFactory, T1, InnerResourceCollectionCloudFormationCollectionFilterFactory> WithCloudFormation<T1>(this CombinedResult<InnerResourceCollectionResourceCollectionFilterFactory, T1> combinedResult, Action<Humidifier.DevOpsGuru.ResourceCollectionTypes.CloudFormationCollectionFilter> subFactoryAction = null) => new (combinedResult, combinedResult, WithCloudFormation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceCollectionResourceCollectionFilterFactory, InnerResourceCollectionCloudFormationCollectionFilterFactory> WithCloudFormation<T1>(this CombinedResult<T1, InnerResourceCollectionResourceCollectionFilterFactory> combinedResult, Action<Humidifier.DevOpsGuru.ResourceCollectionTypes.CloudFormationCollectionFilter> subFactoryAction = null) => new (combinedResult, combinedResult, WithCloudFormation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerResourceCollectionResourceCollectionFilterFactory, T1, T2, InnerResourceCollectionCloudFormationCollectionFilterFactory> WithCloudFormation<T1, T2>(this CombinedResult<InnerResourceCollectionResourceCollectionFilterFactory, T1, T2> combinedResult, Action<Humidifier.DevOpsGuru.ResourceCollectionTypes.CloudFormationCollectionFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCloudFormation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceCollectionResourceCollectionFilterFactory, T2, InnerResourceCollectionCloudFormationCollectionFilterFactory> WithCloudFormation<T1, T2>(this CombinedResult<T1, InnerResourceCollectionResourceCollectionFilterFactory, T2> combinedResult, Action<Humidifier.DevOpsGuru.ResourceCollectionTypes.CloudFormationCollectionFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCloudFormation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceCollectionResourceCollectionFilterFactory, InnerResourceCollectionCloudFormationCollectionFilterFactory> WithCloudFormation<T1, T2>(this CombinedResult<T1, T2, InnerResourceCollectionResourceCollectionFilterFactory> combinedResult, Action<Humidifier.DevOpsGuru.ResourceCollectionTypes.CloudFormationCollectionFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCloudFormation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerResourceCollectionResourceCollectionFilterFactory, T1, T2, T3, InnerResourceCollectionCloudFormationCollectionFilterFactory> WithCloudFormation<T1, T2, T3>(this CombinedResult<InnerResourceCollectionResourceCollectionFilterFactory, T1, T2, T3> combinedResult, Action<Humidifier.DevOpsGuru.ResourceCollectionTypes.CloudFormationCollectionFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudFormation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceCollectionResourceCollectionFilterFactory, T2, T3, InnerResourceCollectionCloudFormationCollectionFilterFactory> WithCloudFormation<T1, T2, T3>(this CombinedResult<T1, InnerResourceCollectionResourceCollectionFilterFactory, T2, T3> combinedResult, Action<Humidifier.DevOpsGuru.ResourceCollectionTypes.CloudFormationCollectionFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudFormation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceCollectionResourceCollectionFilterFactory, T3, InnerResourceCollectionCloudFormationCollectionFilterFactory> WithCloudFormation<T1, T2, T3>(this CombinedResult<T1, T2, InnerResourceCollectionResourceCollectionFilterFactory, T3> combinedResult, Action<Humidifier.DevOpsGuru.ResourceCollectionTypes.CloudFormationCollectionFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudFormation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerResourceCollectionResourceCollectionFilterFactory, InnerResourceCollectionCloudFormationCollectionFilterFactory> WithCloudFormation<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerResourceCollectionResourceCollectionFilterFactory> combinedResult, Action<Humidifier.DevOpsGuru.ResourceCollectionTypes.CloudFormationCollectionFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudFormation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerResourceCollectionResourceCollectionFilterFactory, T1, T2, T3, T4, InnerResourceCollectionCloudFormationCollectionFilterFactory> WithCloudFormation<T1, T2, T3, T4>(this CombinedResult<InnerResourceCollectionResourceCollectionFilterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsGuru.ResourceCollectionTypes.CloudFormationCollectionFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudFormation(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerResourceCollectionResourceCollectionFilterFactory, T2, T3, T4, InnerResourceCollectionCloudFormationCollectionFilterFactory> WithCloudFormation<T1, T2, T3, T4>(this CombinedResult<T1, InnerResourceCollectionResourceCollectionFilterFactory, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsGuru.ResourceCollectionTypes.CloudFormationCollectionFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudFormation(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerResourceCollectionResourceCollectionFilterFactory, T3, T4, InnerResourceCollectionCloudFormationCollectionFilterFactory> WithCloudFormation<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerResourceCollectionResourceCollectionFilterFactory, T3, T4> combinedResult, Action<Humidifier.DevOpsGuru.ResourceCollectionTypes.CloudFormationCollectionFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudFormation(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerResourceCollectionResourceCollectionFilterFactory, T4, InnerResourceCollectionCloudFormationCollectionFilterFactory> WithCloudFormation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerResourceCollectionResourceCollectionFilterFactory, T4> combinedResult, Action<Humidifier.DevOpsGuru.ResourceCollectionTypes.CloudFormationCollectionFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudFormation(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerResourceCollectionResourceCollectionFilterFactory, InnerResourceCollectionCloudFormationCollectionFilterFactory> WithCloudFormation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerResourceCollectionResourceCollectionFilterFactory> combinedResult, Action<Humidifier.DevOpsGuru.ResourceCollectionTypes.CloudFormationCollectionFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudFormation(combinedResult.T5, subFactoryAction));
}
