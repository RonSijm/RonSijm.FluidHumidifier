// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerCodeRepositoryGitConfigFactory(Action<Humidifier.SageMaker.CodeRepositoryTypes.GitConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.CodeRepositoryTypes.GitConfig>
{

    protected override Humidifier.SageMaker.CodeRepositoryTypes.GitConfig Create()
    {
        var gitConfigResult = CreateGitConfig();
        factoryAction?.Invoke(gitConfigResult);

        return gitConfigResult;
    }

    private Humidifier.SageMaker.CodeRepositoryTypes.GitConfig CreateGitConfig()
    {
        var gitConfigResult = new Humidifier.SageMaker.CodeRepositoryTypes.GitConfig();

        return gitConfigResult;
    }

} // End Of Class

public static class InnerCodeRepositoryGitConfigFactoryExtensions
{
}
