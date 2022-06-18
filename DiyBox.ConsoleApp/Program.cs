﻿using DIHelper;
using DiyBox.ConsoleApp;
using Unity;

IBootstraper booter = new Bootstraper(
	new UnityDependencySuite(
		new UnityContainer().AddExtension(new Diagnostic())));
booter.CreateApp();
booter.RunApp(args);