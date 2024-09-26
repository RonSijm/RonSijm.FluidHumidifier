// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerServiceServiceConnectConfigurationFactory(Action<Humidifier.ECS.ServiceTypes.ServiceConnectConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ECS.ServiceTypes.ServiceConnectConfiguration>
{

    internal InnerServiceLogConfigurationFactory LogConfigurationFactory { get; set; }

    protected override Humidifier.ECS.ServiceTypes.ServiceConnectConfiguration Create()
    {
        var serviceConnectConfigurationResult = CreateServiceConnectConfiguration();
        factoryAction?.Invoke(serviceConnectConfigurationResult);

        return serviceConnectConfigurationResult;
    }

    private Humidifier.ECS.ServiceTypes.ServiceConnectConfiguration CreateServiceConnectConfiguration()
    {
        var serviceConnectConfigurationResult = new Humidifier.ECS.ServiceTypes.ServiceConnectConfiguration();

        return serviceConnectConfigurationResult;
    }
    public override void CreateChildren(Humidifier.ECS.ServiceTypes.ServiceConnectConfiguration result)
    {
        base.CreateChildren(result);

        result.LogConfiguration ??= LogConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerServiceServiceConnectConfigurationFactoryExtensions
{
    public static CombinedResult<InnerServiceServiceConnectConfigurationFactory, InnerServiceLogConfigurationFactory> WithLogConfiguration(this InnerServiceServiceConnectConfigurationFactory parentFactory, Action<Humidifier.ECS.ServiceTypes.LogConfiguration> subFactoryAction = null)
    {
        parentFactory.LogConfigurationFactory = new InnerServiceLogConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LogConfigurationFactory);
    }

    public static CombinedResult<InnerServiceServiceConnectConfigurationFactory, T1, InnerServiceLogConfigurationFactory> WithLogConfiguration<T1>(this CombinedResult<InnerServiceServiceConnectConfigurationFactory, T1> combinedResult, Action<Humidifier.ECS.ServiceTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLogConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceServiceConnectConfigurationFactory, InnerServiceLogConfigurationFactory> WithLogConfiguration<T1>(this CombinedResult<T1, InnerServiceServiceConnectConfigurationFactory> combinedResult, Action<Humidifier.ECS.ServiceTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLogConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerServiceServiceConnectConfigurationFactory, T1, T2, InnerServiceLogConfigurationFactory> WithLogConfiguration<T1, T2>(this CombinedResult<InnerServiceServiceConnectConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.ECS.ServiceTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceServiceConnectConfigurationFactory, T2, InnerServiceLogConfigurationFactory> WithLogConfiguration<T1, T2>(this CombinedResult<T1, InnerServiceServiceConnectConfigurationFactory, T2> combinedResult, Action<Humidifier.ECS.ServiceTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServiceServiceConnectConfigurationFactory, InnerServiceLogConfigurationFactory> WithLogConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerServiceServiceConnectConfigurationFactory> combinedResult, Action<Humidifier.ECS.ServiceTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerServiceServiceConnectConfigurationFactory, T1, T2, T3, InnerServiceLogConfigurationFactory> WithLogConfiguration<T1, T2, T3>(this CombinedResult<InnerServiceServiceConnectConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.ECS.ServiceTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceServiceConnectConfigurationFactory, T2, T3, InnerServiceLogConfigurationFactory> WithLogConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerServiceServiceConnectConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.ECS.ServiceTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServiceServiceConnectConfigurationFactory, T3, InnerServiceLogConfigurationFactory> WithLogConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerServiceServiceConnectConfigurationFactory, T3> combinedResult, Action<Humidifier.ECS.ServiceTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerServiceServiceConnectConfigurationFactory, InnerServiceLogConfigurationFactory> WithLogConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerServiceServiceConnectConfigurationFactory> combinedResult, Action<Humidifier.ECS.ServiceTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerServiceServiceConnectConfigurationFactory, T1, T2, T3, T4, InnerServiceLogConfigurationFactory> WithLogConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerServiceServiceConnectConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ECS.ServiceTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceServiceConnectConfigurationFactory, T2, T3, T4, InnerServiceLogConfigurationFactory> WithLogConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerServiceServiceConnectConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.ECS.ServiceTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServiceServiceConnectConfigurationFactory, T3, T4, InnerServiceLogConfigurationFactory> WithLogConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerServiceServiceConnectConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.ECS.ServiceTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerServiceServiceConnectConfigurationFactory, T4, InnerServiceLogConfigurationFactory> WithLogConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerServiceServiceConnectConfigurationFactory, T4> combinedResult, Action<Humidifier.ECS.ServiceTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerServiceServiceConnectConfigurationFactory, InnerServiceLogConfigurationFactory> WithLogConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerServiceServiceConnectConfigurationFactory> combinedResult, Action<Humidifier.ECS.ServiceTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T5, subFactoryAction));
}
