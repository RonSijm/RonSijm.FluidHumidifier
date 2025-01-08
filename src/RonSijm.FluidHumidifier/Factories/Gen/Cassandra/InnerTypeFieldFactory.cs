// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Cassandra;

public class InnerTypeFieldFactory(Action<Humidifier.Cassandra.TypeTypes.Field> factoryAction = null) : SubResourceFactory<Humidifier.Cassandra.TypeTypes.Field>
{

    protected override Humidifier.Cassandra.TypeTypes.Field Create()
    {
        var fieldResult = CreateField();
        factoryAction?.Invoke(fieldResult);

        return fieldResult;
    }

    private Humidifier.Cassandra.TypeTypes.Field CreateField()
    {
        var fieldResult = new Humidifier.Cassandra.TypeTypes.Field();

        return fieldResult;
    }

} // End Of Class

public static class InnerTypeFieldFactoryExtensions
{
}
