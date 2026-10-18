// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SES;

public class InnerTenantResourceAssociationFactory(Action<Humidifier.SES.TenantTypes.ResourceAssociation> factoryAction = null) : SubResourceFactory<Humidifier.SES.TenantTypes.ResourceAssociation>
{

    protected override Humidifier.SES.TenantTypes.ResourceAssociation Create()
    {
        var resourceAssociationResult = CreateResourceAssociation();
        factoryAction?.Invoke(resourceAssociationResult);

        return resourceAssociationResult;
    }

    private Humidifier.SES.TenantTypes.ResourceAssociation CreateResourceAssociation()
    {
        var resourceAssociationResult = new Humidifier.SES.TenantTypes.ResourceAssociation();

        return resourceAssociationResult;
    }

} // End Of Class

public static class InnerTenantResourceAssociationFactoryExtensions
{
}
