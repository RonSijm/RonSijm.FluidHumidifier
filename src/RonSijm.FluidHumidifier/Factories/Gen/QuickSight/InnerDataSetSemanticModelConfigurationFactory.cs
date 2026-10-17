// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDataSetSemanticModelConfigurationFactory(Action<Humidifier.QuickSight.DataSetTypes.SemanticModelConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DataSetTypes.SemanticModelConfiguration>
{

    protected override Humidifier.QuickSight.DataSetTypes.SemanticModelConfiguration Create()
    {
        var semanticModelConfigurationResult = CreateSemanticModelConfiguration();
        factoryAction?.Invoke(semanticModelConfigurationResult);

        return semanticModelConfigurationResult;
    }

    private Humidifier.QuickSight.DataSetTypes.SemanticModelConfiguration CreateSemanticModelConfiguration()
    {
        var semanticModelConfigurationResult = new Humidifier.QuickSight.DataSetTypes.SemanticModelConfiguration();

        return semanticModelConfigurationResult;
    }

} // End Of Class

public static class InnerDataSetSemanticModelConfigurationFactoryExtensions
{
}
