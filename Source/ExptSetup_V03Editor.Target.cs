// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class ExptSetup_V03EditorTarget : TargetRules
{
	public ExptSetup_V03EditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "ExptSetup_V03" } );
	}
}
