// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerMLTransformInputRecordTablesFactory(Action<Humidifier.Glue.MLTransformTypes.InputRecordTables> factoryAction = null) : SubResourceFactory<Humidifier.Glue.MLTransformTypes.InputRecordTables>
{

    protected override Humidifier.Glue.MLTransformTypes.InputRecordTables Create()
    {
        var inputRecordTablesResult = CreateInputRecordTables();
        factoryAction?.Invoke(inputRecordTablesResult);

        return inputRecordTablesResult;
    }

    private Humidifier.Glue.MLTransformTypes.InputRecordTables CreateInputRecordTables()
    {
        var inputRecordTablesResult = new Humidifier.Glue.MLTransformTypes.InputRecordTables();

        return inputRecordTablesResult;
    }

} // End Of Class

public static class InnerMLTransformInputRecordTablesFactoryExtensions
{
}
