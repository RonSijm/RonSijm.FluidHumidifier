// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoTSiteWise;

public class InnerWorkspaceEncryptionConfigurationFactory(Action<Humidifier.IoTSiteWise.WorkspaceTypes.EncryptionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IoTSiteWise.WorkspaceTypes.EncryptionConfiguration>
{

    protected override Humidifier.IoTSiteWise.WorkspaceTypes.EncryptionConfiguration Create()
    {
        var encryptionConfigurationResult = CreateEncryptionConfiguration();
        factoryAction?.Invoke(encryptionConfigurationResult);

        return encryptionConfigurationResult;
    }

    private Humidifier.IoTSiteWise.WorkspaceTypes.EncryptionConfiguration CreateEncryptionConfiguration()
    {
        var encryptionConfigurationResult = new Humidifier.IoTSiteWise.WorkspaceTypes.EncryptionConfiguration();

        return encryptionConfigurationResult;
    }

} // End Of Class

public static class InnerWorkspaceEncryptionConfigurationFactoryExtensions
{
}
