// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFormation;

public class ResourceVersionFactory(string resourceName = null, Action<Humidifier.CloudFormation.ResourceVersion> factoryAction = null) : ResourceFactory<Humidifier.CloudFormation.ResourceVersion>(resourceName)
{

    internal InnerResourceVersionLoggingConfigFactory LoggingConfigFactory { get; set; }

    protected override Humidifier.CloudFormation.ResourceVersion Create()
    {
        var resourceVersionResult = CreateResourceVersion();
        factoryAction?.Invoke(resourceVersionResult);

        return resourceVersionResult;
    }

    private Humidifier.CloudFormation.ResourceVersion CreateResourceVersion()
    {
        var resourceVersionResult = new Humidifier.CloudFormation.ResourceVersion
        {
            GivenName = InputResourceName,
        };

        return resourceVersionResult;
    }
    public override void CreateChildren(Humidifier.CloudFormation.ResourceVersion result)
    {
        base.CreateChildren(result);

        result.LoggingConfig ??= LoggingConfigFactory?.Build();
    }

} // End Of Class

public static class ResourceVersionFactoryExtensions
{
    public static CombinedResult<ResourceVersionFactory, InnerResourceVersionLoggingConfigFactory> WithLoggingConfig(this ResourceVersionFactory parentFactory, Action<Humidifier.CloudFormation.ResourceVersionTypes.LoggingConfig> subFactoryAction = null)
    {
        parentFactory.LoggingConfigFactory = new InnerResourceVersionLoggingConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LoggingConfigFactory);
    }

    public static CombinedResult<ResourceVersionFactory, T1, InnerResourceVersionLoggingConfigFactory> WithLoggingConfig<T1>(this CombinedResult<ResourceVersionFactory, T1> combinedResult, Action<Humidifier.CloudFormation.ResourceVersionTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoggingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResourceVersionFactory, InnerResourceVersionLoggingConfigFactory> WithLoggingConfig<T1>(this CombinedResult<T1, ResourceVersionFactory> combinedResult, Action<Humidifier.CloudFormation.ResourceVersionTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithLoggingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ResourceVersionFactory, T1, T2, InnerResourceVersionLoggingConfigFactory> WithLoggingConfig<T1, T2>(this CombinedResult<ResourceVersionFactory, T1, T2> combinedResult, Action<Humidifier.CloudFormation.ResourceVersionTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResourceVersionFactory, T2, InnerResourceVersionLoggingConfigFactory> WithLoggingConfig<T1, T2>(this CombinedResult<T1, ResourceVersionFactory, T2> combinedResult, Action<Humidifier.CloudFormation.ResourceVersionTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ResourceVersionFactory, InnerResourceVersionLoggingConfigFactory> WithLoggingConfig<T1, T2>(this CombinedResult<T1, T2, ResourceVersionFactory> combinedResult, Action<Humidifier.CloudFormation.ResourceVersionTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ResourceVersionFactory, T1, T2, T3, InnerResourceVersionLoggingConfigFactory> WithLoggingConfig<T1, T2, T3>(this CombinedResult<ResourceVersionFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudFormation.ResourceVersionTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResourceVersionFactory, T2, T3, InnerResourceVersionLoggingConfigFactory> WithLoggingConfig<T1, T2, T3>(this CombinedResult<T1, ResourceVersionFactory, T2, T3> combinedResult, Action<Humidifier.CloudFormation.ResourceVersionTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ResourceVersionFactory, T3, InnerResourceVersionLoggingConfigFactory> WithLoggingConfig<T1, T2, T3>(this CombinedResult<T1, T2, ResourceVersionFactory, T3> combinedResult, Action<Humidifier.CloudFormation.ResourceVersionTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ResourceVersionFactory, InnerResourceVersionLoggingConfigFactory> WithLoggingConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, ResourceVersionFactory> combinedResult, Action<Humidifier.CloudFormation.ResourceVersionTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ResourceVersionFactory, T1, T2, T3, T4, InnerResourceVersionLoggingConfigFactory> WithLoggingConfig<T1, T2, T3, T4>(this CombinedResult<ResourceVersionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudFormation.ResourceVersionTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ResourceVersionFactory, T2, T3, T4, InnerResourceVersionLoggingConfigFactory> WithLoggingConfig<T1, T2, T3, T4>(this CombinedResult<T1, ResourceVersionFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudFormation.ResourceVersionTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ResourceVersionFactory, T3, T4, InnerResourceVersionLoggingConfigFactory> WithLoggingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, ResourceVersionFactory, T3, T4> combinedResult, Action<Humidifier.CloudFormation.ResourceVersionTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ResourceVersionFactory, T4, InnerResourceVersionLoggingConfigFactory> WithLoggingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ResourceVersionFactory, T4> combinedResult, Action<Humidifier.CloudFormation.ResourceVersionTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ResourceVersionFactory, InnerResourceVersionLoggingConfigFactory> WithLoggingConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ResourceVersionFactory> combinedResult, Action<Humidifier.CloudFormation.ResourceVersionTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLoggingConfig(combinedResult.T5, subFactoryAction));
}
