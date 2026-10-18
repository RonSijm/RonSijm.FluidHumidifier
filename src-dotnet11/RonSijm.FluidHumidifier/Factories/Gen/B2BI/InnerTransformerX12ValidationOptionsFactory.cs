// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.B2BI;

public class InnerTransformerX12ValidationOptionsFactory(Action<Humidifier.B2BI.TransformerTypes.X12ValidationOptions> factoryAction = null) : SubResourceFactory<Humidifier.B2BI.TransformerTypes.X12ValidationOptions>
{

    protected override Humidifier.B2BI.TransformerTypes.X12ValidationOptions Create()
    {
        var x12ValidationOptionsResult = CreateX12ValidationOptions();
        factoryAction?.Invoke(x12ValidationOptionsResult);

        return x12ValidationOptionsResult;
    }

    private Humidifier.B2BI.TransformerTypes.X12ValidationOptions CreateX12ValidationOptions()
    {
        var x12ValidationOptionsResult = new Humidifier.B2BI.TransformerTypes.X12ValidationOptions();

        return x12ValidationOptionsResult;
    }

} // End Of Class

public static class InnerTransformerX12ValidationOptionsFactoryExtensions
{
}
