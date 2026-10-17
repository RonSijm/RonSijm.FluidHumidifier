// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SCN;

public class InnerDataIntegrationFlowSqlTransformationConfigurationFactory(Action<Humidifier.SCN.DataIntegrationFlowTypes.SqlTransformationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.SCN.DataIntegrationFlowTypes.SqlTransformationConfiguration>
{

    protected override Humidifier.SCN.DataIntegrationFlowTypes.SqlTransformationConfiguration Create()
    {
        var sqlTransformationConfigurationResult = CreateSqlTransformationConfiguration();
        factoryAction?.Invoke(sqlTransformationConfigurationResult);

        return sqlTransformationConfigurationResult;
    }

    private Humidifier.SCN.DataIntegrationFlowTypes.SqlTransformationConfiguration CreateSqlTransformationConfiguration()
    {
        var sqlTransformationConfigurationResult = new Humidifier.SCN.DataIntegrationFlowTypes.SqlTransformationConfiguration();

        return sqlTransformationConfigurationResult;
    }

} // End Of Class

public static class InnerDataIntegrationFlowSqlTransformationConfigurationFactoryExtensions
{
}
