// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class DaemonTaskDefinitionFactory(string resourceName = null, Action<Humidifier.ECS.DaemonTaskDefinition> factoryAction = null) : ResourceFactory<Humidifier.ECS.DaemonTaskDefinition>(resourceName)
{

    internal List<InnerDaemonTaskDefinitionVolumeFactory> VolumesFactories { get; set; } = [];

    internal List<InnerDaemonTaskDefinitionDaemonContainerDefinitionFactory> ContainerDefinitionsFactories { get; set; } = [];

    protected override Humidifier.ECS.DaemonTaskDefinition Create()
    {
        var daemonTaskDefinitionResult = CreateDaemonTaskDefinition();
        factoryAction?.Invoke(daemonTaskDefinitionResult);

        return daemonTaskDefinitionResult;
    }

    private Humidifier.ECS.DaemonTaskDefinition CreateDaemonTaskDefinition()
    {
        var daemonTaskDefinitionResult = new Humidifier.ECS.DaemonTaskDefinition
        {
            GivenName = InputResourceName,
        };

        return daemonTaskDefinitionResult;
    }
    public override void CreateChildren(Humidifier.ECS.DaemonTaskDefinition result)
    {
        base.CreateChildren(result);

        result.Volumes = VolumesFactories.Any() ? VolumesFactories.Select(x => x.Build()).ToList() : null;
        result.ContainerDefinitions = ContainerDefinitionsFactories.Any() ? ContainerDefinitionsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class DaemonTaskDefinitionFactoryExtensions
{
    public static CombinedResult<DaemonTaskDefinitionFactory, InnerDaemonTaskDefinitionVolumeFactory> WithVolumes(this DaemonTaskDefinitionFactory parentFactory, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.Volume> subFactoryAction = null)
    {
        var factory = new InnerDaemonTaskDefinitionVolumeFactory(subFactoryAction);
        parentFactory.VolumesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<DaemonTaskDefinitionFactory, InnerDaemonTaskDefinitionDaemonContainerDefinitionFactory> WithContainerDefinitions(this DaemonTaskDefinitionFactory parentFactory, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.DaemonContainerDefinition> subFactoryAction = null)
    {
        var factory = new InnerDaemonTaskDefinitionDaemonContainerDefinitionFactory(subFactoryAction);
        parentFactory.ContainerDefinitionsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<DaemonTaskDefinitionFactory, T1, InnerDaemonTaskDefinitionVolumeFactory> WithVolumes<T1>(this CombinedResult<DaemonTaskDefinitionFactory, T1> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.Volume> subFactoryAction = null) => new (combinedResult, combinedResult, WithVolumes(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DaemonTaskDefinitionFactory, InnerDaemonTaskDefinitionVolumeFactory> WithVolumes<T1>(this CombinedResult<T1, DaemonTaskDefinitionFactory> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.Volume> subFactoryAction = null) => new (combinedResult, combinedResult, WithVolumes(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<DaemonTaskDefinitionFactory, T1, T2, InnerDaemonTaskDefinitionVolumeFactory> WithVolumes<T1, T2>(this CombinedResult<DaemonTaskDefinitionFactory, T1, T2> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.Volume> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVolumes(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DaemonTaskDefinitionFactory, T2, InnerDaemonTaskDefinitionVolumeFactory> WithVolumes<T1, T2>(this CombinedResult<T1, DaemonTaskDefinitionFactory, T2> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.Volume> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVolumes(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DaemonTaskDefinitionFactory, InnerDaemonTaskDefinitionVolumeFactory> WithVolumes<T1, T2>(this CombinedResult<T1, T2, DaemonTaskDefinitionFactory> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.Volume> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVolumes(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<DaemonTaskDefinitionFactory, T1, T2, T3, InnerDaemonTaskDefinitionVolumeFactory> WithVolumes<T1, T2, T3>(this CombinedResult<DaemonTaskDefinitionFactory, T1, T2, T3> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.Volume> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVolumes(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DaemonTaskDefinitionFactory, T2, T3, InnerDaemonTaskDefinitionVolumeFactory> WithVolumes<T1, T2, T3>(this CombinedResult<T1, DaemonTaskDefinitionFactory, T2, T3> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.Volume> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVolumes(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DaemonTaskDefinitionFactory, T3, InnerDaemonTaskDefinitionVolumeFactory> WithVolumes<T1, T2, T3>(this CombinedResult<T1, T2, DaemonTaskDefinitionFactory, T3> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.Volume> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVolumes(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DaemonTaskDefinitionFactory, InnerDaemonTaskDefinitionVolumeFactory> WithVolumes<T1, T2, T3>(this CombinedResult<T1, T2, T3, DaemonTaskDefinitionFactory> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.Volume> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVolumes(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<DaemonTaskDefinitionFactory, T1, T2, T3, T4, InnerDaemonTaskDefinitionVolumeFactory> WithVolumes<T1, T2, T3, T4>(this CombinedResult<DaemonTaskDefinitionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.Volume> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVolumes(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DaemonTaskDefinitionFactory, T2, T3, T4, InnerDaemonTaskDefinitionVolumeFactory> WithVolumes<T1, T2, T3, T4>(this CombinedResult<T1, DaemonTaskDefinitionFactory, T2, T3, T4> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.Volume> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVolumes(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DaemonTaskDefinitionFactory, T3, T4, InnerDaemonTaskDefinitionVolumeFactory> WithVolumes<T1, T2, T3, T4>(this CombinedResult<T1, T2, DaemonTaskDefinitionFactory, T3, T4> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.Volume> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVolumes(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DaemonTaskDefinitionFactory, T4, InnerDaemonTaskDefinitionVolumeFactory> WithVolumes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DaemonTaskDefinitionFactory, T4> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.Volume> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVolumes(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, DaemonTaskDefinitionFactory, InnerDaemonTaskDefinitionVolumeFactory> WithVolumes<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DaemonTaskDefinitionFactory> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.Volume> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVolumes(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<DaemonTaskDefinitionFactory, T1, InnerDaemonTaskDefinitionDaemonContainerDefinitionFactory> WithContainerDefinitions<T1>(this CombinedResult<DaemonTaskDefinitionFactory, T1> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.DaemonContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithContainerDefinitions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DaemonTaskDefinitionFactory, InnerDaemonTaskDefinitionDaemonContainerDefinitionFactory> WithContainerDefinitions<T1>(this CombinedResult<T1, DaemonTaskDefinitionFactory> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.DaemonContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithContainerDefinitions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<DaemonTaskDefinitionFactory, T1, T2, InnerDaemonTaskDefinitionDaemonContainerDefinitionFactory> WithContainerDefinitions<T1, T2>(this CombinedResult<DaemonTaskDefinitionFactory, T1, T2> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.DaemonContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContainerDefinitions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DaemonTaskDefinitionFactory, T2, InnerDaemonTaskDefinitionDaemonContainerDefinitionFactory> WithContainerDefinitions<T1, T2>(this CombinedResult<T1, DaemonTaskDefinitionFactory, T2> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.DaemonContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContainerDefinitions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DaemonTaskDefinitionFactory, InnerDaemonTaskDefinitionDaemonContainerDefinitionFactory> WithContainerDefinitions<T1, T2>(this CombinedResult<T1, T2, DaemonTaskDefinitionFactory> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.DaemonContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContainerDefinitions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<DaemonTaskDefinitionFactory, T1, T2, T3, InnerDaemonTaskDefinitionDaemonContainerDefinitionFactory> WithContainerDefinitions<T1, T2, T3>(this CombinedResult<DaemonTaskDefinitionFactory, T1, T2, T3> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.DaemonContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerDefinitions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DaemonTaskDefinitionFactory, T2, T3, InnerDaemonTaskDefinitionDaemonContainerDefinitionFactory> WithContainerDefinitions<T1, T2, T3>(this CombinedResult<T1, DaemonTaskDefinitionFactory, T2, T3> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.DaemonContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerDefinitions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DaemonTaskDefinitionFactory, T3, InnerDaemonTaskDefinitionDaemonContainerDefinitionFactory> WithContainerDefinitions<T1, T2, T3>(this CombinedResult<T1, T2, DaemonTaskDefinitionFactory, T3> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.DaemonContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerDefinitions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DaemonTaskDefinitionFactory, InnerDaemonTaskDefinitionDaemonContainerDefinitionFactory> WithContainerDefinitions<T1, T2, T3>(this CombinedResult<T1, T2, T3, DaemonTaskDefinitionFactory> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.DaemonContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContainerDefinitions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<DaemonTaskDefinitionFactory, T1, T2, T3, T4, InnerDaemonTaskDefinitionDaemonContainerDefinitionFactory> WithContainerDefinitions<T1, T2, T3, T4>(this CombinedResult<DaemonTaskDefinitionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.DaemonContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerDefinitions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, DaemonTaskDefinitionFactory, T2, T3, T4, InnerDaemonTaskDefinitionDaemonContainerDefinitionFactory> WithContainerDefinitions<T1, T2, T3, T4>(this CombinedResult<T1, DaemonTaskDefinitionFactory, T2, T3, T4> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.DaemonContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerDefinitions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, DaemonTaskDefinitionFactory, T3, T4, InnerDaemonTaskDefinitionDaemonContainerDefinitionFactory> WithContainerDefinitions<T1, T2, T3, T4>(this CombinedResult<T1, T2, DaemonTaskDefinitionFactory, T3, T4> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.DaemonContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerDefinitions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, DaemonTaskDefinitionFactory, T4, InnerDaemonTaskDefinitionDaemonContainerDefinitionFactory> WithContainerDefinitions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, DaemonTaskDefinitionFactory, T4> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.DaemonContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerDefinitions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, DaemonTaskDefinitionFactory, InnerDaemonTaskDefinitionDaemonContainerDefinitionFactory> WithContainerDefinitions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, DaemonTaskDefinitionFactory> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.DaemonContainerDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContainerDefinitions(combinedResult.T5, subFactoryAction).T2);
}
