// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IoT;

public class InnerCommandAwsJsonSubstitutionCommandPreprocessorConfigFactory(Action<Humidifier.IoT.CommandTypes.AwsJsonSubstitutionCommandPreprocessorConfig> factoryAction = null) : SubResourceFactory<Humidifier.IoT.CommandTypes.AwsJsonSubstitutionCommandPreprocessorConfig>
{

    protected override Humidifier.IoT.CommandTypes.AwsJsonSubstitutionCommandPreprocessorConfig Create()
    {
        var awsJsonSubstitutionCommandPreprocessorConfigResult = CreateAwsJsonSubstitutionCommandPreprocessorConfig();
        factoryAction?.Invoke(awsJsonSubstitutionCommandPreprocessorConfigResult);

        return awsJsonSubstitutionCommandPreprocessorConfigResult;
    }

    private Humidifier.IoT.CommandTypes.AwsJsonSubstitutionCommandPreprocessorConfig CreateAwsJsonSubstitutionCommandPreprocessorConfig()
    {
        var awsJsonSubstitutionCommandPreprocessorConfigResult = new Humidifier.IoT.CommandTypes.AwsJsonSubstitutionCommandPreprocessorConfig();

        return awsJsonSubstitutionCommandPreprocessorConfigResult;
    }

} // End Of Class

public static class InnerCommandAwsJsonSubstitutionCommandPreprocessorConfigFactoryExtensions
{
}
