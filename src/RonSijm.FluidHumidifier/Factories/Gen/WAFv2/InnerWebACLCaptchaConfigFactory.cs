// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerWebACLCaptchaConfigFactory(Action<Humidifier.WAFv2.WebACLTypes.CaptchaConfig> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.WebACLTypes.CaptchaConfig>
{

    internal InnerWebACLImmunityTimePropertyFactory ImmunityTimePropertyFactory { get; set; }

    protected override Humidifier.WAFv2.WebACLTypes.CaptchaConfig Create()
    {
        var captchaConfigResult = CreateCaptchaConfig();
        factoryAction?.Invoke(captchaConfigResult);

        return captchaConfigResult;
    }

    private Humidifier.WAFv2.WebACLTypes.CaptchaConfig CreateCaptchaConfig()
    {
        var captchaConfigResult = new Humidifier.WAFv2.WebACLTypes.CaptchaConfig();

        return captchaConfigResult;
    }
    public override void CreateChildren(Humidifier.WAFv2.WebACLTypes.CaptchaConfig result)
    {
        base.CreateChildren(result);

        result.ImmunityTimeProperty ??= ImmunityTimePropertyFactory?.Build();
    }

} // End Of Class

public static class InnerWebACLCaptchaConfigFactoryExtensions
{
    public static CombinedResult<InnerWebACLCaptchaConfigFactory, InnerWebACLImmunityTimePropertyFactory> WithImmunityTimeProperty(this InnerWebACLCaptchaConfigFactory parentFactory, Action<Humidifier.WAFv2.WebACLTypes.ImmunityTimeProperty> subFactoryAction = null)
    {
        parentFactory.ImmunityTimePropertyFactory = new InnerWebACLImmunityTimePropertyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ImmunityTimePropertyFactory);
    }

    public static CombinedResult<InnerWebACLCaptchaConfigFactory, T1, InnerWebACLImmunityTimePropertyFactory> WithImmunityTimeProperty<T1>(this CombinedResult<InnerWebACLCaptchaConfigFactory, T1> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLCaptchaConfigFactory, InnerWebACLImmunityTimePropertyFactory> WithImmunityTimeProperty<T1>(this CombinedResult<T1, InnerWebACLCaptchaConfigFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerWebACLCaptchaConfigFactory, T1, T2, InnerWebACLImmunityTimePropertyFactory> WithImmunityTimeProperty<T1, T2>(this CombinedResult<InnerWebACLCaptchaConfigFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLCaptchaConfigFactory, T2, InnerWebACLImmunityTimePropertyFactory> WithImmunityTimeProperty<T1, T2>(this CombinedResult<T1, InnerWebACLCaptchaConfigFactory, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLCaptchaConfigFactory, InnerWebACLImmunityTimePropertyFactory> WithImmunityTimeProperty<T1, T2>(this CombinedResult<T1, T2, InnerWebACLCaptchaConfigFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerWebACLCaptchaConfigFactory, T1, T2, T3, InnerWebACLImmunityTimePropertyFactory> WithImmunityTimeProperty<T1, T2, T3>(this CombinedResult<InnerWebACLCaptchaConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLCaptchaConfigFactory, T2, T3, InnerWebACLImmunityTimePropertyFactory> WithImmunityTimeProperty<T1, T2, T3>(this CombinedResult<T1, InnerWebACLCaptchaConfigFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLCaptchaConfigFactory, T3, InnerWebACLImmunityTimePropertyFactory> WithImmunityTimeProperty<T1, T2, T3>(this CombinedResult<T1, T2, InnerWebACLCaptchaConfigFactory, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLCaptchaConfigFactory, InnerWebACLImmunityTimePropertyFactory> WithImmunityTimeProperty<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWebACLCaptchaConfigFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerWebACLCaptchaConfigFactory, T1, T2, T3, T4, InnerWebACLImmunityTimePropertyFactory> WithImmunityTimeProperty<T1, T2, T3, T4>(this CombinedResult<InnerWebACLCaptchaConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLCaptchaConfigFactory, T2, T3, T4, InnerWebACLImmunityTimePropertyFactory> WithImmunityTimeProperty<T1, T2, T3, T4>(this CombinedResult<T1, InnerWebACLCaptchaConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLCaptchaConfigFactory, T3, T4, InnerWebACLImmunityTimePropertyFactory> WithImmunityTimeProperty<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWebACLCaptchaConfigFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLCaptchaConfigFactory, T4, InnerWebACLImmunityTimePropertyFactory> WithImmunityTimeProperty<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWebACLCaptchaConfigFactory, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerWebACLCaptchaConfigFactory, InnerWebACLImmunityTimePropertyFactory> WithImmunityTimeProperty<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWebACLCaptchaConfigFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T5, subFactoryAction));
}
