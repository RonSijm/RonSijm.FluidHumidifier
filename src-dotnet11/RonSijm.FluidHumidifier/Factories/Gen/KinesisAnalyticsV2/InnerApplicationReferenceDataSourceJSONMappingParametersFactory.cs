// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.KinesisAnalyticsV2;

public class InnerApplicationReferenceDataSourceJSONMappingParametersFactory(Action<Humidifier.KinesisAnalyticsV2.ApplicationReferenceDataSourceTypes.JSONMappingParameters> factoryAction = null) : SubResourceFactory<Humidifier.KinesisAnalyticsV2.ApplicationReferenceDataSourceTypes.JSONMappingParameters>
{

    protected override Humidifier.KinesisAnalyticsV2.ApplicationReferenceDataSourceTypes.JSONMappingParameters Create()
    {
        var jSONMappingParametersResult = CreateJSONMappingParameters();
        factoryAction?.Invoke(jSONMappingParametersResult);

        return jSONMappingParametersResult;
    }

    private Humidifier.KinesisAnalyticsV2.ApplicationReferenceDataSourceTypes.JSONMappingParameters CreateJSONMappingParameters()
    {
        var jSONMappingParametersResult = new Humidifier.KinesisAnalyticsV2.ApplicationReferenceDataSourceTypes.JSONMappingParameters();

        return jSONMappingParametersResult;
    }

} // End Of Class

public static class InnerApplicationReferenceDataSourceJSONMappingParametersFactoryExtensions
{
}
