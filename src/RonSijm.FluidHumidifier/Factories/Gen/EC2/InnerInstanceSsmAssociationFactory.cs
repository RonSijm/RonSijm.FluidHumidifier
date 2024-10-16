// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerInstanceSsmAssociationFactory(Action<Humidifier.EC2.InstanceTypes.SsmAssociation> factoryAction = null) : SubResourceFactory<Humidifier.EC2.InstanceTypes.SsmAssociation>
{

    protected override Humidifier.EC2.InstanceTypes.SsmAssociation Create()
    {
        var ssmAssociationResult = CreateSsmAssociation();
        factoryAction?.Invoke(ssmAssociationResult);

        return ssmAssociationResult;
    }

    private Humidifier.EC2.InstanceTypes.SsmAssociation CreateSsmAssociation()
    {
        var ssmAssociationResult = new Humidifier.EC2.InstanceTypes.SsmAssociation();

        return ssmAssociationResult;
    }

} // End Of Class

public static class InnerInstanceSsmAssociationFactoryExtensions
{
}
