// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataSourceDeletionProtectionConfigurationFactory(Action<Humidifier.Bedrock.DataSourceTypes.DeletionProtectionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataSourceTypes.DeletionProtectionConfiguration>
{

    protected override Humidifier.Bedrock.DataSourceTypes.DeletionProtectionConfiguration Create()
    {
        var deletionProtectionConfigurationResult = CreateDeletionProtectionConfiguration();
        factoryAction?.Invoke(deletionProtectionConfigurationResult);

        return deletionProtectionConfigurationResult;
    }

    private Humidifier.Bedrock.DataSourceTypes.DeletionProtectionConfiguration CreateDeletionProtectionConfiguration()
    {
        var deletionProtectionConfigurationResult = new Humidifier.Bedrock.DataSourceTypes.DeletionProtectionConfiguration();

        return deletionProtectionConfigurationResult;
    }

} // End Of Class

public static class InnerDataSourceDeletionProtectionConfigurationFactoryExtensions
{
}
