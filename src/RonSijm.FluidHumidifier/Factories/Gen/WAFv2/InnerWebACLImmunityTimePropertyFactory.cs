// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerWebACLImmunityTimePropertyFactory(Action<Humidifier.WAFv2.WebACLTypes.ImmunityTimeProperty> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.WebACLTypes.ImmunityTimeProperty>
{

    protected override Humidifier.WAFv2.WebACLTypes.ImmunityTimeProperty Create()
    {
        var immunityTimePropertyResult = CreateImmunityTimeProperty();
        factoryAction?.Invoke(immunityTimePropertyResult);

        return immunityTimePropertyResult;
    }

    private Humidifier.WAFv2.WebACLTypes.ImmunityTimeProperty CreateImmunityTimeProperty()
    {
        var immunityTimePropertyResult = new Humidifier.WAFv2.WebACLTypes.ImmunityTimeProperty();

        return immunityTimePropertyResult;
    }

} // End Of Class

public static class InnerWebACLImmunityTimePropertyFactoryExtensions
{
}
