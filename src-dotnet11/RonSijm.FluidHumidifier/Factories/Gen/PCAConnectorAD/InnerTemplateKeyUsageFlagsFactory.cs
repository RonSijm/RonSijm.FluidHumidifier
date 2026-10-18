// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCAConnectorAD;

public class InnerTemplateKeyUsageFlagsFactory(Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageFlags> factoryAction = null) : SubResourceFactory<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageFlags>
{

    protected override Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageFlags Create()
    {
        var keyUsageFlagsResult = CreateKeyUsageFlags();
        factoryAction?.Invoke(keyUsageFlagsResult);

        return keyUsageFlagsResult;
    }

    private Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageFlags CreateKeyUsageFlags()
    {
        var keyUsageFlagsResult = new Humidifier.PCAConnectorAD.TemplateTypes.KeyUsageFlags();

        return keyUsageFlagsResult;
    }

} // End Of Class

public static class InnerTemplateKeyUsageFlagsFactoryExtensions
{
}
