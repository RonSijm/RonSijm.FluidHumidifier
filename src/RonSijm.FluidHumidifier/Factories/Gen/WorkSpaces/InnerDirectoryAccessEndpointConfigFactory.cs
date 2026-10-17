// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkSpaces;

public class InnerDirectoryAccessEndpointConfigFactory(Action<Humidifier.WorkSpaces.DirectoryTypes.AccessEndpointConfig> factoryAction = null) : SubResourceFactory<Humidifier.WorkSpaces.DirectoryTypes.AccessEndpointConfig>
{

    protected override Humidifier.WorkSpaces.DirectoryTypes.AccessEndpointConfig Create()
    {
        var accessEndpointConfigResult = CreateAccessEndpointConfig();
        factoryAction?.Invoke(accessEndpointConfigResult);

        return accessEndpointConfigResult;
    }

    private Humidifier.WorkSpaces.DirectoryTypes.AccessEndpointConfig CreateAccessEndpointConfig()
    {
        var accessEndpointConfigResult = new Humidifier.WorkSpaces.DirectoryTypes.AccessEndpointConfig();

        return accessEndpointConfigResult;
    }

} // End Of Class

public static class InnerDirectoryAccessEndpointConfigFactoryExtensions
{
}
