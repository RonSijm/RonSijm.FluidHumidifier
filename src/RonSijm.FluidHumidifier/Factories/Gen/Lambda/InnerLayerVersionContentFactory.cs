// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class InnerLayerVersionContentFactory(Action<Humidifier.Lambda.LayerVersionTypes.Content> factoryAction = null) : SubResourceFactory<Humidifier.Lambda.LayerVersionTypes.Content>
{

    protected override Humidifier.Lambda.LayerVersionTypes.Content Create()
    {
        var contentResult = CreateContent();
        factoryAction?.Invoke(contentResult);

        return contentResult;
    }

    private Humidifier.Lambda.LayerVersionTypes.Content CreateContent()
    {
        var contentResult = new Humidifier.Lambda.LayerVersionTypes.Content();

        return contentResult;
    }

} // End Of Class

public static class InnerLayerVersionContentFactoryExtensions
{
}
