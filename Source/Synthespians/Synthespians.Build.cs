// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Synthespians : ModuleRules
{
	public Synthespians(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"Synthespians",
			"Synthespians/Variant_Platforming",
			"Synthespians/Variant_Platforming/Animation",
			"Synthespians/Variant_Combat",
			"Synthespians/Variant_Combat/AI",
			"Synthespians/Variant_Combat/Animation",
			"Synthespians/Variant_Combat/Gameplay",
			"Synthespians/Variant_Combat/Interfaces",
			"Synthespians/Variant_Combat/UI",
			"Synthespians/Variant_SideScrolling",
			"Synthespians/Variant_SideScrolling/AI",
			"Synthespians/Variant_SideScrolling/Gameplay",
			"Synthespians/Variant_SideScrolling/Interfaces",
			"Synthespians/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
