namespace RonSijm.FluidHumidifier.Factories.EC2
{
    public static class SecurityGroupCanTalkToExtension
    {
        public static SecurityGroupFactory CanTalkTo<T>(this StackFactory stackFactory, CombinedResult<T, SecurityGroupFactory> factory, string description, SecurityGroupFactory targetFactory, int fromPort, int toPort = 0, string protocol = "tcp")
        {
            return CanTalkTo(stackFactory, factory.T2, description, targetFactory, fromPort, toPort, protocol);
        }

        public static SecurityGroupFactory CanTalkTo<T, T2>(this StackFactory stackFactory, CombinedResult<T, T2, SecurityGroupFactory> factory, string description, SecurityGroupFactory targetFactory, int fromPort, int toPort = 0, string protocol = "tcp")
        {
            return CanTalkTo(stackFactory, factory.T3, description, targetFactory, fromPort, toPort, protocol);
        }

        public static SecurityGroupFactory CanTalkTo(this StackFactory stackFactory, SecurityGroupFactory factory, string description, SecurityGroupFactory targetFactory, int fromPort, int toPort = 0, string protocol = "tcp")
        {
            if (toPort == 0)
            {
                toPort = fromPort;
            }

            stackFactory.WithEC2SecurityGroupIngress($"{factory.InputResourceName}To{targetFactory.InputResourceName}SG-In", x =>
            {
                x.GroupId = FFn.FFnREF(factory);
                x.SourceSecurityGroupId = FFn.FFnREF(targetFactory);
                x.IpProtocol = protocol;
                x.FromPort = fromPort;
                x.ToPort = fromPort;
                x.Description = FFn.FnStringJoin($"For {description} - Lets ", FFn.FFnName(factory), " Talk to ", FFn.FFnName(targetFactory));
            });

            stackFactory.WithEC2SecurityGroupIngress($"{targetFactory.InputResourceName}To{factory.InputResourceName}SG-In", x =>
            {
                x.GroupId = FFn.FFnREF(targetFactory);
                x.SourceSecurityGroupId = FFn.FFnREF(factory);
                x.IpProtocol = protocol;
                x.FromPort = toPort;
                x.ToPort = toPort;
                x.Description = FFn.FnStringJoin($"For {description} - Lets ", FFn.FFnName(factory), " Talk to ", FFn.FFnName(targetFactory));
            });

            return factory;
        }

        public static SecurityGroupFactory AcceptTraffic<T>(this CombinedResult<T, SecurityGroupFactory> factory, string description, int fromPort, int toPort = 0, string protocol = "tcp", dynamic cidrIp = null)
        {
            return AcceptTraffic(factory.T2, description, fromPort, toPort, protocol, cidrIp);
        }

        public static SecurityGroupFactory AcceptTraffic(this SecurityGroupFactory factory, string description, int fromPort, int toPort = 0, string protocol = "tcp", dynamic cidrIp = null)
        {
            if (toPort == 0)
            {
                toPort = fromPort;
            }

            if (cidrIp == null)
            {
                cidrIp = "0.0.0.0/0";
            }

            factory.WithSecurityGroupIngress(x =>
            {
                x.IpProtocol = protocol;
                x.FromPort = fromPort;
                x.ToPort = toPort;
                x.CidrIp = cidrIp;
                x.Description = FFn.FnStringJoin($"For {description} - Lets ", FFn.FFnName(factory), $" Communicate over {protocol} {fromPort}-{toPort}");
            });

            return factory;
        }
    }
}