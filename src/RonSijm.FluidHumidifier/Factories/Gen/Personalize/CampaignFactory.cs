// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Personalize;

public class CampaignFactory(string resourceName = null, Action<Humidifier.Personalize.Campaign> factoryAction = null) : ResourceFactory<Humidifier.Personalize.Campaign>(resourceName)
{

    internal InnerCampaignCampaignConfigFactory CampaignConfigFactory { get; set; }

    protected override Humidifier.Personalize.Campaign Create()
    {
        var campaignResult = CreateCampaign();
        factoryAction?.Invoke(campaignResult);

        return campaignResult;
    }

    private Humidifier.Personalize.Campaign CreateCampaign()
    {
        var campaignResult = new Humidifier.Personalize.Campaign
        {
            GivenName = InputResourceName,
        };

        return campaignResult;
    }
    public override void CreateChildren(Humidifier.Personalize.Campaign result)
    {
        base.CreateChildren(result);

        result.CampaignConfig ??= CampaignConfigFactory?.Build();
    }

} // End Of Class

public static class CampaignFactoryExtensions
{
    public static CombinedResult<CampaignFactory, InnerCampaignCampaignConfigFactory> WithCampaignConfig(this CampaignFactory parentFactory, Action<Humidifier.Personalize.CampaignTypes.CampaignConfig> subFactoryAction = null)
    {
        parentFactory.CampaignConfigFactory = new InnerCampaignCampaignConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CampaignConfigFactory);
    }

    public static CombinedResult<CampaignFactory, T1, InnerCampaignCampaignConfigFactory> WithCampaignConfig<T1>(this CombinedResult<CampaignFactory, T1> combinedResult, Action<Humidifier.Personalize.CampaignTypes.CampaignConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithCampaignConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CampaignFactory, InnerCampaignCampaignConfigFactory> WithCampaignConfig<T1>(this CombinedResult<T1, CampaignFactory> combinedResult, Action<Humidifier.Personalize.CampaignTypes.CampaignConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithCampaignConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<CampaignFactory, T1, T2, InnerCampaignCampaignConfigFactory> WithCampaignConfig<T1, T2>(this CombinedResult<CampaignFactory, T1, T2> combinedResult, Action<Humidifier.Personalize.CampaignTypes.CampaignConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCampaignConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CampaignFactory, T2, InnerCampaignCampaignConfigFactory> WithCampaignConfig<T1, T2>(this CombinedResult<T1, CampaignFactory, T2> combinedResult, Action<Humidifier.Personalize.CampaignTypes.CampaignConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCampaignConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CampaignFactory, InnerCampaignCampaignConfigFactory> WithCampaignConfig<T1, T2>(this CombinedResult<T1, T2, CampaignFactory> combinedResult, Action<Humidifier.Personalize.CampaignTypes.CampaignConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCampaignConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<CampaignFactory, T1, T2, T3, InnerCampaignCampaignConfigFactory> WithCampaignConfig<T1, T2, T3>(this CombinedResult<CampaignFactory, T1, T2, T3> combinedResult, Action<Humidifier.Personalize.CampaignTypes.CampaignConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCampaignConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CampaignFactory, T2, T3, InnerCampaignCampaignConfigFactory> WithCampaignConfig<T1, T2, T3>(this CombinedResult<T1, CampaignFactory, T2, T3> combinedResult, Action<Humidifier.Personalize.CampaignTypes.CampaignConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCampaignConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CampaignFactory, T3, InnerCampaignCampaignConfigFactory> WithCampaignConfig<T1, T2, T3>(this CombinedResult<T1, T2, CampaignFactory, T3> combinedResult, Action<Humidifier.Personalize.CampaignTypes.CampaignConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCampaignConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CampaignFactory, InnerCampaignCampaignConfigFactory> WithCampaignConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, CampaignFactory> combinedResult, Action<Humidifier.Personalize.CampaignTypes.CampaignConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCampaignConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<CampaignFactory, T1, T2, T3, T4, InnerCampaignCampaignConfigFactory> WithCampaignConfig<T1, T2, T3, T4>(this CombinedResult<CampaignFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Personalize.CampaignTypes.CampaignConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCampaignConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CampaignFactory, T2, T3, T4, InnerCampaignCampaignConfigFactory> WithCampaignConfig<T1, T2, T3, T4>(this CombinedResult<T1, CampaignFactory, T2, T3, T4> combinedResult, Action<Humidifier.Personalize.CampaignTypes.CampaignConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCampaignConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CampaignFactory, T3, T4, InnerCampaignCampaignConfigFactory> WithCampaignConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, CampaignFactory, T3, T4> combinedResult, Action<Humidifier.Personalize.CampaignTypes.CampaignConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCampaignConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CampaignFactory, T4, InnerCampaignCampaignConfigFactory> WithCampaignConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CampaignFactory, T4> combinedResult, Action<Humidifier.Personalize.CampaignTypes.CampaignConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCampaignConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, CampaignFactory, InnerCampaignCampaignConfigFactory> WithCampaignConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CampaignFactory> combinedResult, Action<Humidifier.Personalize.CampaignTypes.CampaignConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCampaignConfig(combinedResult.T5, subFactoryAction).T2);
}
