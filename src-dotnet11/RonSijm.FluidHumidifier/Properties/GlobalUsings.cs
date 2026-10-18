// Global using directives

global using System.Reflection;
global using Humidifier;
global using Humidifier.IAM;
global using JetBrains.Annotations;

global using RonSijm.FluidHumidifier.Features.Factories.Extensions;
global using RonSijm.FluidHumidifier.Features.Factories.Base;

global using RonSijm.FluidHumidifier.Factories.Core;
global using RonSijm.FluidHumidifier.Features.Helpers;

global using PolicyPrincipalValue = Humidifier.Union<string, Humidifier.PolicyPrincipal, System.Collections.Generic.IReadOnlyDictionary<string, object>, Humidifier.BaseFunction>?;
global using PolicyResourceValue = Humidifier.Union<string, System.Collections.Generic.IReadOnlyList<string>, System.Collections.Generic.IReadOnlyList<Humidifier.Union<string, Humidifier.BaseFunction>>, System.Lazy<string>, Humidifier.BaseFunction>?;
