// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerReplicatorS3Factory(Action<Humidifier.MSK.ReplicatorTypes.S3> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ReplicatorTypes.S3>
{

    protected override Humidifier.MSK.ReplicatorTypes.S3 Create()
    {
        var s3Result = CreateS3();
        factoryAction?.Invoke(s3Result);

        return s3Result;
    }

    private Humidifier.MSK.ReplicatorTypes.S3 CreateS3()
    {
        var s3Result = new Humidifier.MSK.ReplicatorTypes.S3();

        return s3Result;
    }

} // End Of Class

public static class InnerReplicatorS3FactoryExtensions
{
}
