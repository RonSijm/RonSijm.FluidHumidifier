// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerApplicationInferenceProfileInferenceProfileModelSourceFactory(Action<Humidifier.Bedrock.ApplicationInferenceProfileTypes.InferenceProfileModelSource> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.ApplicationInferenceProfileTypes.InferenceProfileModelSource>
{

    protected override Humidifier.Bedrock.ApplicationInferenceProfileTypes.InferenceProfileModelSource Create()
    {
        var inferenceProfileModelSourceResult = CreateInferenceProfileModelSource();
        factoryAction?.Invoke(inferenceProfileModelSourceResult);

        return inferenceProfileModelSourceResult;
    }

    private Humidifier.Bedrock.ApplicationInferenceProfileTypes.InferenceProfileModelSource CreateInferenceProfileModelSource()
    {
        var inferenceProfileModelSourceResult = new Humidifier.Bedrock.ApplicationInferenceProfileTypes.InferenceProfileModelSource();

        return inferenceProfileModelSourceResult;
    }

} // End Of Class

public static class InnerApplicationInferenceProfileInferenceProfileModelSourceFactoryExtensions
{
}
