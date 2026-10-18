// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.B2BI;

public class InnerTransformerX12SplitOptionsFactory(Action<Humidifier.B2BI.TransformerTypes.X12SplitOptions> factoryAction = null) : SubResourceFactory<Humidifier.B2BI.TransformerTypes.X12SplitOptions>
{

    protected override Humidifier.B2BI.TransformerTypes.X12SplitOptions Create()
    {
        var x12SplitOptionsResult = CreateX12SplitOptions();
        factoryAction?.Invoke(x12SplitOptionsResult);

        return x12SplitOptionsResult;
    }

    private Humidifier.B2BI.TransformerTypes.X12SplitOptions CreateX12SplitOptions()
    {
        var x12SplitOptionsResult = new Humidifier.B2BI.TransformerTypes.X12SplitOptions();

        return x12SplitOptionsResult;
    }

} // End Of Class

public static class InnerTransformerX12SplitOptionsFactoryExtensions
{
}
