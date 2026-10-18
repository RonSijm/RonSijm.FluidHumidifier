// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerVerifiedAccessInstanceS3Factory(Action<Humidifier.EC2.VerifiedAccessInstanceTypes.S3> factoryAction = null) : SubResourceFactory<Humidifier.EC2.VerifiedAccessInstanceTypes.S3>
{

    protected override Humidifier.EC2.VerifiedAccessInstanceTypes.S3 Create()
    {
        var s3Result = CreateS3();
        factoryAction?.Invoke(s3Result);

        return s3Result;
    }

    private Humidifier.EC2.VerifiedAccessInstanceTypes.S3 CreateS3()
    {
        var s3Result = new Humidifier.EC2.VerifiedAccessInstanceTypes.S3();

        return s3Result;
    }

} // End Of Class

public static class InnerVerifiedAccessInstanceS3FactoryExtensions
{
}
