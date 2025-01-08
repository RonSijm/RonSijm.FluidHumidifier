// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Batch;

public class InnerJobDefinitionEksPropertiesFactory(Action<Humidifier.Batch.JobDefinitionTypes.EksProperties> factoryAction = null) : SubResourceFactory<Humidifier.Batch.JobDefinitionTypes.EksProperties>
{

    internal InnerJobDefinitionEksPodPropertiesFactory PodPropertiesFactory { get; set; }

    protected override Humidifier.Batch.JobDefinitionTypes.EksProperties Create()
    {
        var eksPropertiesResult = CreateEksProperties();
        factoryAction?.Invoke(eksPropertiesResult);

        return eksPropertiesResult;
    }

    private Humidifier.Batch.JobDefinitionTypes.EksProperties CreateEksProperties()
    {
        var eksPropertiesResult = new Humidifier.Batch.JobDefinitionTypes.EksProperties();

        return eksPropertiesResult;
    }
    public override void CreateChildren(Humidifier.Batch.JobDefinitionTypes.EksProperties result)
    {
        base.CreateChildren(result);

        result.PodProperties ??= PodPropertiesFactory?.Build();
    }

} // End Of Class

public static class InnerJobDefinitionEksPropertiesFactoryExtensions
{
    public static CombinedResult<InnerJobDefinitionEksPropertiesFactory, InnerJobDefinitionEksPodPropertiesFactory> WithPodProperties(this InnerJobDefinitionEksPropertiesFactory parentFactory, Action<Humidifier.Batch.JobDefinitionTypes.EksPodProperties> subFactoryAction = null)
    {
        parentFactory.PodPropertiesFactory = new InnerJobDefinitionEksPodPropertiesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PodPropertiesFactory);
    }

    public static CombinedResult<InnerJobDefinitionEksPropertiesFactory, T1, InnerJobDefinitionEksPodPropertiesFactory> WithPodProperties<T1>(this CombinedResult<InnerJobDefinitionEksPropertiesFactory, T1> combinedResult, Action<Humidifier.Batch.JobDefinitionTypes.EksPodProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithPodProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobDefinitionEksPropertiesFactory, InnerJobDefinitionEksPodPropertiesFactory> WithPodProperties<T1>(this CombinedResult<T1, InnerJobDefinitionEksPropertiesFactory> combinedResult, Action<Humidifier.Batch.JobDefinitionTypes.EksPodProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithPodProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerJobDefinitionEksPropertiesFactory, T1, T2, InnerJobDefinitionEksPodPropertiesFactory> WithPodProperties<T1, T2>(this CombinedResult<InnerJobDefinitionEksPropertiesFactory, T1, T2> combinedResult, Action<Humidifier.Batch.JobDefinitionTypes.EksPodProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPodProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobDefinitionEksPropertiesFactory, T2, InnerJobDefinitionEksPodPropertiesFactory> WithPodProperties<T1, T2>(this CombinedResult<T1, InnerJobDefinitionEksPropertiesFactory, T2> combinedResult, Action<Humidifier.Batch.JobDefinitionTypes.EksPodProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPodProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerJobDefinitionEksPropertiesFactory, InnerJobDefinitionEksPodPropertiesFactory> WithPodProperties<T1, T2>(this CombinedResult<T1, T2, InnerJobDefinitionEksPropertiesFactory> combinedResult, Action<Humidifier.Batch.JobDefinitionTypes.EksPodProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPodProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerJobDefinitionEksPropertiesFactory, T1, T2, T3, InnerJobDefinitionEksPodPropertiesFactory> WithPodProperties<T1, T2, T3>(this CombinedResult<InnerJobDefinitionEksPropertiesFactory, T1, T2, T3> combinedResult, Action<Humidifier.Batch.JobDefinitionTypes.EksPodProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPodProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobDefinitionEksPropertiesFactory, T2, T3, InnerJobDefinitionEksPodPropertiesFactory> WithPodProperties<T1, T2, T3>(this CombinedResult<T1, InnerJobDefinitionEksPropertiesFactory, T2, T3> combinedResult, Action<Humidifier.Batch.JobDefinitionTypes.EksPodProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPodProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerJobDefinitionEksPropertiesFactory, T3, InnerJobDefinitionEksPodPropertiesFactory> WithPodProperties<T1, T2, T3>(this CombinedResult<T1, T2, InnerJobDefinitionEksPropertiesFactory, T3> combinedResult, Action<Humidifier.Batch.JobDefinitionTypes.EksPodProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPodProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerJobDefinitionEksPropertiesFactory, InnerJobDefinitionEksPodPropertiesFactory> WithPodProperties<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerJobDefinitionEksPropertiesFactory> combinedResult, Action<Humidifier.Batch.JobDefinitionTypes.EksPodProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPodProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerJobDefinitionEksPropertiesFactory, T1, T2, T3, T4, InnerJobDefinitionEksPodPropertiesFactory> WithPodProperties<T1, T2, T3, T4>(this CombinedResult<InnerJobDefinitionEksPropertiesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Batch.JobDefinitionTypes.EksPodProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPodProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerJobDefinitionEksPropertiesFactory, T2, T3, T4, InnerJobDefinitionEksPodPropertiesFactory> WithPodProperties<T1, T2, T3, T4>(this CombinedResult<T1, InnerJobDefinitionEksPropertiesFactory, T2, T3, T4> combinedResult, Action<Humidifier.Batch.JobDefinitionTypes.EksPodProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPodProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerJobDefinitionEksPropertiesFactory, T3, T4, InnerJobDefinitionEksPodPropertiesFactory> WithPodProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerJobDefinitionEksPropertiesFactory, T3, T4> combinedResult, Action<Humidifier.Batch.JobDefinitionTypes.EksPodProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPodProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerJobDefinitionEksPropertiesFactory, T4, InnerJobDefinitionEksPodPropertiesFactory> WithPodProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerJobDefinitionEksPropertiesFactory, T4> combinedResult, Action<Humidifier.Batch.JobDefinitionTypes.EksPodProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPodProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerJobDefinitionEksPropertiesFactory, InnerJobDefinitionEksPodPropertiesFactory> WithPodProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerJobDefinitionEksPropertiesFactory> combinedResult, Action<Humidifier.Batch.JobDefinitionTypes.EksPodProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPodProperties(combinedResult.T5, subFactoryAction));
}
