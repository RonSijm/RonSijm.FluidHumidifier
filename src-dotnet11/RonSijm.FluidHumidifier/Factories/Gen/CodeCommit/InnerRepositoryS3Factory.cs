// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeCommit;

public class InnerRepositoryS3Factory(Action<Humidifier.CodeCommit.RepositoryTypes.S3> factoryAction = null) : SubResourceFactory<Humidifier.CodeCommit.RepositoryTypes.S3>
{

    protected override Humidifier.CodeCommit.RepositoryTypes.S3 Create()
    {
        var s3Result = CreateS3();
        factoryAction?.Invoke(s3Result);

        return s3Result;
    }

    private Humidifier.CodeCommit.RepositoryTypes.S3 CreateS3()
    {
        var s3Result = new Humidifier.CodeCommit.RepositoryTypes.S3();

        return s3Result;
    }

} // End Of Class

public static class InnerRepositoryS3FactoryExtensions
{
}
