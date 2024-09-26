// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BCMDataExports;

public class InnerExportResourceTagFactory(Action<Humidifier.BCMDataExports.ExportTypes.ResourceTag> factoryAction = null) : SubResourceFactory<Humidifier.BCMDataExports.ExportTypes.ResourceTag>
{

    protected override Humidifier.BCMDataExports.ExportTypes.ResourceTag Create()
    {
        var resourceTagResult = CreateResourceTag();
        factoryAction?.Invoke(resourceTagResult);

        return resourceTagResult;
    }

    private Humidifier.BCMDataExports.ExportTypes.ResourceTag CreateResourceTag()
    {
        var resourceTagResult = new Humidifier.BCMDataExports.ExportTypes.ResourceTag();

        return resourceTagResult;
    }

} // End Of Class

public static class InnerExportResourceTagFactoryExtensions
{
}
