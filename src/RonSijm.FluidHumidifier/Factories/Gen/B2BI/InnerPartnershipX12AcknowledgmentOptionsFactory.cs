// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.B2BI;

public class InnerPartnershipX12AcknowledgmentOptionsFactory(Action<Humidifier.B2BI.PartnershipTypes.X12AcknowledgmentOptions> factoryAction = null) : SubResourceFactory<Humidifier.B2BI.PartnershipTypes.X12AcknowledgmentOptions>
{

    protected override Humidifier.B2BI.PartnershipTypes.X12AcknowledgmentOptions Create()
    {
        var x12AcknowledgmentOptionsResult = CreateX12AcknowledgmentOptions();
        factoryAction?.Invoke(x12AcknowledgmentOptionsResult);

        return x12AcknowledgmentOptionsResult;
    }

    private Humidifier.B2BI.PartnershipTypes.X12AcknowledgmentOptions CreateX12AcknowledgmentOptions()
    {
        var x12AcknowledgmentOptionsResult = new Humidifier.B2BI.PartnershipTypes.X12AcknowledgmentOptions();

        return x12AcknowledgmentOptionsResult;
    }

} // End Of Class

public static class InnerPartnershipX12AcknowledgmentOptionsFactoryExtensions
{
}
