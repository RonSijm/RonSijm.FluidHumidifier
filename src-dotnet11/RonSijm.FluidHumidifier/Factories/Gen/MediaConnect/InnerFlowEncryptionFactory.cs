// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerFlowEncryptionFactory(Action<Humidifier.MediaConnect.FlowTypes.Encryption> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.FlowTypes.Encryption>
{

    protected override Humidifier.MediaConnect.FlowTypes.Encryption Create()
    {
        var encryptionResult = CreateEncryption();
        factoryAction?.Invoke(encryptionResult);

        return encryptionResult;
    }

    private Humidifier.MediaConnect.FlowTypes.Encryption CreateEncryption()
    {
        var encryptionResult = new Humidifier.MediaConnect.FlowTypes.Encryption();

        return encryptionResult;
    }

} // End Of Class

public static class InnerFlowEncryptionFactoryExtensions
{
}
