// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SystemsManagerSAP;

public class InnerApplicationCredentialFactory(Action<Humidifier.SystemsManagerSAP.ApplicationTypes.Credential> factoryAction = null) : SubResourceFactory<Humidifier.SystemsManagerSAP.ApplicationTypes.Credential>
{

    protected override Humidifier.SystemsManagerSAP.ApplicationTypes.Credential Create()
    {
        var credentialResult = CreateCredential();
        factoryAction?.Invoke(credentialResult);

        return credentialResult;
    }

    private Humidifier.SystemsManagerSAP.ApplicationTypes.Credential CreateCredential()
    {
        var credentialResult = new Humidifier.SystemsManagerSAP.ApplicationTypes.Credential();

        return credentialResult;
    }

} // End Of Class

public static class InnerApplicationCredentialFactoryExtensions
{
}
