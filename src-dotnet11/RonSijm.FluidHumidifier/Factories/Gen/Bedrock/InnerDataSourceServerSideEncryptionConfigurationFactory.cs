// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataSourceServerSideEncryptionConfigurationFactory(Action<Humidifier.Bedrock.DataSourceTypes.ServerSideEncryptionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataSourceTypes.ServerSideEncryptionConfiguration>
{

    protected override Humidifier.Bedrock.DataSourceTypes.ServerSideEncryptionConfiguration Create()
    {
        var serverSideEncryptionConfigurationResult = CreateServerSideEncryptionConfiguration();
        factoryAction?.Invoke(serverSideEncryptionConfigurationResult);

        return serverSideEncryptionConfigurationResult;
    }

    private Humidifier.Bedrock.DataSourceTypes.ServerSideEncryptionConfiguration CreateServerSideEncryptionConfiguration()
    {
        var serverSideEncryptionConfigurationResult = new Humidifier.Bedrock.DataSourceTypes.ServerSideEncryptionConfiguration();

        return serverSideEncryptionConfigurationResult;
    }

} // End Of Class

public static class InnerDataSourceServerSideEncryptionConfigurationFactoryExtensions
{
}
