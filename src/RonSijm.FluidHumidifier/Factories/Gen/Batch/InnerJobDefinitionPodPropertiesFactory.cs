// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Batch;

public class InnerJobDefinitionPodPropertiesFactory(Action<Humidifier.Batch.JobDefinitionTypes.PodProperties> factoryAction = null) : SubResourceFactory<Humidifier.Batch.JobDefinitionTypes.PodProperties>
{

    internal InnerJobDefinitionMetadataFactory MetadataFactory { get; set; }

    protected override Humidifier.Batch.JobDefinitionTypes.PodProperties Create()
    {
        var podPropertiesResult = CreatePodProperties();
        factoryAction?.Invoke(podPropertiesResult);

        return podPropertiesResult;
    }

    private Humidifier.Batch.JobDefinitionTypes.PodProperties CreatePodProperties()
    {
        var podPropertiesResult = new Humidifier.Batch.JobDefinitionTypes.PodProperties();

        return podPropertiesResult;
    }
    public override void CreateChildren(Humidifier.Batch.JobDefinitionTypes.PodProperties result)
    {
        base.CreateChildren(result);

        result.Metadata ??= MetadataFactory?.Build();
    }

} // End Of Class

public static class InnerJobDefinitionPodPropertiesFactoryExtensions
{
    public static CombinedResult<InnerJobDefinitionPodPropertiesFactory, InnerJobDefinitionMetadataFactory> WithMetadata(this InnerJobDefinitionPodPropertiesFactory parentFactory, Action<Humidifier.Batch.JobDefinitionTypes.Metadata> subFactoryAction = null)
    {
        parentFactory.MetadataFactory = new InnerJobDefinitionMetadataFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MetadataFactory);
    }

    public static CombinedResult<InnerJobDefinitionPodPropertiesFactory, T1, InnerJobDefinitionMetadataFactory> WithMetadata<T1>(this CombinedResult<InnerJobDefinitionPodPropertiesFactory, T1> combinedResult, Action<Humidifier.Batch.JobDefinitionTypes.Metadata> subFactoryAction = null) => new (combinedResult, combinedResult, WithMetadata(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobDefinitionPodPropertiesFactory, InnerJobDefinitionMetadataFactory> WithMetadata<T1>(this CombinedResult<T1, InnerJobDefinitionPodPropertiesFactory> combinedResult, Action<Humidifier.Batch.JobDefinitionTypes.Metadata> subFactoryAction = null) => new (combinedResult, combinedResult, WithMetadata(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerJobDefinitionPodPropertiesFactory, T1, T2, InnerJobDefinitionMetadataFactory> WithMetadata<T1, T2>(this CombinedResult<InnerJobDefinitionPodPropertiesFactory, T1, T2> combinedResult, Action<Humidifier.Batch.JobDefinitionTypes.Metadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetadata(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobDefinitionPodPropertiesFactory, T2, InnerJobDefinitionMetadataFactory> WithMetadata<T1, T2>(this CombinedResult<T1, InnerJobDefinitionPodPropertiesFactory, T2> combinedResult, Action<Humidifier.Batch.JobDefinitionTypes.Metadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetadata(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerJobDefinitionPodPropertiesFactory, InnerJobDefinitionMetadataFactory> WithMetadata<T1, T2>(this CombinedResult<T1, T2, InnerJobDefinitionPodPropertiesFactory> combinedResult, Action<Humidifier.Batch.JobDefinitionTypes.Metadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetadata(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerJobDefinitionPodPropertiesFactory, T1, T2, T3, InnerJobDefinitionMetadataFactory> WithMetadata<T1, T2, T3>(this CombinedResult<InnerJobDefinitionPodPropertiesFactory, T1, T2, T3> combinedResult, Action<Humidifier.Batch.JobDefinitionTypes.Metadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetadata(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobDefinitionPodPropertiesFactory, T2, T3, InnerJobDefinitionMetadataFactory> WithMetadata<T1, T2, T3>(this CombinedResult<T1, InnerJobDefinitionPodPropertiesFactory, T2, T3> combinedResult, Action<Humidifier.Batch.JobDefinitionTypes.Metadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetadata(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerJobDefinitionPodPropertiesFactory, T3, InnerJobDefinitionMetadataFactory> WithMetadata<T1, T2, T3>(this CombinedResult<T1, T2, InnerJobDefinitionPodPropertiesFactory, T3> combinedResult, Action<Humidifier.Batch.JobDefinitionTypes.Metadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetadata(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerJobDefinitionPodPropertiesFactory, InnerJobDefinitionMetadataFactory> WithMetadata<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerJobDefinitionPodPropertiesFactory> combinedResult, Action<Humidifier.Batch.JobDefinitionTypes.Metadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetadata(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerJobDefinitionPodPropertiesFactory, T1, T2, T3, T4, InnerJobDefinitionMetadataFactory> WithMetadata<T1, T2, T3, T4>(this CombinedResult<InnerJobDefinitionPodPropertiesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Batch.JobDefinitionTypes.Metadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetadata(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobDefinitionPodPropertiesFactory, T2, T3, T4, InnerJobDefinitionMetadataFactory> WithMetadata<T1, T2, T3, T4>(this CombinedResult<T1, InnerJobDefinitionPodPropertiesFactory, T2, T3, T4> combinedResult, Action<Humidifier.Batch.JobDefinitionTypes.Metadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetadata(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerJobDefinitionPodPropertiesFactory, T3, T4, InnerJobDefinitionMetadataFactory> WithMetadata<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerJobDefinitionPodPropertiesFactory, T3, T4> combinedResult, Action<Humidifier.Batch.JobDefinitionTypes.Metadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetadata(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerJobDefinitionPodPropertiesFactory, T4, InnerJobDefinitionMetadataFactory> WithMetadata<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerJobDefinitionPodPropertiesFactory, T4> combinedResult, Action<Humidifier.Batch.JobDefinitionTypes.Metadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetadata(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerJobDefinitionPodPropertiesFactory, InnerJobDefinitionMetadataFactory> WithMetadata<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerJobDefinitionPodPropertiesFactory> combinedResult, Action<Humidifier.Batch.JobDefinitionTypes.Metadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetadata(combinedResult.T5, subFactoryAction));
}
