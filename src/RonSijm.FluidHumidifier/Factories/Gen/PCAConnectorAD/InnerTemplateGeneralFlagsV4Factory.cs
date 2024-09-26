// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCAConnectorAD;

public class InnerTemplateGeneralFlagsV4Factory(Action<Humidifier.PCAConnectorAD.TemplateTypes.GeneralFlagsV4> factoryAction = null) : SubResourceFactory<Humidifier.PCAConnectorAD.TemplateTypes.GeneralFlagsV4>
{

    protected override Humidifier.PCAConnectorAD.TemplateTypes.GeneralFlagsV4 Create()
    {
        var generalFlagsV4Result = CreateGeneralFlagsV4();
        factoryAction?.Invoke(generalFlagsV4Result);

        return generalFlagsV4Result;
    }

    private Humidifier.PCAConnectorAD.TemplateTypes.GeneralFlagsV4 CreateGeneralFlagsV4()
    {
        var generalFlagsV4Result = new Humidifier.PCAConnectorAD.TemplateTypes.GeneralFlagsV4();

        return generalFlagsV4Result;
    }

} // End Of Class

public static class InnerTemplateGeneralFlagsV4FactoryExtensions
{
}
