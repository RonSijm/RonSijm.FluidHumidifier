// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BCMDataExports;

public class InnerExportRefreshCadenceFactory(Action<Humidifier.BCMDataExports.ExportTypes.RefreshCadence> factoryAction = null) : SubResourceFactory<Humidifier.BCMDataExports.ExportTypes.RefreshCadence>
{

    protected override Humidifier.BCMDataExports.ExportTypes.RefreshCadence Create()
    {
        var refreshCadenceResult = CreateRefreshCadence();
        factoryAction?.Invoke(refreshCadenceResult);

        return refreshCadenceResult;
    }

    private Humidifier.BCMDataExports.ExportTypes.RefreshCadence CreateRefreshCadence()
    {
        var refreshCadenceResult = new Humidifier.BCMDataExports.ExportTypes.RefreshCadence();

        return refreshCadenceResult;
    }

} // End Of Class

public static class InnerExportRefreshCadenceFactoryExtensions
{
}
