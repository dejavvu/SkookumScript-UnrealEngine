//=======================================================================================
// Copyright (c) 2001-2017 Agog Labs Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//=======================================================================================

//=======================================================================================
// SkookumScript Plugin for Unreal Engine 4
//=======================================================================================

using System.IO;
using UnrealBuildTool;

namespace UnrealBuildTool.Rules
{
  public class SkookumScriptGenerator : ModuleRules
  {
    public SkookumScriptGenerator(ReadOnlyTargetRules Target) : base(Target)
    {			
      // Tell build system we're not using PCHs
      PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

      PublicIncludePaths.AddRange(
        new string[] {					
          "Programs/UnrealHeaderTool/Public",
          // ... add other public include paths required here ...
        }
        );

      PrivateIncludePaths.AddRange(
        new string[] {
          // "Developer/SkookumScriptGenerator/Private",
          // ... add other private include paths required here ...
        }
        );

      PublicDependencyModuleNames.AddRange(
        new string[]
        {
          "Core",
          "CoreUObject",
          // ... add other public dependencies that you statically link with here ...
        }
        );

      PrivateDependencyModuleNames.AddRange(
        new string[]
        {
          // ... add private dependencies that you statically link with here ...
        }
        );

      DynamicallyLoadedModuleNames.AddRange(
        new string[]
        {
          // ... add any modules that your module loads dynamically here ...
        }
        );
    }
  }
}