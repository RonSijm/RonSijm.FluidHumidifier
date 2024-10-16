// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerServiceServiceVolumeConfigurationFactory(Action<Humidifier.ECS.ServiceTypes.ServiceVolumeConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ECS.ServiceTypes.ServiceVolumeConfiguration>
{

    internal InnerServiceServiceManagedEBSVolumeConfigurationFactory ManagedEBSVolumeFactory { get; set; }

    protected override Humidifier.ECS.ServiceTypes.ServiceVolumeConfiguration Create()
    {
        var serviceVolumeConfigurationResult = CreateServiceVolumeConfiguration();
        factoryAction?.Invoke(serviceVolumeConfigurationResult);

        return serviceVolumeConfigurationResult;
    }

    private Humidifier.ECS.ServiceTypes.ServiceVolumeConfiguration CreateServiceVolumeConfiguration()
    {
        var serviceVolumeConfigurationResult = new Humidifier.ECS.ServiceTypes.ServiceVolumeConfiguration();

        return serviceVolumeConfigurationResult;
    }
    public override void CreateChildren(Humidifier.ECS.ServiceTypes.ServiceVolumeConfiguration result)
    {
        base.CreateChildren(result);

        result.ManagedEBSVolume ??= ManagedEBSVolumeFactory?.Build();
    }

} // End Of Class

public static class InnerServiceServiceVolumeConfigurationFactoryExtensions
{
    public static CombinedResult<InnerServiceServiceVolumeConfigurationFactory, InnerServiceServiceManagedEBSVolumeConfigurationFactory> WithManagedEBSVolume(this InnerServiceServiceVolumeConfigurationFactory parentFactory, Action<Humidifier.ECS.ServiceTypes.ServiceManagedEBSVolumeConfiguration> subFactoryAction = null)
    {
        parentFactory.ManagedEBSVolumeFactory = new InnerServiceServiceManagedEBSVolumeConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ManagedEBSVolumeFactory);
    }

    public static CombinedResult<InnerServiceServiceVolumeConfigurationFactory, T1, InnerServiceServiceManagedEBSVolumeConfigurationFactory> WithManagedEBSVolume<T1>(this CombinedResult<InnerServiceServiceVolumeConfigurationFactory, T1> combinedResult, Action<Humidifier.ECS.ServiceTypes.ServiceManagedEBSVolumeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithManagedEBSVolume(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceServiceVolumeConfigurationFactory, InnerServiceServiceManagedEBSVolumeConfigurationFactory> WithManagedEBSVolume<T1>(this CombinedResult<T1, InnerServiceServiceVolumeConfigurationFactory> combinedResult, Action<Humidifier.ECS.ServiceTypes.ServiceManagedEBSVolumeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithManagedEBSVolume(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerServiceServiceVolumeConfigurationFactory, T1, T2, InnerServiceServiceManagedEBSVolumeConfigurationFactory> WithManagedEBSVolume<T1, T2>(this CombinedResult<InnerServiceServiceVolumeConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.ECS.ServiceTypes.ServiceManagedEBSVolumeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithManagedEBSVolume(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceServiceVolumeConfigurationFactory, T2, InnerServiceServiceManagedEBSVolumeConfigurationFactory> WithManagedEBSVolume<T1, T2>(this CombinedResult<T1, InnerServiceServiceVolumeConfigurationFactory, T2> combinedResult, Action<Humidifier.ECS.ServiceTypes.ServiceManagedEBSVolumeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithManagedEBSVolume(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServiceServiceVolumeConfigurationFactory, InnerServiceServiceManagedEBSVolumeConfigurationFactory> WithManagedEBSVolume<T1, T2>(this CombinedResult<T1, T2, InnerServiceServiceVolumeConfigurationFactory> combinedResult, Action<Humidifier.ECS.ServiceTypes.ServiceManagedEBSVolumeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithManagedEBSVolume(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerServiceServiceVolumeConfigurationFactory, T1, T2, T3, InnerServiceServiceManagedEBSVolumeConfigurationFactory> WithManagedEBSVolume<T1, T2, T3>(this CombinedResult<InnerServiceServiceVolumeConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.ECS.ServiceTypes.ServiceManagedEBSVolumeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManagedEBSVolume(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceServiceVolumeConfigurationFactory, T2, T3, InnerServiceServiceManagedEBSVolumeConfigurationFactory> WithManagedEBSVolume<T1, T2, T3>(this CombinedResult<T1, InnerServiceServiceVolumeConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.ECS.ServiceTypes.ServiceManagedEBSVolumeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManagedEBSVolume(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServiceServiceVolumeConfigurationFactory, T3, InnerServiceServiceManagedEBSVolumeConfigurationFactory> WithManagedEBSVolume<T1, T2, T3>(this CombinedResult<T1, T2, InnerServiceServiceVolumeConfigurationFactory, T3> combinedResult, Action<Humidifier.ECS.ServiceTypes.ServiceManagedEBSVolumeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManagedEBSVolume(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerServiceServiceVolumeConfigurationFactory, InnerServiceServiceManagedEBSVolumeConfigurationFactory> WithManagedEBSVolume<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerServiceServiceVolumeConfigurationFactory> combinedResult, Action<Humidifier.ECS.ServiceTypes.ServiceManagedEBSVolumeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManagedEBSVolume(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerServiceServiceVolumeConfigurationFactory, T1, T2, T3, T4, InnerServiceServiceManagedEBSVolumeConfigurationFactory> WithManagedEBSVolume<T1, T2, T3, T4>(this CombinedResult<InnerServiceServiceVolumeConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ECS.ServiceTypes.ServiceManagedEBSVolumeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManagedEBSVolume(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceServiceVolumeConfigurationFactory, T2, T3, T4, InnerServiceServiceManagedEBSVolumeConfigurationFactory> WithManagedEBSVolume<T1, T2, T3, T4>(this CombinedResult<T1, InnerServiceServiceVolumeConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.ECS.ServiceTypes.ServiceManagedEBSVolumeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManagedEBSVolume(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServiceServiceVolumeConfigurationFactory, T3, T4, InnerServiceServiceManagedEBSVolumeConfigurationFactory> WithManagedEBSVolume<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerServiceServiceVolumeConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.ECS.ServiceTypes.ServiceManagedEBSVolumeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManagedEBSVolume(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerServiceServiceVolumeConfigurationFactory, T4, InnerServiceServiceManagedEBSVolumeConfigurationFactory> WithManagedEBSVolume<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerServiceServiceVolumeConfigurationFactory, T4> combinedResult, Action<Humidifier.ECS.ServiceTypes.ServiceManagedEBSVolumeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManagedEBSVolume(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerServiceServiceVolumeConfigurationFactory, InnerServiceServiceManagedEBSVolumeConfigurationFactory> WithManagedEBSVolume<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerServiceServiceVolumeConfigurationFactory> combinedResult, Action<Humidifier.ECS.ServiceTypes.ServiceManagedEBSVolumeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManagedEBSVolume(combinedResult.T5, subFactoryAction));
}
