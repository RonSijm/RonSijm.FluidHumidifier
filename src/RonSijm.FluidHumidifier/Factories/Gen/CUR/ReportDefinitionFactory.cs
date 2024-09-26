// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CUR;

public class ReportDefinitionFactory(string resourceName = null, Action<Humidifier.CUR.ReportDefinition> factoryAction = null) : ResourceFactory<Humidifier.CUR.ReportDefinition>(resourceName)
{

    protected override Humidifier.CUR.ReportDefinition Create()
    {
        var reportDefinitionResult = CreateReportDefinition();
        factoryAction?.Invoke(reportDefinitionResult);

        return reportDefinitionResult;
    }

    private Humidifier.CUR.ReportDefinition CreateReportDefinition()
    {
        var reportDefinitionResult = new Humidifier.CUR.ReportDefinition
        {
            GivenName = InputResourceName,
        };

        return reportDefinitionResult;
    }

} // End Of Class

public static class ReportDefinitionFactoryExtensions
{
}
