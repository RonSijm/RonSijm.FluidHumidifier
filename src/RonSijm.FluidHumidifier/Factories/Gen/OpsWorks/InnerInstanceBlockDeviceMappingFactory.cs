// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpsWorks;

public class InnerInstanceBlockDeviceMappingFactory(Action<Humidifier.OpsWorks.InstanceTypes.BlockDeviceMapping> factoryAction = null) : SubResourceFactory<Humidifier.OpsWorks.InstanceTypes.BlockDeviceMapping>
{

    internal InnerInstanceEbsBlockDeviceFactory EbsFactory { get; set; }

    protected override Humidifier.OpsWorks.InstanceTypes.BlockDeviceMapping Create()
    {
        var blockDeviceMappingResult = CreateBlockDeviceMapping();
        factoryAction?.Invoke(blockDeviceMappingResult);

        return blockDeviceMappingResult;
    }

    private Humidifier.OpsWorks.InstanceTypes.BlockDeviceMapping CreateBlockDeviceMapping()
    {
        var blockDeviceMappingResult = new Humidifier.OpsWorks.InstanceTypes.BlockDeviceMapping();

        return blockDeviceMappingResult;
    }
    public override void CreateChildren(Humidifier.OpsWorks.InstanceTypes.BlockDeviceMapping result)
    {
        base.CreateChildren(result);

        result.Ebs ??= EbsFactory?.Build();
    }

} // End Of Class

public static class InnerInstanceBlockDeviceMappingFactoryExtensions
{
    public static CombinedResult<InnerInstanceBlockDeviceMappingFactory, InnerInstanceEbsBlockDeviceFactory> WithEbs(this InnerInstanceBlockDeviceMappingFactory parentFactory, Action<Humidifier.OpsWorks.InstanceTypes.EbsBlockDevice> subFactoryAction = null)
    {
        parentFactory.EbsFactory = new InnerInstanceEbsBlockDeviceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EbsFactory);
    }

    public static CombinedResult<InnerInstanceBlockDeviceMappingFactory, T1, InnerInstanceEbsBlockDeviceFactory> WithEbs<T1>(this CombinedResult<InnerInstanceBlockDeviceMappingFactory, T1> combinedResult, Action<Humidifier.OpsWorks.InstanceTypes.EbsBlockDevice> subFactoryAction = null) => new (combinedResult, combinedResult, WithEbs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceBlockDeviceMappingFactory, InnerInstanceEbsBlockDeviceFactory> WithEbs<T1>(this CombinedResult<T1, InnerInstanceBlockDeviceMappingFactory> combinedResult, Action<Humidifier.OpsWorks.InstanceTypes.EbsBlockDevice> subFactoryAction = null) => new (combinedResult, combinedResult, WithEbs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerInstanceBlockDeviceMappingFactory, T1, T2, InnerInstanceEbsBlockDeviceFactory> WithEbs<T1, T2>(this CombinedResult<InnerInstanceBlockDeviceMappingFactory, T1, T2> combinedResult, Action<Humidifier.OpsWorks.InstanceTypes.EbsBlockDevice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEbs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceBlockDeviceMappingFactory, T2, InnerInstanceEbsBlockDeviceFactory> WithEbs<T1, T2>(this CombinedResult<T1, InnerInstanceBlockDeviceMappingFactory, T2> combinedResult, Action<Humidifier.OpsWorks.InstanceTypes.EbsBlockDevice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEbs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInstanceBlockDeviceMappingFactory, InnerInstanceEbsBlockDeviceFactory> WithEbs<T1, T2>(this CombinedResult<T1, T2, InnerInstanceBlockDeviceMappingFactory> combinedResult, Action<Humidifier.OpsWorks.InstanceTypes.EbsBlockDevice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEbs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerInstanceBlockDeviceMappingFactory, T1, T2, T3, InnerInstanceEbsBlockDeviceFactory> WithEbs<T1, T2, T3>(this CombinedResult<InnerInstanceBlockDeviceMappingFactory, T1, T2, T3> combinedResult, Action<Humidifier.OpsWorks.InstanceTypes.EbsBlockDevice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEbs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceBlockDeviceMappingFactory, T2, T3, InnerInstanceEbsBlockDeviceFactory> WithEbs<T1, T2, T3>(this CombinedResult<T1, InnerInstanceBlockDeviceMappingFactory, T2, T3> combinedResult, Action<Humidifier.OpsWorks.InstanceTypes.EbsBlockDevice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEbs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInstanceBlockDeviceMappingFactory, T3, InnerInstanceEbsBlockDeviceFactory> WithEbs<T1, T2, T3>(this CombinedResult<T1, T2, InnerInstanceBlockDeviceMappingFactory, T3> combinedResult, Action<Humidifier.OpsWorks.InstanceTypes.EbsBlockDevice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEbs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerInstanceBlockDeviceMappingFactory, InnerInstanceEbsBlockDeviceFactory> WithEbs<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerInstanceBlockDeviceMappingFactory> combinedResult, Action<Humidifier.OpsWorks.InstanceTypes.EbsBlockDevice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEbs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerInstanceBlockDeviceMappingFactory, T1, T2, T3, T4, InnerInstanceEbsBlockDeviceFactory> WithEbs<T1, T2, T3, T4>(this CombinedResult<InnerInstanceBlockDeviceMappingFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.OpsWorks.InstanceTypes.EbsBlockDevice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEbs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceBlockDeviceMappingFactory, T2, T3, T4, InnerInstanceEbsBlockDeviceFactory> WithEbs<T1, T2, T3, T4>(this CombinedResult<T1, InnerInstanceBlockDeviceMappingFactory, T2, T3, T4> combinedResult, Action<Humidifier.OpsWorks.InstanceTypes.EbsBlockDevice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEbs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInstanceBlockDeviceMappingFactory, T3, T4, InnerInstanceEbsBlockDeviceFactory> WithEbs<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerInstanceBlockDeviceMappingFactory, T3, T4> combinedResult, Action<Humidifier.OpsWorks.InstanceTypes.EbsBlockDevice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEbs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerInstanceBlockDeviceMappingFactory, T4, InnerInstanceEbsBlockDeviceFactory> WithEbs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerInstanceBlockDeviceMappingFactory, T4> combinedResult, Action<Humidifier.OpsWorks.InstanceTypes.EbsBlockDevice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEbs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerInstanceBlockDeviceMappingFactory, InnerInstanceEbsBlockDeviceFactory> WithEbs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerInstanceBlockDeviceMappingFactory> combinedResult, Action<Humidifier.OpsWorks.InstanceTypes.EbsBlockDevice> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEbs(combinedResult.T5, subFactoryAction));
}
