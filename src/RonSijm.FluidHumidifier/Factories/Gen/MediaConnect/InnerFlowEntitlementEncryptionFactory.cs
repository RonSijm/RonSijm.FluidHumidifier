// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerFlowEntitlementEncryptionFactory(Action<Humidifier.MediaConnect.FlowEntitlementTypes.Encryption> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.FlowEntitlementTypes.Encryption>
{

    protected override Humidifier.MediaConnect.FlowEntitlementTypes.Encryption Create()
    {
        var encryptionResult = CreateEncryption();
        factoryAction?.Invoke(encryptionResult);

        return encryptionResult;
    }

    private Humidifier.MediaConnect.FlowEntitlementTypes.Encryption CreateEncryption()
    {
        var encryptionResult = new Humidifier.MediaConnect.FlowEntitlementTypes.Encryption();

        return encryptionResult;
    }

} // End Of Class

public static class InnerFlowEntitlementEncryptionFactoryExtensions
{
}
