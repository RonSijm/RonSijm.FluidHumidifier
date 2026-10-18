// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCAConnectorAD;

public class InnerTemplateValidityPeriodFactory(Action<Humidifier.PCAConnectorAD.TemplateTypes.ValidityPeriod> factoryAction = null) : SubResourceFactory<Humidifier.PCAConnectorAD.TemplateTypes.ValidityPeriod>
{

    protected override Humidifier.PCAConnectorAD.TemplateTypes.ValidityPeriod Create()
    {
        var validityPeriodResult = CreateValidityPeriod();
        factoryAction?.Invoke(validityPeriodResult);

        return validityPeriodResult;
    }

    private Humidifier.PCAConnectorAD.TemplateTypes.ValidityPeriod CreateValidityPeriod()
    {
        var validityPeriodResult = new Humidifier.PCAConnectorAD.TemplateTypes.ValidityPeriod();

        return validityPeriodResult;
    }

} // End Of Class

public static class InnerTemplateValidityPeriodFactoryExtensions
{
}
