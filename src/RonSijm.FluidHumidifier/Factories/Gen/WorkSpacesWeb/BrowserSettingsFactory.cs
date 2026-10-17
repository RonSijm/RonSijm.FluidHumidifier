// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkSpacesWeb;

public class BrowserSettingsFactory(string resourceName = null, Action<Humidifier.WorkSpacesWeb.BrowserSettings> factoryAction = null) : ResourceFactory<Humidifier.WorkSpacesWeb.BrowserSettings>(resourceName)
{

    internal InnerBrowserSettingsWebContentFilteringPolicyFactory WebContentFilteringPolicyFactory { get; set; }

    protected override Humidifier.WorkSpacesWeb.BrowserSettings Create()
    {
        var browserSettingsResult = CreateBrowserSettings();
        factoryAction?.Invoke(browserSettingsResult);

        return browserSettingsResult;
    }

    private Humidifier.WorkSpacesWeb.BrowserSettings CreateBrowserSettings()
    {
        var browserSettingsResult = new Humidifier.WorkSpacesWeb.BrowserSettings
        {
            GivenName = InputResourceName,
        };

        return browserSettingsResult;
    }
    public override void CreateChildren(Humidifier.WorkSpacesWeb.BrowserSettings result)
    {
        base.CreateChildren(result);

        result.WebContentFilteringPolicy ??= WebContentFilteringPolicyFactory?.Build();
    }

} // End Of Class

public static class BrowserSettingsFactoryExtensions
{
    public static CombinedResult<BrowserSettingsFactory, InnerBrowserSettingsWebContentFilteringPolicyFactory> WithWebContentFilteringPolicy(this BrowserSettingsFactory parentFactory, Action<Humidifier.WorkSpacesWeb.BrowserSettingsTypes.WebContentFilteringPolicy> subFactoryAction = null)
    {
        parentFactory.WebContentFilteringPolicyFactory = new InnerBrowserSettingsWebContentFilteringPolicyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.WebContentFilteringPolicyFactory);
    }

    public static CombinedResult<BrowserSettingsFactory, T1, InnerBrowserSettingsWebContentFilteringPolicyFactory> WithWebContentFilteringPolicy<T1>(this CombinedResult<BrowserSettingsFactory, T1> combinedResult, Action<Humidifier.WorkSpacesWeb.BrowserSettingsTypes.WebContentFilteringPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithWebContentFilteringPolicy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, BrowserSettingsFactory, InnerBrowserSettingsWebContentFilteringPolicyFactory> WithWebContentFilteringPolicy<T1>(this CombinedResult<T1, BrowserSettingsFactory> combinedResult, Action<Humidifier.WorkSpacesWeb.BrowserSettingsTypes.WebContentFilteringPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, WithWebContentFilteringPolicy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<BrowserSettingsFactory, T1, T2, InnerBrowserSettingsWebContentFilteringPolicyFactory> WithWebContentFilteringPolicy<T1, T2>(this CombinedResult<BrowserSettingsFactory, T1, T2> combinedResult, Action<Humidifier.WorkSpacesWeb.BrowserSettingsTypes.WebContentFilteringPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWebContentFilteringPolicy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, BrowserSettingsFactory, T2, InnerBrowserSettingsWebContentFilteringPolicyFactory> WithWebContentFilteringPolicy<T1, T2>(this CombinedResult<T1, BrowserSettingsFactory, T2> combinedResult, Action<Humidifier.WorkSpacesWeb.BrowserSettingsTypes.WebContentFilteringPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWebContentFilteringPolicy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, BrowserSettingsFactory, InnerBrowserSettingsWebContentFilteringPolicyFactory> WithWebContentFilteringPolicy<T1, T2>(this CombinedResult<T1, T2, BrowserSettingsFactory> combinedResult, Action<Humidifier.WorkSpacesWeb.BrowserSettingsTypes.WebContentFilteringPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWebContentFilteringPolicy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<BrowserSettingsFactory, T1, T2, T3, InnerBrowserSettingsWebContentFilteringPolicyFactory> WithWebContentFilteringPolicy<T1, T2, T3>(this CombinedResult<BrowserSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.WorkSpacesWeb.BrowserSettingsTypes.WebContentFilteringPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWebContentFilteringPolicy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, BrowserSettingsFactory, T2, T3, InnerBrowserSettingsWebContentFilteringPolicyFactory> WithWebContentFilteringPolicy<T1, T2, T3>(this CombinedResult<T1, BrowserSettingsFactory, T2, T3> combinedResult, Action<Humidifier.WorkSpacesWeb.BrowserSettingsTypes.WebContentFilteringPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWebContentFilteringPolicy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, BrowserSettingsFactory, T3, InnerBrowserSettingsWebContentFilteringPolicyFactory> WithWebContentFilteringPolicy<T1, T2, T3>(this CombinedResult<T1, T2, BrowserSettingsFactory, T3> combinedResult, Action<Humidifier.WorkSpacesWeb.BrowserSettingsTypes.WebContentFilteringPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWebContentFilteringPolicy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, BrowserSettingsFactory, InnerBrowserSettingsWebContentFilteringPolicyFactory> WithWebContentFilteringPolicy<T1, T2, T3>(this CombinedResult<T1, T2, T3, BrowserSettingsFactory> combinedResult, Action<Humidifier.WorkSpacesWeb.BrowserSettingsTypes.WebContentFilteringPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWebContentFilteringPolicy(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<BrowserSettingsFactory, T1, T2, T3, T4, InnerBrowserSettingsWebContentFilteringPolicyFactory> WithWebContentFilteringPolicy<T1, T2, T3, T4>(this CombinedResult<BrowserSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WorkSpacesWeb.BrowserSettingsTypes.WebContentFilteringPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWebContentFilteringPolicy(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, BrowserSettingsFactory, T2, T3, T4, InnerBrowserSettingsWebContentFilteringPolicyFactory> WithWebContentFilteringPolicy<T1, T2, T3, T4>(this CombinedResult<T1, BrowserSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.WorkSpacesWeb.BrowserSettingsTypes.WebContentFilteringPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWebContentFilteringPolicy(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, BrowserSettingsFactory, T3, T4, InnerBrowserSettingsWebContentFilteringPolicyFactory> WithWebContentFilteringPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, BrowserSettingsFactory, T3, T4> combinedResult, Action<Humidifier.WorkSpacesWeb.BrowserSettingsTypes.WebContentFilteringPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWebContentFilteringPolicy(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, BrowserSettingsFactory, T4, InnerBrowserSettingsWebContentFilteringPolicyFactory> WithWebContentFilteringPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, BrowserSettingsFactory, T4> combinedResult, Action<Humidifier.WorkSpacesWeb.BrowserSettingsTypes.WebContentFilteringPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWebContentFilteringPolicy(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, BrowserSettingsFactory, InnerBrowserSettingsWebContentFilteringPolicyFactory> WithWebContentFilteringPolicy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, BrowserSettingsFactory> combinedResult, Action<Humidifier.WorkSpacesWeb.BrowserSettingsTypes.WebContentFilteringPolicy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWebContentFilteringPolicy(combinedResult.T5, subFactoryAction).T2);
}
