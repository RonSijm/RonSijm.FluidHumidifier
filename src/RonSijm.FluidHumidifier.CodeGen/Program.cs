using System.Threading.Tasks;
using Humidifier.CodeGen.Lib;
using Microsoft.Extensions.DependencyInjection;
using RonSijm.FluidHumidifier.CodeGen.CLI.Features.Wiring;

namespace RonSijm.FluidHumidifier.CodeGen.CLI;

public static class Program
{
    public static async Task Main(string[] args)
    {
        args ??= [];

        var serviceProvider = new ServiceCollection().WireEntryImplicit().WireImplicit<CodeGeneratorCore>().BuildServiceProvider();

        var core = serviceProvider.GetRequiredService<FluentGeneratorCore>();

        var config = ConfigArgParser.CreateConfig(args);
        await core.Process(config);
    }
}