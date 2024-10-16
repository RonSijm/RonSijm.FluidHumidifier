// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NimbleStudio;

public class InnerLaunchProfileStreamConfigurationSessionStorageFactory(Action<Humidifier.NimbleStudio.LaunchProfileTypes.StreamConfigurationSessionStorage> factoryAction = null) : SubResourceFactory<Humidifier.NimbleStudio.LaunchProfileTypes.StreamConfigurationSessionStorage>
{

    internal InnerLaunchProfileStreamingSessionStorageRootFactory RootFactory { get; set; }

    protected override Humidifier.NimbleStudio.LaunchProfileTypes.StreamConfigurationSessionStorage Create()
    {
        var streamConfigurationSessionStorageResult = CreateStreamConfigurationSessionStorage();
        factoryAction?.Invoke(streamConfigurationSessionStorageResult);

        return streamConfigurationSessionStorageResult;
    }

    private Humidifier.NimbleStudio.LaunchProfileTypes.StreamConfigurationSessionStorage CreateStreamConfigurationSessionStorage()
    {
        var streamConfigurationSessionStorageResult = new Humidifier.NimbleStudio.LaunchProfileTypes.StreamConfigurationSessionStorage();

        return streamConfigurationSessionStorageResult;
    }
    public override void CreateChildren(Humidifier.NimbleStudio.LaunchProfileTypes.StreamConfigurationSessionStorage result)
    {
        base.CreateChildren(result);

        result.Root ??= RootFactory?.Build();
    }

} // End Of Class

public static class InnerLaunchProfileStreamConfigurationSessionStorageFactoryExtensions
{
    public static CombinedResult<InnerLaunchProfileStreamConfigurationSessionStorageFactory, InnerLaunchProfileStreamingSessionStorageRootFactory> WithRoot(this InnerLaunchProfileStreamConfigurationSessionStorageFactory parentFactory, Action<Humidifier.NimbleStudio.LaunchProfileTypes.StreamingSessionStorageRoot> subFactoryAction = null)
    {
        parentFactory.RootFactory = new InnerLaunchProfileStreamingSessionStorageRootFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RootFactory);
    }

    public static CombinedResult<InnerLaunchProfileStreamConfigurationSessionStorageFactory, T1, InnerLaunchProfileStreamingSessionStorageRootFactory> WithRoot<T1>(this CombinedResult<InnerLaunchProfileStreamConfigurationSessionStorageFactory, T1> combinedResult, Action<Humidifier.NimbleStudio.LaunchProfileTypes.StreamingSessionStorageRoot> subFactoryAction = null) => new (combinedResult, combinedResult, WithRoot(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLaunchProfileStreamConfigurationSessionStorageFactory, InnerLaunchProfileStreamingSessionStorageRootFactory> WithRoot<T1>(this CombinedResult<T1, InnerLaunchProfileStreamConfigurationSessionStorageFactory> combinedResult, Action<Humidifier.NimbleStudio.LaunchProfileTypes.StreamingSessionStorageRoot> subFactoryAction = null) => new (combinedResult, combinedResult, WithRoot(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerLaunchProfileStreamConfigurationSessionStorageFactory, T1, T2, InnerLaunchProfileStreamingSessionStorageRootFactory> WithRoot<T1, T2>(this CombinedResult<InnerLaunchProfileStreamConfigurationSessionStorageFactory, T1, T2> combinedResult, Action<Humidifier.NimbleStudio.LaunchProfileTypes.StreamingSessionStorageRoot> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRoot(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLaunchProfileStreamConfigurationSessionStorageFactory, T2, InnerLaunchProfileStreamingSessionStorageRootFactory> WithRoot<T1, T2>(this CombinedResult<T1, InnerLaunchProfileStreamConfigurationSessionStorageFactory, T2> combinedResult, Action<Humidifier.NimbleStudio.LaunchProfileTypes.StreamingSessionStorageRoot> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRoot(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLaunchProfileStreamConfigurationSessionStorageFactory, InnerLaunchProfileStreamingSessionStorageRootFactory> WithRoot<T1, T2>(this CombinedResult<T1, T2, InnerLaunchProfileStreamConfigurationSessionStorageFactory> combinedResult, Action<Humidifier.NimbleStudio.LaunchProfileTypes.StreamingSessionStorageRoot> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRoot(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerLaunchProfileStreamConfigurationSessionStorageFactory, T1, T2, T3, InnerLaunchProfileStreamingSessionStorageRootFactory> WithRoot<T1, T2, T3>(this CombinedResult<InnerLaunchProfileStreamConfigurationSessionStorageFactory, T1, T2, T3> combinedResult, Action<Humidifier.NimbleStudio.LaunchProfileTypes.StreamingSessionStorageRoot> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRoot(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLaunchProfileStreamConfigurationSessionStorageFactory, T2, T3, InnerLaunchProfileStreamingSessionStorageRootFactory> WithRoot<T1, T2, T3>(this CombinedResult<T1, InnerLaunchProfileStreamConfigurationSessionStorageFactory, T2, T3> combinedResult, Action<Humidifier.NimbleStudio.LaunchProfileTypes.StreamingSessionStorageRoot> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRoot(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLaunchProfileStreamConfigurationSessionStorageFactory, T3, InnerLaunchProfileStreamingSessionStorageRootFactory> WithRoot<T1, T2, T3>(this CombinedResult<T1, T2, InnerLaunchProfileStreamConfigurationSessionStorageFactory, T3> combinedResult, Action<Humidifier.NimbleStudio.LaunchProfileTypes.StreamingSessionStorageRoot> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRoot(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLaunchProfileStreamConfigurationSessionStorageFactory, InnerLaunchProfileStreamingSessionStorageRootFactory> WithRoot<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLaunchProfileStreamConfigurationSessionStorageFactory> combinedResult, Action<Humidifier.NimbleStudio.LaunchProfileTypes.StreamingSessionStorageRoot> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRoot(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerLaunchProfileStreamConfigurationSessionStorageFactory, T1, T2, T3, T4, InnerLaunchProfileStreamingSessionStorageRootFactory> WithRoot<T1, T2, T3, T4>(this CombinedResult<InnerLaunchProfileStreamConfigurationSessionStorageFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.NimbleStudio.LaunchProfileTypes.StreamingSessionStorageRoot> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRoot(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLaunchProfileStreamConfigurationSessionStorageFactory, T2, T3, T4, InnerLaunchProfileStreamingSessionStorageRootFactory> WithRoot<T1, T2, T3, T4>(this CombinedResult<T1, InnerLaunchProfileStreamConfigurationSessionStorageFactory, T2, T3, T4> combinedResult, Action<Humidifier.NimbleStudio.LaunchProfileTypes.StreamingSessionStorageRoot> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRoot(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLaunchProfileStreamConfigurationSessionStorageFactory, T3, T4, InnerLaunchProfileStreamingSessionStorageRootFactory> WithRoot<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLaunchProfileStreamConfigurationSessionStorageFactory, T3, T4> combinedResult, Action<Humidifier.NimbleStudio.LaunchProfileTypes.StreamingSessionStorageRoot> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRoot(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLaunchProfileStreamConfigurationSessionStorageFactory, T4, InnerLaunchProfileStreamingSessionStorageRootFactory> WithRoot<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLaunchProfileStreamConfigurationSessionStorageFactory, T4> combinedResult, Action<Humidifier.NimbleStudio.LaunchProfileTypes.StreamingSessionStorageRoot> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRoot(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerLaunchProfileStreamConfigurationSessionStorageFactory, InnerLaunchProfileStreamingSessionStorageRootFactory> WithRoot<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLaunchProfileStreamConfigurationSessionStorageFactory> combinedResult, Action<Humidifier.NimbleStudio.LaunchProfileTypes.StreamingSessionStorageRoot> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRoot(combinedResult.T5, subFactoryAction));
}
