// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerWebACLApplicationConfigFactory(Action<Humidifier.WAFv2.WebACLTypes.ApplicationConfig> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.WebACLTypes.ApplicationConfig>
{

    protected override Humidifier.WAFv2.WebACLTypes.ApplicationConfig Create()
    {
        var applicationConfigResult = CreateApplicationConfig();
        factoryAction?.Invoke(applicationConfigResult);

        return applicationConfigResult;
    }

    private Humidifier.WAFv2.WebACLTypes.ApplicationConfig CreateApplicationConfig()
    {
        var applicationConfigResult = new Humidifier.WAFv2.WebACLTypes.ApplicationConfig();

        return applicationConfigResult;
    }

} // End Of Class

public static class InnerWebACLApplicationConfigFactoryExtensions
{
}
