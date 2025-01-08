// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Batch;

public class InnerJobDefinitionEksPodPropertiesFactory(Action<Humidifier.Batch.JobDefinitionTypes.EksPodProperties> factoryAction = null) : SubResourceFactory<Humidifier.Batch.JobDefinitionTypes.EksPodProperties>
{

    internal InnerJobDefinitionEksMetadataFactory MetadataFactory { get; set; }

    protected override Humidifier.Batch.JobDefinitionTypes.EksPodProperties Create()
    {
        var eksPodPropertiesResult = CreateEksPodProperties();
        factoryAction?.Invoke(eksPodPropertiesResult);

        return eksPodPropertiesResult;
    }

    private Humidifier.Batch.JobDefinitionTypes.EksPodProperties CreateEksPodProperties()
    {
        var eksPodPropertiesResult = new Humidifier.Batch.JobDefinitionTypes.EksPodProperties();

        return eksPodPropertiesResult;
    }
    public override void CreateChildren(Humidifier.Batch.JobDefinitionTypes.EksPodProperties result)
    {
        base.CreateChildren(result);

        result.Metadata ??= MetadataFactory?.Build();
    }

} // End Of Class

public static class InnerJobDefinitionEksPodPropertiesFactoryExtensions
{
    public static CombinedResult<InnerJobDefinitionEksPodPropertiesFactory, InnerJobDefinitionEksMetadataFactory> WithMetadata(this InnerJobDefinitionEksPodPropertiesFactory parentFactory, Action<Humidifier.Batch.JobDefinitionTypes.EksMetadata> subFactoryAction = null)
    {
        parentFactory.MetadataFactory = new InnerJobDefinitionEksMetadataFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MetadataFactory);
    }

    public static CombinedResult<InnerJobDefinitionEksPodPropertiesFactory, T1, InnerJobDefinitionEksMetadataFactory> WithMetadata<T1>(this CombinedResult<InnerJobDefinitionEksPodPropertiesFactory, T1> combinedResult, Action<Humidifier.Batch.JobDefinitionTypes.EksMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, WithMetadata(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobDefinitionEksPodPropertiesFactory, InnerJobDefinitionEksMetadataFactory> WithMetadata<T1>(this CombinedResult<T1, InnerJobDefinitionEksPodPropertiesFactory> combinedResult, Action<Humidifier.Batch.JobDefinitionTypes.EksMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, WithMetadata(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerJobDefinitionEksPodPropertiesFactory, T1, T2, InnerJobDefinitionEksMetadataFactory> WithMetadata<T1, T2>(this CombinedResult<InnerJobDefinitionEksPodPropertiesFactory, T1, T2> combinedResult, Action<Humidifier.Batch.JobDefinitionTypes.EksMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetadata(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobDefinitionEksPodPropertiesFactory, T2, InnerJobDefinitionEksMetadataFactory> WithMetadata<T1, T2>(this CombinedResult<T1, InnerJobDefinitionEksPodPropertiesFactory, T2> combinedResult, Action<Humidifier.Batch.JobDefinitionTypes.EksMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetadata(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerJobDefinitionEksPodPropertiesFactory, InnerJobDefinitionEksMetadataFactory> WithMetadata<T1, T2>(this CombinedResult<T1, T2, InnerJobDefinitionEksPodPropertiesFactory> combinedResult, Action<Humidifier.Batch.JobDefinitionTypes.EksMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetadata(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerJobDefinitionEksPodPropertiesFactory, T1, T2, T3, InnerJobDefinitionEksMetadataFactory> WithMetadata<T1, T2, T3>(this CombinedResult<InnerJobDefinitionEksPodPropertiesFactory, T1, T2, T3> combinedResult, Action<Humidifier.Batch.JobDefinitionTypes.EksMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetadata(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobDefinitionEksPodPropertiesFactory, T2, T3, InnerJobDefinitionEksMetadataFactory> WithMetadata<T1, T2, T3>(this CombinedResult<T1, InnerJobDefinitionEksPodPropertiesFactory, T2, T3> combinedResult, Action<Humidifier.Batch.JobDefinitionTypes.EksMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetadata(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerJobDefinitionEksPodPropertiesFactory, T3, InnerJobDefinitionEksMetadataFactory> WithMetadata<T1, T2, T3>(this CombinedResult<T1, T2, InnerJobDefinitionEksPodPropertiesFactory, T3> combinedResult, Action<Humidifier.Batch.JobDefinitionTypes.EksMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetadata(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerJobDefinitionEksPodPropertiesFactory, InnerJobDefinitionEksMetadataFactory> WithMetadata<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerJobDefinitionEksPodPropertiesFactory> combinedResult, Action<Humidifier.Batch.JobDefinitionTypes.EksMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetadata(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerJobDefinitionEksPodPropertiesFactory, T1, T2, T3, T4, InnerJobDefinitionEksMetadataFactory> WithMetadata<T1, T2, T3, T4>(this CombinedResult<InnerJobDefinitionEksPodPropertiesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Batch.JobDefinitionTypes.EksMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetadata(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobDefinitionEksPodPropertiesFactory, T2, T3, T4, InnerJobDefinitionEksMetadataFactory> WithMetadata<T1, T2, T3, T4>(this CombinedResult<T1, InnerJobDefinitionEksPodPropertiesFactory, T2, T3, T4> combinedResult, Action<Humidifier.Batch.JobDefinitionTypes.EksMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetadata(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerJobDefinitionEksPodPropertiesFactory, T3, T4, InnerJobDefinitionEksMetadataFactory> WithMetadata<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerJobDefinitionEksPodPropertiesFactory, T3, T4> combinedResult, Action<Humidifier.Batch.JobDefinitionTypes.EksMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetadata(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerJobDefinitionEksPodPropertiesFactory, T4, InnerJobDefinitionEksMetadataFactory> WithMetadata<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerJobDefinitionEksPodPropertiesFactory, T4> combinedResult, Action<Humidifier.Batch.JobDefinitionTypes.EksMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetadata(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerJobDefinitionEksPodPropertiesFactory, InnerJobDefinitionEksMetadataFactory> WithMetadata<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerJobDefinitionEksPodPropertiesFactory> combinedResult, Action<Humidifier.Batch.JobDefinitionTypes.EksMetadata> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetadata(combinedResult.T5, subFactoryAction));
}
