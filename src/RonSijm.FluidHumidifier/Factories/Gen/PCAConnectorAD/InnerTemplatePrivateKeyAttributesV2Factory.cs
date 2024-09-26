// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCAConnectorAD;

public class InnerTemplatePrivateKeyAttributesV2Factory(Action<Humidifier.PCAConnectorAD.TemplateTypes.PrivateKeyAttributesV2> factoryAction = null) : SubResourceFactory<Humidifier.PCAConnectorAD.TemplateTypes.PrivateKeyAttributesV2>
{

    protected override Humidifier.PCAConnectorAD.TemplateTypes.PrivateKeyAttributesV2 Create()
    {
        var privateKeyAttributesV2Result = CreatePrivateKeyAttributesV2();
        factoryAction?.Invoke(privateKeyAttributesV2Result);

        return privateKeyAttributesV2Result;
    }

    private Humidifier.PCAConnectorAD.TemplateTypes.PrivateKeyAttributesV2 CreatePrivateKeyAttributesV2()
    {
        var privateKeyAttributesV2Result = new Humidifier.PCAConnectorAD.TemplateTypes.PrivateKeyAttributesV2();

        return privateKeyAttributesV2Result;
    }

} // End Of Class

public static class InnerTemplatePrivateKeyAttributesV2FactoryExtensions
{
}
