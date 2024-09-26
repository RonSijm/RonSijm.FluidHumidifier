// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerPromptTextS3LocationFactory(Action<Humidifier.Bedrock.PromptTypes.TextS3Location> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.PromptTypes.TextS3Location>
{

    protected override Humidifier.Bedrock.PromptTypes.TextS3Location Create()
    {
        var textS3LocationResult = CreateTextS3Location();
        factoryAction?.Invoke(textS3LocationResult);

        return textS3LocationResult;
    }

    private Humidifier.Bedrock.PromptTypes.TextS3Location CreateTextS3Location()
    {
        var textS3LocationResult = new Humidifier.Bedrock.PromptTypes.TextS3Location();

        return textS3LocationResult;
    }

} // End Of Class

public static class InnerPromptTextS3LocationFactoryExtensions
{
}
