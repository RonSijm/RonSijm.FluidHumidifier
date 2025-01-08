// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Logs;

public class InnerTransformerParseCloudfrontFactory(Action<Humidifier.Logs.TransformerTypes.ParseCloudfront> factoryAction = null) : SubResourceFactory<Humidifier.Logs.TransformerTypes.ParseCloudfront>
{

    protected override Humidifier.Logs.TransformerTypes.ParseCloudfront Create()
    {
        var parseCloudfrontResult = CreateParseCloudfront();
        factoryAction?.Invoke(parseCloudfrontResult);

        return parseCloudfrontResult;
    }

    private Humidifier.Logs.TransformerTypes.ParseCloudfront CreateParseCloudfront()
    {
        var parseCloudfrontResult = new Humidifier.Logs.TransformerTypes.ParseCloudfront();

        return parseCloudfrontResult;
    }

} // End Of Class

public static class InnerTransformerParseCloudfrontFactoryExtensions
{
}
