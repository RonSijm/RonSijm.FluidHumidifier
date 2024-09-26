// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QBusiness;

public class WebExperienceFactory(string resourceName = null, Action<Humidifier.QBusiness.WebExperience> factoryAction = null) : ResourceFactory<Humidifier.QBusiness.WebExperience>(resourceName)
{

    internal InnerWebExperienceIdentityProviderConfigurationFactory IdentityProviderConfigurationFactory { get; set; }

    protected override Humidifier.QBusiness.WebExperience Create()
    {
        var webExperienceResult = CreateWebExperience();
        factoryAction?.Invoke(webExperienceResult);

        return webExperienceResult;
    }

    private Humidifier.QBusiness.WebExperience CreateWebExperience()
    {
        var webExperienceResult = new Humidifier.QBusiness.WebExperience
        {
            GivenName = InputResourceName,
        };

        return webExperienceResult;
    }
    public override void CreateChildren(Humidifier.QBusiness.WebExperience result)
    {
        base.CreateChildren(result);

        result.IdentityProviderConfiguration ??= IdentityProviderConfigurationFactory?.Build();
    }

} // End Of Class

public static class WebExperienceFactoryExtensions
{
    public static CombinedResult<WebExperienceFactory, InnerWebExperienceIdentityProviderConfigurationFactory> WithIdentityProviderConfiguration(this WebExperienceFactory parentFactory, Action<Humidifier.QBusiness.WebExperienceTypes.IdentityProviderConfiguration> subFactoryAction = null)
    {
        parentFactory.IdentityProviderConfigurationFactory = new InnerWebExperienceIdentityProviderConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IdentityProviderConfigurationFactory);
    }

    public static CombinedResult<WebExperienceFactory, T1, InnerWebExperienceIdentityProviderConfigurationFactory> WithIdentityProviderConfiguration<T1>(this CombinedResult<WebExperienceFactory, T1> combinedResult, Action<Humidifier.QBusiness.WebExperienceTypes.IdentityProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdentityProviderConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WebExperienceFactory, InnerWebExperienceIdentityProviderConfigurationFactory> WithIdentityProviderConfiguration<T1>(this CombinedResult<T1, WebExperienceFactory> combinedResult, Action<Humidifier.QBusiness.WebExperienceTypes.IdentityProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdentityProviderConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<WebExperienceFactory, T1, T2, InnerWebExperienceIdentityProviderConfigurationFactory> WithIdentityProviderConfiguration<T1, T2>(this CombinedResult<WebExperienceFactory, T1, T2> combinedResult, Action<Humidifier.QBusiness.WebExperienceTypes.IdentityProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdentityProviderConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WebExperienceFactory, T2, InnerWebExperienceIdentityProviderConfigurationFactory> WithIdentityProviderConfiguration<T1, T2>(this CombinedResult<T1, WebExperienceFactory, T2> combinedResult, Action<Humidifier.QBusiness.WebExperienceTypes.IdentityProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdentityProviderConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WebExperienceFactory, InnerWebExperienceIdentityProviderConfigurationFactory> WithIdentityProviderConfiguration<T1, T2>(this CombinedResult<T1, T2, WebExperienceFactory> combinedResult, Action<Humidifier.QBusiness.WebExperienceTypes.IdentityProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdentityProviderConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<WebExperienceFactory, T1, T2, T3, InnerWebExperienceIdentityProviderConfigurationFactory> WithIdentityProviderConfiguration<T1, T2, T3>(this CombinedResult<WebExperienceFactory, T1, T2, T3> combinedResult, Action<Humidifier.QBusiness.WebExperienceTypes.IdentityProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityProviderConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WebExperienceFactory, T2, T3, InnerWebExperienceIdentityProviderConfigurationFactory> WithIdentityProviderConfiguration<T1, T2, T3>(this CombinedResult<T1, WebExperienceFactory, T2, T3> combinedResult, Action<Humidifier.QBusiness.WebExperienceTypes.IdentityProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityProviderConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WebExperienceFactory, T3, InnerWebExperienceIdentityProviderConfigurationFactory> WithIdentityProviderConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, WebExperienceFactory, T3> combinedResult, Action<Humidifier.QBusiness.WebExperienceTypes.IdentityProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityProviderConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, WebExperienceFactory, InnerWebExperienceIdentityProviderConfigurationFactory> WithIdentityProviderConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, WebExperienceFactory> combinedResult, Action<Humidifier.QBusiness.WebExperienceTypes.IdentityProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityProviderConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<WebExperienceFactory, T1, T2, T3, T4, InnerWebExperienceIdentityProviderConfigurationFactory> WithIdentityProviderConfiguration<T1, T2, T3, T4>(this CombinedResult<WebExperienceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QBusiness.WebExperienceTypes.IdentityProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityProviderConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, WebExperienceFactory, T2, T3, T4, InnerWebExperienceIdentityProviderConfigurationFactory> WithIdentityProviderConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, WebExperienceFactory, T2, T3, T4> combinedResult, Action<Humidifier.QBusiness.WebExperienceTypes.IdentityProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityProviderConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, WebExperienceFactory, T3, T4, InnerWebExperienceIdentityProviderConfigurationFactory> WithIdentityProviderConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, WebExperienceFactory, T3, T4> combinedResult, Action<Humidifier.QBusiness.WebExperienceTypes.IdentityProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityProviderConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, WebExperienceFactory, T4, InnerWebExperienceIdentityProviderConfigurationFactory> WithIdentityProviderConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, WebExperienceFactory, T4> combinedResult, Action<Humidifier.QBusiness.WebExperienceTypes.IdentityProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityProviderConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, WebExperienceFactory, InnerWebExperienceIdentityProviderConfigurationFactory> WithIdentityProviderConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, WebExperienceFactory> combinedResult, Action<Humidifier.QBusiness.WebExperienceTypes.IdentityProviderConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdentityProviderConfiguration(combinedResult.T5, subFactoryAction));
}
