// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.B2BI;

public class InnerPartnershipX12ControlNumbersFactory(Action<Humidifier.B2BI.PartnershipTypes.X12ControlNumbers> factoryAction = null) : SubResourceFactory<Humidifier.B2BI.PartnershipTypes.X12ControlNumbers>
{

    protected override Humidifier.B2BI.PartnershipTypes.X12ControlNumbers Create()
    {
        var x12ControlNumbersResult = CreateX12ControlNumbers();
        factoryAction?.Invoke(x12ControlNumbersResult);

        return x12ControlNumbersResult;
    }

    private Humidifier.B2BI.PartnershipTypes.X12ControlNumbers CreateX12ControlNumbers()
    {
        var x12ControlNumbersResult = new Humidifier.B2BI.PartnershipTypes.X12ControlNumbers();

        return x12ControlNumbersResult;
    }

} // End Of Class

public static class InnerPartnershipX12ControlNumbersFactoryExtensions
{
}
