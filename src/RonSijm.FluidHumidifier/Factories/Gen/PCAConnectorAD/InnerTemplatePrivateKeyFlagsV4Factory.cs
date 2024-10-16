// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCAConnectorAD;

public class InnerTemplatePrivateKeyFlagsV4Factory(Action<Humidifier.PCAConnectorAD.TemplateTypes.PrivateKeyFlagsV4> factoryAction = null) : SubResourceFactory<Humidifier.PCAConnectorAD.TemplateTypes.PrivateKeyFlagsV4>
{

    protected override Humidifier.PCAConnectorAD.TemplateTypes.PrivateKeyFlagsV4 Create()
    {
        var privateKeyFlagsV4Result = CreatePrivateKeyFlagsV4();
        factoryAction?.Invoke(privateKeyFlagsV4Result);

        return privateKeyFlagsV4Result;
    }

    private Humidifier.PCAConnectorAD.TemplateTypes.PrivateKeyFlagsV4 CreatePrivateKeyFlagsV4()
    {
        var privateKeyFlagsV4Result = new Humidifier.PCAConnectorAD.TemplateTypes.PrivateKeyFlagsV4();

        return privateKeyFlagsV4Result;
    }

} // End Of Class

public static class InnerTemplatePrivateKeyFlagsV4FactoryExtensions
{
}
