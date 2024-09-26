// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerInstanceBlockDeviceMappingFactory(Action<Humidifier.EC2.InstanceTypes.BlockDeviceMapping> factoryAction = null) : SubResourceFactory<Humidifier.EC2.InstanceTypes.BlockDeviceMapping>
{

    internal InnerInstanceEbsFactory EbsFactory { get; set; }

    protected override Humidifier.EC2.InstanceTypes.BlockDeviceMapping Create()
    {
        var blockDeviceMappingResult = CreateBlockDeviceMapping();
        factoryAction?.Invoke(blockDeviceMappingResult);

        return blockDeviceMappingResult;
    }

    private Humidifier.EC2.InstanceTypes.BlockDeviceMapping CreateBlockDeviceMapping()
    {
        var blockDeviceMappingResult = new Humidifier.EC2.InstanceTypes.BlockDeviceMapping();

        return blockDeviceMappingResult;
    }
    public override void CreateChildren(Humidifier.EC2.InstanceTypes.BlockDeviceMapping result)
    {
        base.CreateChildren(result);

        result.Ebs ??= EbsFactory?.Build();
    }

} // End Of Class

public static class InnerInstanceBlockDeviceMappingFactoryExtensions
{
    public static CombinedResult<InnerInstanceBlockDeviceMappingFactory, InnerInstanceEbsFactory> WithEbs(this InnerInstanceBlockDeviceMappingFactory parentFactory, Action<Humidifier.EC2.InstanceTypes.Ebs> subFactoryAction = null)
    {
        parentFactory.EbsFactory = new InnerInstanceEbsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EbsFactory);
    }

    public static CombinedResult<InnerInstanceBlockDeviceMappingFactory, T1, InnerInstanceEbsFactory> WithEbs<T1>(this CombinedResult<InnerInstanceBlockDeviceMappingFactory, T1> combinedResult, Action<Humidifier.EC2.InstanceTypes.Ebs> subFactoryAction = null) => new (combinedResult, combinedResult, WithEbs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceBlockDeviceMappingFactory, InnerInstanceEbsFactory> WithEbs<T1>(this CombinedResult<T1, InnerInstanceBlockDeviceMappingFactory> combinedResult, Action<Humidifier.EC2.InstanceTypes.Ebs> subFactoryAction = null) => new (combinedResult, combinedResult, WithEbs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerInstanceBlockDeviceMappingFactory, T1, T2, InnerInstanceEbsFactory> WithEbs<T1, T2>(this CombinedResult<InnerInstanceBlockDeviceMappingFactory, T1, T2> combinedResult, Action<Humidifier.EC2.InstanceTypes.Ebs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEbs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceBlockDeviceMappingFactory, T2, InnerInstanceEbsFactory> WithEbs<T1, T2>(this CombinedResult<T1, InnerInstanceBlockDeviceMappingFactory, T2> combinedResult, Action<Humidifier.EC2.InstanceTypes.Ebs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEbs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInstanceBlockDeviceMappingFactory, InnerInstanceEbsFactory> WithEbs<T1, T2>(this CombinedResult<T1, T2, InnerInstanceBlockDeviceMappingFactory> combinedResult, Action<Humidifier.EC2.InstanceTypes.Ebs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEbs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerInstanceBlockDeviceMappingFactory, T1, T2, T3, InnerInstanceEbsFactory> WithEbs<T1, T2, T3>(this CombinedResult<InnerInstanceBlockDeviceMappingFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.InstanceTypes.Ebs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEbs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceBlockDeviceMappingFactory, T2, T3, InnerInstanceEbsFactory> WithEbs<T1, T2, T3>(this CombinedResult<T1, InnerInstanceBlockDeviceMappingFactory, T2, T3> combinedResult, Action<Humidifier.EC2.InstanceTypes.Ebs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEbs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInstanceBlockDeviceMappingFactory, T3, InnerInstanceEbsFactory> WithEbs<T1, T2, T3>(this CombinedResult<T1, T2, InnerInstanceBlockDeviceMappingFactory, T3> combinedResult, Action<Humidifier.EC2.InstanceTypes.Ebs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEbs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerInstanceBlockDeviceMappingFactory, InnerInstanceEbsFactory> WithEbs<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerInstanceBlockDeviceMappingFactory> combinedResult, Action<Humidifier.EC2.InstanceTypes.Ebs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEbs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerInstanceBlockDeviceMappingFactory, T1, T2, T3, T4, InnerInstanceEbsFactory> WithEbs<T1, T2, T3, T4>(this CombinedResult<InnerInstanceBlockDeviceMappingFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.InstanceTypes.Ebs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEbs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerInstanceBlockDeviceMappingFactory, T2, T3, T4, InnerInstanceEbsFactory> WithEbs<T1, T2, T3, T4>(this CombinedResult<T1, InnerInstanceBlockDeviceMappingFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.InstanceTypes.Ebs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEbs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerInstanceBlockDeviceMappingFactory, T3, T4, InnerInstanceEbsFactory> WithEbs<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerInstanceBlockDeviceMappingFactory, T3, T4> combinedResult, Action<Humidifier.EC2.InstanceTypes.Ebs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEbs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerInstanceBlockDeviceMappingFactory, T4, InnerInstanceEbsFactory> WithEbs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerInstanceBlockDeviceMappingFactory, T4> combinedResult, Action<Humidifier.EC2.InstanceTypes.Ebs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEbs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerInstanceBlockDeviceMappingFactory, InnerInstanceEbsFactory> WithEbs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerInstanceBlockDeviceMappingFactory> combinedResult, Action<Humidifier.EC2.InstanceTypes.Ebs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEbs(combinedResult.T5, subFactoryAction));
}
