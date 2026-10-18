// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerClusterS3Factory(Action<Humidifier.MSK.ClusterTypes.S3> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ClusterTypes.S3>
{

    protected override Humidifier.MSK.ClusterTypes.S3 Create()
    {
        var s3Result = CreateS3();
        factoryAction?.Invoke(s3Result);

        return s3Result;
    }

    private Humidifier.MSK.ClusterTypes.S3 CreateS3()
    {
        var s3Result = new Humidifier.MSK.ClusterTypes.S3();

        return s3Result;
    }

} // End Of Class

public static class InnerClusterS3FactoryExtensions
{
}
