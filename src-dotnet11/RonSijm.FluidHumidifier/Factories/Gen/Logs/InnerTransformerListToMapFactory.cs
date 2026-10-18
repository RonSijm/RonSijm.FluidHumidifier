// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Logs;

public class InnerTransformerListToMapFactory(Action<Humidifier.Logs.TransformerTypes.ListToMap> factoryAction = null) : SubResourceFactory<Humidifier.Logs.TransformerTypes.ListToMap>
{

    protected override Humidifier.Logs.TransformerTypes.ListToMap Create()
    {
        var listToMapResult = CreateListToMap();
        factoryAction?.Invoke(listToMapResult);

        return listToMapResult;
    }

    private Humidifier.Logs.TransformerTypes.ListToMap CreateListToMap()
    {
        var listToMapResult = new Humidifier.Logs.TransformerTypes.ListToMap();

        return listToMapResult;
    }

} // End Of Class

public static class InnerTransformerListToMapFactoryExtensions
{
}
