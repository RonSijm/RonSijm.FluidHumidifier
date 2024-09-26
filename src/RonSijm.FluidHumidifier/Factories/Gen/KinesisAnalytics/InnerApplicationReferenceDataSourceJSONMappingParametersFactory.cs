// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisAnalytics;

public class InnerApplicationReferenceDataSourceJSONMappingParametersFactory(Action<Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.JSONMappingParameters> factoryAction = null) : SubResourceFactory<Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.JSONMappingParameters>
{

    protected override Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.JSONMappingParameters Create()
    {
        var jSONMappingParametersResult = CreateJSONMappingParameters();
        factoryAction?.Invoke(jSONMappingParametersResult);

        return jSONMappingParametersResult;
    }

    private Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.JSONMappingParameters CreateJSONMappingParameters()
    {
        var jSONMappingParametersResult = new Humidifier.KinesisAnalytics.ApplicationReferenceDataSourceTypes.JSONMappingParameters();

        return jSONMappingParametersResult;
    }

} // End Of Class

public static class InnerApplicationReferenceDataSourceJSONMappingParametersFactoryExtensions
{
}
