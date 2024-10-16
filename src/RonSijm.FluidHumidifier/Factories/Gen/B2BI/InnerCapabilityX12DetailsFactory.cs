// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.B2BI;

public class InnerCapabilityX12DetailsFactory(Action<Humidifier.B2BI.CapabilityTypes.X12Details> factoryAction = null) : SubResourceFactory<Humidifier.B2BI.CapabilityTypes.X12Details>
{

    protected override Humidifier.B2BI.CapabilityTypes.X12Details Create()
    {
        var x12DetailsResult = CreateX12Details();
        factoryAction?.Invoke(x12DetailsResult);

        return x12DetailsResult;
    }

    private Humidifier.B2BI.CapabilityTypes.X12Details CreateX12Details()
    {
        var x12DetailsResult = new Humidifier.B2BI.CapabilityTypes.X12Details();

        return x12DetailsResult;
    }

} // End Of Class

public static class InnerCapabilityX12DetailsFactoryExtensions
{
}
