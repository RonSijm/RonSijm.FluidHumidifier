// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerCapacityProviderAutoRepairConfigurationFactory(Action<Humidifier.ECS.CapacityProviderTypes.AutoRepairConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ECS.CapacityProviderTypes.AutoRepairConfiguration>
{

    protected override Humidifier.ECS.CapacityProviderTypes.AutoRepairConfiguration Create()
    {
        var autoRepairConfigurationResult = CreateAutoRepairConfiguration();
        factoryAction?.Invoke(autoRepairConfigurationResult);

        return autoRepairConfigurationResult;
    }

    private Humidifier.ECS.CapacityProviderTypes.AutoRepairConfiguration CreateAutoRepairConfiguration()
    {
        var autoRepairConfigurationResult = new Humidifier.ECS.CapacityProviderTypes.AutoRepairConfiguration();

        return autoRepairConfigurationResult;
    }

} // End Of Class

public static class InnerCapacityProviderAutoRepairConfigurationFactoryExtensions
{
}
