using System.Threading.Tasks;
using Humidifier.CodeGen.Lib.Features.Init;
using Humidifier.CodeGen.Lib.Features.JsonToModels;
using Humidifier.CodeGen.Lib.Features.JsonToModels.Models;
using RonSijm.FluidHumidifier.CodeGen.CLI.Generators;
using RonSijm.FluidHumidifier.CodeGen.CLI.Generators.PropertyGenerators;
using RonSijm.FluidHumidifier.CodeGen.CLI.Helpers;

namespace RonSijm.FluidHumidifier.CodeGen.CLI;

public class FluentGeneratorCore(SourceDirectoryLocator sourceDirectoryLocator, JsonSpecsRetriever jsonSpecsRetriever, SpecificationToModelParser specificationToModelParser, SpecVersionChecker specVersionChecker)
{
    public async Task Process(FluentGeneratorCoreSettings settings)
    {
        var sourcePath = sourceDirectoryLocator.TryFindSourcePath(settings.Directory);
        var json = await jsonSpecsRetriever.GetSpecsJson(sourcePath, settings.NoUpdateCheck, settings.ForceRedownload);

        var specification = specificationToModelParser.ParseSpecification(json);

        var versionFile = await specVersionChecker.CheckSpecVersion(specification, sourcePath, settings.ForceRegenerate);

        if (versionFile == null)
        {
            return;
        }

        var outputPath = Path.GetFullPath(CodeGenSettings.OutputPath);
        var projectPath = Path.GetFullPath(Path.Combine(outputPath, "..", "..", "RonSijm.FluidHumidifier.csproj"));
        if (Path.GetFileName(outputPath) != "Gen" || !File.Exists(projectPath))
        {
            throw new InvalidOperationException($"Refusing to clean a directory outside FluidHumidifier/Factories/Gen: {outputPath}");
        }

        if (Directory.Exists(outputPath))
        {
            Directory.Delete(outputPath, true);
        }

        Directory.CreateDirectory(CodeGenSettings.OutputPath);

        PropertyNameFormatter.WriteSpecsToFile(sourcePath, json);

        var resourceFactory = new ResourceFactoryFactory();

        var generatedResources = new List<ResourceType>();

        foreach (var resource in specification.ResourceTypes)
        {
            generatedResources.Add(resource);
            await resourceFactory.Create(specification, resource, resource.ClassName, true);

            var name = resource.Group + resource.ClassName;
        }

        var groupedByNamesResources = GroupResourcesByName(specification);

        var uniqueNamedResources = GetResourcesByName(groupedByNamesResources);

        var namedGeneratedResources = uniqueNamedResources.Where(x => generatedResources.Contains(x.Item2)).ToList();

        var stackFactoryFactory = new StackFactoryFactory();
        await stackFactoryFactory.Create(namedGeneratedResources);

        var generators = new List<BaseExtensionsGenerator>()
        {
            new VPCIdExtensionsGenerator(),
            new HasSubnetsExtensionsGenerator(),
        };

        foreach (var generator in generators)
        {
            var generatorResources = namedGeneratedResources.Where(x => generator.CanGenerate(x.Item2)).ToList();
            var collidingResources = generatorResources
                .GroupBy(x => generator.GetOutputFileName(x.Item1), StringComparer.OrdinalIgnoreCase)
                .Where(x => x.Count() > 1)
                .SelectMany(x => x)
                .Select(x => x.Item2)
                .ToHashSet();

            foreach (var generatedResource in generatorResources)
            {
                var resourceName = collidingResources.Contains(generatedResource.Item2)
                    ? $"{generatedResource.Item2.Group}{generatedResource.Item1}"
                    : generatedResource.Item1;

                generator.Generate(resourceName, generatedResource.Item2);
            }
        }
    }

    private static List<(string, ResourceType)> GetResourcesByName(Dictionary<string, List<ResourceType>> groupedByNamesResources)
    {
        var namedResources = new List<(string, ResourceType)>();

        foreach (var groupedByNamesResource in groupedByNamesResources)
        {
            if (groupedByNamesResource.Value.Count == 1)
            {
                var item = groupedByNamesResource.Value[0];
                namedResources.Add((item.ClassName, item));
            }
            else
            {
                foreach (var resourceType in groupedByNamesResource.Value)
                {
                    namedResources.Add(($"{resourceType.Group}{resourceType.ClassName}", resourceType));
                }
            }
        }

        return namedResources;
    }

    private static Dictionary<string, List<ResourceType>> GroupResourcesByName(Specification specification)
    {
        var groupedByNamesResources = new Dictionary<string, List<ResourceType>>();

        foreach (var resourceType in specification.ResourceTypes)
        {
            if (groupedByNamesResources.TryGetValue(resourceType.ClassName, out var list))
            {
                list.Add(resourceType);
            }
            else
            {
                groupedByNamesResources.Add(resourceType.ClassName, [resourceType]);
            }
        }

        return groupedByNamesResources;
    }
}
