// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerTaskDefinitionFSxWindowsFileServerVolumeConfigurationFactory(Action<Humidifier.ECS.TaskDefinitionTypes.FSxWindowsFileServerVolumeConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ECS.TaskDefinitionTypes.FSxWindowsFileServerVolumeConfiguration>
{

    internal InnerTaskDefinitionFSxAuthorizationConfigFactory AuthorizationConfigFactory { get; set; }

    protected override Humidifier.ECS.TaskDefinitionTypes.FSxWindowsFileServerVolumeConfiguration Create()
    {
        var fSxWindowsFileServerVolumeConfigurationResult = CreateFSxWindowsFileServerVolumeConfiguration();
        factoryAction?.Invoke(fSxWindowsFileServerVolumeConfigurationResult);

        return fSxWindowsFileServerVolumeConfigurationResult;
    }

    private Humidifier.ECS.TaskDefinitionTypes.FSxWindowsFileServerVolumeConfiguration CreateFSxWindowsFileServerVolumeConfiguration()
    {
        var fSxWindowsFileServerVolumeConfigurationResult = new Humidifier.ECS.TaskDefinitionTypes.FSxWindowsFileServerVolumeConfiguration();

        return fSxWindowsFileServerVolumeConfigurationResult;
    }
    public override void CreateChildren(Humidifier.ECS.TaskDefinitionTypes.FSxWindowsFileServerVolumeConfiguration result)
    {
        base.CreateChildren(result);

        result.AuthorizationConfig ??= AuthorizationConfigFactory?.Build();
    }

} // End Of Class

public static class InnerTaskDefinitionFSxWindowsFileServerVolumeConfigurationFactoryExtensions
{
    public static CombinedResult<InnerTaskDefinitionFSxWindowsFileServerVolumeConfigurationFactory, InnerTaskDefinitionFSxAuthorizationConfigFactory> WithAuthorizationConfig(this InnerTaskDefinitionFSxWindowsFileServerVolumeConfigurationFactory parentFactory, Action<Humidifier.ECS.TaskDefinitionTypes.FSxAuthorizationConfig> subFactoryAction = null)
    {
        parentFactory.AuthorizationConfigFactory = new InnerTaskDefinitionFSxAuthorizationConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AuthorizationConfigFactory);
    }

    public static CombinedResult<InnerTaskDefinitionFSxWindowsFileServerVolumeConfigurationFactory, T1, InnerTaskDefinitionFSxAuthorizationConfigFactory> WithAuthorizationConfig<T1>(this CombinedResult<InnerTaskDefinitionFSxWindowsFileServerVolumeConfigurationFactory, T1> combinedResult, Action<Humidifier.ECS.TaskDefinitionTypes.FSxAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskDefinitionFSxWindowsFileServerVolumeConfigurationFactory, InnerTaskDefinitionFSxAuthorizationConfigFactory> WithAuthorizationConfig<T1>(this CombinedResult<T1, InnerTaskDefinitionFSxWindowsFileServerVolumeConfigurationFactory> combinedResult, Action<Humidifier.ECS.TaskDefinitionTypes.FSxAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTaskDefinitionFSxWindowsFileServerVolumeConfigurationFactory, T1, T2, InnerTaskDefinitionFSxAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2>(this CombinedResult<InnerTaskDefinitionFSxWindowsFileServerVolumeConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.ECS.TaskDefinitionTypes.FSxAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskDefinitionFSxWindowsFileServerVolumeConfigurationFactory, T2, InnerTaskDefinitionFSxAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2>(this CombinedResult<T1, InnerTaskDefinitionFSxWindowsFileServerVolumeConfigurationFactory, T2> combinedResult, Action<Humidifier.ECS.TaskDefinitionTypes.FSxAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTaskDefinitionFSxWindowsFileServerVolumeConfigurationFactory, InnerTaskDefinitionFSxAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2>(this CombinedResult<T1, T2, InnerTaskDefinitionFSxWindowsFileServerVolumeConfigurationFactory> combinedResult, Action<Humidifier.ECS.TaskDefinitionTypes.FSxAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTaskDefinitionFSxWindowsFileServerVolumeConfigurationFactory, T1, T2, T3, InnerTaskDefinitionFSxAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3>(this CombinedResult<InnerTaskDefinitionFSxWindowsFileServerVolumeConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.ECS.TaskDefinitionTypes.FSxAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskDefinitionFSxWindowsFileServerVolumeConfigurationFactory, T2, T3, InnerTaskDefinitionFSxAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3>(this CombinedResult<T1, InnerTaskDefinitionFSxWindowsFileServerVolumeConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.ECS.TaskDefinitionTypes.FSxAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTaskDefinitionFSxWindowsFileServerVolumeConfigurationFactory, T3, InnerTaskDefinitionFSxAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerTaskDefinitionFSxWindowsFileServerVolumeConfigurationFactory, T3> combinedResult, Action<Humidifier.ECS.TaskDefinitionTypes.FSxAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTaskDefinitionFSxWindowsFileServerVolumeConfigurationFactory, InnerTaskDefinitionFSxAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTaskDefinitionFSxWindowsFileServerVolumeConfigurationFactory> combinedResult, Action<Humidifier.ECS.TaskDefinitionTypes.FSxAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTaskDefinitionFSxWindowsFileServerVolumeConfigurationFactory, T1, T2, T3, T4, InnerTaskDefinitionFSxAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<InnerTaskDefinitionFSxWindowsFileServerVolumeConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ECS.TaskDefinitionTypes.FSxAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTaskDefinitionFSxWindowsFileServerVolumeConfigurationFactory, T2, T3, T4, InnerTaskDefinitionFSxAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerTaskDefinitionFSxWindowsFileServerVolumeConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.ECS.TaskDefinitionTypes.FSxAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTaskDefinitionFSxWindowsFileServerVolumeConfigurationFactory, T3, T4, InnerTaskDefinitionFSxAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTaskDefinitionFSxWindowsFileServerVolumeConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.ECS.TaskDefinitionTypes.FSxAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTaskDefinitionFSxWindowsFileServerVolumeConfigurationFactory, T4, InnerTaskDefinitionFSxAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTaskDefinitionFSxWindowsFileServerVolumeConfigurationFactory, T4> combinedResult, Action<Humidifier.ECS.TaskDefinitionTypes.FSxAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTaskDefinitionFSxWindowsFileServerVolumeConfigurationFactory, InnerTaskDefinitionFSxAuthorizationConfigFactory> WithAuthorizationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTaskDefinitionFSxWindowsFileServerVolumeConfigurationFactory> combinedResult, Action<Humidifier.ECS.TaskDefinitionTypes.FSxAuthorizationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthorizationConfig(combinedResult.T5, subFactoryAction));
}
