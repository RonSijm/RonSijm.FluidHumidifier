// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Artifact;

public class ReportFactory(string resourceName = null, Action<Humidifier.Artifact.Report> factoryAction = null) : ResourceFactory<Humidifier.Artifact.Report>(resourceName)
{

    protected override Humidifier.Artifact.Report Create()
    {
        var reportResult = CreateReport();
        factoryAction?.Invoke(reportResult);

        return reportResult;
    }

    private Humidifier.Artifact.Report CreateReport()
    {
        var reportResult = new Humidifier.Artifact.Report
        {
            GivenName = InputResourceName,
        };

        return reportResult;
    }

} // End Of Class

public static class ReportFactoryExtensions
{
}
