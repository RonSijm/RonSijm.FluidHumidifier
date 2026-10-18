// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerMicrovmImageEnvironmentVariableFactory(Action<Humidifier.Lambda.MicrovmImageTypes.EnvironmentVariable> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.MicrovmImageTypes.EnvironmentVariable>
{

    protected override Humidifier.Lambda.MicrovmImageTypes.EnvironmentVariable Create()
    {
        var environmentVariableResult = CreateEnvironmentVariable();
        factoryAction?.Invoke(environmentVariableResult);

        return environmentVariableResult;
    }

    private Humidifier.Lambda.MicrovmImageTypes.EnvironmentVariable CreateEnvironmentVariable()
    {
        var environmentVariableResult = new Humidifier.Lambda.MicrovmImageTypes.EnvironmentVariable();

        return environmentVariableResult;
    }

} // End Of Class

public static class InnerMicrovmImageEnvironmentVariableFactoryExtensions
{
}
