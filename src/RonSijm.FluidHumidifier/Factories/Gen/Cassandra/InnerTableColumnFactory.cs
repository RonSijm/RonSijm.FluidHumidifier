// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cassandra;

public class InnerTableColumnFactory(Action<Humidifier.Cassandra.TableTypes.Column> factoryAction = null) : SubResourceFactory<Humidifier.Cassandra.TableTypes.Column>
{

    protected override Humidifier.Cassandra.TableTypes.Column Create()
    {
        var columnResult = CreateColumn();
        factoryAction?.Invoke(columnResult);

        return columnResult;
    }

    private Humidifier.Cassandra.TableTypes.Column CreateColumn()
    {
        var columnResult = new Humidifier.Cassandra.TableTypes.Column();

        return columnResult;
    }

} // End Of Class

public static class InnerTableColumnFactoryExtensions
{
}
