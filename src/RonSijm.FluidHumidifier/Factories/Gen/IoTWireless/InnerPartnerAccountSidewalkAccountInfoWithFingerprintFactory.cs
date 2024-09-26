// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTWireless;

public class InnerPartnerAccountSidewalkAccountInfoWithFingerprintFactory(Action<Humidifier.IoTWireless.PartnerAccountTypes.SidewalkAccountInfoWithFingerprint> factoryAction = null) : SubResourceFactory<Humidifier.IoTWireless.PartnerAccountTypes.SidewalkAccountInfoWithFingerprint>
{

    protected override Humidifier.IoTWireless.PartnerAccountTypes.SidewalkAccountInfoWithFingerprint Create()
    {
        var sidewalkAccountInfoWithFingerprintResult = CreateSidewalkAccountInfoWithFingerprint();
        factoryAction?.Invoke(sidewalkAccountInfoWithFingerprintResult);

        return sidewalkAccountInfoWithFingerprintResult;
    }

    private Humidifier.IoTWireless.PartnerAccountTypes.SidewalkAccountInfoWithFingerprint CreateSidewalkAccountInfoWithFingerprint()
    {
        var sidewalkAccountInfoWithFingerprintResult = new Humidifier.IoTWireless.PartnerAccountTypes.SidewalkAccountInfoWithFingerprint();

        return sidewalkAccountInfoWithFingerprintResult;
    }

} // End Of Class

public static class InnerPartnerAccountSidewalkAccountInfoWithFingerprintFactoryExtensions
{
}
