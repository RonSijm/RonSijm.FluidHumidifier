// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkSpaces;

public class InnerDirectoryMicrosoftEntraConfigFactory(Action<Humidifier.WorkSpaces.DirectoryTypes.MicrosoftEntraConfig> factoryAction = null) : SubResourceFactory<Humidifier.WorkSpaces.DirectoryTypes.MicrosoftEntraConfig>
{

    protected override Humidifier.WorkSpaces.DirectoryTypes.MicrosoftEntraConfig Create()
    {
        var microsoftEntraConfigResult = CreateMicrosoftEntraConfig();
        factoryAction?.Invoke(microsoftEntraConfigResult);

        return microsoftEntraConfigResult;
    }

    private Humidifier.WorkSpaces.DirectoryTypes.MicrosoftEntraConfig CreateMicrosoftEntraConfig()
    {
        var microsoftEntraConfigResult = new Humidifier.WorkSpaces.DirectoryTypes.MicrosoftEntraConfig();

        return microsoftEntraConfigResult;
    }

} // End Of Class

public static class InnerDirectoryMicrosoftEntraConfigFactoryExtensions
{
}
