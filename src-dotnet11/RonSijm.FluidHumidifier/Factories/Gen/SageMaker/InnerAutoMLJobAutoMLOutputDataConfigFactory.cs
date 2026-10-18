// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerAutoMLJobAutoMLOutputDataConfigFactory(Action<Humidifier.SageMaker.AutoMLJobTypes.AutoMLOutputDataConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.AutoMLJobTypes.AutoMLOutputDataConfig>
{

    protected override Humidifier.SageMaker.AutoMLJobTypes.AutoMLOutputDataConfig Create()
    {
        var autoMLOutputDataConfigResult = CreateAutoMLOutputDataConfig();
        factoryAction?.Invoke(autoMLOutputDataConfigResult);

        return autoMLOutputDataConfigResult;
    }

    private Humidifier.SageMaker.AutoMLJobTypes.AutoMLOutputDataConfig CreateAutoMLOutputDataConfig()
    {
        var autoMLOutputDataConfigResult = new Humidifier.SageMaker.AutoMLJobTypes.AutoMLOutputDataConfig();

        return autoMLOutputDataConfigResult;
    }

} // End Of Class

public static class InnerAutoMLJobAutoMLOutputDataConfigFactoryExtensions
{
}
