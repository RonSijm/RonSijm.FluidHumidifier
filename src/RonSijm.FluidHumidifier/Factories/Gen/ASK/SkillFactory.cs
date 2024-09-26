// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ASK;

public class SkillFactory(string resourceName = null, Action<Humidifier.ASK.Skill> factoryAction = null) : ResourceFactory<Humidifier.ASK.Skill>(resourceName)
{

    internal InnerSkillAuthenticationConfigurationFactory AuthenticationConfigurationFactory { get; set; }

    internal InnerSkillSkillPackageFactory SkillPackageFactory { get; set; }

    protected override Humidifier.ASK.Skill Create()
    {
        var skillResult = CreateSkill();
        factoryAction?.Invoke(skillResult);

        return skillResult;
    }

    private Humidifier.ASK.Skill CreateSkill()
    {
        var skillResult = new Humidifier.ASK.Skill
        {
            GivenName = InputResourceName,
        };

        return skillResult;
    }
    public override void CreateChildren(Humidifier.ASK.Skill result)
    {
        base.CreateChildren(result);

        result.AuthenticationConfiguration ??= AuthenticationConfigurationFactory?.Build();
        result.SkillPackage ??= SkillPackageFactory?.Build();
    }

} // End Of Class

public static class SkillFactoryExtensions
{
    public static CombinedResult<SkillFactory, InnerSkillAuthenticationConfigurationFactory> WithAuthenticationConfiguration(this SkillFactory parentFactory, Action<Humidifier.ASK.SkillTypes.AuthenticationConfiguration> subFactoryAction = null)
    {
        parentFactory.AuthenticationConfigurationFactory = new InnerSkillAuthenticationConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AuthenticationConfigurationFactory);
    }

    public static CombinedResult<SkillFactory, InnerSkillSkillPackageFactory> WithSkillPackage(this SkillFactory parentFactory, Action<Humidifier.ASK.SkillTypes.SkillPackage> subFactoryAction = null)
    {
        parentFactory.SkillPackageFactory = new InnerSkillSkillPackageFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SkillPackageFactory);
    }

    public static CombinedResult<SkillFactory, T1, InnerSkillAuthenticationConfigurationFactory> WithAuthenticationConfiguration<T1>(this CombinedResult<SkillFactory, T1> combinedResult, Action<Humidifier.ASK.SkillTypes.AuthenticationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SkillFactory, InnerSkillAuthenticationConfigurationFactory> WithAuthenticationConfiguration<T1>(this CombinedResult<T1, SkillFactory> combinedResult, Action<Humidifier.ASK.SkillTypes.AuthenticationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<SkillFactory, T1, T2, InnerSkillAuthenticationConfigurationFactory> WithAuthenticationConfiguration<T1, T2>(this CombinedResult<SkillFactory, T1, T2> combinedResult, Action<Humidifier.ASK.SkillTypes.AuthenticationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SkillFactory, T2, InnerSkillAuthenticationConfigurationFactory> WithAuthenticationConfiguration<T1, T2>(this CombinedResult<T1, SkillFactory, T2> combinedResult, Action<Humidifier.ASK.SkillTypes.AuthenticationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SkillFactory, InnerSkillAuthenticationConfigurationFactory> WithAuthenticationConfiguration<T1, T2>(this CombinedResult<T1, T2, SkillFactory> combinedResult, Action<Humidifier.ASK.SkillTypes.AuthenticationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<SkillFactory, T1, T2, T3, InnerSkillAuthenticationConfigurationFactory> WithAuthenticationConfiguration<T1, T2, T3>(this CombinedResult<SkillFactory, T1, T2, T3> combinedResult, Action<Humidifier.ASK.SkillTypes.AuthenticationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SkillFactory, T2, T3, InnerSkillAuthenticationConfigurationFactory> WithAuthenticationConfiguration<T1, T2, T3>(this CombinedResult<T1, SkillFactory, T2, T3> combinedResult, Action<Humidifier.ASK.SkillTypes.AuthenticationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SkillFactory, T3, InnerSkillAuthenticationConfigurationFactory> WithAuthenticationConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, SkillFactory, T3> combinedResult, Action<Humidifier.ASK.SkillTypes.AuthenticationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SkillFactory, InnerSkillAuthenticationConfigurationFactory> WithAuthenticationConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, SkillFactory> combinedResult, Action<Humidifier.ASK.SkillTypes.AuthenticationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<SkillFactory, T1, T2, T3, T4, InnerSkillAuthenticationConfigurationFactory> WithAuthenticationConfiguration<T1, T2, T3, T4>(this CombinedResult<SkillFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ASK.SkillTypes.AuthenticationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SkillFactory, T2, T3, T4, InnerSkillAuthenticationConfigurationFactory> WithAuthenticationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, SkillFactory, T2, T3, T4> combinedResult, Action<Humidifier.ASK.SkillTypes.AuthenticationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SkillFactory, T3, T4, InnerSkillAuthenticationConfigurationFactory> WithAuthenticationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, SkillFactory, T3, T4> combinedResult, Action<Humidifier.ASK.SkillTypes.AuthenticationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SkillFactory, T4, InnerSkillAuthenticationConfigurationFactory> WithAuthenticationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SkillFactory, T4> combinedResult, Action<Humidifier.ASK.SkillTypes.AuthenticationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, SkillFactory, InnerSkillAuthenticationConfigurationFactory> WithAuthenticationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SkillFactory> combinedResult, Action<Humidifier.ASK.SkillTypes.AuthenticationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAuthenticationConfiguration(combinedResult.T5, subFactoryAction));
    public static CombinedResult<SkillFactory, T1, InnerSkillSkillPackageFactory> WithSkillPackage<T1>(this CombinedResult<SkillFactory, T1> combinedResult, Action<Humidifier.ASK.SkillTypes.SkillPackage> subFactoryAction = null) => new (combinedResult, combinedResult, WithSkillPackage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SkillFactory, InnerSkillSkillPackageFactory> WithSkillPackage<T1>(this CombinedResult<T1, SkillFactory> combinedResult, Action<Humidifier.ASK.SkillTypes.SkillPackage> subFactoryAction = null) => new (combinedResult, combinedResult, WithSkillPackage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<SkillFactory, T1, T2, InnerSkillSkillPackageFactory> WithSkillPackage<T1, T2>(this CombinedResult<SkillFactory, T1, T2> combinedResult, Action<Humidifier.ASK.SkillTypes.SkillPackage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSkillPackage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SkillFactory, T2, InnerSkillSkillPackageFactory> WithSkillPackage<T1, T2>(this CombinedResult<T1, SkillFactory, T2> combinedResult, Action<Humidifier.ASK.SkillTypes.SkillPackage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSkillPackage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SkillFactory, InnerSkillSkillPackageFactory> WithSkillPackage<T1, T2>(this CombinedResult<T1, T2, SkillFactory> combinedResult, Action<Humidifier.ASK.SkillTypes.SkillPackage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSkillPackage(combinedResult.T3, subFactoryAction));
    public static CombinedResult<SkillFactory, T1, T2, T3, InnerSkillSkillPackageFactory> WithSkillPackage<T1, T2, T3>(this CombinedResult<SkillFactory, T1, T2, T3> combinedResult, Action<Humidifier.ASK.SkillTypes.SkillPackage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSkillPackage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SkillFactory, T2, T3, InnerSkillSkillPackageFactory> WithSkillPackage<T1, T2, T3>(this CombinedResult<T1, SkillFactory, T2, T3> combinedResult, Action<Humidifier.ASK.SkillTypes.SkillPackage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSkillPackage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SkillFactory, T3, InnerSkillSkillPackageFactory> WithSkillPackage<T1, T2, T3>(this CombinedResult<T1, T2, SkillFactory, T3> combinedResult, Action<Humidifier.ASK.SkillTypes.SkillPackage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSkillPackage(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SkillFactory, InnerSkillSkillPackageFactory> WithSkillPackage<T1, T2, T3>(this CombinedResult<T1, T2, T3, SkillFactory> combinedResult, Action<Humidifier.ASK.SkillTypes.SkillPackage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSkillPackage(combinedResult.T4, subFactoryAction));
    public static CombinedResult<SkillFactory, T1, T2, T3, T4, InnerSkillSkillPackageFactory> WithSkillPackage<T1, T2, T3, T4>(this CombinedResult<SkillFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ASK.SkillTypes.SkillPackage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSkillPackage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SkillFactory, T2, T3, T4, InnerSkillSkillPackageFactory> WithSkillPackage<T1, T2, T3, T4>(this CombinedResult<T1, SkillFactory, T2, T3, T4> combinedResult, Action<Humidifier.ASK.SkillTypes.SkillPackage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSkillPackage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SkillFactory, T3, T4, InnerSkillSkillPackageFactory> WithSkillPackage<T1, T2, T3, T4>(this CombinedResult<T1, T2, SkillFactory, T3, T4> combinedResult, Action<Humidifier.ASK.SkillTypes.SkillPackage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSkillPackage(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SkillFactory, T4, InnerSkillSkillPackageFactory> WithSkillPackage<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SkillFactory, T4> combinedResult, Action<Humidifier.ASK.SkillTypes.SkillPackage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSkillPackage(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, SkillFactory, InnerSkillSkillPackageFactory> WithSkillPackage<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SkillFactory> combinedResult, Action<Humidifier.ASK.SkillTypes.SkillPackage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSkillPackage(combinedResult.T5, subFactoryAction));
}
