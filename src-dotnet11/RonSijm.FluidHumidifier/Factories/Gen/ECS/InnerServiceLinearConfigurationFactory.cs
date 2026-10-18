// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerServiceLinearConfigurationFactory(Action<Humidifier.ECS.ServiceTypes.LinearConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ECS.ServiceTypes.LinearConfiguration>
{

    protected override Humidifier.ECS.ServiceTypes.LinearConfiguration Create()
    {
        var linearConfigurationResult = CreateLinearConfiguration();
        factoryAction?.Invoke(linearConfigurationResult);

        return linearConfigurationResult;
    }

    private Humidifier.ECS.ServiceTypes.LinearConfiguration CreateLinearConfiguration()
    {
        var linearConfigurationResult = new Humidifier.ECS.ServiceTypes.LinearConfiguration();

        return linearConfigurationResult;
    }

} // End Of Class

public static class InnerServiceLinearConfigurationFactoryExtensions
{
}
