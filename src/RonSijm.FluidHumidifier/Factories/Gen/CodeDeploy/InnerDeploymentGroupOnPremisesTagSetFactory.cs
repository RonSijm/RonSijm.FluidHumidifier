// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeDeploy;

public class InnerDeploymentGroupOnPremisesTagSetFactory(Action<Humidifier.CodeDeploy.DeploymentGroupTypes.OnPremisesTagSet> factoryAction = null) : SubResourceFactory<Humidifier.CodeDeploy.DeploymentGroupTypes.OnPremisesTagSet>
{

    protected override Humidifier.CodeDeploy.DeploymentGroupTypes.OnPremisesTagSet Create()
    {
        var onPremisesTagSetResult = CreateOnPremisesTagSet();
        factoryAction?.Invoke(onPremisesTagSetResult);

        return onPremisesTagSetResult;
    }

    private Humidifier.CodeDeploy.DeploymentGroupTypes.OnPremisesTagSet CreateOnPremisesTagSet()
    {
        var onPremisesTagSetResult = new Humidifier.CodeDeploy.DeploymentGroupTypes.OnPremisesTagSet();

        return onPremisesTagSetResult;
    }

} // End Of Class

public static class InnerDeploymentGroupOnPremisesTagSetFactoryExtensions
{
}
