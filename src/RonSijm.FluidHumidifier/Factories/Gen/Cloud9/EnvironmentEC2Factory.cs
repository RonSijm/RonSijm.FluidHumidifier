// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cloud9;

public class EnvironmentEC2Factory(string resourceName = null, Action<Humidifier.Cloud9.EnvironmentEC2> factoryAction = null) : ResourceFactory<Humidifier.Cloud9.EnvironmentEC2>(resourceName)
{

    internal List<InnerEnvironmentEC2RepositoryFactory> RepositoriesFactories { get; set; } = [];

    protected override Humidifier.Cloud9.EnvironmentEC2 Create()
    {
        var environmentEC2Result = CreateEnvironmentEC2();
        factoryAction?.Invoke(environmentEC2Result);

        return environmentEC2Result;
    }

    private Humidifier.Cloud9.EnvironmentEC2 CreateEnvironmentEC2()
    {
        var environmentEC2Result = new Humidifier.Cloud9.EnvironmentEC2
        {
            GivenName = InputResourceName,
        };

        return environmentEC2Result;
    }
    public override void CreateChildren(Humidifier.Cloud9.EnvironmentEC2 result)
    {
        base.CreateChildren(result);

        result.Repositories = RepositoriesFactories.Any() ? RepositoriesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class EnvironmentEC2FactoryExtensions
{
    public static CombinedResult<EnvironmentEC2Factory, InnerEnvironmentEC2RepositoryFactory> WithRepositories(this EnvironmentEC2Factory parentFactory, Action<Humidifier.Cloud9.EnvironmentEC2Types.Repository> subFactoryAction = null)
    {
        var factory = new InnerEnvironmentEC2RepositoryFactory(subFactoryAction);
        parentFactory.RepositoriesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<EnvironmentEC2Factory, T1, InnerEnvironmentEC2RepositoryFactory> WithRepositories<T1>(this CombinedResult<EnvironmentEC2Factory, T1> combinedResult, Action<Humidifier.Cloud9.EnvironmentEC2Types.Repository> subFactoryAction = null) => new (combinedResult, combinedResult, WithRepositories(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentEC2Factory, InnerEnvironmentEC2RepositoryFactory> WithRepositories<T1>(this CombinedResult<T1, EnvironmentEC2Factory> combinedResult, Action<Humidifier.Cloud9.EnvironmentEC2Types.Repository> subFactoryAction = null) => new (combinedResult, combinedResult, WithRepositories(combinedResult.T2, subFactoryAction));
    public static CombinedResult<EnvironmentEC2Factory, T1, T2, InnerEnvironmentEC2RepositoryFactory> WithRepositories<T1, T2>(this CombinedResult<EnvironmentEC2Factory, T1, T2> combinedResult, Action<Humidifier.Cloud9.EnvironmentEC2Types.Repository> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRepositories(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentEC2Factory, T2, InnerEnvironmentEC2RepositoryFactory> WithRepositories<T1, T2>(this CombinedResult<T1, EnvironmentEC2Factory, T2> combinedResult, Action<Humidifier.Cloud9.EnvironmentEC2Types.Repository> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRepositories(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnvironmentEC2Factory, InnerEnvironmentEC2RepositoryFactory> WithRepositories<T1, T2>(this CombinedResult<T1, T2, EnvironmentEC2Factory> combinedResult, Action<Humidifier.Cloud9.EnvironmentEC2Types.Repository> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRepositories(combinedResult.T3, subFactoryAction));
    public static CombinedResult<EnvironmentEC2Factory, T1, T2, T3, InnerEnvironmentEC2RepositoryFactory> WithRepositories<T1, T2, T3>(this CombinedResult<EnvironmentEC2Factory, T1, T2, T3> combinedResult, Action<Humidifier.Cloud9.EnvironmentEC2Types.Repository> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRepositories(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentEC2Factory, T2, T3, InnerEnvironmentEC2RepositoryFactory> WithRepositories<T1, T2, T3>(this CombinedResult<T1, EnvironmentEC2Factory, T2, T3> combinedResult, Action<Humidifier.Cloud9.EnvironmentEC2Types.Repository> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRepositories(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnvironmentEC2Factory, T3, InnerEnvironmentEC2RepositoryFactory> WithRepositories<T1, T2, T3>(this CombinedResult<T1, T2, EnvironmentEC2Factory, T3> combinedResult, Action<Humidifier.Cloud9.EnvironmentEC2Types.Repository> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRepositories(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EnvironmentEC2Factory, InnerEnvironmentEC2RepositoryFactory> WithRepositories<T1, T2, T3>(this CombinedResult<T1, T2, T3, EnvironmentEC2Factory> combinedResult, Action<Humidifier.Cloud9.EnvironmentEC2Types.Repository> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRepositories(combinedResult.T4, subFactoryAction));
    public static CombinedResult<EnvironmentEC2Factory, T1, T2, T3, T4, InnerEnvironmentEC2RepositoryFactory> WithRepositories<T1, T2, T3, T4>(this CombinedResult<EnvironmentEC2Factory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Cloud9.EnvironmentEC2Types.Repository> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRepositories(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EnvironmentEC2Factory, T2, T3, T4, InnerEnvironmentEC2RepositoryFactory> WithRepositories<T1, T2, T3, T4>(this CombinedResult<T1, EnvironmentEC2Factory, T2, T3, T4> combinedResult, Action<Humidifier.Cloud9.EnvironmentEC2Types.Repository> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRepositories(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EnvironmentEC2Factory, T3, T4, InnerEnvironmentEC2RepositoryFactory> WithRepositories<T1, T2, T3, T4>(this CombinedResult<T1, T2, EnvironmentEC2Factory, T3, T4> combinedResult, Action<Humidifier.Cloud9.EnvironmentEC2Types.Repository> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRepositories(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EnvironmentEC2Factory, T4, InnerEnvironmentEC2RepositoryFactory> WithRepositories<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EnvironmentEC2Factory, T4> combinedResult, Action<Humidifier.Cloud9.EnvironmentEC2Types.Repository> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRepositories(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, EnvironmentEC2Factory, InnerEnvironmentEC2RepositoryFactory> WithRepositories<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EnvironmentEC2Factory> combinedResult, Action<Humidifier.Cloud9.EnvironmentEC2Types.Repository> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRepositories(combinedResult.T5, subFactoryAction));
}
