// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NimbleStudio;

public class LaunchProfileFactory(string resourceName = null, Action<Humidifier.NimbleStudio.LaunchProfile> factoryAction = null) : ResourceFactory<Humidifier.NimbleStudio.LaunchProfile>(resourceName)
{

    internal InnerLaunchProfileStreamConfigurationFactory StreamConfigurationFactory { get; set; }

    protected override Humidifier.NimbleStudio.LaunchProfile Create()
    {
        var launchProfileResult = CreateLaunchProfile();
        factoryAction?.Invoke(launchProfileResult);

        return launchProfileResult;
    }

    private Humidifier.NimbleStudio.LaunchProfile CreateLaunchProfile()
    {
        var launchProfileResult = new Humidifier.NimbleStudio.LaunchProfile
        {
            GivenName = InputResourceName,
        };

        return launchProfileResult;
    }
    public override void CreateChildren(Humidifier.NimbleStudio.LaunchProfile result)
    {
        base.CreateChildren(result);

        result.StreamConfiguration ??= StreamConfigurationFactory?.Build();
    }

} // End Of Class

public static class LaunchProfileFactoryExtensions
{
    public static CombinedResult<LaunchProfileFactory, InnerLaunchProfileStreamConfigurationFactory> WithStreamConfiguration(this LaunchProfileFactory parentFactory, Action<Humidifier.NimbleStudio.LaunchProfileTypes.StreamConfiguration> subFactoryAction = null)
    {
        parentFactory.StreamConfigurationFactory = new InnerLaunchProfileStreamConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StreamConfigurationFactory);
    }

    public static CombinedResult<LaunchProfileFactory, T1, InnerLaunchProfileStreamConfigurationFactory> WithStreamConfiguration<T1>(this CombinedResult<LaunchProfileFactory, T1> combinedResult, Action<Humidifier.NimbleStudio.LaunchProfileTypes.StreamConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithStreamConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LaunchProfileFactory, InnerLaunchProfileStreamConfigurationFactory> WithStreamConfiguration<T1>(this CombinedResult<T1, LaunchProfileFactory> combinedResult, Action<Humidifier.NimbleStudio.LaunchProfileTypes.StreamConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithStreamConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<LaunchProfileFactory, T1, T2, InnerLaunchProfileStreamConfigurationFactory> WithStreamConfiguration<T1, T2>(this CombinedResult<LaunchProfileFactory, T1, T2> combinedResult, Action<Humidifier.NimbleStudio.LaunchProfileTypes.StreamConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStreamConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LaunchProfileFactory, T2, InnerLaunchProfileStreamConfigurationFactory> WithStreamConfiguration<T1, T2>(this CombinedResult<T1, LaunchProfileFactory, T2> combinedResult, Action<Humidifier.NimbleStudio.LaunchProfileTypes.StreamConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStreamConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LaunchProfileFactory, InnerLaunchProfileStreamConfigurationFactory> WithStreamConfiguration<T1, T2>(this CombinedResult<T1, T2, LaunchProfileFactory> combinedResult, Action<Humidifier.NimbleStudio.LaunchProfileTypes.StreamConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStreamConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<LaunchProfileFactory, T1, T2, T3, InnerLaunchProfileStreamConfigurationFactory> WithStreamConfiguration<T1, T2, T3>(this CombinedResult<LaunchProfileFactory, T1, T2, T3> combinedResult, Action<Humidifier.NimbleStudio.LaunchProfileTypes.StreamConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStreamConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LaunchProfileFactory, T2, T3, InnerLaunchProfileStreamConfigurationFactory> WithStreamConfiguration<T1, T2, T3>(this CombinedResult<T1, LaunchProfileFactory, T2, T3> combinedResult, Action<Humidifier.NimbleStudio.LaunchProfileTypes.StreamConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStreamConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LaunchProfileFactory, T3, InnerLaunchProfileStreamConfigurationFactory> WithStreamConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, LaunchProfileFactory, T3> combinedResult, Action<Humidifier.NimbleStudio.LaunchProfileTypes.StreamConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStreamConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LaunchProfileFactory, InnerLaunchProfileStreamConfigurationFactory> WithStreamConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, LaunchProfileFactory> combinedResult, Action<Humidifier.NimbleStudio.LaunchProfileTypes.StreamConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStreamConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<LaunchProfileFactory, T1, T2, T3, T4, InnerLaunchProfileStreamConfigurationFactory> WithStreamConfiguration<T1, T2, T3, T4>(this CombinedResult<LaunchProfileFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.NimbleStudio.LaunchProfileTypes.StreamConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStreamConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LaunchProfileFactory, T2, T3, T4, InnerLaunchProfileStreamConfigurationFactory> WithStreamConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, LaunchProfileFactory, T2, T3, T4> combinedResult, Action<Humidifier.NimbleStudio.LaunchProfileTypes.StreamConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStreamConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LaunchProfileFactory, T3, T4, InnerLaunchProfileStreamConfigurationFactory> WithStreamConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, LaunchProfileFactory, T3, T4> combinedResult, Action<Humidifier.NimbleStudio.LaunchProfileTypes.StreamConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStreamConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LaunchProfileFactory, T4, InnerLaunchProfileStreamConfigurationFactory> WithStreamConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LaunchProfileFactory, T4> combinedResult, Action<Humidifier.NimbleStudio.LaunchProfileTypes.StreamConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStreamConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, LaunchProfileFactory, InnerLaunchProfileStreamConfigurationFactory> WithStreamConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LaunchProfileFactory> combinedResult, Action<Humidifier.NimbleStudio.LaunchProfileTypes.StreamConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStreamConfiguration(combinedResult.T5, subFactoryAction));
}
