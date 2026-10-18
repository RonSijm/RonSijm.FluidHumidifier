// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCAConnectorAD;

public class InnerTemplatePrivateKeyFlagsV2Factory(Action<Humidifier.PCAConnectorAD.TemplateTypes.PrivateKeyFlagsV2> factoryAction = null) : SubResourceFactory<Humidifier.PCAConnectorAD.TemplateTypes.PrivateKeyFlagsV2>
{

    protected override Humidifier.PCAConnectorAD.TemplateTypes.PrivateKeyFlagsV2 Create()
    {
        var privateKeyFlagsV2Result = CreatePrivateKeyFlagsV2();
        factoryAction?.Invoke(privateKeyFlagsV2Result);

        return privateKeyFlagsV2Result;
    }

    private Humidifier.PCAConnectorAD.TemplateTypes.PrivateKeyFlagsV2 CreatePrivateKeyFlagsV2()
    {
        var privateKeyFlagsV2Result = new Humidifier.PCAConnectorAD.TemplateTypes.PrivateKeyFlagsV2();

        return privateKeyFlagsV2Result;
    }

} // End Of Class

public static class InnerTemplatePrivateKeyFlagsV2FactoryExtensions
{
}
