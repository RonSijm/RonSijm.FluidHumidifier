// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ASK;

public class InnerSkillOverridesFactory(Action<Humidifier.ASK.SkillTypes.Overrides> factoryAction = null) : SubResourceFactory<Humidifier.ASK.SkillTypes.Overrides>
{

    protected override Humidifier.ASK.SkillTypes.Overrides Create()
    {
        var overridesResult = CreateOverrides();
        factoryAction?.Invoke(overridesResult);

        return overridesResult;
    }

    private Humidifier.ASK.SkillTypes.Overrides CreateOverrides()
    {
        var overridesResult = new Humidifier.ASK.SkillTypes.Overrides();

        return overridesResult;
    }

} // End Of Class

public static class InnerSkillOverridesFactoryExtensions
{
}
