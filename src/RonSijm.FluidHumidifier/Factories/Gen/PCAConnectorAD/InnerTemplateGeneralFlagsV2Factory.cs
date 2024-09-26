// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCAConnectorAD;

public class InnerTemplateGeneralFlagsV2Factory(Action<Humidifier.PCAConnectorAD.TemplateTypes.GeneralFlagsV2> factoryAction = null) : SubResourceFactory<Humidifier.PCAConnectorAD.TemplateTypes.GeneralFlagsV2>
{

    protected override Humidifier.PCAConnectorAD.TemplateTypes.GeneralFlagsV2 Create()
    {
        var generalFlagsV2Result = CreateGeneralFlagsV2();
        factoryAction?.Invoke(generalFlagsV2Result);

        return generalFlagsV2Result;
    }

    private Humidifier.PCAConnectorAD.TemplateTypes.GeneralFlagsV2 CreateGeneralFlagsV2()
    {
        var generalFlagsV2Result = new Humidifier.PCAConnectorAD.TemplateTypes.GeneralFlagsV2();

        return generalFlagsV2Result;
    }

} // End Of Class

public static class InnerTemplateGeneralFlagsV2FactoryExtensions
{
}
