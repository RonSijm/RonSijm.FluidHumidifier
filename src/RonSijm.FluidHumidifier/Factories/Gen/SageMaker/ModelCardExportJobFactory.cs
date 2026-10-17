// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class ModelCardExportJobFactory(string resourceName = null, Action<Humidifier.SageMaker.ModelCardExportJob> factoryAction = null) : ResourceFactory<Humidifier.SageMaker.ModelCardExportJob>(resourceName)
{

    internal InnerModelCardExportJobModelCardExportOutputConfigFactory OutputConfigFactory { get; set; }

    protected override Humidifier.SageMaker.ModelCardExportJob Create()
    {
        var modelCardExportJobResult = CreateModelCardExportJob();
        factoryAction?.Invoke(modelCardExportJobResult);

        return modelCardExportJobResult;
    }

    private Humidifier.SageMaker.ModelCardExportJob CreateModelCardExportJob()
    {
        var modelCardExportJobResult = new Humidifier.SageMaker.ModelCardExportJob
        {
            GivenName = InputResourceName,
        };

        return modelCardExportJobResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.ModelCardExportJob result)
    {
        base.CreateChildren(result);

        result.OutputConfig ??= OutputConfigFactory?.Build();
    }

} // End Of Class

public static class ModelCardExportJobFactoryExtensions
{
    public static CombinedResult<ModelCardExportJobFactory, InnerModelCardExportJobModelCardExportOutputConfigFactory> WithOutputConfig(this ModelCardExportJobFactory parentFactory, Action<Humidifier.SageMaker.ModelCardExportJobTypes.ModelCardExportOutputConfig> subFactoryAction = null)
    {
        parentFactory.OutputConfigFactory = new InnerModelCardExportJobModelCardExportOutputConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OutputConfigFactory);
    }

    public static CombinedResult<ModelCardExportJobFactory, T1, InnerModelCardExportJobModelCardExportOutputConfigFactory> WithOutputConfig<T1>(this CombinedResult<ModelCardExportJobFactory, T1> combinedResult, Action<Humidifier.SageMaker.ModelCardExportJobTypes.ModelCardExportOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithOutputConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ModelCardExportJobFactory, InnerModelCardExportJobModelCardExportOutputConfigFactory> WithOutputConfig<T1>(this CombinedResult<T1, ModelCardExportJobFactory> combinedResult, Action<Humidifier.SageMaker.ModelCardExportJobTypes.ModelCardExportOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithOutputConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ModelCardExportJobFactory, T1, T2, InnerModelCardExportJobModelCardExportOutputConfigFactory> WithOutputConfig<T1, T2>(this CombinedResult<ModelCardExportJobFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ModelCardExportJobTypes.ModelCardExportOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutputConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ModelCardExportJobFactory, T2, InnerModelCardExportJobModelCardExportOutputConfigFactory> WithOutputConfig<T1, T2>(this CombinedResult<T1, ModelCardExportJobFactory, T2> combinedResult, Action<Humidifier.SageMaker.ModelCardExportJobTypes.ModelCardExportOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutputConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ModelCardExportJobFactory, InnerModelCardExportJobModelCardExportOutputConfigFactory> WithOutputConfig<T1, T2>(this CombinedResult<T1, T2, ModelCardExportJobFactory> combinedResult, Action<Humidifier.SageMaker.ModelCardExportJobTypes.ModelCardExportOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOutputConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ModelCardExportJobFactory, T1, T2, T3, InnerModelCardExportJobModelCardExportOutputConfigFactory> WithOutputConfig<T1, T2, T3>(this CombinedResult<ModelCardExportJobFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelCardExportJobTypes.ModelCardExportOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ModelCardExportJobFactory, T2, T3, InnerModelCardExportJobModelCardExportOutputConfigFactory> WithOutputConfig<T1, T2, T3>(this CombinedResult<T1, ModelCardExportJobFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelCardExportJobTypes.ModelCardExportOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ModelCardExportJobFactory, T3, InnerModelCardExportJobModelCardExportOutputConfigFactory> WithOutputConfig<T1, T2, T3>(this CombinedResult<T1, T2, ModelCardExportJobFactory, T3> combinedResult, Action<Humidifier.SageMaker.ModelCardExportJobTypes.ModelCardExportOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ModelCardExportJobFactory, InnerModelCardExportJobModelCardExportOutputConfigFactory> WithOutputConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, ModelCardExportJobFactory> combinedResult, Action<Humidifier.SageMaker.ModelCardExportJobTypes.ModelCardExportOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ModelCardExportJobFactory, T1, T2, T3, T4, InnerModelCardExportJobModelCardExportOutputConfigFactory> WithOutputConfig<T1, T2, T3, T4>(this CombinedResult<ModelCardExportJobFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelCardExportJobTypes.ModelCardExportOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ModelCardExportJobFactory, T2, T3, T4, InnerModelCardExportJobModelCardExportOutputConfigFactory> WithOutputConfig<T1, T2, T3, T4>(this CombinedResult<T1, ModelCardExportJobFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelCardExportJobTypes.ModelCardExportOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ModelCardExportJobFactory, T3, T4, InnerModelCardExportJobModelCardExportOutputConfigFactory> WithOutputConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, ModelCardExportJobFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelCardExportJobTypes.ModelCardExportOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ModelCardExportJobFactory, T4, InnerModelCardExportJobModelCardExportOutputConfigFactory> WithOutputConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ModelCardExportJobFactory, T4> combinedResult, Action<Humidifier.SageMaker.ModelCardExportJobTypes.ModelCardExportOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ModelCardExportJobFactory, InnerModelCardExportJobModelCardExportOutputConfigFactory> WithOutputConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ModelCardExportJobFactory> combinedResult, Action<Humidifier.SageMaker.ModelCardExportJobTypes.ModelCardExportOutputConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOutputConfig(combinedResult.T5, subFactoryAction).T2);
}
