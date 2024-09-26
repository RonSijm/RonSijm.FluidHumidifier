using Humidifier.CodeGen.Lib.Features.JsonToModels.Models;

namespace RonSijm.FluidHumidifier.CodeGen.CLI.Generators.PropertyGenerators
{
    public abstract class BaseExtensionsGenerator
    {
        public void Generate(string resourceName, ResourceType resource)
        {
            if (!CanHandle(resource))
            {
                return;
            }

            var code = GenerateCode(resourceName, resource);

            var outputPath = $"{CodeGenSettings.OutputPath}{ParentGroup}\\Extensions\\";
            var outputFile = $"{Parent}.With{resourceName}{FileNameAppendage}Extension.cs";

            if (!Directory.Exists(outputPath))
            {
                Directory.CreateDirectory(outputPath);
            }

            var file = outputPath + outputFile;

            File.WriteAllText(file, code);
        }

        protected abstract bool CanHandle(ResourceType resource);

        protected abstract string GenerateCode(string resourceName, ResourceType resource);

        protected abstract string Parent { get; }
        protected abstract string ParentGroup { get; }

        // ReSharper disable once UnassignedGetOnlyAutoProperty
        protected virtual string FileNameAppendage { get; }
    }
}