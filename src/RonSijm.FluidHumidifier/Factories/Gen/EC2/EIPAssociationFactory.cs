// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class EIPAssociationFactory(string resourceName = null, Action<Humidifier.EC2.EIPAssociation> factoryAction = null) : ResourceFactory<Humidifier.EC2.EIPAssociation>(resourceName)
{

    protected override Humidifier.EC2.EIPAssociation Create()
    {
        var eIPAssociationResult = CreateEIPAssociation();
        factoryAction?.Invoke(eIPAssociationResult);

        return eIPAssociationResult;
    }

    private Humidifier.EC2.EIPAssociation CreateEIPAssociation()
    {
        var eIPAssociationResult = new Humidifier.EC2.EIPAssociation
        {
            GivenName = InputResourceName,
        };

        return eIPAssociationResult;
    }

} // End Of Class

public static class EIPAssociationFactoryExtensions
{
}
