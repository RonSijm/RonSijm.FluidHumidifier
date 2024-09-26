// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ASK;

public class InnerSkillSkillPackageFactory(Action<Humidifier.ASK.SkillTypes.SkillPackage> factoryAction = null) : SubResourceFactory<Humidifier.ASK.SkillTypes.SkillPackage>
{

    internal InnerSkillOverridesFactory OverridesFactory { get; set; }

    protected override Humidifier.ASK.SkillTypes.SkillPackage Create()
    {
        var skillPackageResult = CreateSkillPackage();
        factoryAction?.Invoke(skillPackageResult);

        return skillPackageResult;
    }

    private Humidifier.ASK.SkillTypes.SkillPackage CreateSkillPackage()
    {
        var skillPackageResult = new Humidifier.ASK.SkillTypes.SkillPackage();

        return skillPackageResult;
    }
    public override void CreateChildren(Humidifier.ASK.SkillTypes.SkillPackage result)
    {
        base.CreateChildren(result);

        result.Overrides ??= OverridesFactory?.Build();
    }

} // End Of Class

public static class InnerSkillSkillPackageFactoryExtensions
{
    public static CombinedResult<InnerSkillSkillPackageFactory, InnerSkillOverridesFactory> WithOverrides(this InnerSkillSkillPackageFactory parentFactory, Action<Humidifier.ASK.SkillTypes.Overrides> subFactoryAction = null)
    {
        parentFactory.OverridesFactory = new InnerSkillOverridesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OverridesFactory);
    }

    public static CombinedResult<InnerSkillSkillPackageFactory, T1, InnerSkillOverridesFactory> WithOverrides<T1>(this CombinedResult<InnerSkillSkillPackageFactory, T1> combinedResult, Action<Humidifier.ASK.SkillTypes.Overrides> subFactoryAction = null) => new (combinedResult, combinedResult, WithOverrides(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSkillSkillPackageFactory, InnerSkillOverridesFactory> WithOverrides<T1>(this CombinedResult<T1, InnerSkillSkillPackageFactory> combinedResult, Action<Humidifier.ASK.SkillTypes.Overrides> subFactoryAction = null) => new (combinedResult, combinedResult, WithOverrides(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerSkillSkillPackageFactory, T1, T2, InnerSkillOverridesFactory> WithOverrides<T1, T2>(this CombinedResult<InnerSkillSkillPackageFactory, T1, T2> combinedResult, Action<Humidifier.ASK.SkillTypes.Overrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOverrides(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSkillSkillPackageFactory, T2, InnerSkillOverridesFactory> WithOverrides<T1, T2>(this CombinedResult<T1, InnerSkillSkillPackageFactory, T2> combinedResult, Action<Humidifier.ASK.SkillTypes.Overrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOverrides(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSkillSkillPackageFactory, InnerSkillOverridesFactory> WithOverrides<T1, T2>(this CombinedResult<T1, T2, InnerSkillSkillPackageFactory> combinedResult, Action<Humidifier.ASK.SkillTypes.Overrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOverrides(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerSkillSkillPackageFactory, T1, T2, T3, InnerSkillOverridesFactory> WithOverrides<T1, T2, T3>(this CombinedResult<InnerSkillSkillPackageFactory, T1, T2, T3> combinedResult, Action<Humidifier.ASK.SkillTypes.Overrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOverrides(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSkillSkillPackageFactory, T2, T3, InnerSkillOverridesFactory> WithOverrides<T1, T2, T3>(this CombinedResult<T1, InnerSkillSkillPackageFactory, T2, T3> combinedResult, Action<Humidifier.ASK.SkillTypes.Overrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOverrides(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSkillSkillPackageFactory, T3, InnerSkillOverridesFactory> WithOverrides<T1, T2, T3>(this CombinedResult<T1, T2, InnerSkillSkillPackageFactory, T3> combinedResult, Action<Humidifier.ASK.SkillTypes.Overrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOverrides(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSkillSkillPackageFactory, InnerSkillOverridesFactory> WithOverrides<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerSkillSkillPackageFactory> combinedResult, Action<Humidifier.ASK.SkillTypes.Overrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOverrides(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerSkillSkillPackageFactory, T1, T2, T3, T4, InnerSkillOverridesFactory> WithOverrides<T1, T2, T3, T4>(this CombinedResult<InnerSkillSkillPackageFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ASK.SkillTypes.Overrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOverrides(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSkillSkillPackageFactory, T2, T3, T4, InnerSkillOverridesFactory> WithOverrides<T1, T2, T3, T4>(this CombinedResult<T1, InnerSkillSkillPackageFactory, T2, T3, T4> combinedResult, Action<Humidifier.ASK.SkillTypes.Overrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOverrides(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSkillSkillPackageFactory, T3, T4, InnerSkillOverridesFactory> WithOverrides<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerSkillSkillPackageFactory, T3, T4> combinedResult, Action<Humidifier.ASK.SkillTypes.Overrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOverrides(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSkillSkillPackageFactory, T4, InnerSkillOverridesFactory> WithOverrides<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerSkillSkillPackageFactory, T4> combinedResult, Action<Humidifier.ASK.SkillTypes.Overrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOverrides(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerSkillSkillPackageFactory, InnerSkillOverridesFactory> WithOverrides<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerSkillSkillPackageFactory> combinedResult, Action<Humidifier.ASK.SkillTypes.Overrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOverrides(combinedResult.T5, subFactoryAction));
}
