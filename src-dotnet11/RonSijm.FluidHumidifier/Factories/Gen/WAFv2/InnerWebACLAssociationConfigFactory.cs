// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerWebACLAssociationConfigFactory(Action<Humidifier.WAFv2.WebACLTypes.AssociationConfig> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.WebACLTypes.AssociationConfig>
{

    protected override Humidifier.WAFv2.WebACLTypes.AssociationConfig Create()
    {
        var associationConfigResult = CreateAssociationConfig();
        factoryAction?.Invoke(associationConfigResult);

        return associationConfigResult;
    }

    private Humidifier.WAFv2.WebACLTypes.AssociationConfig CreateAssociationConfig()
    {
        var associationConfigResult = new Humidifier.WAFv2.WebACLTypes.AssociationConfig();

        return associationConfigResult;
    }

} // End Of Class

public static class InnerWebACLAssociationConfigFactoryExtensions
{
}
