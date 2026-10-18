// Global using directives

global using System.Reflection;
global using Humidifier;
global using Humidifier.IAM;
global using Microsoft.Extensions.DependencyInjection;
global using RonSijm.FluidHumidifier.Factories;

global using System.Collections;

global using Humidifier.Lambda.FunctionTypes;
global using RonSijm.FluidHumidifier.Batch;
global using RonSijm.FluidHumidifier.Factories.IAM;
global using RonSijm.FluidHumidifier.Factories.Lambda;
global using RonSijm.FluidHumidifier.Factories.S3;
global using RonSijm.FluidHumidifier.Factories.SNS;
global using RonSijm.FluidHumidifier.Features.Consumer;
global using RonSijm.FluidHumidifier.Features.Consumer.Environment;
global using RonSijm.FluidHumidifier.Features.Decorating.Interfaces;
global using RonSijm.FluidHumidifier.Features.Factories.Base;
global using RonSijm.FluidHumidifier.Features.Output;
global using RonSijm.FluidHumidifier.Github;
global using Humidifier.Json.Serializer;
global using StringValue = Humidifier.Union<string, Humidifier.BaseFunction>?;
global using StringListValue = Humidifier.Union<System.Collections.Generic.IReadOnlyList<string>, System.Collections.Generic.IReadOnlyList<Humidifier.Union<string, Humidifier.BaseFunction>>, Humidifier.BaseFunction>?;
global using RonSijm.FluidHumidifier.Features.Helpers;
