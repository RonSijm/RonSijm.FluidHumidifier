// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class AddonFactory(string resourceName = null, Action<Humidifier.EKS.Addon> factoryAction = null) : ResourceFactory<Humidifier.EKS.Addon>(resourceName)
{

    internal List<InnerAddonPodIdentityAssociationFactory> PodIdentityAssociationsFactories { get; set; } = [];

    protected override Humidifier.EKS.Addon Create()
    {
        var addonResult = CreateAddon();
        factoryAction?.Invoke(addonResult);

        return addonResult;
    }

    private Humidifier.EKS.Addon CreateAddon()
    {
        var addonResult = new Humidifier.EKS.Addon
        {
            GivenName = InputResourceName,
        };

        return addonResult;
    }
    public override void CreateChildren(Humidifier.EKS.Addon result)
    {
        base.CreateChildren(result);

        result.PodIdentityAssociations = PodIdentityAssociationsFactories.Any() ? PodIdentityAssociationsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class AddonFactoryExtensions
{
    public static CombinedResult<AddonFactory, InnerAddonPodIdentityAssociationFactory> WithPodIdentityAssociations(this AddonFactory parentFactory, Action<Humidifier.EKS.AddonTypes.PodIdentityAssociation> subFactoryAction = null)
    {
        var factory = new InnerAddonPodIdentityAssociationFactory(subFactoryAction);
        parentFactory.PodIdentityAssociationsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<AddonFactory, T1, InnerAddonPodIdentityAssociationFactory> WithPodIdentityAssociations<T1>(this CombinedResult<AddonFactory, T1> combinedResult, Action<Humidifier.EKS.AddonTypes.PodIdentityAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, WithPodIdentityAssociations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AddonFactory, InnerAddonPodIdentityAssociationFactory> WithPodIdentityAssociations<T1>(this CombinedResult<T1, AddonFactory> combinedResult, Action<Humidifier.EKS.AddonTypes.PodIdentityAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, WithPodIdentityAssociations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AddonFactory, T1, T2, InnerAddonPodIdentityAssociationFactory> WithPodIdentityAssociations<T1, T2>(this CombinedResult<AddonFactory, T1, T2> combinedResult, Action<Humidifier.EKS.AddonTypes.PodIdentityAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPodIdentityAssociations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AddonFactory, T2, InnerAddonPodIdentityAssociationFactory> WithPodIdentityAssociations<T1, T2>(this CombinedResult<T1, AddonFactory, T2> combinedResult, Action<Humidifier.EKS.AddonTypes.PodIdentityAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPodIdentityAssociations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AddonFactory, InnerAddonPodIdentityAssociationFactory> WithPodIdentityAssociations<T1, T2>(this CombinedResult<T1, T2, AddonFactory> combinedResult, Action<Humidifier.EKS.AddonTypes.PodIdentityAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPodIdentityAssociations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AddonFactory, T1, T2, T3, InnerAddonPodIdentityAssociationFactory> WithPodIdentityAssociations<T1, T2, T3>(this CombinedResult<AddonFactory, T1, T2, T3> combinedResult, Action<Humidifier.EKS.AddonTypes.PodIdentityAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPodIdentityAssociations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AddonFactory, T2, T3, InnerAddonPodIdentityAssociationFactory> WithPodIdentityAssociations<T1, T2, T3>(this CombinedResult<T1, AddonFactory, T2, T3> combinedResult, Action<Humidifier.EKS.AddonTypes.PodIdentityAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPodIdentityAssociations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AddonFactory, T3, InnerAddonPodIdentityAssociationFactory> WithPodIdentityAssociations<T1, T2, T3>(this CombinedResult<T1, T2, AddonFactory, T3> combinedResult, Action<Humidifier.EKS.AddonTypes.PodIdentityAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPodIdentityAssociations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AddonFactory, InnerAddonPodIdentityAssociationFactory> WithPodIdentityAssociations<T1, T2, T3>(this CombinedResult<T1, T2, T3, AddonFactory> combinedResult, Action<Humidifier.EKS.AddonTypes.PodIdentityAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPodIdentityAssociations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AddonFactory, T1, T2, T3, T4, InnerAddonPodIdentityAssociationFactory> WithPodIdentityAssociations<T1, T2, T3, T4>(this CombinedResult<AddonFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EKS.AddonTypes.PodIdentityAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPodIdentityAssociations(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AddonFactory, T2, T3, T4, InnerAddonPodIdentityAssociationFactory> WithPodIdentityAssociations<T1, T2, T3, T4>(this CombinedResult<T1, AddonFactory, T2, T3, T4> combinedResult, Action<Humidifier.EKS.AddonTypes.PodIdentityAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPodIdentityAssociations(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AddonFactory, T3, T4, InnerAddonPodIdentityAssociationFactory> WithPodIdentityAssociations<T1, T2, T3, T4>(this CombinedResult<T1, T2, AddonFactory, T3, T4> combinedResult, Action<Humidifier.EKS.AddonTypes.PodIdentityAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPodIdentityAssociations(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AddonFactory, T4, InnerAddonPodIdentityAssociationFactory> WithPodIdentityAssociations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AddonFactory, T4> combinedResult, Action<Humidifier.EKS.AddonTypes.PodIdentityAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPodIdentityAssociations(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AddonFactory, InnerAddonPodIdentityAssociationFactory> WithPodIdentityAssociations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AddonFactory> combinedResult, Action<Humidifier.EKS.AddonTypes.PodIdentityAssociation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPodIdentityAssociations(combinedResult.T5, subFactoryAction));
}
