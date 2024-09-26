// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFormation;

public class HookTypeConfigFactory(string resourceName = null, Action<Humidifier.CloudFormation.HookTypeConfig> factoryAction = null) : ResourceFactory<Humidifier.CloudFormation.HookTypeConfig>(resourceName)
{

    protected override Humidifier.CloudFormation.HookTypeConfig Create()
    {
        var hookTypeConfigResult = CreateHookTypeConfig();
        factoryAction?.Invoke(hookTypeConfigResult);

        return hookTypeConfigResult;
    }

    private Humidifier.CloudFormation.HookTypeConfig CreateHookTypeConfig()
    {
        var hookTypeConfigResult = new Humidifier.CloudFormation.HookTypeConfig
        {
            GivenName = InputResourceName,
        };

        return hookTypeConfigResult;
    }

} // End Of Class

public static class HookTypeConfigFactoryExtensions
{
}
