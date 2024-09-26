// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeDeploy;

public class InnerDeploymentGroupAlarmConfigurationFactory(Action<Humidifier.CodeDeploy.DeploymentGroupTypes.AlarmConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.CodeDeploy.DeploymentGroupTypes.AlarmConfiguration>
{

    protected override Humidifier.CodeDeploy.DeploymentGroupTypes.AlarmConfiguration Create()
    {
        var alarmConfigurationResult = CreateAlarmConfiguration();
        factoryAction?.Invoke(alarmConfigurationResult);

        return alarmConfigurationResult;
    }

    private Humidifier.CodeDeploy.DeploymentGroupTypes.AlarmConfiguration CreateAlarmConfiguration()
    {
        var alarmConfigurationResult = new Humidifier.CodeDeploy.DeploymentGroupTypes.AlarmConfiguration();

        return alarmConfigurationResult;
    }

} // End Of Class

public static class InnerDeploymentGroupAlarmConfigurationFactoryExtensions
{
}
