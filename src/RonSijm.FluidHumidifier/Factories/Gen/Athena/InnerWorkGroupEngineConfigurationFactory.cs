// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Athena;

public class InnerWorkGroupEngineConfigurationFactory(Action<Humidifier.Athena.WorkGroupTypes.EngineConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Athena.WorkGroupTypes.EngineConfiguration>
{

    protected override Humidifier.Athena.WorkGroupTypes.EngineConfiguration Create()
    {
        var engineConfigurationResult = CreateEngineConfiguration();
        factoryAction?.Invoke(engineConfigurationResult);

        return engineConfigurationResult;
    }

    private Humidifier.Athena.WorkGroupTypes.EngineConfiguration CreateEngineConfiguration()
    {
        var engineConfigurationResult = new Humidifier.Athena.WorkGroupTypes.EngineConfiguration();

        return engineConfigurationResult;
    }

} // End Of Class

public static class InnerWorkGroupEngineConfigurationFactoryExtensions
{
}
