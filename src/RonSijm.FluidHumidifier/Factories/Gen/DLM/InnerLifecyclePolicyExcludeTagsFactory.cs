// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DLM;

public class InnerLifecyclePolicyExcludeTagsFactory(Action<Humidifier.DLM.LifecyclePolicyTypes.ExcludeTags> factoryAction = null) : SubResourceFactory<Humidifier.DLM.LifecyclePolicyTypes.ExcludeTags>
{

    protected override Humidifier.DLM.LifecyclePolicyTypes.ExcludeTags Create()
    {
        var excludeTagsResult = CreateExcludeTags();
        factoryAction?.Invoke(excludeTagsResult);

        return excludeTagsResult;
    }

    private Humidifier.DLM.LifecyclePolicyTypes.ExcludeTags CreateExcludeTags()
    {
        var excludeTagsResult = new Humidifier.DLM.LifecyclePolicyTypes.ExcludeTags();

        return excludeTagsResult;
    }

} // End Of Class

public static class InnerLifecyclePolicyExcludeTagsFactoryExtensions
{
}
