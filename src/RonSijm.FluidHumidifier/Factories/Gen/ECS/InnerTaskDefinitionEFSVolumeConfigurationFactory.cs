// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerTaskDefinitionEFSVolumeConfigurationFactory(Action<Humidifier.ECS.TaskDefinitionTypes.EFSVolumeConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ECS.TaskDefinitionTypes.EFSVolumeConfiguration>
{

    internal InnerTaskDefinitionAuthorizationConfigFactory AuthorizationConfigFactory { get; set; }

    protected override Humidifier.ECS.TaskDefinitionTypes.EFSVolumeConfiguration Create()
    {
        var eFSVolumeConfigurationResult = CreateEFSVolumeConfiguration();
        factoryAction?.Invoke(eFSVolumeConfigurationResult);

        return eFSVolumeConfigurationResult;
    }

    private Humidifier.ECS.TaskDefinitionTypes.EFSVolumeConfiguration CreateEFSVolumeConfiguration()
    {
        var eFSVolumeConfigurationResult = new Humidifier.ECS.TaskDefinitionTypes.EFSVolumeConfiguration();

        return eFSVolumeConfigurationResult;
    }
    public override void CreateChildren(Humidifier.ECS.TaskDefinitionTypes.EFSVolumeConfiguration result)
    {
        base.CreateChildren(result);

        result.AuthorizationConfig ??= AuthorizationConfigFactory?.Build();
    }

} // End Of Class

public static class InnerTaskDefinitionEFSVolumeConfigurationFactoryExtensions
{
    public static CombinedResult<InnerTaskDefinitionEFSVolumeConfigurationFactory, InnerTaskDefinitionAuthorizationConfigFactory> WithAuthorizationConfig(this InnerTaskDefinitionEFSVolumeConfigurationFactory parentFactory, Action<Humidifier.ECS.TaskDefinitionTypes.AuthorizationConfig> subFactoryAction = null)
    {
        parentFactory.AuthorizationConfigFactory = new InnerTaskDefinitionAuthorizationConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AuthorizationConfigFactory);
    }

    public static CombinedResult<InnerTaskDefinitionEFSVolumeConfigurationFactory, T1, InnerTaskDefinitionAuthorizationConfigFactory> WithAuthorizationConfig<T1>(this CombinedResult<InnerTaskDefinitionEFSVolumeConfigurationFactory, T1> combinedResult, Action<Humidifier.ECS.TaskDefinitionTypes.AuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskDefinitionEFSVolumeConfigurationFactory, InnerTaskDefinitionAuthorizationConfigFactory> WithAuthorizationConfig<T1>(this CombinedResult<T1, InnerTaskDefinitionEFSVolumeConfigurationFactory> combinedResult, Action<Humidifier.ECS.TaskDefinitionTypes.AuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTaskDefinitionEFSVolumeConfigurationFactory, T1, T2, InnerTaskDefinitionAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2>(this CombinedResult<InnerTaskDefinitionEFSVolumeConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.ECS.TaskDefinitionTypes.AuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskDefinitionEFSVolumeConfigurationFactory, T2, InnerTaskDefinitionAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2>(this CombinedResult<T1, InnerTaskDefinitionEFSVolumeConfigurationFactory, T2> combinedResult, Action<Humidifier.ECS.TaskDefinitionTypes.AuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTaskDefinitionEFSVolumeConfigurationFactory, InnerTaskDefinitionAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2>(this CombinedResult<T1, T2, InnerTaskDefinitionEFSVolumeConfigurationFactory> combinedResult, Action<Humidifier.ECS.TaskDefinitionTypes.AuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTaskDefinitionEFSVolumeConfigurationFactory, T1, T2, T3, InnerTaskDefinitionAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3>(this CombinedResult<InnerTaskDefinitionEFSVolumeConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.ECS.TaskDefinitionTypes.AuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskDefinitionEFSVolumeConfigurationFactory, T2, T3, InnerTaskDefinitionAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3>(this CombinedResult<T1, InnerTaskDefinitionEFSVolumeConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.ECS.TaskDefinitionTypes.AuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTaskDefinitionEFSVolumeConfigurationFactory, T3, InnerTaskDefinitionAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerTaskDefinitionEFSVolumeConfigurationFactory, T3> combinedResult, Action<Humidifier.ECS.TaskDefinitionTypes.AuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTaskDefinitionEFSVolumeConfigurationFactory, InnerTaskDefinitionAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTaskDefinitionEFSVolumeConfigurationFactory> combinedResult, Action<Humidifier.ECS.TaskDefinitionTypes.AuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTaskDefinitionEFSVolumeConfigurationFactory, T1, T2, T3, T4, InnerTaskDefinitionAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<InnerTaskDefinitionEFSVolumeConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ECS.TaskDefinitionTypes.AuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskDefinitionEFSVolumeConfigurationFactory, T2, T3, T4, InnerTaskDefinitionAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerTaskDefinitionEFSVolumeConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.ECS.TaskDefinitionTypes.AuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTaskDefinitionEFSVolumeConfigurationFactory, T3, T4, InnerTaskDefinitionAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTaskDefinitionEFSVolumeConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.ECS.TaskDefinitionTypes.AuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTaskDefinitionEFSVolumeConfigurationFactory, T4, InnerTaskDefinitionAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTaskDefinitionEFSVolumeConfigurationFactory, T4> combinedResult, Action<Humidifier.ECS.TaskDefinitionTypes.AuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTaskDefinitionEFSVolumeConfigurationFactory, InnerTaskDefinitionAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTaskDefinitionEFSVolumeConfigurationFactory> combinedResult, Action<Humidifier.ECS.TaskDefinitionTypes.AuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T5, subFactoryAction));
}
