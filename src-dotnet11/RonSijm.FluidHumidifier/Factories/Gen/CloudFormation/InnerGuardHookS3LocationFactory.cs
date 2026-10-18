// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFormation;

public class InnerGuardHookS3LocationFactory(Action<Humidifier.CloudFormation.GuardHookTypes.S3Location> factoryAction = null) : SubResourceFactory<Humidifier.CloudFormation.GuardHookTypes.S3Location>
{

    protected override Humidifier.CloudFormation.GuardHookTypes.S3Location Create()
    {
        var s3LocationResult = CreateS3Location();
        factoryAction?.Invoke(s3LocationResult);

        return s3LocationResult;
    }

    private Humidifier.CloudFormation.GuardHookTypes.S3Location CreateS3Location()
    {
        var s3LocationResult = new Humidifier.CloudFormation.GuardHookTypes.S3Location();

        return s3LocationResult;
    }

} // End Of Class

public static class InnerGuardHookS3LocationFactoryExtensions
{
}
