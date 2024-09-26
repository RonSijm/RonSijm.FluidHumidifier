// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeDeploy;

public class InnerDeploymentGroupS3LocationFactory(Action<Humidifier.CodeDeploy.DeploymentGroupTypes.S3Location> factoryAction = null) : SubResourceFactory<Humidifier.CodeDeploy.DeploymentGroupTypes.S3Location>
{

    protected override Humidifier.CodeDeploy.DeploymentGroupTypes.S3Location Create()
    {
        var s3LocationResult = CreateS3Location();
        factoryAction?.Invoke(s3LocationResult);

        return s3LocationResult;
    }

    private Humidifier.CodeDeploy.DeploymentGroupTypes.S3Location CreateS3Location()
    {
        var s3LocationResult = new Humidifier.CodeDeploy.DeploymentGroupTypes.S3Location();

        return s3LocationResult;
    }

} // End Of Class

public static class InnerDeploymentGroupS3LocationFactoryExtensions
{
}
