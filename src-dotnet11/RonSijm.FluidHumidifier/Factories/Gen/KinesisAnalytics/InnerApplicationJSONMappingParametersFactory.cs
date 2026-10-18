// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisAnalytics;

public class InnerApplicationJSONMappingParametersFactory(Action<Humidifier.KinesisAnalytics.ApplicationTypes.JSONMappingParameters> factoryAction = null) : SubResourceFactory<Humidifier.KinesisAnalytics.ApplicationTypes.JSONMappingParameters>
{

    protected override Humidifier.KinesisAnalytics.ApplicationTypes.JSONMappingParameters Create()
    {
        var jSONMappingParametersResult = CreateJSONMappingParameters();
        factoryAction?.Invoke(jSONMappingParametersResult);

        return jSONMappingParametersResult;
    }

    private Humidifier.KinesisAnalytics.ApplicationTypes.JSONMappingParameters CreateJSONMappingParameters()
    {
        var jSONMappingParametersResult = new Humidifier.KinesisAnalytics.ApplicationTypes.JSONMappingParameters();

        return jSONMappingParametersResult;
    }

} // End Of Class

public static class InnerApplicationJSONMappingParametersFactoryExtensions
{
}
