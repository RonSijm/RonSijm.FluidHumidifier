// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerDataTableRecordValueFactory(Action<Humidifier.Connect.DataTableRecordTypes.Value> factoryAction = null) : SubResourceFactory<Humidifier.Connect.DataTableRecordTypes.Value>
{

    protected override Humidifier.Connect.DataTableRecordTypes.Value Create()
    {
        var valueResult = CreateValue();
        factoryAction?.Invoke(valueResult);

        return valueResult;
    }

    private Humidifier.Connect.DataTableRecordTypes.Value CreateValue()
    {
        var valueResult = new Humidifier.Connect.DataTableRecordTypes.Value();

        return valueResult;
    }

} // End Of Class

public static class InnerDataTableRecordValueFactoryExtensions
{
}
