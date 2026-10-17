// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApplicationSignals;

public class InnerServiceLevelObjectiveBurnRateConfigurationFactory(Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.BurnRateConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.BurnRateConfiguration>
{

    protected override Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.BurnRateConfiguration Create()
    {
        var burnRateConfigurationResult = CreateBurnRateConfiguration();
        factoryAction?.Invoke(burnRateConfigurationResult);

        return burnRateConfigurationResult;
    }

    private Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.BurnRateConfiguration CreateBurnRateConfiguration()
    {
        var burnRateConfigurationResult = new Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.BurnRateConfiguration();

        return burnRateConfigurationResult;
    }

} // End Of Class

public static class InnerServiceLevelObjectiveBurnRateConfigurationFactoryExtensions
{
}
