namespace AppleStore.AWS.NimbusFactory.CLI;

public static class ScriptOutputHelper
{
    public static void WriteScriptsToFiles(this List<EnvironmentOutputResult> allEnvironments)
    {
        var serializer = new JsonStackSerializer();

        foreach (var environment in allEnvironments)
        {
            foreach (var stack in environment.Stacks)
            {
                stack.BaseDir = $"{AppSettingsContainer.Settings.BaseDir}";

                if (string.IsNullOrWhiteSpace(stack.RelativePath))
                {
                    stack.RelativePath = $@"Cloud Formation\Scripts\3 - Environments\{environment.Environment.EnvironmentName}";
                }

                var basePath = $"{stack.BaseDir}{stack.RelativePath}";

                if (!Directory.Exists(basePath))
                {
                    Directory.CreateDirectory(basePath);
                }

                var outputFile = $"{basePath}\\{stack.FileName}";

                if (stack is StackOutputResult stackOutputResult)
                {
                    var template = serializer.Serialize(stackOutputResult.Result);
                    File.WriteAllText(outputFile, template);
                }

                if (stack is ScriptOutputResult scriptOutputResult)
                {
                    File.WriteAllText(outputFile, scriptOutputResult.Result);
                }
            }
        }
    }
}