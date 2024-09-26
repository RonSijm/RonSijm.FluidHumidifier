// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cloud9;

public class InnerEnvironmentEC2RepositoryFactory(Action<Humidifier.Cloud9.EnvironmentEC2Types.Repository> factoryAction = null) : SubResourceFactory<Humidifier.Cloud9.EnvironmentEC2Types.Repository>
{

    protected override Humidifier.Cloud9.EnvironmentEC2Types.Repository Create()
    {
        var repositoryResult = CreateRepository();
        factoryAction?.Invoke(repositoryResult);

        return repositoryResult;
    }

    private Humidifier.Cloud9.EnvironmentEC2Types.Repository CreateRepository()
    {
        var repositoryResult = new Humidifier.Cloud9.EnvironmentEC2Types.Repository();

        return repositoryResult;
    }

} // End Of Class

public static class InnerEnvironmentEC2RepositoryFactoryExtensions
{
}
