// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RolesAnywhere;

public class InnerProfileAttributeMappingFactory(Action<Humidifier.RolesAnywhere.ProfileTypes.AttributeMapping> factoryAction = null) : SubResourceFactory<Humidifier.RolesAnywhere.ProfileTypes.AttributeMapping>
{

    protected override Humidifier.RolesAnywhere.ProfileTypes.AttributeMapping Create()
    {
        var attributeMappingResult = CreateAttributeMapping();
        factoryAction?.Invoke(attributeMappingResult);

        return attributeMappingResult;
    }

    private Humidifier.RolesAnywhere.ProfileTypes.AttributeMapping CreateAttributeMapping()
    {
        var attributeMappingResult = new Humidifier.RolesAnywhere.ProfileTypes.AttributeMapping();

        return attributeMappingResult;
    }

} // End Of Class

public static class InnerProfileAttributeMappingFactoryExtensions
{
}
