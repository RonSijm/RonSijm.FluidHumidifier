// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.B2BI;

public class InnerPartnershipX12DelimitersFactory(Action<Humidifier.B2BI.PartnershipTypes.X12Delimiters> factoryAction = null) : SubResourceFactory<Humidifier.B2BI.PartnershipTypes.X12Delimiters>
{

    protected override Humidifier.B2BI.PartnershipTypes.X12Delimiters Create()
    {
        var x12DelimitersResult = CreateX12Delimiters();
        factoryAction?.Invoke(x12DelimitersResult);

        return x12DelimitersResult;
    }

    private Humidifier.B2BI.PartnershipTypes.X12Delimiters CreateX12Delimiters()
    {
        var x12DelimitersResult = new Humidifier.B2BI.PartnershipTypes.X12Delimiters();

        return x12DelimitersResult;
    }

} // End Of Class

public static class InnerPartnershipX12DelimitersFactoryExtensions
{
}
