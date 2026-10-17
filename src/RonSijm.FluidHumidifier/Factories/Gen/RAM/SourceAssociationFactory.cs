// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RAM;

public class SourceAssociationFactory(string resourceName = null, Action<Humidifier.RAM.SourceAssociation> factoryAction = null) : ResourceFactory<Humidifier.RAM.SourceAssociation>(resourceName)
{

    protected override Humidifier.RAM.SourceAssociation Create()
    {
        var sourceAssociationResult = CreateSourceAssociation();
        factoryAction?.Invoke(sourceAssociationResult);

        return sourceAssociationResult;
    }

    private Humidifier.RAM.SourceAssociation CreateSourceAssociation()
    {
        var sourceAssociationResult = new Humidifier.RAM.SourceAssociation
        {
            GivenName = InputResourceName,
        };

        return sourceAssociationResult;
    }

} // End Of Class

public static class SourceAssociationFactoryExtensions
{
}
