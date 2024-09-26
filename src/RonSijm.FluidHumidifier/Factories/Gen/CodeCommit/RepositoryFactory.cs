// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeCommit;

public class RepositoryFactory(string resourceName = null, Action<Humidifier.CodeCommit.Repository> factoryAction = null) : ResourceFactory<Humidifier.CodeCommit.Repository>(resourceName)
{

    internal List<InnerRepositoryRepositoryTriggerFactory> TriggersFactories { get; set; } = [];

    internal InnerRepositoryCodeFactory CodeFactory { get; set; }

    protected override Humidifier.CodeCommit.Repository Create()
    {
        var repositoryResult = CreateRepository();
        factoryAction?.Invoke(repositoryResult);

        return repositoryResult;
    }

    private Humidifier.CodeCommit.Repository CreateRepository()
    {
        var repositoryResult = new Humidifier.CodeCommit.Repository
        {
            GivenName = InputResourceName,
        };

        return repositoryResult;
    }
    public override void CreateChildren(Humidifier.CodeCommit.Repository result)
    {
        base.CreateChildren(result);

        result.Triggers = TriggersFactories.Any() ? TriggersFactories.Select(x => x.Build()).ToList() : null;
        result.Code ??= CodeFactory?.Build();
    }

} // End Of Class

public static class RepositoryFactoryExtensions
{
    public static CombinedResult<RepositoryFactory, InnerRepositoryRepositoryTriggerFactory> WithTriggers(this RepositoryFactory parentFactory, Action<Humidifier.CodeCommit.RepositoryTypes.RepositoryTrigger> subFactoryAction = null)
    {
        var factory = new InnerRepositoryRepositoryTriggerFactory(subFactoryAction);
        parentFactory.TriggersFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<RepositoryFactory, InnerRepositoryCodeFactory> WithCode(this RepositoryFactory parentFactory, Action<Humidifier.CodeCommit.RepositoryTypes.Code> subFactoryAction = null)
    {
        parentFactory.CodeFactory = new InnerRepositoryCodeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CodeFactory);
    }

    public static CombinedResult<RepositoryFactory, T1, InnerRepositoryRepositoryTriggerFactory> WithTriggers<T1>(this CombinedResult<RepositoryFactory, T1> combinedResult, Action<Humidifier.CodeCommit.RepositoryTypes.RepositoryTrigger> subFactoryAction = null) => new (combinedResult, combinedResult, WithTriggers(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RepositoryFactory, InnerRepositoryRepositoryTriggerFactory> WithTriggers<T1>(this CombinedResult<T1, RepositoryFactory> combinedResult, Action<Humidifier.CodeCommit.RepositoryTypes.RepositoryTrigger> subFactoryAction = null) => new (combinedResult, combinedResult, WithTriggers(combinedResult.T2, subFactoryAction));
    public static CombinedResult<RepositoryFactory, T1, T2, InnerRepositoryRepositoryTriggerFactory> WithTriggers<T1, T2>(this CombinedResult<RepositoryFactory, T1, T2> combinedResult, Action<Humidifier.CodeCommit.RepositoryTypes.RepositoryTrigger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTriggers(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RepositoryFactory, T2, InnerRepositoryRepositoryTriggerFactory> WithTriggers<T1, T2>(this CombinedResult<T1, RepositoryFactory, T2> combinedResult, Action<Humidifier.CodeCommit.RepositoryTypes.RepositoryTrigger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTriggers(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RepositoryFactory, InnerRepositoryRepositoryTriggerFactory> WithTriggers<T1, T2>(this CombinedResult<T1, T2, RepositoryFactory> combinedResult, Action<Humidifier.CodeCommit.RepositoryTypes.RepositoryTrigger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTriggers(combinedResult.T3, subFactoryAction));
    public static CombinedResult<RepositoryFactory, T1, T2, T3, InnerRepositoryRepositoryTriggerFactory> WithTriggers<T1, T2, T3>(this CombinedResult<RepositoryFactory, T1, T2, T3> combinedResult, Action<Humidifier.CodeCommit.RepositoryTypes.RepositoryTrigger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTriggers(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RepositoryFactory, T2, T3, InnerRepositoryRepositoryTriggerFactory> WithTriggers<T1, T2, T3>(this CombinedResult<T1, RepositoryFactory, T2, T3> combinedResult, Action<Humidifier.CodeCommit.RepositoryTypes.RepositoryTrigger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTriggers(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RepositoryFactory, T3, InnerRepositoryRepositoryTriggerFactory> WithTriggers<T1, T2, T3>(this CombinedResult<T1, T2, RepositoryFactory, T3> combinedResult, Action<Humidifier.CodeCommit.RepositoryTypes.RepositoryTrigger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTriggers(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RepositoryFactory, InnerRepositoryRepositoryTriggerFactory> WithTriggers<T1, T2, T3>(this CombinedResult<T1, T2, T3, RepositoryFactory> combinedResult, Action<Humidifier.CodeCommit.RepositoryTypes.RepositoryTrigger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTriggers(combinedResult.T4, subFactoryAction));
    public static CombinedResult<RepositoryFactory, T1, T2, T3, T4, InnerRepositoryRepositoryTriggerFactory> WithTriggers<T1, T2, T3, T4>(this CombinedResult<RepositoryFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CodeCommit.RepositoryTypes.RepositoryTrigger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTriggers(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RepositoryFactory, T2, T3, T4, InnerRepositoryRepositoryTriggerFactory> WithTriggers<T1, T2, T3, T4>(this CombinedResult<T1, RepositoryFactory, T2, T3, T4> combinedResult, Action<Humidifier.CodeCommit.RepositoryTypes.RepositoryTrigger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTriggers(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RepositoryFactory, T3, T4, InnerRepositoryRepositoryTriggerFactory> WithTriggers<T1, T2, T3, T4>(this CombinedResult<T1, T2, RepositoryFactory, T3, T4> combinedResult, Action<Humidifier.CodeCommit.RepositoryTypes.RepositoryTrigger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTriggers(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RepositoryFactory, T4, InnerRepositoryRepositoryTriggerFactory> WithTriggers<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RepositoryFactory, T4> combinedResult, Action<Humidifier.CodeCommit.RepositoryTypes.RepositoryTrigger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTriggers(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, RepositoryFactory, InnerRepositoryRepositoryTriggerFactory> WithTriggers<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RepositoryFactory> combinedResult, Action<Humidifier.CodeCommit.RepositoryTypes.RepositoryTrigger> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTriggers(combinedResult.T5, subFactoryAction));
    public static CombinedResult<RepositoryFactory, T1, InnerRepositoryCodeFactory> WithCode<T1>(this CombinedResult<RepositoryFactory, T1> combinedResult, Action<Humidifier.CodeCommit.RepositoryTypes.Code> subFactoryAction = null) => new (combinedResult, combinedResult, WithCode(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RepositoryFactory, InnerRepositoryCodeFactory> WithCode<T1>(this CombinedResult<T1, RepositoryFactory> combinedResult, Action<Humidifier.CodeCommit.RepositoryTypes.Code> subFactoryAction = null) => new (combinedResult, combinedResult, WithCode(combinedResult.T2, subFactoryAction));
    public static CombinedResult<RepositoryFactory, T1, T2, InnerRepositoryCodeFactory> WithCode<T1, T2>(this CombinedResult<RepositoryFactory, T1, T2> combinedResult, Action<Humidifier.CodeCommit.RepositoryTypes.Code> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCode(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RepositoryFactory, T2, InnerRepositoryCodeFactory> WithCode<T1, T2>(this CombinedResult<T1, RepositoryFactory, T2> combinedResult, Action<Humidifier.CodeCommit.RepositoryTypes.Code> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCode(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RepositoryFactory, InnerRepositoryCodeFactory> WithCode<T1, T2>(this CombinedResult<T1, T2, RepositoryFactory> combinedResult, Action<Humidifier.CodeCommit.RepositoryTypes.Code> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCode(combinedResult.T3, subFactoryAction));
    public static CombinedResult<RepositoryFactory, T1, T2, T3, InnerRepositoryCodeFactory> WithCode<T1, T2, T3>(this CombinedResult<RepositoryFactory, T1, T2, T3> combinedResult, Action<Humidifier.CodeCommit.RepositoryTypes.Code> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCode(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RepositoryFactory, T2, T3, InnerRepositoryCodeFactory> WithCode<T1, T2, T3>(this CombinedResult<T1, RepositoryFactory, T2, T3> combinedResult, Action<Humidifier.CodeCommit.RepositoryTypes.Code> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCode(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RepositoryFactory, T3, InnerRepositoryCodeFactory> WithCode<T1, T2, T3>(this CombinedResult<T1, T2, RepositoryFactory, T3> combinedResult, Action<Humidifier.CodeCommit.RepositoryTypes.Code> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCode(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RepositoryFactory, InnerRepositoryCodeFactory> WithCode<T1, T2, T3>(this CombinedResult<T1, T2, T3, RepositoryFactory> combinedResult, Action<Humidifier.CodeCommit.RepositoryTypes.Code> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCode(combinedResult.T4, subFactoryAction));
    public static CombinedResult<RepositoryFactory, T1, T2, T3, T4, InnerRepositoryCodeFactory> WithCode<T1, T2, T3, T4>(this CombinedResult<RepositoryFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CodeCommit.RepositoryTypes.Code> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCode(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RepositoryFactory, T2, T3, T4, InnerRepositoryCodeFactory> WithCode<T1, T2, T3, T4>(this CombinedResult<T1, RepositoryFactory, T2, T3, T4> combinedResult, Action<Humidifier.CodeCommit.RepositoryTypes.Code> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCode(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RepositoryFactory, T3, T4, InnerRepositoryCodeFactory> WithCode<T1, T2, T3, T4>(this CombinedResult<T1, T2, RepositoryFactory, T3, T4> combinedResult, Action<Humidifier.CodeCommit.RepositoryTypes.Code> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCode(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RepositoryFactory, T4, InnerRepositoryCodeFactory> WithCode<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RepositoryFactory, T4> combinedResult, Action<Humidifier.CodeCommit.RepositoryTypes.Code> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCode(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, RepositoryFactory, InnerRepositoryCodeFactory> WithCode<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RepositoryFactory> combinedResult, Action<Humidifier.CodeCommit.RepositoryTypes.Code> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCode(combinedResult.T5, subFactoryAction));
}
