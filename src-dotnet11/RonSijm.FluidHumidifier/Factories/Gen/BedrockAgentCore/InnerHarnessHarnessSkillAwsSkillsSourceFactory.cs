// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerHarnessHarnessSkillAwsSkillsSourceFactory(Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessSkillAwsSkillsSource> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.HarnessTypes.HarnessSkillAwsSkillsSource>
{

    protected override Humidifier.BedrockAgentCore.HarnessTypes.HarnessSkillAwsSkillsSource Create()
    {
        var harnessSkillAwsSkillsSourceResult = CreateHarnessSkillAwsSkillsSource();
        factoryAction?.Invoke(harnessSkillAwsSkillsSourceResult);

        return harnessSkillAwsSkillsSourceResult;
    }

    private Humidifier.BedrockAgentCore.HarnessTypes.HarnessSkillAwsSkillsSource CreateHarnessSkillAwsSkillsSource()
    {
        var harnessSkillAwsSkillsSourceResult = new Humidifier.BedrockAgentCore.HarnessTypes.HarnessSkillAwsSkillsSource();

        return harnessSkillAwsSkillsSourceResult;
    }

} // End Of Class

public static class InnerHarnessHarnessSkillAwsSkillsSourceFactoryExtensions
{
}
