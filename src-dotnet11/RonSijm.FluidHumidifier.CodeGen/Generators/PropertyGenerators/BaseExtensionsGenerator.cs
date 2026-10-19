using Humidifier.CodeGen.Lib.Features.JsonToModels.Models;

namespace RonSijm.FluidHumidifier.CodeGen.CLI.Generators.PropertyGenerators
{
    public abstract class BaseExtensionsGenerator
    {
        public void Generate(string resourceName, ResourceType resource)
        {
            if (!CanGenerate(resource))
            {
                return;
            }

            var code = GenerateCode(resourceName, resource);

            var outputPath = Path.Combine(CodeGenSettings.OutputPath, ParentGroup, "Extensions");
            var outputFile = GetOutputFileName(resourceName);

            if (!Directory.Exists(outputPath))
            {
                Directory.CreateDirectory(outputPath);
            }

            var file = Path.Combine(outputPath, outputFile);

            File.WriteAllText(file, code);
        }

        public bool CanGenerate(ResourceType resource) => CanHandle(resource);

        public string GetOutputFileName(string resourceName) => $"{Parent}.With{resourceName}{FileNameAppendage}Extension.cs";

        protected abstract bool CanHandle(ResourceType resource);

        protected abstract string GenerateCode(string resourceName, ResourceType resource);

        protected abstract string Parent { get; }
        protected abstract string ParentGroup { get; }

        // ReSharper disable once UnassignedGetOnlyAutoProperty
        protected virtual string FileNameAppendage { get; }
    }
}
