// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kendra;

public class InnerIndexServerSideEncryptionConfigurationFactory(Action<Humidifier.Kendra.IndexTypes.ServerSideEncryptionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Kendra.IndexTypes.ServerSideEncryptionConfiguration>
{

    protected override Humidifier.Kendra.IndexTypes.ServerSideEncryptionConfiguration Create()
    {
        var serverSideEncryptionConfigurationResult = CreateServerSideEncryptionConfiguration();
        factoryAction?.Invoke(serverSideEncryptionConfigurationResult);

        return serverSideEncryptionConfigurationResult;
    }

    private Humidifier.Kendra.IndexTypes.ServerSideEncryptionConfiguration CreateServerSideEncryptionConfiguration()
    {
        var serverSideEncryptionConfigurationResult = new Humidifier.Kendra.IndexTypes.ServerSideEncryptionConfiguration();

        return serverSideEncryptionConfigurationResult;
    }

} // End Of Class

public static class InnerIndexServerSideEncryptionConfigurationFactoryExtensions
{
}
