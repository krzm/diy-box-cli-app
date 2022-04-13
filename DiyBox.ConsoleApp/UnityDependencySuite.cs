using Config.Wrapper.Unity;
using DiyBox.Core;
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
    }

	protected override void RegisterProgram() => 
		RegisterSet<AppProgram<DiyBoxProgram>>();
}