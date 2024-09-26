// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCAConnectorAD;

public class InnerTemplateGeneralFlagsV3Factory(Action<Humidifier.PCAConnectorAD.TemplateTypes.GeneralFlagsV3> factoryAction = null) : SubResourceFactory<Humidifier.PCAConnectorAD.TemplateTypes.GeneralFlagsV3>
{

    protected override Humidifier.PCAConnectorAD.TemplateTypes.GeneralFlagsV3 Create()
    {
        var generalFlagsV3Result = CreateGeneralFlagsV3();
        factoryAction?.Invoke(generalFlagsV3Result);

        return generalFlagsV3Result;
    }

    private Humidifier.PCAConnectorAD.TemplateTypes.GeneralFlagsV3 CreateGeneralFlagsV3()
    {
        var generalFlagsV3Result = new Humidifier.PCAConnectorAD.TemplateTypes.GeneralFlagsV3();

        return generalFlagsV3Result;
    }

} // End Of Class

public static class InnerTemplateGeneralFlagsV3FactoryExtensions
{
}
