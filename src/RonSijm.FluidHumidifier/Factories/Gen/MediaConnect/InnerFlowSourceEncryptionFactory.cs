// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerFlowSourceEncryptionFactory(Action<Humidifier.MediaConnect.FlowSourceTypes.Encryption> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.FlowSourceTypes.Encryption>
{

    protected override Humidifier.MediaConnect.FlowSourceTypes.Encryption Create()
    {
        var encryptionResult = CreateEncryption();
        factoryAction?.Invoke(encryptionResult);

        return encryptionResult;
    }

    private Humidifier.MediaConnect.FlowSourceTypes.Encryption CreateEncryption()
    {
        var encryptionResult = new Humidifier.MediaConnect.FlowSourceTypes.Encryption();

        return encryptionResult;
    }

} // End Of Class

public static class InnerFlowSourceEncryptionFactoryExtensions
{
}
