// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FSx;

public class InnerTaskCompletionReportFactory(Action<Humidifier.FSx.TaskTypes.CompletionReport> factoryAction = null) : SubResourceFactory<Humidifier.FSx.TaskTypes.CompletionReport>
{

    protected override Humidifier.FSx.TaskTypes.CompletionReport Create()
    {
        var completionReportResult = CreateCompletionReport();
        factoryAction?.Invoke(completionReportResult);

        return completionReportResult;
    }

    private Humidifier.FSx.TaskTypes.CompletionReport CreateCompletionReport()
    {
        var completionReportResult = new Humidifier.FSx.TaskTypes.CompletionReport();

        return completionReportResult;
    }

} // End Of Class

public static class InnerTaskCompletionReportFactoryExtensions
{
}
