using CLIHelper.Unity;
using Config.Wrapper.Unity;
using DiyBox.Core;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Serilog.Wrapper.Unity;
using Unity;

namespace DiyBox.ConsoleApp;

public class UnityDependencySuite 
	: DIHelper.Unity.UnityDependencySuite
{
	public UnityDependencySuite(
		IUnityContainer container) :
			base(container)
	{
	}
	
	protected override void RegisterAppData()
    {
        RegisterSet<AppLoggerSet>();
        RegisterSet<AppConfigSet>();
        RegisterSet<DiyBoxSet>();
        RegisterSet<DescriptorSet>();
        RegisterSet<CliIOSet>();
    }

	protected override void RegisterProgram() => 
		RegisterSet<AppProgram<DiyBoxProgram>>();
}