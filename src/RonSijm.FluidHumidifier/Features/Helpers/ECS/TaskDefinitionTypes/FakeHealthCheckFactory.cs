using Humidifier.ECS.TaskDefinitionTypes;

namespace RonSijm.FluidHumidifier.Features.Helpers.ECS.TaskDefinitionTypes
{
    public static class FakeHealthCheckFactory
    {
        public static HealthCheck FakeHealthCheck { get; } = new()
        {
            Command = new[] { "CMD-SHELL", "exit 0" },
            Interval = 30,
            Timeout = 30,
            Retries = 3,
            StartPeriod = 1,
        };
    }
}