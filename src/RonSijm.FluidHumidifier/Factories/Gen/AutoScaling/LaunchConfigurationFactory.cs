// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AutoScaling;

public class LaunchConfigurationFactory(string resourceName = null, Action<Humidifier.AutoScaling.LaunchConfiguration> factoryAction = null) : ResourceFactory<Humidifier.AutoScaling.LaunchConfiguration>(resourceName)
{

    internal List<InnerLaunchConfigurationBlockDeviceMappingFactory> BlockDeviceMappingsFactories { get; set; } = [];

    internal InnerLaunchConfigurationMetadataOptionsFactory MetadataOptionsFactory { get; set; }

    protected override Humidifier.AutoScaling.LaunchConfiguration Create()
    {
        var launchConfigurationResult = CreateLaunchConfiguration();
        factoryAction?.Invoke(launchConfigurationResult);

        return launchConfigurationResult;
    }

    private Humidifier.AutoScaling.LaunchConfiguration CreateLaunchConfiguration()
    {
        var launchConfigurationResult = new Humidifier.AutoScaling.LaunchConfiguration
        {
            GivenName = InputResourceName,
        };

        return launchConfigurationResult;
    }
    public override void CreateChildren(Humidifier.AutoScaling.LaunchConfiguration result)
    {
        base.CreateChildren(result);

        result.BlockDeviceMappings = BlockDeviceMappingsFactories.Any() ? BlockDeviceMappingsFactories.Select(x => x.Build()).ToList() : null;
        result.MetadataOptions ??= MetadataOptionsFactory?.Build();
    }

} // End Of Class

public static class LaunchConfigurationFactoryExtensions
{
    public static CombinedResult<LaunchConfigurationFactory, InnerLaunchConfigurationBlockDeviceMappingFactory> WithBlockDeviceMappings(this LaunchConfigurationFactory parentFactory, Action<Humidifier.AutoScaling.LaunchConfigurationTypes.BlockDeviceMapping> subFactoryAction = null)
    {
        var factory = new InnerLaunchConfigurationBlockDeviceMappingFactory(subFactoryAction);
        parentFactory.BlockDeviceMappingsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<LaunchConfigurationFactory, InnerLaunchConfigurationMetadataOptionsFactory> WithMetadataOptions(this LaunchConfigurationFactory parentFactory, Action<Humidifier.AutoScaling.LaunchConfigurationTypes.MetadataOptions> subFactoryAction = null)
    {
        parentFactory.MetadataOptionsFactory = new InnerLaunchConfigurationMetadataOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MetadataOptionsFactory);
    }

    public static CombinedResult<LaunchConfigurationFactory, T1, InnerLaunchConfigurationBlockDeviceMappingFactory> WithBlockDeviceMappings<T1>(this CombinedResult<LaunchConfigurationFactory, T1> combinedResult, Action<Humidifier.AutoScaling.LaunchConfigurationTypes.BlockDeviceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, WithBlockDeviceMappings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LaunchConfigurationFactory, InnerLaunchConfigurationBlockDeviceMappingFactory> WithBlockDeviceMappings<T1>(this CombinedResult<T1, LaunchConfigurationFactory> combinedResult, Action<Humidifier.AutoScaling.LaunchConfigurationTypes.BlockDeviceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, WithBlockDeviceMappings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<LaunchConfigurationFactory, T1, T2, InnerLaunchConfigurationBlockDeviceMappingFactory> WithBlockDeviceMappings<T1, T2>(this CombinedResult<LaunchConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.AutoScaling.LaunchConfigurationTypes.BlockDeviceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBlockDeviceMappings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LaunchConfigurationFactory, T2, InnerLaunchConfigurationBlockDeviceMappingFactory> WithBlockDeviceMappings<T1, T2>(this CombinedResult<T1, LaunchConfigurationFactory, T2> combinedResult, Action<Humidifier.AutoScaling.LaunchConfigurationTypes.BlockDeviceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBlockDeviceMappings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LaunchConfigurationFactory, InnerLaunchConfigurationBlockDeviceMappingFactory> WithBlockDeviceMappings<T1, T2>(this CombinedResult<T1, T2, LaunchConfigurationFactory> combinedResult, Action<Humidifier.AutoScaling.LaunchConfigurationTypes.BlockDeviceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBlockDeviceMappings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<LaunchConfigurationFactory, T1, T2, T3, InnerLaunchConfigurationBlockDeviceMappingFactory> WithBlockDeviceMappings<T1, T2, T3>(this CombinedResult<LaunchConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.AutoScaling.LaunchConfigurationTypes.BlockDeviceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBlockDeviceMappings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LaunchConfigurationFactory, T2, T3, InnerLaunchConfigurationBlockDeviceMappingFactory> WithBlockDeviceMappings<T1, T2, T3>(this CombinedResult<T1, LaunchConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.AutoScaling.LaunchConfigurationTypes.BlockDeviceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBlockDeviceMappings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LaunchConfigurationFactory, T3, InnerLaunchConfigurationBlockDeviceMappingFactory> WithBlockDeviceMappings<T1, T2, T3>(this CombinedResult<T1, T2, LaunchConfigurationFactory, T3> combinedResult, Action<Humidifier.AutoScaling.LaunchConfigurationTypes.BlockDeviceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBlockDeviceMappings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LaunchConfigurationFactory, InnerLaunchConfigurationBlockDeviceMappingFactory> WithBlockDeviceMappings<T1, T2, T3>(this CombinedResult<T1, T2, T3, LaunchConfigurationFactory> combinedResult, Action<Humidifier.AutoScaling.LaunchConfigurationTypes.BlockDeviceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBlockDeviceMappings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<LaunchConfigurationFactory, T1, T2, T3, T4, InnerLaunchConfigurationBlockDeviceMappingFactory> WithBlockDeviceMappings<T1, T2, T3, T4>(this CombinedResult<LaunchConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AutoScaling.LaunchConfigurationTypes.BlockDeviceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBlockDeviceMappings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LaunchConfigurationFactory, T2, T3, T4, InnerLaunchConfigurationBlockDeviceMappingFactory> WithBlockDeviceMappings<T1, T2, T3, T4>(this CombinedResult<T1, LaunchConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.AutoScaling.LaunchConfigurationTypes.BlockDeviceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBlockDeviceMappings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LaunchConfigurationFactory, T3, T4, InnerLaunchConfigurationBlockDeviceMappingFactory> WithBlockDeviceMappings<T1, T2, T3, T4>(this CombinedResult<T1, T2, LaunchConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.AutoScaling.LaunchConfigurationTypes.BlockDeviceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBlockDeviceMappings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LaunchConfigurationFactory, T4, InnerLaunchConfigurationBlockDeviceMappingFactory> WithBlockDeviceMappings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LaunchConfigurationFactory, T4> combinedResult, Action<Humidifier.AutoScaling.LaunchConfigurationTypes.BlockDeviceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBlockDeviceMappings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, LaunchConfigurationFactory, InnerLaunchConfigurationBlockDeviceMappingFactory> WithBlockDeviceMappings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LaunchConfigurationFactory> combinedResult, Action<Humidifier.AutoScaling.LaunchConfigurationTypes.BlockDeviceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBlockDeviceMappings(combinedResult.T5, subFactoryAction));
    public static CombinedResult<LaunchConfigurationFactory, T1, InnerLaunchConfigurationMetadataOptionsFactory> WithMetadataOptions<T1>(this CombinedResult<LaunchConfigurationFactory, T1> combinedResult, Action<Humidifier.AutoScaling.LaunchConfigurationTypes.MetadataOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithMetadataOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LaunchConfigurationFactory, InnerLaunchConfigurationMetadataOptionsFactory> WithMetadataOptions<T1>(this CombinedResult<T1, LaunchConfigurationFactory> combinedResult, Action<Humidifier.AutoScaling.LaunchConfigurationTypes.MetadataOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithMetadataOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<LaunchConfigurationFactory, T1, T2, InnerLaunchConfigurationMetadataOptionsFactory> WithMetadataOptions<T1, T2>(this CombinedResult<LaunchConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.AutoScaling.LaunchConfigurationTypes.MetadataOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetadataOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LaunchConfigurationFactory, T2, InnerLaunchConfigurationMetadataOptionsFactory> WithMetadataOptions<T1, T2>(this CombinedResult<T1, LaunchConfigurationFactory, T2> combinedResult, Action<Humidifier.AutoScaling.LaunchConfigurationTypes.MetadataOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetadataOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LaunchConfigurationFactory, InnerLaunchConfigurationMetadataOptionsFactory> WithMetadataOptions<T1, T2>(this CombinedResult<T1, T2, LaunchConfigurationFactory> combinedResult, Action<Humidifier.AutoScaling.LaunchConfigurationTypes.MetadataOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMetadataOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<LaunchConfigurationFactory, T1, T2, T3, InnerLaunchConfigurationMetadataOptionsFactory> WithMetadataOptions<T1, T2, T3>(this CombinedResult<LaunchConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.AutoScaling.LaunchConfigurationTypes.MetadataOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LaunchConfigurationFactory, T2, T3, InnerLaunchConfigurationMetadataOptionsFactory> WithMetadataOptions<T1, T2, T3>(this CombinedResult<T1, LaunchConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.AutoScaling.LaunchConfigurationTypes.MetadataOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LaunchConfigurationFactory, T3, InnerLaunchConfigurationMetadataOptionsFactory> WithMetadataOptions<T1, T2, T3>(this CombinedResult<T1, T2, LaunchConfigurationFactory, T3> combinedResult, Action<Humidifier.AutoScaling.LaunchConfigurationTypes.MetadataOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LaunchConfigurationFactory, InnerLaunchConfigurationMetadataOptionsFactory> WithMetadataOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, LaunchConfigurationFactory> combinedResult, Action<Humidifier.AutoScaling.LaunchConfigurationTypes.MetadataOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<LaunchConfigurationFactory, T1, T2, T3, T4, InnerLaunchConfigurationMetadataOptionsFactory> WithMetadataOptions<T1, T2, T3, T4>(this CombinedResult<LaunchConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AutoScaling.LaunchConfigurationTypes.MetadataOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LaunchConfigurationFactory, T2, T3, T4, InnerLaunchConfigurationMetadataOptionsFactory> WithMetadataOptions<T1, T2, T3, T4>(this CombinedResult<T1, LaunchConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.AutoScaling.LaunchConfigurationTypes.MetadataOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LaunchConfigurationFactory, T3, T4, InnerLaunchConfigurationMetadataOptionsFactory> WithMetadataOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, LaunchConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.AutoScaling.LaunchConfigurationTypes.MetadataOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LaunchConfigurationFactory, T4, InnerLaunchConfigurationMetadataOptionsFactory> WithMetadataOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LaunchConfigurationFactory, T4> combinedResult, Action<Humidifier.AutoScaling.LaunchConfigurationTypes.MetadataOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, LaunchConfigurationFactory, InnerLaunchConfigurationMetadataOptionsFactory> WithMetadataOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LaunchConfigurationFactory> combinedResult, Action<Humidifier.AutoScaling.LaunchConfigurationTypes.MetadataOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMetadataOptions(combinedResult.T5, subFactoryAction));
}
