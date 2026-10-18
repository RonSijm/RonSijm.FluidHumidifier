// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkSpacesWeb;

public class TrustStoreFactory(string resourceName = null, Action<Humidifier.WorkSpacesWeb.TrustStore> factoryAction = null) : ResourceFactory<Humidifier.WorkSpacesWeb.TrustStore>(resourceName)
{

    protected override Humidifier.WorkSpacesWeb.TrustStore Create()
    {
        var trustStoreResult = CreateTrustStore();
        factoryAction?.Invoke(trustStoreResult);

        return trustStoreResult;
    }

    private Humidifier.WorkSpacesWeb.TrustStore CreateTrustStore()
    {
        var trustStoreResult = new Humidifier.WorkSpacesWeb.TrustStore
        {
            GivenName = InputResourceName,
        };

        return trustStoreResult;
    }

} // End Of Class

public static class TrustStoreFactoryExtensions
{
}
