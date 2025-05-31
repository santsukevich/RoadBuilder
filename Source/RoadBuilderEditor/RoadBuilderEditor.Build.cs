// Publisher: Fullike (https://github.com/fullike)
// Copyright 2024. All Rights Reserved.

namespace UnrealBuildTool.Rules
{
	public class RoadBuilderEditor : ModuleRules
	{
		public RoadBuilderEditor(ReadOnlyTargetRules Target) : base(Target)
		{
			IWYUSupport = IWYUSupport.Full;
			PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
			
			PublicIncludePaths.AddRange(
				[
					// ... add public include paths required here ...
				]
			);

			PrivateIncludePaths.AddRange(
				[
					// ... add other private include paths required here ...
				]
			);

			PublicDependencyModuleNames.AddRange(
				[
					"BlueprintGraph",
					"ContentBrowserData",
					"Core",
                    "CoreUObject",
					"DesktopPlatform",
					"EditorStyle",
					"EditorFramework",
                    "Engine",
					"GeometryAlgorithms",
					"GeometryCore",
                    "InputCore",
					"MainFrame",
					"RenderCore",
					"RoadBuilder",
                    "Slate",
                    "SlateCore",
					"ToolMenus",
                    "UnrealEd"
					// ... add other public dependencies that you statically link with here ...
				]
			);

			PrivateDependencyModuleNames.AddRange(
				[
					// ... add private dependencies that you statically link with here ...
				]
			);

			DynamicallyLoadedModuleNames.AddRange(
				[
					// ... add any modules that your module loads dynamically here ...
				]
			);
		}
	}
}
