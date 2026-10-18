// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerPromptCachePointBlockFactory(Action<Humidifier.Bedrock.PromptTypes.CachePointBlock> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.PromptTypes.CachePointBlock>
{

    protected override Humidifier.Bedrock.PromptTypes.CachePointBlock Create()
    {
        var cachePointBlockResult = CreateCachePointBlock();
        factoryAction?.Invoke(cachePointBlockResult);

        return cachePointBlockResult;
    }

    private Humidifier.Bedrock.PromptTypes.CachePointBlock CreateCachePointBlock()
    {
        var cachePointBlockResult = new Humidifier.Bedrock.PromptTypes.CachePointBlock();

        return cachePointBlockResult;
    }

} // End Of Class

public static class InnerPromptCachePointBlockFactoryExtensions
{
}
