// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpsWorks;

public class InnerAppEnvironmentVariableFactory(Action<Humidifier.OpsWorks.AppTypes.EnvironmentVariable> factoryAction = null) : SubResourceFactory<Humidifier.OpsWorks.AppTypes.EnvironmentVariable>
{

    protected override Humidifier.OpsWorks.AppTypes.EnvironmentVariable Create()
    {
        var environmentVariableResult = CreateEnvironmentVariable();
        factoryAction?.Invoke(environmentVariableResult);

        return environmentVariableResult;
    }

    private Humidifier.OpsWorks.AppTypes.EnvironmentVariable CreateEnvironmentVariable()
    {
        var environmentVariableResult = new Humidifier.OpsWorks.AppTypes.EnvironmentVariable();

        return environmentVariableResult;
    }

} // End Of Class

public static class InnerAppEnvironmentVariableFactoryExtensions
{
}
