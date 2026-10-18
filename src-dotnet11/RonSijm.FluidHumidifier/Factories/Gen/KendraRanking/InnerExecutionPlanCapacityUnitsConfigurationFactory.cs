// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KendraRanking;

public class InnerExecutionPlanCapacityUnitsConfigurationFactory(Action<Humidifier.KendraRanking.ExecutionPlanTypes.CapacityUnitsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.KendraRanking.ExecutionPlanTypes.CapacityUnitsConfiguration>
{

    protected override Humidifier.KendraRanking.ExecutionPlanTypes.CapacityUnitsConfiguration Create()
    {
        var capacityUnitsConfigurationResult = CreateCapacityUnitsConfiguration();
        factoryAction?.Invoke(capacityUnitsConfigurationResult);

        return capacityUnitsConfigurationResult;
    }

    private Humidifier.KendraRanking.ExecutionPlanTypes.CapacityUnitsConfiguration CreateCapacityUnitsConfiguration()
    {
        var capacityUnitsConfigurationResult = new Humidifier.KendraRanking.ExecutionPlanTypes.CapacityUnitsConfiguration();

        return capacityUnitsConfigurationResult;
    }

} // End Of Class

public static class InnerExecutionPlanCapacityUnitsConfigurationFactoryExtensions
{
}
