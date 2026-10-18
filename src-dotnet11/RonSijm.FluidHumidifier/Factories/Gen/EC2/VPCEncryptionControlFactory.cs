// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class VPCEncryptionControlFactory(string resourceName = null, Action<Humidifier.EC2.VPCEncryptionControl> factoryAction = null) : ResourceFactory<Humidifier.EC2.VPCEncryptionControl>(resourceName)
{

    protected override Humidifier.EC2.VPCEncryptionControl Create()
    {
        var vPCEncryptionControlResult = CreateVPCEncryptionControl();
        factoryAction?.Invoke(vPCEncryptionControlResult);

        return vPCEncryptionControlResult;
    }

    private Humidifier.EC2.VPCEncryptionControl CreateVPCEncryptionControl()
    {
        var vPCEncryptionControlResult = new Humidifier.EC2.VPCEncryptionControl
        {
            GivenName = InputResourceName,
        };

        return vPCEncryptionControlResult;
    }

} // End Of Class

public static class VPCEncryptionControlFactoryExtensions
{
}
