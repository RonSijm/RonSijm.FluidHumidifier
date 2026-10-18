// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkSpaces;

public class InnerDirectoryActiveDirectoryConfigFactory(Action<Humidifier.WorkSpaces.DirectoryTypes.ActiveDirectoryConfig> factoryAction = null) : SubResourceFactory<Humidifier.WorkSpaces.DirectoryTypes.ActiveDirectoryConfig>
{

    protected override Humidifier.WorkSpaces.DirectoryTypes.ActiveDirectoryConfig Create()
    {
        var activeDirectoryConfigResult = CreateActiveDirectoryConfig();
        factoryAction?.Invoke(activeDirectoryConfigResult);

        return activeDirectoryConfigResult;
    }

    private Humidifier.WorkSpaces.DirectoryTypes.ActiveDirectoryConfig CreateActiveDirectoryConfig()
    {
        var activeDirectoryConfigResult = new Humidifier.WorkSpaces.DirectoryTypes.ActiveDirectoryConfig();

        return activeDirectoryConfigResult;
    }

} // End Of Class

public static class InnerDirectoryActiveDirectoryConfigFactoryExtensions
{
}
