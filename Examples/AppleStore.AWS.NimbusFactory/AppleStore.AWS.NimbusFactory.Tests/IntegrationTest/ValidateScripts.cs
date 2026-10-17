using System.Diagnostics;
using System.Text;
using AppleStore.AWS.NimbusFactory.CLI;
using AppleStore.AWS.NimbusFactory.CLI.Core.Wiring;
using FluentAssertions;
using RonSijm.FluidHumidifier.Features.Output;

namespace AppleStore.AWS.NimbusFactory.Tests.IntegrationTest
{
    public class ValidateScripts
    {
        [Fact]
        public async Task AllScriptsAreValid()
        {
            var serviceProvider = ServiceProviderBuilder.Build();
            var environmentFactory = serviceProvider.GetRequiredService<EnvironmentResultFactory>();

            var environments = environmentFactory.CreateEnvironments();
            var integrationDirectory = Path.Combine(AppContext.BaseDirectory, "IntegrationTest");
            Directory.CreateDirectory(Path.Combine(integrationDirectory, "Results"));

            foreach (var stack in environments.SelectMany(environment => environment.Stacks))
            {
                stack.BaseDir = integrationDirectory;
                stack.RelativePath = @"\Scripts\";
            }

            environments.WriteScriptsToFiles();

            var bob = new StringBuilder();

            await foreach (var result in CreateResults(environments))
            {
                var (stack, outputFile, errorFilePath) = result;

                var error = await File.ReadAllTextAsync(errorFilePath);
                Assert.True(string.IsNullOrEmpty(error), $"cfn-lint errors:\n{error}");

                var output = await File.ReadAllTextAsync(outputFile);

                if (output.Contains("E"))
                {
                    var lines = output.Split(Environment.NewLine);

                    for (var index = 0; index < lines.Length; index++)
                    {
                        if (lines[index].StartsWith("E"))
                        {
                            bob.AppendLine(lines[index]);
                            bob.AppendLine(lines[index + 1]);
                            bob.AppendLine();
                        }
                    }
                }
            }

            var errors = bob.ToString();
            errors.Should().Be(string.Empty);
        }

        private static async IAsyncEnumerable<(IOutputResult stack, string outputFile, string errorFile)> CreateResults<T>(List<T> environments) where T: EnvironmentOutputResult
        {
            foreach (var environment in environments)
            {
                foreach (var stack in environment.Stacks)
                {
                    var template = $"{stack.BaseDir}{stack.RelativePath}{stack.Name}.json";
                    var outputLocation = $"{stack.BaseDir}\\Results\\{stack.Name}.json";
                    var outputFilePath = $"{outputLocation}.output.txt";
                    var errorFilePath = $"{outputLocation}.errors.log";

                    var processStartInfo = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",
                        Arguments = $"/c cfn-lint \"{template}\" > \"{outputFilePath}\" 2> \"{errorFilePath}\"",
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    };

                    using (var process = new Process())
                    {
                        process.StartInfo = processStartInfo;
                        process.Start();

                        await process.WaitForExitAsync();
                    }

                    yield return (stack, outputFilePath, errorFilePath);
                }
            }
        }
    }
}
