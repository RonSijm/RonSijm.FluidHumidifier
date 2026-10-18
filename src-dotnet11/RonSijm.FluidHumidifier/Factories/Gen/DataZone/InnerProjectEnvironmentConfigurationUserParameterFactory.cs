// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataZone;

public class InnerProjectEnvironmentConfigurationUserParameterFactory(Action<Humidifier.DataZone.ProjectTypes.EnvironmentConfigurationUserParameter> factoryAction = null) : SubResourceFactory<Humidifier.DataZone.ProjectTypes.EnvironmentConfigurationUserParameter>
{

    protected override Humidifier.DataZone.ProjectTypes.EnvironmentConfigurationUserParameter Create()
    {
        var environmentConfigurationUserParameterResult = CreateEnvironmentConfigurationUserParameter();
        factoryAction?.Invoke(environmentConfigurationUserParameterResult);

        return environmentConfigurationUserParameterResult;
    }

    private Humidifier.DataZone.ProjectTypes.EnvironmentConfigurationUserParameter CreateEnvironmentConfigurationUserParameter()
    {
        var environmentConfigurationUserParameterResult = new Humidifier.DataZone.ProjectTypes.EnvironmentConfigurationUserParameter();

        return environmentConfigurationUserParameterResult;
    }

} // End Of Class

public static class InnerProjectEnvironmentConfigurationUserParameterFactoryExtensions
{
}
