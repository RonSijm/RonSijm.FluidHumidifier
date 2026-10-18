// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSourceKeyPairCredentialsFactory(Action<Humidifier.QuickSight.DataSourceTypes.KeyPairCredentials> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSourceTypes.KeyPairCredentials>
{

    protected override Humidifier.QuickSight.DataSourceTypes.KeyPairCredentials Create()
    {
        var keyPairCredentialsResult = CreateKeyPairCredentials();
        factoryAction?.Invoke(keyPairCredentialsResult);

        return keyPairCredentialsResult;
    }

    private Humidifier.QuickSight.DataSourceTypes.KeyPairCredentials CreateKeyPairCredentials()
    {
        var keyPairCredentialsResult = new Humidifier.QuickSight.DataSourceTypes.KeyPairCredentials();

        return keyPairCredentialsResult;
    }

} // End Of Class

public static class InnerDataSourceKeyPairCredentialsFactoryExtensions
{
}
