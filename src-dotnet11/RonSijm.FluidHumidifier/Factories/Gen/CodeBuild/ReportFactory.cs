// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeBuild;

public class ReportFactory(string resourceName = null, Action<Humidifier.CodeBuild.Report> factoryAction = null) : ResourceFactory<Humidifier.CodeBuild.Report>(resourceName)
{

    protected override Humidifier.CodeBuild.Report Create()
    {
        var reportResult = CreateReport();
        factoryAction?.Invoke(reportResult);

        return reportResult;
    }

    private Humidifier.CodeBuild.Report CreateReport()
    {
        var reportResult = new Humidifier.CodeBuild.Report
        {
            GivenName = InputResourceName,
        };

        return reportResult;
    }

} // End Of Class

public static class ReportFactoryExtensions
{
}
