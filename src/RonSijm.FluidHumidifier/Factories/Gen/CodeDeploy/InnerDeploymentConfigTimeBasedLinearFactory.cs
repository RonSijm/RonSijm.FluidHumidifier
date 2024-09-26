// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeDeploy;

public class InnerDeploymentConfigTimeBasedLinearFactory(Action<Humidifier.CodeDeploy.DeploymentConfigTypes.TimeBasedLinear> factoryAction = null) : SubResourceFactory<Humidifier.CodeDeploy.DeploymentConfigTypes.TimeBasedLinear>
{

    protected override Humidifier.CodeDeploy.DeploymentConfigTypes.TimeBasedLinear Create()
    {
        var timeBasedLinearResult = CreateTimeBasedLinear();
        factoryAction?.Invoke(timeBasedLinearResult);

        return timeBasedLinearResult;
    }

    private Humidifier.CodeDeploy.DeploymentConfigTypes.TimeBasedLinear CreateTimeBasedLinear()
    {
        var timeBasedLinearResult = new Humidifier.CodeDeploy.DeploymentConfigTypes.TimeBasedLinear();

        return timeBasedLinearResult;
    }

} // End Of Class

public static class InnerDeploymentConfigTimeBasedLinearFactoryExtensions
{
}
