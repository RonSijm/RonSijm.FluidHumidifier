// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerHarnessHarnessSkillS3SourceFactory(Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessSkillS3Source> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.HarnessTypes.HarnessSkillS3Source>
{

    protected override Humidifier.BedrockAgentCore.HarnessTypes.HarnessSkillS3Source Create()
    {
        var harnessSkillS3SourceResult = CreateHarnessSkillS3Source();
        factoryAction?.Invoke(harnessSkillS3SourceResult);

        return harnessSkillS3SourceResult;
    }

    private Humidifier.BedrockAgentCore.HarnessTypes.HarnessSkillS3Source CreateHarnessSkillS3Source()
    {
        var harnessSkillS3SourceResult = new Humidifier.BedrockAgentCore.HarnessTypes.HarnessSkillS3Source();

        return harnessSkillS3SourceResult;
    }

} // End Of Class

public static class InnerHarnessHarnessSkillS3SourceFactoryExtensions
{
}
