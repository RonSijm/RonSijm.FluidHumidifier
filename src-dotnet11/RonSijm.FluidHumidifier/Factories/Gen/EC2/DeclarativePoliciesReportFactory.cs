// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class DeclarativePoliciesReportFactory(string resourceName = null, Action<Humidifier.EC2.DeclarativePoliciesReport> factoryAction = null) : ResourceFactory<Humidifier.EC2.DeclarativePoliciesReport>(resourceName)
{

    protected override Humidifier.EC2.DeclarativePoliciesReport Create()
    {
        var declarativePoliciesReportResult = CreateDeclarativePoliciesReport();
        factoryAction?.Invoke(declarativePoliciesReportResult);

        return declarativePoliciesReportResult;
    }

    private Humidifier.EC2.DeclarativePoliciesReport CreateDeclarativePoliciesReport()
    {
        var declarativePoliciesReportResult = new Humidifier.EC2.DeclarativePoliciesReport
        {
            GivenName = InputResourceName,
        };

        return declarativePoliciesReportResult;
    }

} // End Of Class

public static class DeclarativePoliciesReportFactoryExtensions
{
}
