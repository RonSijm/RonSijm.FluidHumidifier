// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkSpaces;

public class InnerDirectorySamlPropertiesFactory(Action<Humidifier.WorkSpaces.DirectoryTypes.SamlProperties> factoryAction = null) : SubResourceFactory<Humidifier.WorkSpaces.DirectoryTypes.SamlProperties>
{

    protected override Humidifier.WorkSpaces.DirectoryTypes.SamlProperties Create()
    {
        var samlPropertiesResult = CreateSamlProperties();
        factoryAction?.Invoke(samlPropertiesResult);

        return samlPropertiesResult;
    }

    private Humidifier.WorkSpaces.DirectoryTypes.SamlProperties CreateSamlProperties()
    {
        var samlPropertiesResult = new Humidifier.WorkSpaces.DirectoryTypes.SamlProperties();

        return samlPropertiesResult;
    }

} // End Of Class

public static class InnerDirectorySamlPropertiesFactoryExtensions
{
}
