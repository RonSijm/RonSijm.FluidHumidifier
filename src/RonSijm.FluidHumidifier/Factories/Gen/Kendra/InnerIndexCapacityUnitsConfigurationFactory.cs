// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kendra;

public class InnerIndexCapacityUnitsConfigurationFactory(Action<Humidifier.Kendra.IndexTypes.CapacityUnitsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Kendra.IndexTypes.CapacityUnitsConfiguration>
{

    protected override Humidifier.Kendra.IndexTypes.CapacityUnitsConfiguration Create()
    {
        var capacityUnitsConfigurationResult = CreateCapacityUnitsConfiguration();
        factoryAction?.Invoke(capacityUnitsConfigurationResult);

        return capacityUnitsConfigurationResult;
    }

    private Humidifier.Kendra.IndexTypes.CapacityUnitsConfiguration CreateCapacityUnitsConfiguration()
    {
        var capacityUnitsConfigurationResult = new Humidifier.Kendra.IndexTypes.CapacityUnitsConfiguration();

        return capacityUnitsConfigurationResult;
    }

} // End Of Class

public static class InnerIndexCapacityUnitsConfigurationFactoryExtensions
{
}
