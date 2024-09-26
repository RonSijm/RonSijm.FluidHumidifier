// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transfer;

public class InnerConnectorSftpConfigFactory(Action<Humidifier.Transfer.ConnectorTypes.SftpConfig> factoryAction = null) : SubResourceFactory<Humidifier.Transfer.ConnectorTypes.SftpConfig>
{

    protected override Humidifier.Transfer.ConnectorTypes.SftpConfig Create()
    {
        var sftpConfigResult = CreateSftpConfig();
        factoryAction?.Invoke(sftpConfigResult);

        return sftpConfigResult;
    }

    private Humidifier.Transfer.ConnectorTypes.SftpConfig CreateSftpConfig()
    {
        var sftpConfigResult = new Humidifier.Transfer.ConnectorTypes.SftpConfig();

        return sftpConfigResult;
    }

} // End Of Class

public static class InnerConnectorSftpConfigFactoryExtensions
{
}
