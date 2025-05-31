// Publisher: Fullike (https://github.com/fullike)
// Copyright 2024. All Rights Reserved.

namespace UnrealBuildTool.Rules
{
	public class RoadBuilder : ModuleRules
	{
		public RoadBuilder(ReadOnlyTargetRules Target) : base(Target)
		{
			IWYUSupport = IWYUSupport.Full;
			PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
			
			PrivateIncludePaths.AddRange(
				[
					// ... add other private include paths required here ...
				]
			);

			PublicDependencyModuleNames.AddRange(
				[
					"Core",
                    "CoreUObject",
					"DeveloperSettings",
                    "Engine",
					"GeometryAlgorithms",
					"GeometryCore",
                    "GeoReferencing",
                    "HTTP",
                    "MeshConversion",
					"MeshDescription",
					"PCG",
					"ProceduralMeshComponent",
					"StaticMeshDescription",
					"XmlParser"
					// ... add other public dependencies that you statically link with here ...
				]
			);

			if (Target.bBuildEditor)
			{
				PublicDependencyModuleNames.AddRange(
					[
						"DesktopPlatform",
						"Slate",
						"SlateCore",
						"UnrealEd"
					]
				);
			}

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
