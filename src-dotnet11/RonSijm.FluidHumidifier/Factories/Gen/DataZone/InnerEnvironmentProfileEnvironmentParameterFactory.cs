// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerEnvironmentProfileEnvironmentParameterFactory(Action<Humidifier.DataZone.EnvironmentProfileTypes.EnvironmentParameter> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.EnvironmentProfileTypes.EnvironmentParameter>
{

    protected override Humidifier.DataZone.EnvironmentProfileTypes.EnvironmentParameter Create()
    {
        var environmentParameterResult = CreateEnvironmentParameter();
        factoryAction?.Invoke(environmentParameterResult);

        return environmentParameterResult;
    }

    private Humidifier.DataZone.EnvironmentProfileTypes.EnvironmentParameter CreateEnvironmentParameter()
    {
        var environmentParameterResult = new Humidifier.DataZone.EnvironmentProfileTypes.EnvironmentParameter();

        return environmentParameterResult;
    }

} // End Of Class

public static class InnerEnvironmentProfileEnvironmentParameterFactoryExtensions
{
}
