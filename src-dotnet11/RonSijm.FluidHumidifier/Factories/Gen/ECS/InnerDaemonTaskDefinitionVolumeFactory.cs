// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerDaemonTaskDefinitionVolumeFactory(Action<Humidifier.ECS.DaemonTaskDefinitionTypes.Volume> factoryAction = null) : SubResourceFactory<Humidifier.ECS.DaemonTaskDefinitionTypes.Volume>
{

    internal InnerDaemonTaskDefinitionHostVolumePropertiesFactory HostFactory { get; set; }

    protected override Humidifier.ECS.DaemonTaskDefinitionTypes.Volume Create()
    {
        var volumeResult = CreateVolume();
        factoryAction?.Invoke(volumeResult);

        return volumeResult;
    }

    private Humidifier.ECS.DaemonTaskDefinitionTypes.Volume CreateVolume()
    {
        var volumeResult = new Humidifier.ECS.DaemonTaskDefinitionTypes.Volume();

        return volumeResult;
    }
    public override void CreateChildren(Humidifier.ECS.DaemonTaskDefinitionTypes.Volume result)
    {
        base.CreateChildren(result);

        result.Host ??= HostFactory?.Build();
    }

} // End Of Class

public static class InnerDaemonTaskDefinitionVolumeFactoryExtensions
{
    public static CombinedResult<InnerDaemonTaskDefinitionVolumeFactory, InnerDaemonTaskDefinitionHostVolumePropertiesFactory> WithHost(this InnerDaemonTaskDefinitionVolumeFactory parentFactory, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.HostVolumeProperties> subFactoryAction = null)
    {
        parentFactory.HostFactory = new InnerDaemonTaskDefinitionHostVolumePropertiesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.HostFactory);
    }

    public static CombinedResult<InnerDaemonTaskDefinitionVolumeFactory, T1, InnerDaemonTaskDefinitionHostVolumePropertiesFactory> WithHost<T1>(this CombinedResult<InnerDaemonTaskDefinitionVolumeFactory, T1> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.HostVolumeProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithHost(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDaemonTaskDefinitionVolumeFactory, InnerDaemonTaskDefinitionHostVolumePropertiesFactory> WithHost<T1>(this CombinedResult<T1, InnerDaemonTaskDefinitionVolumeFactory> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.HostVolumeProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithHost(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerDaemonTaskDefinitionVolumeFactory, T1, T2, InnerDaemonTaskDefinitionHostVolumePropertiesFactory> WithHost<T1, T2>(this CombinedResult<InnerDaemonTaskDefinitionVolumeFactory, T1, T2> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.HostVolumeProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHost(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDaemonTaskDefinitionVolumeFactory, T2, InnerDaemonTaskDefinitionHostVolumePropertiesFactory> WithHost<T1, T2>(this CombinedResult<T1, InnerDaemonTaskDefinitionVolumeFactory, T2> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.HostVolumeProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHost(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDaemonTaskDefinitionVolumeFactory, InnerDaemonTaskDefinitionHostVolumePropertiesFactory> WithHost<T1, T2>(this CombinedResult<T1, T2, InnerDaemonTaskDefinitionVolumeFactory> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.HostVolumeProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHost(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerDaemonTaskDefinitionVolumeFactory, T1, T2, T3, InnerDaemonTaskDefinitionHostVolumePropertiesFactory> WithHost<T1, T2, T3>(this CombinedResult<InnerDaemonTaskDefinitionVolumeFactory, T1, T2, T3> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.HostVolumeProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHost(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDaemonTaskDefinitionVolumeFactory, T2, T3, InnerDaemonTaskDefinitionHostVolumePropertiesFactory> WithHost<T1, T2, T3>(this CombinedResult<T1, InnerDaemonTaskDefinitionVolumeFactory, T2, T3> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.HostVolumeProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHost(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDaemonTaskDefinitionVolumeFactory, T3, InnerDaemonTaskDefinitionHostVolumePropertiesFactory> WithHost<T1, T2, T3>(this CombinedResult<T1, T2, InnerDaemonTaskDefinitionVolumeFactory, T3> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.HostVolumeProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHost(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDaemonTaskDefinitionVolumeFactory, InnerDaemonTaskDefinitionHostVolumePropertiesFactory> WithHost<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDaemonTaskDefinitionVolumeFactory> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.HostVolumeProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHost(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerDaemonTaskDefinitionVolumeFactory, T1, T2, T3, T4, InnerDaemonTaskDefinitionHostVolumePropertiesFactory> WithHost<T1, T2, T3, T4>(this CombinedResult<InnerDaemonTaskDefinitionVolumeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.HostVolumeProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHost(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerDaemonTaskDefinitionVolumeFactory, T2, T3, T4, InnerDaemonTaskDefinitionHostVolumePropertiesFactory> WithHost<T1, T2, T3, T4>(this CombinedResult<T1, InnerDaemonTaskDefinitionVolumeFactory, T2, T3, T4> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.HostVolumeProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHost(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerDaemonTaskDefinitionVolumeFactory, T3, T4, InnerDaemonTaskDefinitionHostVolumePropertiesFactory> WithHost<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDaemonTaskDefinitionVolumeFactory, T3, T4> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.HostVolumeProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHost(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerDaemonTaskDefinitionVolumeFactory, T4, InnerDaemonTaskDefinitionHostVolumePropertiesFactory> WithHost<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDaemonTaskDefinitionVolumeFactory, T4> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.HostVolumeProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHost(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerDaemonTaskDefinitionVolumeFactory, InnerDaemonTaskDefinitionHostVolumePropertiesFactory> WithHost<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDaemonTaskDefinitionVolumeFactory> combinedResult, Action<Humidifier.ECS.DaemonTaskDefinitionTypes.HostVolumeProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHost(combinedResult.T5, subFactoryAction).T2);
}
