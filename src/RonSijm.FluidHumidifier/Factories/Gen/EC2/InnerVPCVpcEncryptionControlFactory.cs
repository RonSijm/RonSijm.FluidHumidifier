// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerVPCVpcEncryptionControlFactory(Action<Humidifier.EC2.VPCTypes.VpcEncryptionControl> factoryAction = null) : SubResourceFactory<Humidifier.EC2.VPCTypes.VpcEncryptionControl>
{

    internal InnerVPCVpcEncryptionControlExclusionsFactory ResourceExclusionsFactory { get; set; }

    protected override Humidifier.EC2.VPCTypes.VpcEncryptionControl Create()
    {
        var vpcEncryptionControlResult = CreateVpcEncryptionControl();
        factoryAction?.Invoke(vpcEncryptionControlResult);

        return vpcEncryptionControlResult;
    }

    private Humidifier.EC2.VPCTypes.VpcEncryptionControl CreateVpcEncryptionControl()
    {
        var vpcEncryptionControlResult = new Humidifier.EC2.VPCTypes.VpcEncryptionControl();

        return vpcEncryptionControlResult;
    }
    public override void CreateChildren(Humidifier.EC2.VPCTypes.VpcEncryptionControl result)
    {
        base.CreateChildren(result);

        result.ResourceExclusions ??= ResourceExclusionsFactory?.Build();
    }

} // End Of Class

public static class InnerVPCVpcEncryptionControlFactoryExtensions
{
    public static CombinedResult<InnerVPCVpcEncryptionControlFactory, InnerVPCVpcEncryptionControlExclusionsFactory> WithResourceExclusions(this InnerVPCVpcEncryptionControlFactory parentFactory, Action<Humidifier.EC2.VPCTypes.VpcEncryptionControlExclusions> subFactoryAction = null)
    {
        parentFactory.ResourceExclusionsFactory = new InnerVPCVpcEncryptionControlExclusionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ResourceExclusionsFactory);
    }

    public static CombinedResult<InnerVPCVpcEncryptionControlFactory, T1, InnerVPCVpcEncryptionControlExclusionsFactory> WithResourceExclusions<T1>(this CombinedResult<InnerVPCVpcEncryptionControlFactory, T1> combinedResult, Action<Humidifier.EC2.VPCTypes.VpcEncryptionControlExclusions> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceExclusions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerVPCVpcEncryptionControlFactory, InnerVPCVpcEncryptionControlExclusionsFactory> WithResourceExclusions<T1>(this CombinedResult<T1, InnerVPCVpcEncryptionControlFactory> combinedResult, Action<Humidifier.EC2.VPCTypes.VpcEncryptionControlExclusions> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceExclusions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerVPCVpcEncryptionControlFactory, T1, T2, InnerVPCVpcEncryptionControlExclusionsFactory> WithResourceExclusions<T1, T2>(this CombinedResult<InnerVPCVpcEncryptionControlFactory, T1, T2> combinedResult, Action<Humidifier.EC2.VPCTypes.VpcEncryptionControlExclusions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceExclusions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerVPCVpcEncryptionControlFactory, T2, InnerVPCVpcEncryptionControlExclusionsFactory> WithResourceExclusions<T1, T2>(this CombinedResult<T1, InnerVPCVpcEncryptionControlFactory, T2> combinedResult, Action<Humidifier.EC2.VPCTypes.VpcEncryptionControlExclusions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceExclusions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerVPCVpcEncryptionControlFactory, InnerVPCVpcEncryptionControlExclusionsFactory> WithResourceExclusions<T1, T2>(this CombinedResult<T1, T2, InnerVPCVpcEncryptionControlFactory> combinedResult, Action<Humidifier.EC2.VPCTypes.VpcEncryptionControlExclusions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceExclusions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerVPCVpcEncryptionControlFactory, T1, T2, T3, InnerVPCVpcEncryptionControlExclusionsFactory> WithResourceExclusions<T1, T2, T3>(this CombinedResult<InnerVPCVpcEncryptionControlFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.VPCTypes.VpcEncryptionControlExclusions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceExclusions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerVPCVpcEncryptionControlFactory, T2, T3, InnerVPCVpcEncryptionControlExclusionsFactory> WithResourceExclusions<T1, T2, T3>(this CombinedResult<T1, InnerVPCVpcEncryptionControlFactory, T2, T3> combinedResult, Action<Humidifier.EC2.VPCTypes.VpcEncryptionControlExclusions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceExclusions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerVPCVpcEncryptionControlFactory, T3, InnerVPCVpcEncryptionControlExclusionsFactory> WithResourceExclusions<T1, T2, T3>(this CombinedResult<T1, T2, InnerVPCVpcEncryptionControlFactory, T3> combinedResult, Action<Humidifier.EC2.VPCTypes.VpcEncryptionControlExclusions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceExclusions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerVPCVpcEncryptionControlFactory, InnerVPCVpcEncryptionControlExclusionsFactory> WithResourceExclusions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerVPCVpcEncryptionControlFactory> combinedResult, Action<Humidifier.EC2.VPCTypes.VpcEncryptionControlExclusions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceExclusions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerVPCVpcEncryptionControlFactory, T1, T2, T3, T4, InnerVPCVpcEncryptionControlExclusionsFactory> WithResourceExclusions<T1, T2, T3, T4>(this CombinedResult<InnerVPCVpcEncryptionControlFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.VPCTypes.VpcEncryptionControlExclusions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceExclusions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerVPCVpcEncryptionControlFactory, T2, T3, T4, InnerVPCVpcEncryptionControlExclusionsFactory> WithResourceExclusions<T1, T2, T3, T4>(this CombinedResult<T1, InnerVPCVpcEncryptionControlFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.VPCTypes.VpcEncryptionControlExclusions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceExclusions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerVPCVpcEncryptionControlFactory, T3, T4, InnerVPCVpcEncryptionControlExclusionsFactory> WithResourceExclusions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerVPCVpcEncryptionControlFactory, T3, T4> combinedResult, Action<Humidifier.EC2.VPCTypes.VpcEncryptionControlExclusions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceExclusions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerVPCVpcEncryptionControlFactory, T4, InnerVPCVpcEncryptionControlExclusionsFactory> WithResourceExclusions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerVPCVpcEncryptionControlFactory, T4> combinedResult, Action<Humidifier.EC2.VPCTypes.VpcEncryptionControlExclusions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceExclusions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerVPCVpcEncryptionControlFactory, InnerVPCVpcEncryptionControlExclusionsFactory> WithResourceExclusions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerVPCVpcEncryptionControlFactory> combinedResult, Action<Humidifier.EC2.VPCTypes.VpcEncryptionControlExclusions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceExclusions(combinedResult.T5, subFactoryAction).T2);
}
