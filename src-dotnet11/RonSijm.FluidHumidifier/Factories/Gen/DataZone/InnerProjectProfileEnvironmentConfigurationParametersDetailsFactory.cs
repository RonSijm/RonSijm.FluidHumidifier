// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerProjectProfileEnvironmentConfigurationParametersDetailsFactory(Action<Humidifier.DataZone.ProjectProfileTypes.EnvironmentConfigurationParametersDetails> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.ProjectProfileTypes.EnvironmentConfigurationParametersDetails>
{

    protected override Humidifier.DataZone.ProjectProfileTypes.EnvironmentConfigurationParametersDetails Create()
    {
        var environmentConfigurationParametersDetailsResult = CreateEnvironmentConfigurationParametersDetails();
        factoryAction?.Invoke(environmentConfigurationParametersDetailsResult);

        return environmentConfigurationParametersDetailsResult;
    }

    private Humidifier.DataZone.ProjectProfileTypes.EnvironmentConfigurationParametersDetails CreateEnvironmentConfigurationParametersDetails()
    {
        var environmentConfigurationParametersDetailsResult = new Humidifier.DataZone.ProjectProfileTypes.EnvironmentConfigurationParametersDetails();

        return environmentConfigurationParametersDetailsResult;
    }

} // End Of Class

public static class InnerProjectProfileEnvironmentConfigurationParametersDetailsFactoryExtensions
{
}
