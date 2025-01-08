// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.B2BI;

public class InnerPartnershipX12FunctionalGroupHeadersFactory(Action<Humidifier.B2BI.PartnershipTypes.X12FunctionalGroupHeaders> factoryAction = null) : SubResourceFactory<Humidifier.B2BI.PartnershipTypes.X12FunctionalGroupHeaders>
{

    protected override Humidifier.B2BI.PartnershipTypes.X12FunctionalGroupHeaders Create()
    {
        var x12FunctionalGroupHeadersResult = CreateX12FunctionalGroupHeaders();
        factoryAction?.Invoke(x12FunctionalGroupHeadersResult);

        return x12FunctionalGroupHeadersResult;
    }

    private Humidifier.B2BI.PartnershipTypes.X12FunctionalGroupHeaders CreateX12FunctionalGroupHeaders()
    {
        var x12FunctionalGroupHeadersResult = new Humidifier.B2BI.PartnershipTypes.X12FunctionalGroupHeaders();

        return x12FunctionalGroupHeadersResult;
    }

} // End Of Class

public static class InnerPartnershipX12FunctionalGroupHeadersFactoryExtensions
{
}
