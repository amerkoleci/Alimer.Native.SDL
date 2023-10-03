﻿// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using System.Text;
using CppAst;

namespace Generator;

public static partial class CsCodeGenerator
{
    private static readonly List<CppMacro> s_collectedMacros = new();

    private static void CollectConstants(CppCompilation compilation)
    {
        foreach (CppMacro cppMacro in compilation.Macros)
        {
            if (string.IsNullOrEmpty(cppMacro.Value)
                || cppMacro.Name.EndsWith("_H_", StringComparison.OrdinalIgnoreCase)
                || cppMacro.Name.Equals("SDL_SCANCODE_TO_KEYCODE", StringComparison.OrdinalIgnoreCase)
                || cppMacro.Name.Equals("SDL_INIT_EVERYTHING", StringComparison.OrdinalIgnoreCase) 
                || cppMacro.Name.Equals("VK_DEFINE_HANDLE", StringComparison.OrdinalIgnoreCase)
                || cppMacro.Name.Equals("VK_DEFINE_NON_DISPATCHABLE_HANDLE", StringComparison.OrdinalIgnoreCase)
                || cppMacro.Name.Equals("VK_DEFINE_NON_DISPATCHABLE_HANDLE", StringComparison.OrdinalIgnoreCase)
                )
            {
                continue;
            }

            if (cppMacro.Name == "SDL_OutOfMemory" ||
                cppMacro.Name == "SDL_Unsupported" ||
                cppMacro.Name == "SDL_InvalidParamError" ||
                cppMacro.Name == "SDL_BUTTON" ||
                cppMacro.Name == "SDL_BUTTON_LMASK" ||
                cppMacro.Name == "SDL_BUTTON_MMASK" ||
                cppMacro.Name == "SDL_BUTTON_RMASK" ||
                cppMacro.Name == "SDL_BUTTON_X1MASK" ||
                cppMacro.Name == "SDL_BUTTON_X2MASK" ||
                cppMacro.Name == "SDL_MS_TO_NS" ||
                cppMacro.Name == "SDL_NS_TO_MS" ||
                cppMacro.Name == "SDL_US_TO_NS" ||
                cppMacro.Name == "SDL_NS_TO_US" ||
                cppMacro.Name == "SDL_TOUCH_MOUSEID" ||
                cppMacro.Name == "SDL_MOUSE_TOUCHID")
            {
                continue;
            }

            s_collectedMacros.Add(cppMacro);
        }
    }

    private static void GenerateConstants()
    {
        string visibility = s_options.PublicVisiblity ? "public" : "internal";
        using var writer = new CodeWriter(Path.Combine(s_options.OutputPath, "Constants.cs"), false, s_options.Namespace, []);
        using (writer.PushBlock($"{visibility} static partial class {s_options.ClassName}"))
        {
            foreach (CppMacro cppMacro in s_collectedMacros)
            {
                //string csName = GetPrettyEnumName(cppMacro.Name, "VK_");

                string modifier = "const";
                string csDataType = "string";
                string macroValue = NormalizeEnumValue(cppMacro.Value);
                if (macroValue.EndsWith("F", StringComparison.OrdinalIgnoreCase))
                {
                    csDataType = "float";
                }
                else if (macroValue.EndsWith("LL", StringComparison.OrdinalIgnoreCase))
                {
                    csDataType = "long";
                }
                else if (macroValue.EndsWith("UL", StringComparison.OrdinalIgnoreCase))
                {
                    csDataType = "ulong";
                }
                else if (macroValue.EndsWith("U", StringComparison.OrdinalIgnoreCase))
                {
                    csDataType = "uint";
                }
                else if (uint.TryParse(macroValue, out _) || macroValue.StartsWith("0x"))
                {
                    csDataType = "uint";
                }
                else if (macroValue.Contains("<<"))
                {
                    csDataType = "int";
                }

                if (cppMacro.Name == "SDL_OutOfMemory" || cppMacro.Name == "SDL_Unsupported")
                {
                    modifier = "static readonly";
                    csDataType = "int";
                }
                if (cppMacro.Name == "SDL_JOYSTICK_AXIS_MAX" || cppMacro.Name == "SDL_JOYSTICK_AXIS_MIN")
                {
                    csDataType = "int";
                }
                if (cppMacro.Name == "SDL_IPHONE_MAX_GFORCE")
                {
                    csDataType = "float";
                    macroValue = "5.0f";
                }
                if (cppMacro.Name == "SDL_HAT_RIGHTUP"
                    || cppMacro.Name == "SDL_HAT_RIGHTDOWN"
                    || cppMacro.Name == "SDL_HAT_LEFTUP"
                    || cppMacro.Name == "SDL_HAT_LEFTDOWN")
                {
                    csDataType = "uint";
                }
                if (cppMacro.Name == "SDL_NS_PER_SECOND")
                {
                    csDataType = "long";
                }

                writer.WriteLine($"/// <unmanaged>{cppMacro.Name}</unmanaged>");
                writer.WriteLine($"public {modifier} {csDataType} {cppMacro.Name} = {macroValue};");
            }
        }
    }

}
