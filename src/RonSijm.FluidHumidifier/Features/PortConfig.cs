namespace RonSijm.FluidHumidifier.Features
{
    public static class PortConfig
    {
        public static int RedisDefaultPort { get; set; } = 6379;
        public static int PostgreSQLDefaultPort { get; set; } = 5432;
        public const int PumaPort = 3000;
    }
}
