// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DRS;

public class LaunchConfigurationTemplateFactory(string resourceName = null, Action<Humidifier.DRS.LaunchConfigurationTemplate> factoryAction = null) : ResourceFactory<Humidifier.DRS.LaunchConfigurationTemplate>(resourceName)
{

    internal InnerLaunchConfigurationTemplateLicensingFactory LicensingFactory { get; set; }

    protected override Humidifier.DRS.LaunchConfigurationTemplate Create()
    {
        var launchConfigurationTemplateResult = CreateLaunchConfigurationTemplate();
        factoryAction?.Invoke(launchConfigurationTemplateResult);

        return launchConfigurationTemplateResult;
    }

    private Humidifier.DRS.LaunchConfigurationTemplate CreateLaunchConfigurationTemplate()
    {
        var launchConfigurationTemplateResult = new Humidifier.DRS.LaunchConfigurationTemplate
        {
            GivenName = InputResourceName,
        };

        return launchConfigurationTemplateResult;
    }
    public override void CreateChildren(Humidifier.DRS.LaunchConfigurationTemplate result)
    {
        base.CreateChildren(result);

        result.Licensing ??= LicensingFactory?.Build();
    }

} // End Of Class

public static class LaunchConfigurationTemplateFactoryExtensions
{
    public static CombinedResult<LaunchConfigurationTemplateFactory, InnerLaunchConfigurationTemplateLicensingFactory> WithLicensing(this LaunchConfigurationTemplateFactory parentFactory, Action<Humidifier.DRS.LaunchConfigurationTemplateTypes.Licensing> subFactoryAction = null)
    {
        parentFactory.LicensingFactory = new InnerLaunchConfigurationTemplateLicensingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LicensingFactory);
    }

    public static CombinedResult<LaunchConfigurationTemplateFactory, T1, InnerLaunchConfigurationTemplateLicensingFactory> WithLicensing<T1>(this CombinedResult<LaunchConfigurationTemplateFactory, T1> combinedResult, Action<Humidifier.DRS.LaunchConfigurationTemplateTypes.Licensing> subFactoryAction = null) => new (combinedResult, combinedResult, WithLicensing(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LaunchConfigurationTemplateFactory, InnerLaunchConfigurationTemplateLicensingFactory> WithLicensing<T1>(this CombinedResult<T1, LaunchConfigurationTemplateFactory> combinedResult, Action<Humidifier.DRS.LaunchConfigurationTemplateTypes.Licensing> subFactoryAction = null) => new (combinedResult, combinedResult, WithLicensing(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<LaunchConfigurationTemplateFactory, T1, T2, InnerLaunchConfigurationTemplateLicensingFactory> WithLicensing<T1, T2>(this CombinedResult<LaunchConfigurationTemplateFactory, T1, T2> combinedResult, Action<Humidifier.DRS.LaunchConfigurationTemplateTypes.Licensing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLicensing(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LaunchConfigurationTemplateFactory, T2, InnerLaunchConfigurationTemplateLicensingFactory> WithLicensing<T1, T2>(this CombinedResult<T1, LaunchConfigurationTemplateFactory, T2> combinedResult, Action<Humidifier.DRS.LaunchConfigurationTemplateTypes.Licensing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLicensing(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LaunchConfigurationTemplateFactory, InnerLaunchConfigurationTemplateLicensingFactory> WithLicensing<T1, T2>(this CombinedResult<T1, T2, LaunchConfigurationTemplateFactory> combinedResult, Action<Humidifier.DRS.LaunchConfigurationTemplateTypes.Licensing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLicensing(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<LaunchConfigurationTemplateFactory, T1, T2, T3, InnerLaunchConfigurationTemplateLicensingFactory> WithLicensing<T1, T2, T3>(this CombinedResult<LaunchConfigurationTemplateFactory, T1, T2, T3> combinedResult, Action<Humidifier.DRS.LaunchConfigurationTemplateTypes.Licensing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLicensing(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LaunchConfigurationTemplateFactory, T2, T3, InnerLaunchConfigurationTemplateLicensingFactory> WithLicensing<T1, T2, T3>(this CombinedResult<T1, LaunchConfigurationTemplateFactory, T2, T3> combinedResult, Action<Humidifier.DRS.LaunchConfigurationTemplateTypes.Licensing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLicensing(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LaunchConfigurationTemplateFactory, T3, InnerLaunchConfigurationTemplateLicensingFactory> WithLicensing<T1, T2, T3>(this CombinedResult<T1, T2, LaunchConfigurationTemplateFactory, T3> combinedResult, Action<Humidifier.DRS.LaunchConfigurationTemplateTypes.Licensing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLicensing(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, LaunchConfigurationTemplateFactory, InnerLaunchConfigurationTemplateLicensingFactory> WithLicensing<T1, T2, T3>(this CombinedResult<T1, T2, T3, LaunchConfigurationTemplateFactory> combinedResult, Action<Humidifier.DRS.LaunchConfigurationTemplateTypes.Licensing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLicensing(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<LaunchConfigurationTemplateFactory, T1, T2, T3, T4, InnerLaunchConfigurationTemplateLicensingFactory> WithLicensing<T1, T2, T3, T4>(this CombinedResult<LaunchConfigurationTemplateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DRS.LaunchConfigurationTemplateTypes.Licensing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLicensing(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LaunchConfigurationTemplateFactory, T2, T3, T4, InnerLaunchConfigurationTemplateLicensingFactory> WithLicensing<T1, T2, T3, T4>(this CombinedResult<T1, LaunchConfigurationTemplateFactory, T2, T3, T4> combinedResult, Action<Humidifier.DRS.LaunchConfigurationTemplateTypes.Licensing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLicensing(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LaunchConfigurationTemplateFactory, T3, T4, InnerLaunchConfigurationTemplateLicensingFactory> WithLicensing<T1, T2, T3, T4>(this CombinedResult<T1, T2, LaunchConfigurationTemplateFactory, T3, T4> combinedResult, Action<Humidifier.DRS.LaunchConfigurationTemplateTypes.Licensing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLicensing(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, LaunchConfigurationTemplateFactory, T4, InnerLaunchConfigurationTemplateLicensingFactory> WithLicensing<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LaunchConfigurationTemplateFactory, T4> combinedResult, Action<Humidifier.DRS.LaunchConfigurationTemplateTypes.Licensing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLicensing(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, LaunchConfigurationTemplateFactory, InnerLaunchConfigurationTemplateLicensingFactory> WithLicensing<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LaunchConfigurationTemplateFactory> combinedResult, Action<Humidifier.DRS.LaunchConfigurationTemplateTypes.Licensing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLicensing(combinedResult.T5, subFactoryAction).T2);
}
