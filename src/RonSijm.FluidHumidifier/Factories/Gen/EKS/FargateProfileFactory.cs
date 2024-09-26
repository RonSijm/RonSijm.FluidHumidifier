// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class FargateProfileFactory(string resourceName = null, Action<Humidifier.EKS.FargateProfile> factoryAction = null) : ResourceFactory<Humidifier.EKS.FargateProfile>(resourceName)
{

    internal List<InnerFargateProfileSelectorFactory> SelectorsFactories { get; set; } = [];

    protected override Humidifier.EKS.FargateProfile Create()
    {
        var fargateProfileResult = CreateFargateProfile();
        factoryAction?.Invoke(fargateProfileResult);

        return fargateProfileResult;
    }

    private Humidifier.EKS.FargateProfile CreateFargateProfile()
    {
        var fargateProfileResult = new Humidifier.EKS.FargateProfile
        {
            GivenName = InputResourceName,
        };

        return fargateProfileResult;
    }
    public override void CreateChildren(Humidifier.EKS.FargateProfile result)
    {
        base.CreateChildren(result);

        result.Selectors = SelectorsFactories.Any() ? SelectorsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class FargateProfileFactoryExtensions
{
    public static CombinedResult<FargateProfileFactory, InnerFargateProfileSelectorFactory> WithSelectors(this FargateProfileFactory parentFactory, Action<Humidifier.EKS.FargateProfileTypes.Selector> subFactoryAction = null)
    {
        var factory = new InnerFargateProfileSelectorFactory(subFactoryAction);
        parentFactory.SelectorsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<FargateProfileFactory, T1, InnerFargateProfileSelectorFactory> WithSelectors<T1>(this CombinedResult<FargateProfileFactory, T1> combinedResult, Action<Humidifier.EKS.FargateProfileTypes.Selector> subFactoryAction = null) => new (combinedResult, combinedResult, WithSelectors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FargateProfileFactory, InnerFargateProfileSelectorFactory> WithSelectors<T1>(this CombinedResult<T1, FargateProfileFactory> combinedResult, Action<Humidifier.EKS.FargateProfileTypes.Selector> subFactoryAction = null) => new (combinedResult, combinedResult, WithSelectors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<FargateProfileFactory, T1, T2, InnerFargateProfileSelectorFactory> WithSelectors<T1, T2>(this CombinedResult<FargateProfileFactory, T1, T2> combinedResult, Action<Humidifier.EKS.FargateProfileTypes.Selector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSelectors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FargateProfileFactory, T2, InnerFargateProfileSelectorFactory> WithSelectors<T1, T2>(this CombinedResult<T1, FargateProfileFactory, T2> combinedResult, Action<Humidifier.EKS.FargateProfileTypes.Selector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSelectors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FargateProfileFactory, InnerFargateProfileSelectorFactory> WithSelectors<T1, T2>(this CombinedResult<T1, T2, FargateProfileFactory> combinedResult, Action<Humidifier.EKS.FargateProfileTypes.Selector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSelectors(combinedResult.T3, subFactoryAction));
    public static CombinedResult<FargateProfileFactory, T1, T2, T3, InnerFargateProfileSelectorFactory> WithSelectors<T1, T2, T3>(this CombinedResult<FargateProfileFactory, T1, T2, T3> combinedResult, Action<Humidifier.EKS.FargateProfileTypes.Selector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSelectors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FargateProfileFactory, T2, T3, InnerFargateProfileSelectorFactory> WithSelectors<T1, T2, T3>(this CombinedResult<T1, FargateProfileFactory, T2, T3> combinedResult, Action<Humidifier.EKS.FargateProfileTypes.Selector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSelectors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FargateProfileFactory, T3, InnerFargateProfileSelectorFactory> WithSelectors<T1, T2, T3>(this CombinedResult<T1, T2, FargateProfileFactory, T3> combinedResult, Action<Humidifier.EKS.FargateProfileTypes.Selector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSelectors(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FargateProfileFactory, InnerFargateProfileSelectorFactory> WithSelectors<T1, T2, T3>(this CombinedResult<T1, T2, T3, FargateProfileFactory> combinedResult, Action<Humidifier.EKS.FargateProfileTypes.Selector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSelectors(combinedResult.T4, subFactoryAction));
    public static CombinedResult<FargateProfileFactory, T1, T2, T3, T4, InnerFargateProfileSelectorFactory> WithSelectors<T1, T2, T3, T4>(this CombinedResult<FargateProfileFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EKS.FargateProfileTypes.Selector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSelectors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FargateProfileFactory, T2, T3, T4, InnerFargateProfileSelectorFactory> WithSelectors<T1, T2, T3, T4>(this CombinedResult<T1, FargateProfileFactory, T2, T3, T4> combinedResult, Action<Humidifier.EKS.FargateProfileTypes.Selector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSelectors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FargateProfileFactory, T3, T4, InnerFargateProfileSelectorFactory> WithSelectors<T1, T2, T3, T4>(this CombinedResult<T1, T2, FargateProfileFactory, T3, T4> combinedResult, Action<Humidifier.EKS.FargateProfileTypes.Selector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSelectors(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FargateProfileFactory, T4, InnerFargateProfileSelectorFactory> WithSelectors<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FargateProfileFactory, T4> combinedResult, Action<Humidifier.EKS.FargateProfileTypes.Selector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSelectors(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, FargateProfileFactory, InnerFargateProfileSelectorFactory> WithSelectors<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FargateProfileFactory> combinedResult, Action<Humidifier.EKS.FargateProfileTypes.Selector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSelectors(combinedResult.T5, subFactoryAction));
}
