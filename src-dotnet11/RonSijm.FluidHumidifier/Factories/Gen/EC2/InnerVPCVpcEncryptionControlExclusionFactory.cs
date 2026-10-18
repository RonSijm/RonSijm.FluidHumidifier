// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerVPCVpcEncryptionControlExclusionFactory(Action<Humidifier.EC2.VPCTypes.VpcEncryptionControlExclusion> factoryAction = null) : SubResourceFactory<Humidifier.EC2.VPCTypes.VpcEncryptionControlExclusion>
{

    protected override Humidifier.EC2.VPCTypes.VpcEncryptionControlExclusion Create()
    {
        var vpcEncryptionControlExclusionResult = CreateVpcEncryptionControlExclusion();
        factoryAction?.Invoke(vpcEncryptionControlExclusionResult);

        return vpcEncryptionControlExclusionResult;
    }

    private Humidifier.EC2.VPCTypes.VpcEncryptionControlExclusion CreateVpcEncryptionControlExclusion()
    {
        var vpcEncryptionControlExclusionResult = new Humidifier.EC2.VPCTypes.VpcEncryptionControlExclusion();

        return vpcEncryptionControlExclusionResult;
    }

} // End Of Class

public static class InnerVPCVpcEncryptionControlExclusionFactoryExtensions
{
}
