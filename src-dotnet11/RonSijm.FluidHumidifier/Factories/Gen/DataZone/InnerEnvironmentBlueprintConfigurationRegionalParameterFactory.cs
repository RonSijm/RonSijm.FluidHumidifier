// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerEnvironmentBlueprintConfigurationRegionalParameterFactory(Action<Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.RegionalParameter> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.RegionalParameter>
{

    protected override Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.RegionalParameter Create()
    {
        var regionalParameterResult = CreateRegionalParameter();
        factoryAction?.Invoke(regionalParameterResult);

        return regionalParameterResult;
    }

    private Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.RegionalParameter CreateRegionalParameter()
    {
        var regionalParameterResult = new Humidifier.DataZone.EnvironmentBlueprintConfigurationTypes.RegionalParameter();

        return regionalParameterResult;
    }

} // End Of Class

public static class InnerEnvironmentBlueprintConfigurationRegionalParameterFactoryExtensions
{
}
