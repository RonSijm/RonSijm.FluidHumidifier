// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerServiceAdvancedConfigurationFactory(Action<Humidifier.ECS.ServiceTypes.AdvancedConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ECS.ServiceTypes.AdvancedConfiguration>
{

    protected override Humidifier.ECS.ServiceTypes.AdvancedConfiguration Create()
    {
        var advancedConfigurationResult = CreateAdvancedConfiguration();
        factoryAction?.Invoke(advancedConfigurationResult);

        return advancedConfigurationResult;
    }

    private Humidifier.ECS.ServiceTypes.AdvancedConfiguration CreateAdvancedConfiguration()
    {
        var advancedConfigurationResult = new Humidifier.ECS.ServiceTypes.AdvancedConfiguration();

        return advancedConfigurationResult;
    }

} // End Of Class

public static class InnerServiceAdvancedConfigurationFactoryExtensions
{
}
