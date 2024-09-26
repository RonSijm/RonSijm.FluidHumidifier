// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Amplify;

public class BranchFactory(string resourceName = null, Action<Humidifier.Amplify.Branch> factoryAction = null) : ResourceFactory<Humidifier.Amplify.Branch>(resourceName)
{

    internal List<InnerBranchEnvironmentVariableFactory> EnvironmentVariablesFactories { get; set; } = [];

    internal InnerBranchBackendFactory BackendFactory { get; set; }

    internal InnerBranchBasicAuthConfigFactory BasicAuthConfigFactory { get; set; }

    protected override Humidifier.Amplify.Branch Create()
    {
        var branchResult = CreateBranch();
        factoryAction?.Invoke(branchResult);

        return branchResult;
    }

    private Humidifier.Amplify.Branch CreateBranch()
    {
        var branchResult = new Humidifier.Amplify.Branch
        {
            GivenName = InputResourceName,
        };

        return branchResult;
    }
    public override void CreateChildren(Humidifier.Amplify.Branch result)
    {
        base.CreateChildren(result);

        result.EnvironmentVariables = EnvironmentVariablesFactories.Any() ? EnvironmentVariablesFactories.Select(x => x.Build()).ToList() : null;
        result.Backend ??= BackendFactory?.Build();
        result.BasicAuthConfig ??= BasicAuthConfigFactory?.Build();
    }

} // End Of Class

public static class BranchFactoryExtensions
{
    public static CombinedResult<BranchFactory, InnerBranchEnvironmentVariableFactory> WithEnvironmentVariables(this BranchFactory parentFactory, Action<Humidifier.Amplify.BranchTypes.EnvironmentVariable> subFactoryAction = null)
    {
        var factory = new InnerBranchEnvironmentVariableFactory(subFactoryAction);
        parentFactory.EnvironmentVariablesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<BranchFactory, InnerBranchBackendFactory> WithBackend(this BranchFactory parentFactory, Action<Humidifier.Amplify.BranchTypes.Backend> subFactoryAction = null)
    {
        parentFactory.BackendFactory = new InnerBranchBackendFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.BackendFactory);
    }

    public static CombinedResult<BranchFactory, InnerBranchBasicAuthConfigFactory> WithBasicAuthConfig(this BranchFactory parentFactory, Action<Humidifier.Amplify.BranchTypes.BasicAuthConfig> subFactoryAction = null)
    {
        parentFactory.BasicAuthConfigFactory = new InnerBranchBasicAuthConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.BasicAuthConfigFactory);
    }

    public static CombinedResult<BranchFactory, T1, InnerBranchEnvironmentVariableFactory> WithEnvironmentVariables<T1>(this CombinedResult<BranchFactory, T1> combinedResult, Action<Humidifier.Amplify.BranchTypes.EnvironmentVariable> subFactoryAction = null) => new (combinedResult, combinedResult, WithEnvironmentVariables(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BranchFactory, InnerBranchEnvironmentVariableFactory> WithEnvironmentVariables<T1>(this CombinedResult<T1, BranchFactory> combinedResult, Action<Humidifier.Amplify.BranchTypes.EnvironmentVariable> subFactoryAction = null) => new (combinedResult, combinedResult, WithEnvironmentVariables(combinedResult.T2, subFactoryAction));
    public static CombinedResult<BranchFactory, T1, T2, InnerBranchEnvironmentVariableFactory> WithEnvironmentVariables<T1, T2>(this CombinedResult<BranchFactory, T1, T2> combinedResult, Action<Humidifier.Amplify.BranchTypes.EnvironmentVariable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEnvironmentVariables(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BranchFactory, T2, InnerBranchEnvironmentVariableFactory> WithEnvironmentVariables<T1, T2>(this CombinedResult<T1, BranchFactory, T2> combinedResult, Action<Humidifier.Amplify.BranchTypes.EnvironmentVariable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEnvironmentVariables(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BranchFactory, InnerBranchEnvironmentVariableFactory> WithEnvironmentVariables<T1, T2>(this CombinedResult<T1, T2, BranchFactory> combinedResult, Action<Humidifier.Amplify.BranchTypes.EnvironmentVariable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEnvironmentVariables(combinedResult.T3, subFactoryAction));
    public static CombinedResult<BranchFactory, T1, T2, T3, InnerBranchEnvironmentVariableFactory> WithEnvironmentVariables<T1, T2, T3>(this CombinedResult<BranchFactory, T1, T2, T3> combinedResult, Action<Humidifier.Amplify.BranchTypes.EnvironmentVariable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironmentVariables(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BranchFactory, T2, T3, InnerBranchEnvironmentVariableFactory> WithEnvironmentVariables<T1, T2, T3>(this CombinedResult<T1, BranchFactory, T2, T3> combinedResult, Action<Humidifier.Amplify.BranchTypes.EnvironmentVariable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironmentVariables(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BranchFactory, T3, InnerBranchEnvironmentVariableFactory> WithEnvironmentVariables<T1, T2, T3>(this CombinedResult<T1, T2, BranchFactory, T3> combinedResult, Action<Humidifier.Amplify.BranchTypes.EnvironmentVariable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironmentVariables(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BranchFactory, InnerBranchEnvironmentVariableFactory> WithEnvironmentVariables<T1, T2, T3>(this CombinedResult<T1, T2, T3, BranchFactory> combinedResult, Action<Humidifier.Amplify.BranchTypes.EnvironmentVariable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironmentVariables(combinedResult.T4, subFactoryAction));
    public static CombinedResult<BranchFactory, T1, T2, T3, T4, InnerBranchEnvironmentVariableFactory> WithEnvironmentVariables<T1, T2, T3, T4>(this CombinedResult<BranchFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Amplify.BranchTypes.EnvironmentVariable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironmentVariables(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BranchFactory, T2, T3, T4, InnerBranchEnvironmentVariableFactory> WithEnvironmentVariables<T1, T2, T3, T4>(this CombinedResult<T1, BranchFactory, T2, T3, T4> combinedResult, Action<Humidifier.Amplify.BranchTypes.EnvironmentVariable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironmentVariables(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BranchFactory, T3, T4, InnerBranchEnvironmentVariableFactory> WithEnvironmentVariables<T1, T2, T3, T4>(this CombinedResult<T1, T2, BranchFactory, T3, T4> combinedResult, Action<Humidifier.Amplify.BranchTypes.EnvironmentVariable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironmentVariables(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BranchFactory, T4, InnerBranchEnvironmentVariableFactory> WithEnvironmentVariables<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, BranchFactory, T4> combinedResult, Action<Humidifier.Amplify.BranchTypes.EnvironmentVariable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironmentVariables(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, BranchFactory, InnerBranchEnvironmentVariableFactory> WithEnvironmentVariables<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, BranchFactory> combinedResult, Action<Humidifier.Amplify.BranchTypes.EnvironmentVariable> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEnvironmentVariables(combinedResult.T5, subFactoryAction));
    public static CombinedResult<BranchFactory, T1, InnerBranchBackendFactory> WithBackend<T1>(this CombinedResult<BranchFactory, T1> combinedResult, Action<Humidifier.Amplify.BranchTypes.Backend> subFactoryAction = null) => new (combinedResult, combinedResult, WithBackend(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BranchFactory, InnerBranchBackendFactory> WithBackend<T1>(this CombinedResult<T1, BranchFactory> combinedResult, Action<Humidifier.Amplify.BranchTypes.Backend> subFactoryAction = null) => new (combinedResult, combinedResult, WithBackend(combinedResult.T2, subFactoryAction));
    public static CombinedResult<BranchFactory, T1, T2, InnerBranchBackendFactory> WithBackend<T1, T2>(this CombinedResult<BranchFactory, T1, T2> combinedResult, Action<Humidifier.Amplify.BranchTypes.Backend> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBackend(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BranchFactory, T2, InnerBranchBackendFactory> WithBackend<T1, T2>(this CombinedResult<T1, BranchFactory, T2> combinedResult, Action<Humidifier.Amplify.BranchTypes.Backend> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBackend(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BranchFactory, InnerBranchBackendFactory> WithBackend<T1, T2>(this CombinedResult<T1, T2, BranchFactory> combinedResult, Action<Humidifier.Amplify.BranchTypes.Backend> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBackend(combinedResult.T3, subFactoryAction));
    public static CombinedResult<BranchFactory, T1, T2, T3, InnerBranchBackendFactory> WithBackend<T1, T2, T3>(this CombinedResult<BranchFactory, T1, T2, T3> combinedResult, Action<Humidifier.Amplify.BranchTypes.Backend> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBackend(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BranchFactory, T2, T3, InnerBranchBackendFactory> WithBackend<T1, T2, T3>(this CombinedResult<T1, BranchFactory, T2, T3> combinedResult, Action<Humidifier.Amplify.BranchTypes.Backend> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBackend(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BranchFactory, T3, InnerBranchBackendFactory> WithBackend<T1, T2, T3>(this CombinedResult<T1, T2, BranchFactory, T3> combinedResult, Action<Humidifier.Amplify.BranchTypes.Backend> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBackend(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BranchFactory, InnerBranchBackendFactory> WithBackend<T1, T2, T3>(this CombinedResult<T1, T2, T3, BranchFactory> combinedResult, Action<Humidifier.Amplify.BranchTypes.Backend> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBackend(combinedResult.T4, subFactoryAction));
    public static CombinedResult<BranchFactory, T1, T2, T3, T4, InnerBranchBackendFactory> WithBackend<T1, T2, T3, T4>(this CombinedResult<BranchFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Amplify.BranchTypes.Backend> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBackend(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BranchFactory, T2, T3, T4, InnerBranchBackendFactory> WithBackend<T1, T2, T3, T4>(this CombinedResult<T1, BranchFactory, T2, T3, T4> combinedResult, Action<Humidifier.Amplify.BranchTypes.Backend> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBackend(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BranchFactory, T3, T4, InnerBranchBackendFactory> WithBackend<T1, T2, T3, T4>(this CombinedResult<T1, T2, BranchFactory, T3, T4> combinedResult, Action<Humidifier.Amplify.BranchTypes.Backend> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBackend(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BranchFactory, T4, InnerBranchBackendFactory> WithBackend<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, BranchFactory, T4> combinedResult, Action<Humidifier.Amplify.BranchTypes.Backend> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBackend(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, BranchFactory, InnerBranchBackendFactory> WithBackend<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, BranchFactory> combinedResult, Action<Humidifier.Amplify.BranchTypes.Backend> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBackend(combinedResult.T5, subFactoryAction));
    public static CombinedResult<BranchFactory, T1, InnerBranchBasicAuthConfigFactory> WithBasicAuthConfig<T1>(this CombinedResult<BranchFactory, T1> combinedResult, Action<Humidifier.Amplify.BranchTypes.BasicAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithBasicAuthConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BranchFactory, InnerBranchBasicAuthConfigFactory> WithBasicAuthConfig<T1>(this CombinedResult<T1, BranchFactory> combinedResult, Action<Humidifier.Amplify.BranchTypes.BasicAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithBasicAuthConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<BranchFactory, T1, T2, InnerBranchBasicAuthConfigFactory> WithBasicAuthConfig<T1, T2>(this CombinedResult<BranchFactory, T1, T2> combinedResult, Action<Humidifier.Amplify.BranchTypes.BasicAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBasicAuthConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BranchFactory, T2, InnerBranchBasicAuthConfigFactory> WithBasicAuthConfig<T1, T2>(this CombinedResult<T1, BranchFactory, T2> combinedResult, Action<Humidifier.Amplify.BranchTypes.BasicAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBasicAuthConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BranchFactory, InnerBranchBasicAuthConfigFactory> WithBasicAuthConfig<T1, T2>(this CombinedResult<T1, T2, BranchFactory> combinedResult, Action<Humidifier.Amplify.BranchTypes.BasicAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBasicAuthConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<BranchFactory, T1, T2, T3, InnerBranchBasicAuthConfigFactory> WithBasicAuthConfig<T1, T2, T3>(this CombinedResult<BranchFactory, T1, T2, T3> combinedResult, Action<Humidifier.Amplify.BranchTypes.BasicAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBasicAuthConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BranchFactory, T2, T3, InnerBranchBasicAuthConfigFactory> WithBasicAuthConfig<T1, T2, T3>(this CombinedResult<T1, BranchFactory, T2, T3> combinedResult, Action<Humidifier.Amplify.BranchTypes.BasicAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBasicAuthConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BranchFactory, T3, InnerBranchBasicAuthConfigFactory> WithBasicAuthConfig<T1, T2, T3>(this CombinedResult<T1, T2, BranchFactory, T3> combinedResult, Action<Humidifier.Amplify.BranchTypes.BasicAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBasicAuthConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BranchFactory, InnerBranchBasicAuthConfigFactory> WithBasicAuthConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, BranchFactory> combinedResult, Action<Humidifier.Amplify.BranchTypes.BasicAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBasicAuthConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<BranchFactory, T1, T2, T3, T4, InnerBranchBasicAuthConfigFactory> WithBasicAuthConfig<T1, T2, T3, T4>(this CombinedResult<BranchFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Amplify.BranchTypes.BasicAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBasicAuthConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BranchFactory, T2, T3, T4, InnerBranchBasicAuthConfigFactory> WithBasicAuthConfig<T1, T2, T3, T4>(this CombinedResult<T1, BranchFactory, T2, T3, T4> combinedResult, Action<Humidifier.Amplify.BranchTypes.BasicAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBasicAuthConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BranchFactory, T3, T4, InnerBranchBasicAuthConfigFactory> WithBasicAuthConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, BranchFactory, T3, T4> combinedResult, Action<Humidifier.Amplify.BranchTypes.BasicAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBasicAuthConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BranchFactory, T4, InnerBranchBasicAuthConfigFactory> WithBasicAuthConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, BranchFactory, T4> combinedResult, Action<Humidifier.Amplify.BranchTypes.BasicAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBasicAuthConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, BranchFactory, InnerBranchBasicAuthConfigFactory> WithBasicAuthConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, BranchFactory> combinedResult, Action<Humidifier.Amplify.BranchTypes.BasicAuthConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBasicAuthConfig(combinedResult.T5, subFactoryAction));
}
