// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppStream;

public class StackFleetAssociationFactory(string resourceName = null, Action<Humidifier.AppStream.StackFleetAssociation> factoryAction = null) : ResourceFactory<Humidifier.AppStream.StackFleetAssociation>(resourceName)
{

    protected override Humidifier.AppStream.StackFleetAssociation Create()
    {
        var stackFleetAssociationResult = CreateStackFleetAssociation();
        factoryAction?.Invoke(stackFleetAssociationResult);

        return stackFleetAssociationResult;
    }

    private Humidifier.AppStream.StackFleetAssociation CreateStackFleetAssociation()
    {
        var stackFleetAssociationResult = new Humidifier.AppStream.StackFleetAssociation
        {
            GivenName = InputResourceName,
        };

        return stackFleetAssociationResult;
    }

} // End Of Class

public static class StackFleetAssociationFactoryExtensions
{
}
