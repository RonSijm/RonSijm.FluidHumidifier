// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RAM;

public class PrincipalAssociationFactory(string resourceName = null, Action<Humidifier.RAM.PrincipalAssociation> factoryAction = null) : ResourceFactory<Humidifier.RAM.PrincipalAssociation>(resourceName)
{

    protected override Humidifier.RAM.PrincipalAssociation Create()
    {
        var principalAssociationResult = CreatePrincipalAssociation();
        factoryAction?.Invoke(principalAssociationResult);

        return principalAssociationResult;
    }

    private Humidifier.RAM.PrincipalAssociation CreatePrincipalAssociation()
    {
        var principalAssociationResult = new Humidifier.RAM.PrincipalAssociation
        {
            GivenName = InputResourceName,
        };

        return principalAssociationResult;
    }

} // End Of Class

public static class PrincipalAssociationFactoryExtensions
{
}
