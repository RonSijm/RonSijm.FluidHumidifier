// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFormation;

public class HookDefaultVersionFactory(string resourceName = null, Action<Humidifier.CloudFormation.HookDefaultVersion> factoryAction = null) : ResourceFactory<Humidifier.CloudFormation.HookDefaultVersion>(resourceName)
{

    protected override Humidifier.CloudFormation.HookDefaultVersion Create()
    {
        var hookDefaultVersionResult = CreateHookDefaultVersion();
        factoryAction?.Invoke(hookDefaultVersionResult);

        return hookDefaultVersionResult;
    }

    private Humidifier.CloudFormation.HookDefaultVersion CreateHookDefaultVersion()
    {
        var hookDefaultVersionResult = new Humidifier.CloudFormation.HookDefaultVersion
        {
            GivenName = InputResourceName,
        };

        return hookDefaultVersionResult;
    }

} // End Of Class

public static class HookDefaultVersionFactoryExtensions
{
}
