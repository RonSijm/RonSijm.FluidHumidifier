// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AgentRegistry;

public class InnerRegistryRecordSkillMdSourceFactory(Action<Humidifier.AgentRegistry.RegistryRecordTypes.SkillMdSource> factoryAction = null) : SubResourceFactory<Humidifier.AgentRegistry.RegistryRecordTypes.SkillMdSource>
{

    internal InnerRegistryRecordSkillMdSourceFromUrlFactory FromUrlFactory { get; set; }

    protected override Humidifier.AgentRegistry.RegistryRecordTypes.SkillMdSource Create()
    {
        var skillMdSourceResult = CreateSkillMdSource();
        factoryAction?.Invoke(skillMdSourceResult);

        return skillMdSourceResult;
    }

    private Humidifier.AgentRegistry.RegistryRecordTypes.SkillMdSource CreateSkillMdSource()
    {
        var skillMdSourceResult = new Humidifier.AgentRegistry.RegistryRecordTypes.SkillMdSource();

        return skillMdSourceResult;
    }
    public override void CreateChildren(Humidifier.AgentRegistry.RegistryRecordTypes.SkillMdSource result)
    {
        base.CreateChildren(result);

        result.FromUrl ??= FromUrlFactory?.Build();
    }

} // End Of Class

public static class InnerRegistryRecordSkillMdSourceFactoryExtensions
{
    public static CombinedResult<InnerRegistryRecordSkillMdSourceFactory, InnerRegistryRecordSkillMdSourceFromUrlFactory> WithFromUrl(this InnerRegistryRecordSkillMdSourceFactory parentFactory, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SkillMdSourceFromUrl> subFactoryAction = null)
    {
        parentFactory.FromUrlFactory = new InnerRegistryRecordSkillMdSourceFromUrlFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FromUrlFactory);
    }

    public static CombinedResult<InnerRegistryRecordSkillMdSourceFactory, T1, InnerRegistryRecordSkillMdSourceFromUrlFactory> WithFromUrl<T1>(this CombinedResult<InnerRegistryRecordSkillMdSourceFactory, T1> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SkillMdSourceFromUrl> subFactoryAction = null) => new (combinedResult, combinedResult, WithFromUrl(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRegistryRecordSkillMdSourceFactory, InnerRegistryRecordSkillMdSourceFromUrlFactory> WithFromUrl<T1>(this CombinedResult<T1, InnerRegistryRecordSkillMdSourceFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SkillMdSourceFromUrl> subFactoryAction = null) => new (combinedResult, combinedResult, WithFromUrl(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRegistryRecordSkillMdSourceFactory, T1, T2, InnerRegistryRecordSkillMdSourceFromUrlFactory> WithFromUrl<T1, T2>(this CombinedResult<InnerRegistryRecordSkillMdSourceFactory, T1, T2> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SkillMdSourceFromUrl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFromUrl(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRegistryRecordSkillMdSourceFactory, T2, InnerRegistryRecordSkillMdSourceFromUrlFactory> WithFromUrl<T1, T2>(this CombinedResult<T1, InnerRegistryRecordSkillMdSourceFactory, T2> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SkillMdSourceFromUrl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFromUrl(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRegistryRecordSkillMdSourceFactory, InnerRegistryRecordSkillMdSourceFromUrlFactory> WithFromUrl<T1, T2>(this CombinedResult<T1, T2, InnerRegistryRecordSkillMdSourceFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SkillMdSourceFromUrl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFromUrl(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRegistryRecordSkillMdSourceFactory, T1, T2, T3, InnerRegistryRecordSkillMdSourceFromUrlFactory> WithFromUrl<T1, T2, T3>(this CombinedResult<InnerRegistryRecordSkillMdSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SkillMdSourceFromUrl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFromUrl(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRegistryRecordSkillMdSourceFactory, T2, T3, InnerRegistryRecordSkillMdSourceFromUrlFactory> WithFromUrl<T1, T2, T3>(this CombinedResult<T1, InnerRegistryRecordSkillMdSourceFactory, T2, T3> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SkillMdSourceFromUrl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFromUrl(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRegistryRecordSkillMdSourceFactory, T3, InnerRegistryRecordSkillMdSourceFromUrlFactory> WithFromUrl<T1, T2, T3>(this CombinedResult<T1, T2, InnerRegistryRecordSkillMdSourceFactory, T3> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SkillMdSourceFromUrl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFromUrl(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRegistryRecordSkillMdSourceFactory, InnerRegistryRecordSkillMdSourceFromUrlFactory> WithFromUrl<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRegistryRecordSkillMdSourceFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SkillMdSourceFromUrl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFromUrl(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRegistryRecordSkillMdSourceFactory, T1, T2, T3, T4, InnerRegistryRecordSkillMdSourceFromUrlFactory> WithFromUrl<T1, T2, T3, T4>(this CombinedResult<InnerRegistryRecordSkillMdSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SkillMdSourceFromUrl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFromUrl(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRegistryRecordSkillMdSourceFactory, T2, T3, T4, InnerRegistryRecordSkillMdSourceFromUrlFactory> WithFromUrl<T1, T2, T3, T4>(this CombinedResult<T1, InnerRegistryRecordSkillMdSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SkillMdSourceFromUrl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFromUrl(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRegistryRecordSkillMdSourceFactory, T3, T4, InnerRegistryRecordSkillMdSourceFromUrlFactory> WithFromUrl<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRegistryRecordSkillMdSourceFactory, T3, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SkillMdSourceFromUrl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFromUrl(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRegistryRecordSkillMdSourceFactory, T4, InnerRegistryRecordSkillMdSourceFromUrlFactory> WithFromUrl<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRegistryRecordSkillMdSourceFactory, T4> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SkillMdSourceFromUrl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFromUrl(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRegistryRecordSkillMdSourceFactory, InnerRegistryRecordSkillMdSourceFromUrlFactory> WithFromUrl<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRegistryRecordSkillMdSourceFactory> combinedResult, Action<Humidifier.AgentRegistry.RegistryRecordTypes.SkillMdSourceFromUrl> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFromUrl(combinedResult.T5, subFactoryAction).T2);
}
