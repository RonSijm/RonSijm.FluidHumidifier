// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCAConnectorAD;

public class InnerTemplatePrivateKeyFlagsV3Factory(Action<Humidifier.PCAConnectorAD.TemplateTypes.PrivateKeyFlagsV3> factoryAction = null) : SubResourceFactory<Humidifier.PCAConnectorAD.TemplateTypes.PrivateKeyFlagsV3>
{

    protected override Humidifier.PCAConnectorAD.TemplateTypes.PrivateKeyFlagsV3 Create()
    {
        var privateKeyFlagsV3Result = CreatePrivateKeyFlagsV3();
        factoryAction?.Invoke(privateKeyFlagsV3Result);

        return privateKeyFlagsV3Result;
    }

    private Humidifier.PCAConnectorAD.TemplateTypes.PrivateKeyFlagsV3 CreatePrivateKeyFlagsV3()
    {
        var privateKeyFlagsV3Result = new Humidifier.PCAConnectorAD.TemplateTypes.PrivateKeyFlagsV3();

        return privateKeyFlagsV3Result;
    }

} // End Of Class

public static class InnerTemplatePrivateKeyFlagsV3FactoryExtensions
{
}
