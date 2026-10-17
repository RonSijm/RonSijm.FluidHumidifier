// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Comprehend;

public class InnerDocumentClassificationJobInputDataConfigFactory(Action<Humidifier.Comprehend.DocumentClassificationJobTypes.InputDataConfig> factoryAction = null) : SubResourceFactory<Humidifier.Comprehend.DocumentClassificationJobTypes.InputDataConfig>
{

    protected override Humidifier.Comprehend.DocumentClassificationJobTypes.InputDataConfig Create()
    {
        var inputDataConfigResult = CreateInputDataConfig();
        factoryAction?.Invoke(inputDataConfigResult);

        return inputDataConfigResult;
    }

    private Humidifier.Comprehend.DocumentClassificationJobTypes.InputDataConfig CreateInputDataConfig()
    {
        var inputDataConfigResult = new Humidifier.Comprehend.DocumentClassificationJobTypes.InputDataConfig();

        return inputDataConfigResult;
    }

} // End Of Class

public static class InnerDocumentClassificationJobInputDataConfigFactoryExtensions
{
}
