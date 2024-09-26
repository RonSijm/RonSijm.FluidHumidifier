// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerFlowOutputEncryptionFactory(Action<Humidifier.MediaConnect.FlowOutputTypes.Encryption> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.FlowOutputTypes.Encryption>
{

    protected override Humidifier.MediaConnect.FlowOutputTypes.Encryption Create()
    {
        var encryptionResult = CreateEncryption();
        factoryAction?.Invoke(encryptionResult);

        return encryptionResult;
    }

    private Humidifier.MediaConnect.FlowOutputTypes.Encryption CreateEncryption()
    {
        var encryptionResult = new Humidifier.MediaConnect.FlowOutputTypes.Encryption();

        return encryptionResult;
    }

} // End Of Class

public static class InnerFlowOutputEncryptionFactoryExtensions
{
}
