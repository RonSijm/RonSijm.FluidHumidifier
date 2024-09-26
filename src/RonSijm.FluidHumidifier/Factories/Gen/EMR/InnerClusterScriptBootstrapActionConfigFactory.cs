// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class InnerClusterScriptBootstrapActionConfigFactory(Action<Humidifier.EMR.ClusterTypes.ScriptBootstrapActionConfig> factoryAction = null) : SubResourceFactory<Humidifier.EMR.ClusterTypes.ScriptBootstrapActionConfig>
{

    protected override Humidifier.EMR.ClusterTypes.ScriptBootstrapActionConfig Create()
    {
        var scriptBootstrapActionConfigResult = CreateScriptBootstrapActionConfig();
        factoryAction?.Invoke(scriptBootstrapActionConfigResult);

        return scriptBootstrapActionConfigResult;
    }

    private Humidifier.EMR.ClusterTypes.ScriptBootstrapActionConfig CreateScriptBootstrapActionConfig()
    {
        var scriptBootstrapActionConfigResult = new Humidifier.EMR.ClusterTypes.ScriptBootstrapActionConfig();

        return scriptBootstrapActionConfigResult;
    }

} // End Of Class

public static class InnerClusterScriptBootstrapActionConfigFactoryExtensions
{
}
