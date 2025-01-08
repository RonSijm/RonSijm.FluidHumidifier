// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeBuild;

public class InnerFleetComputeConfigurationFactory(Action<Humidifier.CodeBuild.FleetTypes.ComputeConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.CodeBuild.FleetTypes.ComputeConfiguration>
{

    protected override Humidifier.CodeBuild.FleetTypes.ComputeConfiguration Create()
    {
        var computeConfigurationResult = CreateComputeConfiguration();
        factoryAction?.Invoke(computeConfigurationResult);

        return computeConfigurationResult;
    }

    private Humidifier.CodeBuild.FleetTypes.ComputeConfiguration CreateComputeConfiguration()
    {
        var computeConfigurationResult = new Humidifier.CodeBuild.FleetTypes.ComputeConfiguration();

        return computeConfigurationResult;
    }

} // End Of Class

public static class InnerFleetComputeConfigurationFactoryExtensions
{
}
