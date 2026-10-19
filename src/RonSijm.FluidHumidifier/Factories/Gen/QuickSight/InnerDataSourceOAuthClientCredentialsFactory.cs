// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSourceOAuthClientCredentialsFactory(Action<Humidifier.QuickSight.DataSourceTypes.OAuthClientCredentials> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSourceTypes.OAuthClientCredentials>
{

    protected override Humidifier.QuickSight.DataSourceTypes.OAuthClientCredentials Create()
    {
        var oAuthClientCredentialsResult = CreateOAuthClientCredentials();
        factoryAction?.Invoke(oAuthClientCredentialsResult);

        return oAuthClientCredentialsResult;
    }

    private Humidifier.QuickSight.DataSourceTypes.OAuthClientCredentials CreateOAuthClientCredentials()
    {
        var oAuthClientCredentialsResult = new Humidifier.QuickSight.DataSourceTypes.OAuthClientCredentials();

        return oAuthClientCredentialsResult;
    }

} // End Of Class

public static class InnerDataSourceOAuthClientCredentialsFactoryExtensions
{
}
