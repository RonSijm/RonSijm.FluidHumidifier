// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFormation;

public class InnerStackSetAutoDeploymentFactory(Action<Humidifier.CloudFormation.StackSetTypes.AutoDeployment> factoryAction = null) : SubResourceFactory<Humidifier.CloudFormation.StackSetTypes.AutoDeployment>
{

    protected override Humidifier.CloudFormation.StackSetTypes.AutoDeployment Create()
    {
        var autoDeploymentResult = CreateAutoDeployment();
        factoryAction?.Invoke(autoDeploymentResult);

        return autoDeploymentResult;
    }

    private Humidifier.CloudFormation.StackSetTypes.AutoDeployment CreateAutoDeployment()
    {
        var autoDeploymentResult = new Humidifier.CloudFormation.StackSetTypes.AutoDeployment();

        return autoDeploymentResult;
    }

} // End Of Class

public static class InnerStackSetAutoDeploymentFactoryExtensions
{
}
