// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AgentRegistry;

public class InnerRegistryRecordSkillMdSourceFromUrlFactory(Action<Humidifier.AgentRegistry.RegistryRecordTypes.SkillMdSourceFromUrl> factoryAction = null) : SubResourceFactory<Humidifier.AgentRegistry.RegistryRecordTypes.SkillMdSourceFromUrl>
{

    protected override Humidifier.AgentRegistry.RegistryRecordTypes.SkillMdSourceFromUrl Create()
    {
        var skillMdSourceFromUrlResult = CreateSkillMdSourceFromUrl();
        factoryAction?.Invoke(skillMdSourceFromUrlResult);

        return skillMdSourceFromUrlResult;
    }

    private Humidifier.AgentRegistry.RegistryRecordTypes.SkillMdSourceFromUrl CreateSkillMdSourceFromUrl()
    {
        var skillMdSourceFromUrlResult = new Humidifier.AgentRegistry.RegistryRecordTypes.SkillMdSourceFromUrl();

        return skillMdSourceFromUrlResult;
    }

} // End Of Class

public static class InnerRegistryRecordSkillMdSourceFromUrlFactoryExtensions
{
}
