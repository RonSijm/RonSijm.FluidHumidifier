// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.B2BI;

public class InnerCapabilityS3LocationFactory(Action<Humidifier.B2BI.CapabilityTypes.S3Location> factoryAction = null) : SubResourceFactory<Humidifier.B2BI.CapabilityTypes.S3Location>
{

    protected override Humidifier.B2BI.CapabilityTypes.S3Location Create()
    {
        var s3LocationResult = CreateS3Location();
        factoryAction?.Invoke(s3LocationResult);

        return s3LocationResult;
    }

    private Humidifier.B2BI.CapabilityTypes.S3Location CreateS3Location()
    {
        var s3LocationResult = new Humidifier.B2BI.CapabilityTypes.S3Location();

        return s3LocationResult;
    }

} // End Of Class

public static class InnerCapabilityS3LocationFactoryExtensions
{
}
