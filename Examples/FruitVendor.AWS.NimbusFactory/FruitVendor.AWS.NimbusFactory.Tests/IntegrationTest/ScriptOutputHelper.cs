using Humidifier.Json.Serializer;
using RonSijm.FluidHumidifier.Features.Output;

namespace FruitVendor.AWS.NimbusFactory.Tests.IntegrationTest;

public static class ScriptOutputHelper
{
    public static void WriteScriptsToFiles(this List<EnvironmentOutputResult> allEnvironments)
    {
        var serializer = new JsonStackSerializer();

        foreach (var environment in allEnvironments)
        {
            foreach (var stack in environment.Stacks)
            {
                if (stack is not StackOutputResult stackOutputResult)
                {
                    continue;
                }

                var basePath = $"{stack.BaseDir}{stack.RelativePath}";

                if (!Directory.Exists(basePath))
                {
                    Directory.CreateDirectory(basePath);
                }

                var outputFile = $"{basePath}\\{stack.FileName}";
                var template = serializer.Serialize(stackOutputResult.Result);
                File.WriteAllText(outputFile, template);
            }
        }
    }
}