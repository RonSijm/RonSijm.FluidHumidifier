// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpsWorks;

public class InstanceFactory(string resourceName = null, Action<Humidifier.OpsWorks.Instance> factoryAction = null) : ResourceFactory<Humidifier.OpsWorks.Instance>(resourceName)
{

    internal List<InnerInstanceBlockDeviceMappingFactory> BlockDeviceMappingsFactories { get; set; } = [];

    internal InnerInstanceTimeBasedAutoScalingFactory TimeBasedAutoScalingFactory { get; set; }

    protected override Humidifier.OpsWorks.Instance Create()
    {
        var instanceResult = CreateInstance();
        factoryAction?.Invoke(instanceResult);

        return instanceResult;
    }

    private Humidifier.OpsWorks.Instance CreateInstance()
    {
        var instanceResult = new Humidifier.OpsWorks.Instance
        {
            GivenName = InputResourceName,
        };

        return instanceResult;
    }
    public override void CreateChildren(Humidifier.OpsWorks.Instance result)
    {
        base.CreateChildren(result);

        result.BlockDeviceMappings = BlockDeviceMappingsFactories.Any() ? BlockDeviceMappingsFactories.Select(x => x.Build()).ToList() : null;
        result.TimeBasedAutoScaling ??= TimeBasedAutoScalingFactory?.Build();
    }

} // End Of Class

public static class InstanceFactoryExtensions
{
    public static CombinedResult<InstanceFactory, InnerInstanceBlockDeviceMappingFactory> WithBlockDeviceMappings(this InstanceFactory parentFactory, Action<Humidifier.OpsWorks.InstanceTypes.BlockDeviceMapping> subFactoryAction = null)
    {
        var factory = new InnerInstanceBlockDeviceMappingFactory(subFactoryAction);
        parentFactory.BlockDeviceMappingsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<InstanceFactory, InnerInstanceTimeBasedAutoScalingFactory> WithTimeBasedAutoScaling(this InstanceFactory parentFactory, Action<Humidifier.OpsWorks.InstanceTypes.TimeBasedAutoScaling> subFactoryAction = null)
    {
        parentFactory.TimeBasedAutoScalingFactory = new InnerInstanceTimeBasedAutoScalingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TimeBasedAutoScalingFactory);
    }

    public static CombinedResult<InstanceFactory, T1, InnerInstanceBlockDeviceMappingFactory> WithBlockDeviceMappings<T1>(this CombinedResult<InstanceFactory, T1> combinedResult, Action<Humidifier.OpsWorks.InstanceTypes.BlockDeviceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, WithBlockDeviceMappings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InstanceFactory, InnerInstanceBlockDeviceMappingFactory> WithBlockDeviceMappings<T1>(this CombinedResult<T1, InstanceFactory> combinedResult, Action<Humidifier.OpsWorks.InstanceTypes.BlockDeviceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, WithBlockDeviceMappings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InstanceFactory, T1, T2, InnerInstanceBlockDeviceMappingFactory> WithBlockDeviceMappings<T1, T2>(this CombinedResult<InstanceFactory, T1, T2> combinedResult, Action<Humidifier.OpsWorks.InstanceTypes.BlockDeviceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBlockDeviceMappings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InstanceFactory, T2, InnerInstanceBlockDeviceMappingFactory> WithBlockDeviceMappings<T1, T2>(this CombinedResult<T1, InstanceFactory, T2> combinedResult, Action<Humidifier.OpsWorks.InstanceTypes.BlockDeviceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBlockDeviceMappings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InstanceFactory, InnerInstanceBlockDeviceMappingFactory> WithBlockDeviceMappings<T1, T2>(this CombinedResult<T1, T2, InstanceFactory> combinedResult, Action<Humidifier.OpsWorks.InstanceTypes.BlockDeviceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBlockDeviceMappings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InstanceFactory, T1, T2, T3, InnerInstanceBlockDeviceMappingFactory> WithBlockDeviceMappings<T1, T2, T3>(this CombinedResult<InstanceFactory, T1, T2, T3> combinedResult, Action<Humidifier.OpsWorks.InstanceTypes.BlockDeviceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBlockDeviceMappings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InstanceFactory, T2, T3, InnerInstanceBlockDeviceMappingFactory> WithBlockDeviceMappings<T1, T2, T3>(this CombinedResult<T1, InstanceFactory, T2, T3> combinedResult, Action<Humidifier.OpsWorks.InstanceTypes.BlockDeviceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBlockDeviceMappings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InstanceFactory, T3, InnerInstanceBlockDeviceMappingFactory> WithBlockDeviceMappings<T1, T2, T3>(this CombinedResult<T1, T2, InstanceFactory, T3> combinedResult, Action<Humidifier.OpsWorks.InstanceTypes.BlockDeviceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBlockDeviceMappings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InstanceFactory, InnerInstanceBlockDeviceMappingFactory> WithBlockDeviceMappings<T1, T2, T3>(this CombinedResult<T1, T2, T3, InstanceFactory> combinedResult, Action<Humidifier.OpsWorks.InstanceTypes.BlockDeviceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBlockDeviceMappings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InstanceFactory, T1, T2, T3, T4, InnerInstanceBlockDeviceMappingFactory> WithBlockDeviceMappings<T1, T2, T3, T4>(this CombinedResult<InstanceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.OpsWorks.InstanceTypes.BlockDeviceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBlockDeviceMappings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InstanceFactory, T2, T3, T4, InnerInstanceBlockDeviceMappingFactory> WithBlockDeviceMappings<T1, T2, T3, T4>(this CombinedResult<T1, InstanceFactory, T2, T3, T4> combinedResult, Action<Humidifier.OpsWorks.InstanceTypes.BlockDeviceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBlockDeviceMappings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InstanceFactory, T3, T4, InnerInstanceBlockDeviceMappingFactory> WithBlockDeviceMappings<T1, T2, T3, T4>(this CombinedResult<T1, T2, InstanceFactory, T3, T4> combinedResult, Action<Humidifier.OpsWorks.InstanceTypes.BlockDeviceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBlockDeviceMappings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InstanceFactory, T4, InnerInstanceBlockDeviceMappingFactory> WithBlockDeviceMappings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InstanceFactory, T4> combinedResult, Action<Humidifier.OpsWorks.InstanceTypes.BlockDeviceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBlockDeviceMappings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InstanceFactory, InnerInstanceBlockDeviceMappingFactory> WithBlockDeviceMappings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InstanceFactory> combinedResult, Action<Humidifier.OpsWorks.InstanceTypes.BlockDeviceMapping> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBlockDeviceMappings(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InstanceFactory, T1, InnerInstanceTimeBasedAutoScalingFactory> WithTimeBasedAutoScaling<T1>(this CombinedResult<InstanceFactory, T1> combinedResult, Action<Humidifier.OpsWorks.InstanceTypes.TimeBasedAutoScaling> subFactoryAction = null) => new (combinedResult, combinedResult, WithTimeBasedAutoScaling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InstanceFactory, InnerInstanceTimeBasedAutoScalingFactory> WithTimeBasedAutoScaling<T1>(this CombinedResult<T1, InstanceFactory> combinedResult, Action<Humidifier.OpsWorks.InstanceTypes.TimeBasedAutoScaling> subFactoryAction = null) => new (combinedResult, combinedResult, WithTimeBasedAutoScaling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InstanceFactory, T1, T2, InnerInstanceTimeBasedAutoScalingFactory> WithTimeBasedAutoScaling<T1, T2>(this CombinedResult<InstanceFactory, T1, T2> combinedResult, Action<Humidifier.OpsWorks.InstanceTypes.TimeBasedAutoScaling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTimeBasedAutoScaling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InstanceFactory, T2, InnerInstanceTimeBasedAutoScalingFactory> WithTimeBasedAutoScaling<T1, T2>(this CombinedResult<T1, InstanceFactory, T2> combinedResult, Action<Humidifier.OpsWorks.InstanceTypes.TimeBasedAutoScaling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTimeBasedAutoScaling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InstanceFactory, InnerInstanceTimeBasedAutoScalingFactory> WithTimeBasedAutoScaling<T1, T2>(this CombinedResult<T1, T2, InstanceFactory> combinedResult, Action<Humidifier.OpsWorks.InstanceTypes.TimeBasedAutoScaling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTimeBasedAutoScaling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InstanceFactory, T1, T2, T3, InnerInstanceTimeBasedAutoScalingFactory> WithTimeBasedAutoScaling<T1, T2, T3>(this CombinedResult<InstanceFactory, T1, T2, T3> combinedResult, Action<Humidifier.OpsWorks.InstanceTypes.TimeBasedAutoScaling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimeBasedAutoScaling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InstanceFactory, T2, T3, InnerInstanceTimeBasedAutoScalingFactory> WithTimeBasedAutoScaling<T1, T2, T3>(this CombinedResult<T1, InstanceFactory, T2, T3> combinedResult, Action<Humidifier.OpsWorks.InstanceTypes.TimeBasedAutoScaling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimeBasedAutoScaling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InstanceFactory, T3, InnerInstanceTimeBasedAutoScalingFactory> WithTimeBasedAutoScaling<T1, T2, T3>(this CombinedResult<T1, T2, InstanceFactory, T3> combinedResult, Action<Humidifier.OpsWorks.InstanceTypes.TimeBasedAutoScaling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimeBasedAutoScaling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InstanceFactory, InnerInstanceTimeBasedAutoScalingFactory> WithTimeBasedAutoScaling<T1, T2, T3>(this CombinedResult<T1, T2, T3, InstanceFactory> combinedResult, Action<Humidifier.OpsWorks.InstanceTypes.TimeBasedAutoScaling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimeBasedAutoScaling(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InstanceFactory, T1, T2, T3, T4, InnerInstanceTimeBasedAutoScalingFactory> WithTimeBasedAutoScaling<T1, T2, T3, T4>(this CombinedResult<InstanceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.OpsWorks.InstanceTypes.TimeBasedAutoScaling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimeBasedAutoScaling(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InstanceFactory, T2, T3, T4, InnerInstanceTimeBasedAutoScalingFactory> WithTimeBasedAutoScaling<T1, T2, T3, T4>(this CombinedResult<T1, InstanceFactory, T2, T3, T4> combinedResult, Action<Humidifier.OpsWorks.InstanceTypes.TimeBasedAutoScaling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimeBasedAutoScaling(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InstanceFactory, T3, T4, InnerInstanceTimeBasedAutoScalingFactory> WithTimeBasedAutoScaling<T1, T2, T3, T4>(this CombinedResult<T1, T2, InstanceFactory, T3, T4> combinedResult, Action<Humidifier.OpsWorks.InstanceTypes.TimeBasedAutoScaling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimeBasedAutoScaling(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InstanceFactory, T4, InnerInstanceTimeBasedAutoScalingFactory> WithTimeBasedAutoScaling<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InstanceFactory, T4> combinedResult, Action<Humidifier.OpsWorks.InstanceTypes.TimeBasedAutoScaling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimeBasedAutoScaling(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InstanceFactory, InnerInstanceTimeBasedAutoScalingFactory> WithTimeBasedAutoScaling<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InstanceFactory> combinedResult, Action<Humidifier.OpsWorks.InstanceTypes.TimeBasedAutoScaling> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimeBasedAutoScaling(combinedResult.T5, subFactoryAction));
}
