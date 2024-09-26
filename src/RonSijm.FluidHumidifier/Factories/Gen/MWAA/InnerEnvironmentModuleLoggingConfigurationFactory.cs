// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MWAA;

public class InnerEnvironmentModuleLoggingConfigurationFactory(Action<Humidifier.MWAA.EnvironmentTypes.ModuleLoggingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MWAA.EnvironmentTypes.ModuleLoggingConfiguration>
{

    protected override Humidifier.MWAA.EnvironmentTypes.ModuleLoggingConfiguration Create()
    {
        var moduleLoggingConfigurationResult = CreateModuleLoggingConfiguration();
        factoryAction?.Invoke(moduleLoggingConfigurationResult);

        return moduleLoggingConfigurationResult;
    }

    private Humidifier.MWAA.EnvironmentTypes.ModuleLoggingConfiguration CreateModuleLoggingConfiguration()
    {
        var moduleLoggingConfigurationResult = new Humidifier.MWAA.EnvironmentTypes.ModuleLoggingConfiguration();

        return moduleLoggingConfigurationResult;
    }

} // End Of Class

public static class InnerEnvironmentModuleLoggingConfigurationFactoryExtensions
{
}
