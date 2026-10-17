using Humidifier.Json.Serializer;

namespace AppleStore.AWS.NimbusFactory.Tests.Base;

[UsedImplicitly(ImplicitUseTargetFlags.WithInheritors)]
public abstract class BaseStackBuilderTest
{
    [Fact]
    public async Task CanBuildStack()
    {
        var stack = await BuildStack();

        var serializer = new JsonStackSerializer();
        var template = serializer.Serialize(stack);

        var settings = new VerifySettings();
        settings.UseDirectory("VerificationResults");

        await Verify(template, extension: "json", settings);
    }

    protected abstract Task<Stack> BuildStack();
}