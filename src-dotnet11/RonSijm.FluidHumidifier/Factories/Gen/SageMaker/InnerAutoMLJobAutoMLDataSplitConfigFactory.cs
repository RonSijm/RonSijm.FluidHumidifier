// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerAutoMLJobAutoMLDataSplitConfigFactory(Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLDataSplitConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.AutoMLJobTypes.AutoMLDataSplitConfig>
{

    protected override Humidifier.SageMaker.AutoMLJobTypes.AutoMLDataSplitConfig Create()
    {
        var autoMLDataSplitConfigResult = CreateAutoMLDataSplitConfig();
        factoryAction?.Invoke(autoMLDataSplitConfigResult);

        return autoMLDataSplitConfigResult;
    }

    private Humidifier.SageMaker.AutoMLJobTypes.AutoMLDataSplitConfig CreateAutoMLDataSplitConfig()
    {
        var autoMLDataSplitConfigResult = new Humidifier.SageMaker.AutoMLJobTypes.AutoMLDataSplitConfig();

        return autoMLDataSplitConfigResult;
    }

} // End Of Class

public static class InnerAutoMLJobAutoMLDataSplitConfigFactoryExtensions
{
}
