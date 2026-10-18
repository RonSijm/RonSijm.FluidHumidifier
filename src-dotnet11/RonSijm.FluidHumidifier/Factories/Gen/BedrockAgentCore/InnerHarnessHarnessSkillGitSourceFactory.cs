// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerHarnessHarnessSkillGitSourceFactory(Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessSkillGitSource> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.HarnessTypes.HarnessSkillGitSource>
{

    internal InnerHarnessHarnessSkillGitAuthFactory AuthFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.HarnessTypes.HarnessSkillGitSource Create()
    {
        var harnessSkillGitSourceResult = CreateHarnessSkillGitSource();
        factoryAction?.Invoke(harnessSkillGitSourceResult);

        return harnessSkillGitSourceResult;
    }

    private Humidifier.BedrockAgentCore.HarnessTypes.HarnessSkillGitSource CreateHarnessSkillGitSource()
    {
        var harnessSkillGitSourceResult = new Humidifier.BedrockAgentCore.HarnessTypes.HarnessSkillGitSource();

        return harnessSkillGitSourceResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.HarnessTypes.HarnessSkillGitSource result)
    {
        base.CreateChildren(result);

        result.Auth ??= AuthFactory?.Build();
    }

} // End Of Class

public static class InnerHarnessHarnessSkillGitSourceFactoryExtensions
{
    public static CombinedResult<InnerHarnessHarnessSkillGitSourceFactory, InnerHarnessHarnessSkillGitAuthFactory> WithAuth(this InnerHarnessHarnessSkillGitSourceFactory parentFactory, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessSkillGitAuth> subFactoryAction = null)
    {
        parentFactory.AuthFactory = new InnerHarnessHarnessSkillGitAuthFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AuthFactory);
    }

    public static CombinedResult<InnerHarnessHarnessSkillGitSourceFactory, T1, InnerHarnessHarnessSkillGitAuthFactory> WithAuth<T1>(this CombinedResult<InnerHarnessHarnessSkillGitSourceFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessSkillGitAuth> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuth(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessHarnessSkillGitSourceFactory, InnerHarnessHarnessSkillGitAuthFactory> WithAuth<T1>(this CombinedResult<T1, InnerHarnessHarnessSkillGitSourceFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessSkillGitAuth> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuth(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerHarnessHarnessSkillGitSourceFactory, T1, T2, InnerHarnessHarnessSkillGitAuthFactory> WithAuth<T1, T2>(this CombinedResult<InnerHarnessHarnessSkillGitSourceFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessSkillGitAuth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuth(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessHarnessSkillGitSourceFactory, T2, InnerHarnessHarnessSkillGitAuthFactory> WithAuth<T1, T2>(this CombinedResult<T1, InnerHarnessHarnessSkillGitSourceFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessSkillGitAuth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuth(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHarnessHarnessSkillGitSourceFactory, InnerHarnessHarnessSkillGitAuthFactory> WithAuth<T1, T2>(this CombinedResult<T1, T2, InnerHarnessHarnessSkillGitSourceFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessSkillGitAuth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuth(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerHarnessHarnessSkillGitSourceFactory, T1, T2, T3, InnerHarnessHarnessSkillGitAuthFactory> WithAuth<T1, T2, T3>(this CombinedResult<InnerHarnessHarnessSkillGitSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessSkillGitAuth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuth(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessHarnessSkillGitSourceFactory, T2, T3, InnerHarnessHarnessSkillGitAuthFactory> WithAuth<T1, T2, T3>(this CombinedResult<T1, InnerHarnessHarnessSkillGitSourceFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessSkillGitAuth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuth(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHarnessHarnessSkillGitSourceFactory, T3, InnerHarnessHarnessSkillGitAuthFactory> WithAuth<T1, T2, T3>(this CombinedResult<T1, T2, InnerHarnessHarnessSkillGitSourceFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessSkillGitAuth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuth(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerHarnessHarnessSkillGitSourceFactory, InnerHarnessHarnessSkillGitAuthFactory> WithAuth<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerHarnessHarnessSkillGitSourceFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessSkillGitAuth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuth(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerHarnessHarnessSkillGitSourceFactory, T1, T2, T3, T4, InnerHarnessHarnessSkillGitAuthFactory> WithAuth<T1, T2, T3, T4>(this CombinedResult<InnerHarnessHarnessSkillGitSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessSkillGitAuth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuth(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerHarnessHarnessSkillGitSourceFactory, T2, T3, T4, InnerHarnessHarnessSkillGitAuthFactory> WithAuth<T1, T2, T3, T4>(this CombinedResult<T1, InnerHarnessHarnessSkillGitSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessSkillGitAuth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuth(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerHarnessHarnessSkillGitSourceFactory, T3, T4, InnerHarnessHarnessSkillGitAuthFactory> WithAuth<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerHarnessHarnessSkillGitSourceFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessSkillGitAuth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuth(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerHarnessHarnessSkillGitSourceFactory, T4, InnerHarnessHarnessSkillGitAuthFactory> WithAuth<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerHarnessHarnessSkillGitSourceFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessSkillGitAuth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuth(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerHarnessHarnessSkillGitSourceFactory, InnerHarnessHarnessSkillGitAuthFactory> WithAuth<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerHarnessHarnessSkillGitSourceFactory> combinedResult, Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessSkillGitAuth> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuth(combinedResult.T5, subFactoryAction).T2);
}
