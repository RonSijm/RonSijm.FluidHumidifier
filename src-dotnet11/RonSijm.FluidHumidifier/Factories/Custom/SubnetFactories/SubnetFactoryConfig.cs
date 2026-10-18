using RonSijm.FluidHumidifier.Factories.EC2;

namespace RonSijm.FluidHumidifier.Factories.Custom.SubnetFactories
{
    public class SubnetFactoryConfig
    {
        public string RegionName { get; set; }
        public Func<int, string> CidrBlock { get; set; }
        public int StartAt { get; set; }
        public bool Export { get; set; }
        public RouteTableFactory RouteTable { get; set; }
        public NetworkAclFactory NetworkACL { get; set; }
    }
}
