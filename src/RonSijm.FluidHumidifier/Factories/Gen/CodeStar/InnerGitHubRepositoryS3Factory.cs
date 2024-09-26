// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeStar;

public class InnerGitHubRepositoryS3Factory(Action<Humidifier.CodeStar.GitHubRepositoryTypes.S3> factoryAction = null) : SubResourceFactory<Humidifier.CodeStar.GitHubRepositoryTypes.S3>
{

    protected override Humidifier.CodeStar.GitHubRepositoryTypes.S3 Create()
    {
        var s3Result = CreateS3();
        factoryAction?.Invoke(s3Result);

        return s3Result;
    }

    private Humidifier.CodeStar.GitHubRepositoryTypes.S3 CreateS3()
    {
        var s3Result = new Humidifier.CodeStar.GitHubRepositoryTypes.S3();

        return s3Result;
    }

} // End Of Class

public static class InnerGitHubRepositoryS3FactoryExtensions
{
}
