// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PI;

public class PerfReportsFactory(string resourceName = null, Action<Humidifier.PI.PerfReports> factoryAction = null) : ResourceFactory<Humidifier.PI.PerfReports>(resourceName)
{

    protected override Humidifier.PI.PerfReports Create()
    {
        var perfReportsResult = CreatePerfReports();
        factoryAction?.Invoke(perfReportsResult);

        return perfReportsResult;
    }

    private Humidifier.PI.PerfReports CreatePerfReports()
    {
        var perfReportsResult = new Humidifier.PI.PerfReports
        {
            GivenName = InputResourceName,
        };

        return perfReportsResult;
    }

} // End Of Class

public static class PerfReportsFactoryExtensions
{
}
