// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkspacesInstances;

public class VolumeAssociationFactory(string resourceName = null, Action<Humidifier.WorkspacesInstances.VolumeAssociation> factoryAction = null) : ResourceFactory<Humidifier.WorkspacesInstances.VolumeAssociation>(resourceName)
{

    protected override Humidifier.WorkspacesInstances.VolumeAssociation Create()
    {
        var volumeAssociationResult = CreateVolumeAssociation();
        factoryAction?.Invoke(volumeAssociationResult);

        return volumeAssociationResult;
    }

    private Humidifier.WorkspacesInstances.VolumeAssociation CreateVolumeAssociation()
    {
        var volumeAssociationResult = new Humidifier.WorkspacesInstances.VolumeAssociation
        {
            GivenName = InputResourceName,
        };

        return volumeAssociationResult;
    }

} // End Of Class

public static class VolumeAssociationFactoryExtensions
{
}
