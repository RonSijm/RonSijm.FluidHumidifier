using RonSijm.FluidHumidifier.Features.Consumer;

namespace RonSijm.FluidHumidifier.Features.Output
{
    public class CreateEnvironmentConfig
    {
        public string OutputDir { get; set; }
        public Func<EnvironmentConfig, string> WithNotifications { get; set; }
        public int StartNotificationsAtStack { get; set; }
        public bool NoFailOnEmptyChangeset { get; set; } = true;
        public bool DisableRoleBack { get; set; } = false;
        public string Capabilities { get; set; } = "CAPABILITY_IAM, CAPABILITY_NAMED_IAM";
    }
}