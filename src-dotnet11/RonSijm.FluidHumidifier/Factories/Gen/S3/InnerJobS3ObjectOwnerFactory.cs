// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerJobS3ObjectOwnerFactory(Action<Humidifier.S3.JobTypes.S3ObjectOwner> factoryAction = null) : SubResourceFactory<Humidifier.S3.JobTypes.S3ObjectOwner>
{

    protected override Humidifier.S3.JobTypes.S3ObjectOwner Create()
    {
        var s3ObjectOwnerResult = CreateS3ObjectOwner();
        factoryAction?.Invoke(s3ObjectOwnerResult);

        return s3ObjectOwnerResult;
    }

    private Humidifier.S3.JobTypes.S3ObjectOwner CreateS3ObjectOwner()
    {
        var s3ObjectOwnerResult = new Humidifier.S3.JobTypes.S3ObjectOwner();

        return s3ObjectOwnerResult;
    }

} // End Of Class

public static class InnerJobS3ObjectOwnerFactoryExtensions
{
}
