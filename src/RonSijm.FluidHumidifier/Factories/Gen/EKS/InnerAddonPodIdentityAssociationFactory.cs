// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerAddonPodIdentityAssociationFactory(Action<Humidifier.EKS.AddonTypes.PodIdentityAssociation> factoryAction = null) : SubResourceFactory<Humidifier.EKS.AddonTypes.PodIdentityAssociation>
{

    protected override Humidifier.EKS.AddonTypes.PodIdentityAssociation Create()
    {
        var podIdentityAssociationResult = CreatePodIdentityAssociation();
        factoryAction?.Invoke(podIdentityAssociationResult);

        return podIdentityAssociationResult;
    }

    private Humidifier.EKS.AddonTypes.PodIdentityAssociation CreatePodIdentityAssociation()
    {
        var podIdentityAssociationResult = new Humidifier.EKS.AddonTypes.PodIdentityAssociation();

        return podIdentityAssociationResult;
    }

} // End Of Class

public static class InnerAddonPodIdentityAssociationFactoryExtensions
{
}
