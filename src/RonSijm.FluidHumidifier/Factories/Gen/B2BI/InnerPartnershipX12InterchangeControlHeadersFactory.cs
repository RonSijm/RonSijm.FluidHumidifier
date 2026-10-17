// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.B2BI;

public class InnerPartnershipX12InterchangeControlHeadersFactory(Action<Humidifier.B2BI.PartnershipTypes.X12InterchangeControlHeaders> factoryAction = null) : SubResourceFactory<Humidifier.B2BI.PartnershipTypes.X12InterchangeControlHeaders>
{

    protected override Humidifier.B2BI.PartnershipTypes.X12InterchangeControlHeaders Create()
    {
        var x12InterchangeControlHeadersResult = CreateX12InterchangeControlHeaders();
        factoryAction?.Invoke(x12InterchangeControlHeadersResult);

        return x12InterchangeControlHeadersResult;
    }

    private Humidifier.B2BI.PartnershipTypes.X12InterchangeControlHeaders CreateX12InterchangeControlHeaders()
    {
        var x12InterchangeControlHeadersResult = new Humidifier.B2BI.PartnershipTypes.X12InterchangeControlHeaders();

        return x12InterchangeControlHeadersResult;
    }

} // End Of Class

public static class InnerPartnershipX12InterchangeControlHeadersFactoryExtensions
{
}
