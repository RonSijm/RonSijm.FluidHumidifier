// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerWebACLDataProtectionConfigFactory(Action<Humidifier.WAFv2.WebACLTypes.DataProtectionConfig> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.WebACLTypes.DataProtectionConfig>
{

    protected override Humidifier.WAFv2.WebACLTypes.DataProtectionConfig Create()
    {
        var dataProtectionConfigResult = CreateDataProtectionConfig();
        factoryAction?.Invoke(dataProtectionConfigResult);

        return dataProtectionConfigResult;
    }

    private Humidifier.WAFv2.WebACLTypes.DataProtectionConfig CreateDataProtectionConfig()
    {
        var dataProtectionConfigResult = new Humidifier.WAFv2.WebACLTypes.DataProtectionConfig();

        return dataProtectionConfigResult;
    }

} // End Of Class

public static class InnerWebACLDataProtectionConfigFactoryExtensions
{
}
