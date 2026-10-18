// Global using directives

global using Humidifier;
global using Humidifier.Json;
global using JetBrains.Annotations;
global using Microsoft.Extensions.DependencyInjection;
global using VerifyTests;
global using static VerifyXunit.Verifier;

global using StringValue = Humidifier.Union<string, Humidifier.BaseFunction>?;
global using StringListValue = Humidifier.Union<System.Collections.Generic.IReadOnlyList<string>, System.Collections.Generic.IReadOnlyList<Humidifier.Union<string, Humidifier.BaseFunction>>, Humidifier.BaseFunction>?;
