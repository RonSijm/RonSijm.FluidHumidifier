// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerWebACLVisibilityConfigFactory(Action<Humidifier.WAFv2.WebACLTypes.VisibilityConfig> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.WebACLTypes.VisibilityConfig>
{

    protected override Humidifier.WAFv2.WebACLTypes.VisibilityConfig Create()
    {
        var visibilityConfigResult = CreateVisibilityConfig();
        factoryAction?.Invoke(visibilityConfigResult);

        return visibilityConfigResult;
    }

    private Humidifier.WAFv2.WebACLTypes.VisibilityConfig CreateVisibilityConfig()
    {
        var visibilityConfigResult = new Humidifier.WAFv2.WebACLTypes.VisibilityConfig();

        return visibilityConfigResult;
    }

} // End Of Class

public static class InnerWebACLVisibilityConfigFactoryExtensions
{
}
