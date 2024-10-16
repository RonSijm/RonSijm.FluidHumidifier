// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppStream;

public class StackUserAssociationFactory(string resourceName = null, Action<Humidifier.AppStream.StackUserAssociation> factoryAction = null) : ResourceFactory<Humidifier.AppStream.StackUserAssociation>(resourceName)
{

    protected override Humidifier.AppStream.StackUserAssociation Create()
    {
        var stackUserAssociationResult = CreateStackUserAssociation();
        factoryAction?.Invoke(stackUserAssociationResult);

        return stackUserAssociationResult;
    }

    private Humidifier.AppStream.StackUserAssociation CreateStackUserAssociation()
    {
        var stackUserAssociationResult = new Humidifier.AppStream.StackUserAssociation
        {
            GivenName = InputResourceName,
        };

        return stackUserAssociationResult;
    }

} // End Of Class

public static class StackUserAssociationFactoryExtensions
{
}
