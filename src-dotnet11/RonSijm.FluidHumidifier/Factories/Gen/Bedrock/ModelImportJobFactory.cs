// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class ModelImportJobFactory(string resourceName = null, Action<Humidifier.Bedrock.ModelImportJob> factoryAction = null) : ResourceFactory<Humidifier.Bedrock.ModelImportJob>(resourceName)
{

    internal InnerModelImportJobVpcConfigFactory VpcConfigFactory { get; set; }

    internal InnerModelImportJobModelDataSourceFactory ModelDataSourceFactory { get; set; }

    protected override Humidifier.Bedrock.ModelImportJob Create()
    {
        var modelImportJobResult = CreateModelImportJob();
        factoryAction?.Invoke(modelImportJobResult);

        return modelImportJobResult;
    }

    private Humidifier.Bedrock.ModelImportJob CreateModelImportJob()
    {
        var modelImportJobResult = new Humidifier.Bedrock.ModelImportJob
        {
            GivenName = InputResourceName,
        };

        return modelImportJobResult;
    }
    public override void CreateChildren(Humidifier.Bedrock.ModelImportJob result)
    {
        base.CreateChildren(result);

        result.VpcConfig ??= VpcConfigFactory?.Build();
        result.ModelDataSource ??= ModelDataSourceFactory?.Build();
    }

} // End Of Class

public static class ModelImportJobFactoryExtensions
{
    public static CombinedResult<ModelImportJobFactory, InnerModelImportJobVpcConfigFactory> WithVpcConfig(this ModelImportJobFactory parentFactory, Action<Humidifier.Bedrock.ModelImportJobTypes.VpcConfig> subFactoryAction = null)
    {
        parentFactory.VpcConfigFactory = new InnerModelImportJobVpcConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VpcConfigFactory);
    }

    public static CombinedResult<ModelImportJobFactory, InnerModelImportJobModelDataSourceFactory> WithModelDataSource(this ModelImportJobFactory parentFactory, Action<Humidifier.Bedrock.ModelImportJobTypes.ModelDataSource> subFactoryAction = null)
    {
        parentFactory.ModelDataSourceFactory = new InnerModelImportJobModelDataSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ModelDataSourceFactory);
    }

    public static CombinedResult<ModelImportJobFactory, T1, InnerModelImportJobVpcConfigFactory> WithVpcConfig<T1>(this CombinedResult<ModelImportJobFactory, T1> combinedResult, Action<Humidifier.Bedrock.ModelImportJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ModelImportJobFactory, InnerModelImportJobVpcConfigFactory> WithVpcConfig<T1>(this CombinedResult<T1, ModelImportJobFactory> combinedResult, Action<Humidifier.Bedrock.ModelImportJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ModelImportJobFactory, T1, T2, InnerModelImportJobVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<ModelImportJobFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.ModelImportJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ModelImportJobFactory, T2, InnerModelImportJobVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<T1, ModelImportJobFactory, T2> combinedResult, Action<Humidifier.Bedrock.ModelImportJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ModelImportJobFactory, InnerModelImportJobVpcConfigFactory> WithVpcConfig<T1, T2>(this CombinedResult<T1, T2, ModelImportJobFactory> combinedResult, Action<Humidifier.Bedrock.ModelImportJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ModelImportJobFactory, T1, T2, T3, InnerModelImportJobVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<ModelImportJobFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.ModelImportJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ModelImportJobFactory, T2, T3, InnerModelImportJobVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, ModelImportJobFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.ModelImportJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ModelImportJobFactory, T3, InnerModelImportJobVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, T2, ModelImportJobFactory, T3> combinedResult, Action<Humidifier.Bedrock.ModelImportJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ModelImportJobFactory, InnerModelImportJobVpcConfigFactory> WithVpcConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, ModelImportJobFactory> combinedResult, Action<Humidifier.Bedrock.ModelImportJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ModelImportJobFactory, T1, T2, T3, T4, InnerModelImportJobVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<ModelImportJobFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.ModelImportJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ModelImportJobFactory, T2, T3, T4, InnerModelImportJobVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, ModelImportJobFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.ModelImportJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ModelImportJobFactory, T3, T4, InnerModelImportJobVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, ModelImportJobFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.ModelImportJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ModelImportJobFactory, T4, InnerModelImportJobVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ModelImportJobFactory, T4> combinedResult, Action<Humidifier.Bedrock.ModelImportJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ModelImportJobFactory, InnerModelImportJobVpcConfigFactory> WithVpcConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ModelImportJobFactory> combinedResult, Action<Humidifier.Bedrock.ModelImportJobTypes.VpcConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcConfig(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<ModelImportJobFactory, T1, InnerModelImportJobModelDataSourceFactory> WithModelDataSource<T1>(this CombinedResult<ModelImportJobFactory, T1> combinedResult, Action<Humidifier.Bedrock.ModelImportJobTypes.ModelDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithModelDataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ModelImportJobFactory, InnerModelImportJobModelDataSourceFactory> WithModelDataSource<T1>(this CombinedResult<T1, ModelImportJobFactory> combinedResult, Action<Humidifier.Bedrock.ModelImportJobTypes.ModelDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithModelDataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ModelImportJobFactory, T1, T2, InnerModelImportJobModelDataSourceFactory> WithModelDataSource<T1, T2>(this CombinedResult<ModelImportJobFactory, T1, T2> combinedResult, Action<Humidifier.Bedrock.ModelImportJobTypes.ModelDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithModelDataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ModelImportJobFactory, T2, InnerModelImportJobModelDataSourceFactory> WithModelDataSource<T1, T2>(this CombinedResult<T1, ModelImportJobFactory, T2> combinedResult, Action<Humidifier.Bedrock.ModelImportJobTypes.ModelDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithModelDataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ModelImportJobFactory, InnerModelImportJobModelDataSourceFactory> WithModelDataSource<T1, T2>(this CombinedResult<T1, T2, ModelImportJobFactory> combinedResult, Action<Humidifier.Bedrock.ModelImportJobTypes.ModelDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithModelDataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ModelImportJobFactory, T1, T2, T3, InnerModelImportJobModelDataSourceFactory> WithModelDataSource<T1, T2, T3>(this CombinedResult<ModelImportJobFactory, T1, T2, T3> combinedResult, Action<Humidifier.Bedrock.ModelImportJobTypes.ModelDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithModelDataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ModelImportJobFactory, T2, T3, InnerModelImportJobModelDataSourceFactory> WithModelDataSource<T1, T2, T3>(this CombinedResult<T1, ModelImportJobFactory, T2, T3> combinedResult, Action<Humidifier.Bedrock.ModelImportJobTypes.ModelDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithModelDataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ModelImportJobFactory, T3, InnerModelImportJobModelDataSourceFactory> WithModelDataSource<T1, T2, T3>(this CombinedResult<T1, T2, ModelImportJobFactory, T3> combinedResult, Action<Humidifier.Bedrock.ModelImportJobTypes.ModelDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithModelDataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ModelImportJobFactory, InnerModelImportJobModelDataSourceFactory> WithModelDataSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, ModelImportJobFactory> combinedResult, Action<Humidifier.Bedrock.ModelImportJobTypes.ModelDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithModelDataSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ModelImportJobFactory, T1, T2, T3, T4, InnerModelImportJobModelDataSourceFactory> WithModelDataSource<T1, T2, T3, T4>(this CombinedResult<ModelImportJobFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.ModelImportJobTypes.ModelDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModelDataSource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ModelImportJobFactory, T2, T3, T4, InnerModelImportJobModelDataSourceFactory> WithModelDataSource<T1, T2, T3, T4>(this CombinedResult<T1, ModelImportJobFactory, T2, T3, T4> combinedResult, Action<Humidifier.Bedrock.ModelImportJobTypes.ModelDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModelDataSource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ModelImportJobFactory, T3, T4, InnerModelImportJobModelDataSourceFactory> WithModelDataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, ModelImportJobFactory, T3, T4> combinedResult, Action<Humidifier.Bedrock.ModelImportJobTypes.ModelDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModelDataSource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ModelImportJobFactory, T4, InnerModelImportJobModelDataSourceFactory> WithModelDataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ModelImportJobFactory, T4> combinedResult, Action<Humidifier.Bedrock.ModelImportJobTypes.ModelDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModelDataSource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ModelImportJobFactory, InnerModelImportJobModelDataSourceFactory> WithModelDataSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ModelImportJobFactory> combinedResult, Action<Humidifier.Bedrock.ModelImportJobTypes.ModelDataSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithModelDataSource(combinedResult.T5, subFactoryAction).T2);
}
