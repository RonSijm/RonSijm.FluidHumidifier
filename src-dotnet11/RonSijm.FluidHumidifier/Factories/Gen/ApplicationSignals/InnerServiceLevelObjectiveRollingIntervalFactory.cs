// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApplicationSignals;

public class InnerServiceLevelObjectiveRollingIntervalFactory(Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.RollingInterval> factoryAction = null) : SubResourceFactory<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.RollingInterval>
{

    protected override Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.RollingInterval Create()
    {
        var rollingIntervalResult = CreateRollingInterval();
        factoryAction?.Invoke(rollingIntervalResult);

        return rollingIntervalResult;
    }

    private Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.RollingInterval CreateRollingInterval()
    {
        var rollingIntervalResult = new Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.RollingInterval();

        return rollingIntervalResult;
    }

} // End Of Class

public static class InnerServiceLevelObjectiveRollingIntervalFactoryExtensions
{
}
