// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeDeploy;

public class InnerDeploymentGroupEC2TagSetFactory(Action<Humidifier.CodeDeploy.DeploymentGroupTypes.EC2TagSet> factoryAction = null) : SubResourceFactory<Humidifier.CodeDeploy.DeploymentGroupTypes.EC2TagSet>
{

    protected override Humidifier.CodeDeploy.DeploymentGroupTypes.EC2TagSet Create()
    {
        var eC2TagSetResult = CreateEC2TagSet();
        factoryAction?.Invoke(eC2TagSetResult);

        return eC2TagSetResult;
    }

    private Humidifier.CodeDeploy.DeploymentGroupTypes.EC2TagSet CreateEC2TagSet()
    {
        var eC2TagSetResult = new Humidifier.CodeDeploy.DeploymentGroupTypes.EC2TagSet();

        return eC2TagSetResult;
    }

} // End Of Class

public static class InnerDeploymentGroupEC2TagSetFactoryExtensions
{
}
