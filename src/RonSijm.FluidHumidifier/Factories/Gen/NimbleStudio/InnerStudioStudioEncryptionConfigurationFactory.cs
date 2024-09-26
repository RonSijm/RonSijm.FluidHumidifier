// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NimbleStudio;

public class InnerStudioStudioEncryptionConfigurationFactory(Action<Humidifier.NimbleStudio.StudioTypes.StudioEncryptionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.NimbleStudio.StudioTypes.StudioEncryptionConfiguration>
{

    protected override Humidifier.NimbleStudio.StudioTypes.StudioEncryptionConfiguration Create()
    {
        var studioEncryptionConfigurationResult = CreateStudioEncryptionConfiguration();
        factoryAction?.Invoke(studioEncryptionConfigurationResult);

        return studioEncryptionConfigurationResult;
    }

    private Humidifier.NimbleStudio.StudioTypes.StudioEncryptionConfiguration CreateStudioEncryptionConfiguration()
    {
        var studioEncryptionConfigurationResult = new Humidifier.NimbleStudio.StudioTypes.StudioEncryptionConfiguration();

        return studioEncryptionConfigurationResult;
    }

} // End Of Class

public static class InnerStudioStudioEncryptionConfigurationFactoryExtensions
{
}
