// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeCommit;

public class InnerRepositoryRepositoryTriggerFactory(Action<Humidifier.CodeCommit.RepositoryTypes.RepositoryTrigger> factoryAction = null) : SubResourceFactory<Humidifier.CodeCommit.RepositoryTypes.RepositoryTrigger>
{

    protected override Humidifier.CodeCommit.RepositoryTypes.RepositoryTrigger Create()
    {
        var repositoryTriggerResult = CreateRepositoryTrigger();
        factoryAction?.Invoke(repositoryTriggerResult);

        return repositoryTriggerResult;
    }

    private Humidifier.CodeCommit.RepositoryTypes.RepositoryTrigger CreateRepositoryTrigger()
    {
        var repositoryTriggerResult = new Humidifier.CodeCommit.RepositoryTypes.RepositoryTrigger();

        return repositoryTriggerResult;
    }

} // End Of Class

public static class InnerRepositoryRepositoryTriggerFactoryExtensions
{
}
