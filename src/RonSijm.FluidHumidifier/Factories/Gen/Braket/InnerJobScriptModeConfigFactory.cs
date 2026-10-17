// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Braket;

public class InnerJobScriptModeConfigFactory(Action<Humidifier.Braket.JobTypes.ScriptModeConfig> factoryAction = null) : SubResourceFactory<Humidifier.Braket.JobTypes.ScriptModeConfig>
{

    protected override Humidifier.Braket.JobTypes.ScriptModeConfig Create()
    {
        var scriptModeConfigResult = CreateScriptModeConfig();
        factoryAction?.Invoke(scriptModeConfigResult);

        return scriptModeConfigResult;
    }

    private Humidifier.Braket.JobTypes.ScriptModeConfig CreateScriptModeConfig()
    {
        var scriptModeConfigResult = new Humidifier.Braket.JobTypes.ScriptModeConfig();

        return scriptModeConfigResult;
    }

} // End Of Class

public static class InnerJobScriptModeConfigFactoryExtensions
{
}
