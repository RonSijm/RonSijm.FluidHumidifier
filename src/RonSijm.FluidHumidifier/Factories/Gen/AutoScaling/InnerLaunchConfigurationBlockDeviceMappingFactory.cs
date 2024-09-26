// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AutoScaling;

public class InnerLaunchConfigurationBlockDeviceMappingFactory(Action<Humidifier.AutoScaling.LaunchConfigurationTypes.BlockDeviceMapping> factoryAction = null) : SubResourceFactory<Humidifier.AutoScaling.LaunchConfigurationTypes.BlockDeviceMapping>
{

    internal InnerLaunchConfigurationBlockDeviceFactory EbsFactory { get; set; }

    protected override Humidifier.AutoScaling.LaunchConfigurationTypes.BlockDeviceMapping Create()
    {
        var blockDeviceMappingResult = CreateBlockDeviceMapping();
        factoryAction?.Invoke(blockDeviceMappingResult);

        return blockDeviceMappingResult;
    }

    private Humidifier.AutoScaling.LaunchConfigurationTypes.BlockDeviceMapping CreateBlockDeviceMapping()
    {
        var blockDeviceMappingResult = new Humidifier.AutoScaling.LaunchConfigurationTypes.BlockDeviceMapping();

        return blockDeviceMappingResult;
    }
    public override void CreateChildren(Humidifier.AutoScaling.LaunchConfigurationTypes.BlockDeviceMapping result)
    {
        base.CreateChildren(result);

        result.Ebs ??= EbsFactory?.Build();
    }

} // End Of Class

public static class InnerLaunchConfigurationBlockDeviceMappingFactoryExtensions
{
    public static CombinedResult<InnerLaunchConfigurationBlockDeviceMappingFactory, InnerLaunchConfigurationBlockDeviceFactory> WithEbs(this InnerLaunchConfigurationBlockDeviceMappingFactory parentFactory, Action<Humidifier.AutoScaling.LaunchConfigurationTypes.BlockDevice> subFactoryAction = null)
    {
        parentFactory.EbsFactory = new InnerLaunchConfigurationBlockDeviceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EbsFactory);
    }

    public static CombinedResult<InnerLaunchConfigurationBlockDeviceMappingFactory, T1, InnerLaunchConfigurationBlockDeviceFactory> WithEbs<T1>(this CombinedResult<InnerLaunchConfigurationBlockDeviceMappingFactory, T1> combinedResult, Action<Humidifier.AutoScaling.LaunchConfigurationTypes.BlockDevice> subFactoryAction = null) => new (combinedResult, combinedResult, WithEbs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLaunchConfigurationBlockDeviceMappingFactory, InnerLaunchConfigurationBlockDeviceFactory> WithEbs<T1>(this CombinedResult<T1, InnerLaunchConfigurationBlockDeviceMappingFactory> combinedResult, Action<Humidifier.AutoScaling.LaunchConfigurationTypes.BlockDevice> subFactoryAction = null) => new (combinedResult, combinedResult, WithEbs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerLaunchConfigurationBlockDeviceMappingFactory, T1, T2, InnerLaunchConfigurationBlockDeviceFactory> WithEbs<T1, T2>(this CombinedResult<InnerLaunchConfigurationBlockDeviceMappingFactory, T1, T2> combinedResult, Action<Humidifier.AutoScaling.LaunchConfigurationTypes.BlockDevice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEbs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLaunchConfigurationBlockDeviceMappingFactory, T2, InnerLaunchConfigurationBlockDeviceFactory> WithEbs<T1, T2>(this CombinedResult<T1, InnerLaunchConfigurationBlockDeviceMappingFactory, T2> combinedResult, Action<Humidifier.AutoScaling.LaunchConfigurationTypes.BlockDevice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEbs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLaunchConfigurationBlockDeviceMappingFactory, InnerLaunchConfigurationBlockDeviceFactory> WithEbs<T1, T2>(this CombinedResult<T1, T2, InnerLaunchConfigurationBlockDeviceMappingFactory> combinedResult, Action<Humidifier.AutoScaling.LaunchConfigurationTypes.BlockDevice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEbs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerLaunchConfigurationBlockDeviceMappingFactory, T1, T2, T3, InnerLaunchConfigurationBlockDeviceFactory> WithEbs<T1, T2, T3>(this CombinedResult<InnerLaunchConfigurationBlockDeviceMappingFactory, T1, T2, T3> combinedResult, Action<Humidifier.AutoScaling.LaunchConfigurationTypes.BlockDevice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEbs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLaunchConfigurationBlockDeviceMappingFactory, T2, T3, InnerLaunchConfigurationBlockDeviceFactory> WithEbs<T1, T2, T3>(this CombinedResult<T1, InnerLaunchConfigurationBlockDeviceMappingFactory, T2, T3> combinedResult, Action<Humidifier.AutoScaling.LaunchConfigurationTypes.BlockDevice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEbs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLaunchConfigurationBlockDeviceMappingFactory, T3, InnerLaunchConfigurationBlockDeviceFactory> WithEbs<T1, T2, T3>(this CombinedResult<T1, T2, InnerLaunchConfigurationBlockDeviceMappingFactory, T3> combinedResult, Action<Humidifier.AutoScaling.LaunchConfigurationTypes.BlockDevice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEbs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLaunchConfigurationBlockDeviceMappingFactory, InnerLaunchConfigurationBlockDeviceFactory> WithEbs<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLaunchConfigurationBlockDeviceMappingFactory> combinedResult, Action<Humidifier.AutoScaling.LaunchConfigurationTypes.BlockDevice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEbs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerLaunchConfigurationBlockDeviceMappingFactory, T1, T2, T3, T4, InnerLaunchConfigurationBlockDeviceFactory> WithEbs<T1, T2, T3, T4>(this CombinedResult<InnerLaunchConfigurationBlockDeviceMappingFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AutoScaling.LaunchConfigurationTypes.BlockDevice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEbs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerLaunchConfigurationBlockDeviceMappingFactory, T2, T3, T4, InnerLaunchConfigurationBlockDeviceFactory> WithEbs<T1, T2, T3, T4>(this CombinedResult<T1, InnerLaunchConfigurationBlockDeviceMappingFactory, T2, T3, T4> combinedResult, Action<Humidifier.AutoScaling.LaunchConfigurationTypes.BlockDevice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEbs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerLaunchConfigurationBlockDeviceMappingFactory, T3, T4, InnerLaunchConfigurationBlockDeviceFactory> WithEbs<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLaunchConfigurationBlockDeviceMappingFactory, T3, T4> combinedResult, Action<Humidifier.AutoScaling.LaunchConfigurationTypes.BlockDevice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEbs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerLaunchConfigurationBlockDeviceMappingFactory, T4, InnerLaunchConfigurationBlockDeviceFactory> WithEbs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLaunchConfigurationBlockDeviceMappingFactory, T4> combinedResult, Action<Humidifier.AutoScaling.LaunchConfigurationTypes.BlockDevice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEbs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerLaunchConfigurationBlockDeviceMappingFactory, InnerLaunchConfigurationBlockDeviceFactory> WithEbs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLaunchConfigurationBlockDeviceMappingFactory> combinedResult, Action<Humidifier.AutoScaling.LaunchConfigurationTypes.BlockDevice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEbs(combinedResult.T5, subFactoryAction));
}
