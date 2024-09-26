// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCAConnectorAD;

public class InnerTemplateKeyUsagePropertyFlagsFactory(Action<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsagePropertyFlags> factoryAction = null) : SubResourceFactory<Humidifier.PCAConnectorAD.TemplateTypes.KeyUsagePropertyFlags>
{

    protected override Humidifier.PCAConnectorAD.TemplateTypes.KeyUsagePropertyFlags Create()
    {
        var keyUsagePropertyFlagsResult = CreateKeyUsagePropertyFlags();
        factoryAction?.Invoke(keyUsagePropertyFlagsResult);

        return keyUsagePropertyFlagsResult;
    }

    private Humidifier.PCAConnectorAD.TemplateTypes.KeyUsagePropertyFlags CreateKeyUsagePropertyFlags()
    {
        var keyUsagePropertyFlagsResult = new Humidifier.PCAConnectorAD.TemplateTypes.KeyUsagePropertyFlags();

        return keyUsagePropertyFlagsResult;
    }

} // End Of Class

public static class InnerTemplateKeyUsagePropertyFlagsFactoryExtensions
{
}
