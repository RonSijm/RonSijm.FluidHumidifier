// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Athena;

public class InnerSessionEngineConfigurationFactory(Action<Humidifier.Athena.SessionTypes.EngineConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Athena.SessionTypes.EngineConfiguration>
{

    protected override Humidifier.Athena.SessionTypes.EngineConfiguration Create()
    {
        var engineConfigurationResult = CreateEngineConfiguration();
        factoryAction?.Invoke(engineConfigurationResult);

        return engineConfigurationResult;
    }

    private Humidifier.Athena.SessionTypes.EngineConfiguration CreateEngineConfiguration()
    {
        var engineConfigurationResult = new Humidifier.Athena.SessionTypes.EngineConfiguration();

        return engineConfigurationResult;
    }

} // End Of Class

public static class InnerSessionEngineConfigurationFactoryExtensions
{
}
