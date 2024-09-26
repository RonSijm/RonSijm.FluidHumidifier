// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppRunner;

public class InnerServiceEgressConfigurationFactory(Action<Humidifier.AppRunner.ServiceTypes.EgressConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.AppRunner.ServiceTypes.EgressConfiguration>
{

    protected override Humidifier.AppRunner.ServiceTypes.EgressConfiguration Create()
    {
        var egressConfigurationResult = CreateEgressConfiguration();
        factoryAction?.Invoke(egressConfigurationResult);

        return egressConfigurationResult;
    }

    private Humidifier.AppRunner.ServiceTypes.EgressConfiguration CreateEgressConfiguration()
    {
        var egressConfigurationResult = new Humidifier.AppRunner.ServiceTypes.EgressConfiguration();

        return egressConfigurationResult;
    }

} // End Of Class

public static class InnerServiceEgressConfigurationFactoryExtensions
{
}
