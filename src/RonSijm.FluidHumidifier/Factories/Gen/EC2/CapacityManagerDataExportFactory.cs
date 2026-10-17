// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class CapacityManagerDataExportFactory(string resourceName = null, Action<Humidifier.EC2.CapacityManagerDataExport> factoryAction = null) : ResourceFactory<Humidifier.EC2.CapacityManagerDataExport>(resourceName)
{

    protected override Humidifier.EC2.CapacityManagerDataExport Create()
    {
        var capacityManagerDataExportResult = CreateCapacityManagerDataExport();
        factoryAction?.Invoke(capacityManagerDataExportResult);

        return capacityManagerDataExportResult;
    }

    private Humidifier.EC2.CapacityManagerDataExport CreateCapacityManagerDataExport()
    {
        var capacityManagerDataExportResult = new Humidifier.EC2.CapacityManagerDataExport
        {
            GivenName = InputResourceName,
        };

        return capacityManagerDataExportResult;
    }

} // End Of Class

public static class CapacityManagerDataExportFactoryExtensions
{
}
