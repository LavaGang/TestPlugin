using System.Reflection;
using MelonLoader;

[assembly: AssemblyTitle(TestPlugin.BuildInfo.Description)]
[assembly: AssemblyDescription(TestPlugin.BuildInfo.Description)]
[assembly: AssemblyCompany(TestPlugin.BuildInfo.Company)]
[assembly: AssemblyProduct(TestPlugin.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + TestPlugin.BuildInfo.Author)]
[assembly: AssemblyTrademark(TestPlugin.BuildInfo.Company)]
[assembly: AssemblyVersion(TestPlugin.BuildInfo.Version)]
[assembly: AssemblyFileVersion(TestPlugin.BuildInfo.Version)]
[assembly: MelonInfo(typeof(TestPlugin.TestPlugin), TestPlugin.BuildInfo.Name, TestPlugin.BuildInfo.Version, TestPlugin.BuildInfo.Author, TestPlugin.BuildInfo.DownloadLink)]
[assembly: MelonColor()]

// Create and Setup a MelonGame Attribute to mark a Melon as Universal or Compatible with specific Games.
// If no MelonGame Attribute is found or any of the Values for any MelonGame Attribute on the Melon is null or empty it will be assumed the Melon is Universal.
// Values for MelonGame Attribute can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame(null, null)]