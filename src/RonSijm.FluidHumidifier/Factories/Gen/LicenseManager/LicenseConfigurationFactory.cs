// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LicenseManager;

public class LicenseConfigurationFactory(string resourceName = null, Action<Humidifier.LicenseManager.LicenseConfiguration> factoryAction = null) : ResourceFactory<Humidifier.LicenseManager.LicenseConfiguration>(resourceName)
{

    internal List<InnerLicenseConfigurationProductInformationFactory> ProductInformationListFactories { get; set; } = [];

    protected override Humidifier.LicenseManager.LicenseConfiguration Create()
    {
        var licenseConfigurationResult = CreateLicenseConfiguration();
        factoryAction?.Invoke(licenseConfigurationResult);

        return licenseConfigurationResult;
    }

    private Humidifier.LicenseManager.LicenseConfiguration CreateLicenseConfiguration()
    {
        var licenseConfigurationResult = new Humidifier.LicenseManager.LicenseConfiguration
        {
            GivenName = InputResourceName,
        };

        return licenseConfigurationResult;
    }
    public override void CreateChildren(Humidifier.LicenseManager.LicenseConfiguration result)
    {
        base.CreateChildren(result);

        result.ProductInformationList = ProductInformationListFactories.Any() ? ProductInformationListFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class LicenseConfigurationFactoryExtensions
{
    public static CombinedResult<LicenseConfigurationFactory, InnerLicenseConfigurationProductInformationFactory> WithProductInformationList(this LicenseConfigurationFactory parentFactory, Action<Humidifier.LicenseManager.LicenseConfigurationTypes.ProductInformation> subFactoryAction = null)
    {
        var factory = new InnerLicenseConfigurationProductInformationFactory(subFactoryAction);
        parentFactory.ProductInformationListFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<LicenseConfigurationFactory, T1, InnerLicenseConfigurationProductInformationFactory> WithProductInformationList<T1>(this CombinedResult<LicenseConfigurationFactory, T1> combinedResult, Action<Humidifier.LicenseManager.LicenseConfigurationTypes.ProductInformation> subFactoryAction = null) => new (combinedResult, combinedResult, WithProductInformationList(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LicenseConfigurationFactory, InnerLicenseConfigurationProductInformationFactory> WithProductInformationList<T1>(this CombinedResult<T1, LicenseConfigurationFactory> combinedResult, Action<Humidifier.LicenseManager.LicenseConfigurationTypes.ProductInformation> subFactoryAction = null) => new (combinedResult, combinedResult, WithProductInformationList(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<LicenseConfigurationFactory, T1, T2, InnerLicenseConfigurationProductInformationFactory> WithProductInformationList<T1, T2>(this CombinedResult<LicenseConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.LicenseManager.LicenseConfigurationTypes.ProductInformation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProductInformationList(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LicenseConfigurationFactory, T2, InnerLicenseConfigurationProductInformationFactory> WithProductInformationList<T1, T2>(this CombinedResult<T1, LicenseConfigurationFactory, T2> combinedResult, Action<Humidifier.LicenseManager.LicenseConfigurationTypes.ProductInformation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProductInformationList(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LicenseConfigurationFactory, InnerLicenseConfigurationProductInformationFactory> WithProductInformationList<T1, T2>(this CombinedResult<T1, T2, LicenseConfigurationFactory> combinedResult, Action<Humidifier.LicenseManager.LicenseConfigurationTypes.ProductInformation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithProductInformationList(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<LicenseConfigurationFactory, T1, T2, T3, InnerLicenseConfigurationProductInformationFactory> WithProductInformationList<T1, T2, T3>(this CombinedResult<LicenseConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.LicenseManager.LicenseConfigurationTypes.ProductInformation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProductInformationList(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LicenseConfigurationFactory, T2, T3, InnerLicenseConfigurationProductInformationFactory> WithProductInformationList<T1, T2, T3>(this CombinedResult<T1, LicenseConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.LicenseManager.LicenseConfigurationTypes.ProductInformation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProductInformationList(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LicenseConfigurationFactory, T3, InnerLicenseConfigurationProductInformationFactory> WithProductInformationList<T1, T2, T3>(this CombinedResult<T1, T2, LicenseConfigurationFactory, T3> combinedResult, Action<Humidifier.LicenseManager.LicenseConfigurationTypes.ProductInformation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProductInformationList(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, LicenseConfigurationFactory, InnerLicenseConfigurationProductInformationFactory> WithProductInformationList<T1, T2, T3>(this CombinedResult<T1, T2, T3, LicenseConfigurationFactory> combinedResult, Action<Humidifier.LicenseManager.LicenseConfigurationTypes.ProductInformation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithProductInformationList(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<LicenseConfigurationFactory, T1, T2, T3, T4, InnerLicenseConfigurationProductInformationFactory> WithProductInformationList<T1, T2, T3, T4>(this CombinedResult<LicenseConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.LicenseManager.LicenseConfigurationTypes.ProductInformation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProductInformationList(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LicenseConfigurationFactory, T2, T3, T4, InnerLicenseConfigurationProductInformationFactory> WithProductInformationList<T1, T2, T3, T4>(this CombinedResult<T1, LicenseConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.LicenseManager.LicenseConfigurationTypes.ProductInformation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProductInformationList(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LicenseConfigurationFactory, T3, T4, InnerLicenseConfigurationProductInformationFactory> WithProductInformationList<T1, T2, T3, T4>(this CombinedResult<T1, T2, LicenseConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.LicenseManager.LicenseConfigurationTypes.ProductInformation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProductInformationList(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, LicenseConfigurationFactory, T4, InnerLicenseConfigurationProductInformationFactory> WithProductInformationList<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LicenseConfigurationFactory, T4> combinedResult, Action<Humidifier.LicenseManager.LicenseConfigurationTypes.ProductInformation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProductInformationList(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, LicenseConfigurationFactory, InnerLicenseConfigurationProductInformationFactory> WithProductInformationList<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LicenseConfigurationFactory> combinedResult, Action<Humidifier.LicenseManager.LicenseConfigurationTypes.ProductInformation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithProductInformationList(combinedResult.T5, subFactoryAction).T2);
}
