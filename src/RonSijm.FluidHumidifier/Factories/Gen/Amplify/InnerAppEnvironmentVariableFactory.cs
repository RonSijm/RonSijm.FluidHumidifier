// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Amplify;

public class InnerAppEnvironmentVariableFactory(Action<Humidifier.Amplify.AppTypes.EnvironmentVariable> factoryAction = null) : SubResourceFactory<Humidifier.Amplify.AppTypes.EnvironmentVariable>
{

    protected override Humidifier.Amplify.AppTypes.EnvironmentVariable Create()
    {
        var environmentVariableResult = CreateEnvironmentVariable();
        factoryAction?.Invoke(environmentVariableResult);

        return environmentVariableResult;
    }

    private Humidifier.Amplify.AppTypes.EnvironmentVariable CreateEnvironmentVariable()
    {
        var environmentVariableResult = new Humidifier.Amplify.AppTypes.EnvironmentVariable();

        return environmentVariableResult;
    }

} // End Of Class

public static class InnerAppEnvironmentVariableFactoryExtensions
{
}
