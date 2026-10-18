// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerDataSourceRedshiftCredentialConfigurationFactory(Action<Humidifier.DataZone.DataSourceTypes.RedshiftCredentialConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.DataSourceTypes.RedshiftCredentialConfiguration>
{

    protected override Humidifier.DataZone.DataSourceTypes.RedshiftCredentialConfiguration Create()
    {
        var redshiftCredentialConfigurationResult = CreateRedshiftCredentialConfiguration();
        factoryAction?.Invoke(redshiftCredentialConfigurationResult);

        return redshiftCredentialConfigurationResult;
    }

    private Humidifier.DataZone.DataSourceTypes.RedshiftCredentialConfiguration CreateRedshiftCredentialConfiguration()
    {
        var redshiftCredentialConfigurationResult = new Humidifier.DataZone.DataSourceTypes.RedshiftCredentialConfiguration();

        return redshiftCredentialConfigurationResult;
    }

} // End Of Class

public static class InnerDataSourceRedshiftCredentialConfigurationFactoryExtensions
{
}
