// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class VPCFactory(string resourceName = null, Action<Humidifier.EC2.VPC> factoryAction = null) : ResourceFactory<Humidifier.EC2.VPC>(resourceName)
{

    internal InnerVPCVpcEncryptionControlFactory VpcEncryptionControlFactory { get; set; }

    protected override Humidifier.EC2.VPC Create()
    {
        var vPCResult = CreateVPC();
        factoryAction?.Invoke(vPCResult);

        return vPCResult;
    }

    private Humidifier.EC2.VPC CreateVPC()
    {
        var vPCResult = new Humidifier.EC2.VPC
        {
            GivenName = InputResourceName,
        };

        return vPCResult;
    }
    public override void CreateChildren(Humidifier.EC2.VPC result)
    {
        base.CreateChildren(result);

        result.VpcEncryptionControl ??= VpcEncryptionControlFactory?.Build();
    }

} // End Of Class

public static class VPCFactoryExtensions
{
    public static CombinedResult<VPCFactory, InnerVPCVpcEncryptionControlFactory> WithVpcEncryptionControl(this VPCFactory parentFactory, Action<Humidifier.EC2.VPCTypes.VpcEncryptionControl> subFactoryAction = null)
    {
        parentFactory.VpcEncryptionControlFactory = new InnerVPCVpcEncryptionControlFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VpcEncryptionControlFactory);
    }

    public static CombinedResult<VPCFactory, T1, InnerVPCVpcEncryptionControlFactory> WithVpcEncryptionControl<T1>(this CombinedResult<VPCFactory, T1> combinedResult, Action<Humidifier.EC2.VPCTypes.VpcEncryptionControl> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcEncryptionControl(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, VPCFactory, InnerVPCVpcEncryptionControlFactory> WithVpcEncryptionControl<T1>(this CombinedResult<T1, VPCFactory> combinedResult, Action<Humidifier.EC2.VPCTypes.VpcEncryptionControl> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcEncryptionControl(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<VPCFactory, T1, T2, InnerVPCVpcEncryptionControlFactory> WithVpcEncryptionControl<T1, T2>(this CombinedResult<VPCFactory, T1, T2> combinedResult, Action<Humidifier.EC2.VPCTypes.VpcEncryptionControl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcEncryptionControl(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, VPCFactory, T2, InnerVPCVpcEncryptionControlFactory> WithVpcEncryptionControl<T1, T2>(this CombinedResult<T1, VPCFactory, T2> combinedResult, Action<Humidifier.EC2.VPCTypes.VpcEncryptionControl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcEncryptionControl(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, VPCFactory, InnerVPCVpcEncryptionControlFactory> WithVpcEncryptionControl<T1, T2>(this CombinedResult<T1, T2, VPCFactory> combinedResult, Action<Humidifier.EC2.VPCTypes.VpcEncryptionControl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcEncryptionControl(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<VPCFactory, T1, T2, T3, InnerVPCVpcEncryptionControlFactory> WithVpcEncryptionControl<T1, T2, T3>(this CombinedResult<VPCFactory, T1, T2, T3> combinedResult, Action<Humidifier.EC2.VPCTypes.VpcEncryptionControl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcEncryptionControl(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, VPCFactory, T2, T3, InnerVPCVpcEncryptionControlFactory> WithVpcEncryptionControl<T1, T2, T3>(this CombinedResult<T1, VPCFactory, T2, T3> combinedResult, Action<Humidifier.EC2.VPCTypes.VpcEncryptionControl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcEncryptionControl(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, VPCFactory, T3, InnerVPCVpcEncryptionControlFactory> WithVpcEncryptionControl<T1, T2, T3>(this CombinedResult<T1, T2, VPCFactory, T3> combinedResult, Action<Humidifier.EC2.VPCTypes.VpcEncryptionControl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcEncryptionControl(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, VPCFactory, InnerVPCVpcEncryptionControlFactory> WithVpcEncryptionControl<T1, T2, T3>(this CombinedResult<T1, T2, T3, VPCFactory> combinedResult, Action<Humidifier.EC2.VPCTypes.VpcEncryptionControl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcEncryptionControl(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<VPCFactory, T1, T2, T3, T4, InnerVPCVpcEncryptionControlFactory> WithVpcEncryptionControl<T1, T2, T3, T4>(this CombinedResult<VPCFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EC2.VPCTypes.VpcEncryptionControl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcEncryptionControl(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, VPCFactory, T2, T3, T4, InnerVPCVpcEncryptionControlFactory> WithVpcEncryptionControl<T1, T2, T3, T4>(this CombinedResult<T1, VPCFactory, T2, T3, T4> combinedResult, Action<Humidifier.EC2.VPCTypes.VpcEncryptionControl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcEncryptionControl(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, VPCFactory, T3, T4, InnerVPCVpcEncryptionControlFactory> WithVpcEncryptionControl<T1, T2, T3, T4>(this CombinedResult<T1, T2, VPCFactory, T3, T4> combinedResult, Action<Humidifier.EC2.VPCTypes.VpcEncryptionControl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcEncryptionControl(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, VPCFactory, T4, InnerVPCVpcEncryptionControlFactory> WithVpcEncryptionControl<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, VPCFactory, T4> combinedResult, Action<Humidifier.EC2.VPCTypes.VpcEncryptionControl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcEncryptionControl(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, VPCFactory, InnerVPCVpcEncryptionControlFactory> WithVpcEncryptionControl<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, VPCFactory> combinedResult, Action<Humidifier.EC2.VPCTypes.VpcEncryptionControl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcEncryptionControl(combinedResult.T5, subFactoryAction).T2);
}
