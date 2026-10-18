// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Logs;

public class InnerTransformerCopyValueFactory(Action<Humidifier.Logs.TransformerTypes.CopyValue> factoryAction = null) : SubResourceFactory<Humidifier.Logs.TransformerTypes.CopyValue>
{

    protected override Humidifier.Logs.TransformerTypes.CopyValue Create()
    {
        var copyValueResult = CreateCopyValue();
        factoryAction?.Invoke(copyValueResult);

        return copyValueResult;
    }

    private Humidifier.Logs.TransformerTypes.CopyValue CreateCopyValue()
    {
        var copyValueResult = new Humidifier.Logs.TransformerTypes.CopyValue();

        return copyValueResult;
    }

} // End Of Class

public static class InnerTransformerCopyValueFactoryExtensions
{
}
