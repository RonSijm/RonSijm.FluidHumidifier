// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelRepositoryAuthConfigFactory(Action<Humidifier.SageMaker.ModelTypes.RepositoryAuthConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelTypes.RepositoryAuthConfig>
{

    protected override Humidifier.SageMaker.ModelTypes.RepositoryAuthConfig Create()
    {
        var repositoryAuthConfigResult = CreateRepositoryAuthConfig();
        factoryAction?.Invoke(repositoryAuthConfigResult);

        return repositoryAuthConfigResult;
    }

    private Humidifier.SageMaker.ModelTypes.RepositoryAuthConfig CreateRepositoryAuthConfig()
    {
        var repositoryAuthConfigResult = new Humidifier.SageMaker.ModelTypes.RepositoryAuthConfig();

        return repositoryAuthConfigResult;
    }

} // End Of Class

public static class InnerModelRepositoryAuthConfigFactoryExtensions
{
}
