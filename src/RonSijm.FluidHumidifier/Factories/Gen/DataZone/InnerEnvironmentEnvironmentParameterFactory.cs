// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerEnvironmentEnvironmentParameterFactory(Action<Humidifier.DataZone.EnvironmentTypes.EnvironmentParameter> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.EnvironmentTypes.EnvironmentParameter>
{

    protected override Humidifier.DataZone.EnvironmentTypes.EnvironmentParameter Create()
    {
        var environmentParameterResult = CreateEnvironmentParameter();
        factoryAction?.Invoke(environmentParameterResult);

        return environmentParameterResult;
    }

    private Humidifier.DataZone.EnvironmentTypes.EnvironmentParameter CreateEnvironmentParameter()
    {
        var environmentParameterResult = new Humidifier.DataZone.EnvironmentTypes.EnvironmentParameter();

        return environmentParameterResult;
    }

} // End Of Class

public static class InnerEnvironmentEnvironmentParameterFactoryExtensions
{
}
