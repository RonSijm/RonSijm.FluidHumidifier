// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class PodIdentityAssociationFactory(string resourceName = null, Action<Humidifier.EKS.PodIdentityAssociation> factoryAction = null) : ResourceFactory<Humidifier.EKS.PodIdentityAssociation>(resourceName)
{

    protected override Humidifier.EKS.PodIdentityAssociation Create()
    {
        var podIdentityAssociationResult = CreatePodIdentityAssociation();
        factoryAction?.Invoke(podIdentityAssociationResult);

        return podIdentityAssociationResult;
    }

    private Humidifier.EKS.PodIdentityAssociation CreatePodIdentityAssociation()
    {
        var podIdentityAssociationResult = new Humidifier.EKS.PodIdentityAssociation
        {
            GivenName = InputResourceName,
        };

        return podIdentityAssociationResult;
    }

} // End Of Class

public static class PodIdentityAssociationFactoryExtensions
{
}
