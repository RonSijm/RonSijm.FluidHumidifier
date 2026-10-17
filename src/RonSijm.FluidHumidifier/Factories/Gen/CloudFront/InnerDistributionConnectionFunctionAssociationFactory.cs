// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerDistributionConnectionFunctionAssociationFactory(Action<Humidifier.CloudFront.DistributionTypes.ConnectionFunctionAssociation> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.DistributionTypes.ConnectionFunctionAssociation>
{

    protected override Humidifier.CloudFront.DistributionTypes.ConnectionFunctionAssociation Create()
    {
        var connectionFunctionAssociationResult = CreateConnectionFunctionAssociation();
        factoryAction?.Invoke(connectionFunctionAssociationResult);

        return connectionFunctionAssociationResult;
    }

    private Humidifier.CloudFront.DistributionTypes.ConnectionFunctionAssociation CreateConnectionFunctionAssociation()
    {
        var connectionFunctionAssociationResult = new Humidifier.CloudFront.DistributionTypes.ConnectionFunctionAssociation();

        return connectionFunctionAssociationResult;
    }

} // End Of Class

public static class InnerDistributionConnectionFunctionAssociationFactoryExtensions
{
}
