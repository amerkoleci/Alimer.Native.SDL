﻿// Copyright (c) Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using CppAst;

namespace Generator;

public static class Program
{
    public static int Main(string[] args)
    {
        string outputPath = AppContext.BaseDirectory;
        if (args.Length > 0)
        {
            outputPath = args[0];
        }

        if (!Path.IsPathRooted(outputPath))
        {
            outputPath = Path.Combine(AppContext.BaseDirectory, outputPath);
        }

        if (!outputPath.EndsWith("Generated"))
        {
            outputPath = Path.Combine(outputPath, "Generated");
        }

        if (!Directory.Exists(outputPath))
        {
            Directory.CreateDirectory(outputPath);
        }

        CsCodeGeneratorOptions generateOptions = new()
        {
            OutputPath = outputPath,
            ClassName = "SDL3",
            Namespace = "SDL3",
            PublicVisiblity = true,
            EnumWriteUnmanagedTag = true
        };

        string sdlIncludePath = Path.Combine(AppContext.BaseDirectory, "include");

        List<string> headers =
        [
            Path.Combine(sdlIncludePath, "SDL3/SDL_atomic.h"),
            Path.Combine(sdlIncludePath, "SDL3/SDL_audio.h"),
            Path.Combine(sdlIncludePath, "SDL3/SDL_blendmode.h"),
            Path.Combine(sdlIncludePath, "SDL3/SDL_camera.h"),
            Path.Combine(sdlIncludePath, "SDL3/SDL_clipboard.h"),
            Path.Combine(sdlIncludePath, "SDL3/SDL_cpuinfo.h"),
            Path.Combine(sdlIncludePath, "SDL3/SDL_dialog.h"),
            Path.Combine(sdlIncludePath, "SDL3/SDL_error.h"),
            Path.Combine(sdlIncludePath, "SDL3/SDL_events.h"),
            Path.Combine(sdlIncludePath, "SDL3/SDL_filesystem.h"),
            Path.Combine(sdlIncludePath, "SDL3/SDL_gamepad.h"),
            Path.Combine(sdlIncludePath, "SDL3/SDL_guid.h"),
            Path.Combine(sdlIncludePath, "SDL3/SDL_haptic.h"),
            Path.Combine(sdlIncludePath, "SDL3/SDL_hidapi.h"),
            Path.Combine(sdlIncludePath, "SDL3/SDL_hints.h"),
            Path.Combine(sdlIncludePath, "SDL3/SDL_init.h"),
            Path.Combine(sdlIncludePath, "SDL3/SDL_iostream.h"),
            Path.Combine(sdlIncludePath, "SDL3/SDL_joystick.h"),
            Path.Combine(sdlIncludePath, "SDL3/SDL_keyboard.h"),
            Path.Combine(sdlIncludePath, "SDL3/SDL_keycode.h"),
            Path.Combine(sdlIncludePath, "SDL3/SDL_loadso.h"),
            Path.Combine(sdlIncludePath, "SDL3/SDL_locale.h"),
            Path.Combine(sdlIncludePath, "SDL3/SDL_log.h"),
            Path.Combine(sdlIncludePath, "SDL3/SDL_messagebox.h"),
            Path.Combine(sdlIncludePath, "SDL3/SDL_metal.h"),
            Path.Combine(sdlIncludePath, "SDL3/SDL_misc.h"),
            Path.Combine(sdlIncludePath, "SDL3/SDL_mouse.h"),
            Path.Combine(sdlIncludePath, "SDL3/SDL_mutex.h"),
            Path.Combine(sdlIncludePath, "SDL3/SDL_pen.h"),
            Path.Combine(sdlIncludePath, "SDL3/SDL_pixels.h"),
            Path.Combine(sdlIncludePath, "SDL3/SDL_platform.h"),
            Path.Combine(sdlIncludePath, "SDL3/SDL_power.h"),
            Path.Combine(sdlIncludePath, "SDL3/SDL_properties.h"),
            Path.Combine(sdlIncludePath, "SDL3/SDL_rect.h"),
            Path.Combine(sdlIncludePath, "SDL3/SDL_render.h"),
            Path.Combine(sdlIncludePath, "SDL3/SDL_revision.h"),
            Path.Combine(sdlIncludePath, "SDL3/SDL_scancode.h"),
            Path.Combine(sdlIncludePath, "SDL3/SDL_sensor.h"),
            Path.Combine(sdlIncludePath, "SDL3/SDL_stdinc.h"),
            Path.Combine(sdlIncludePath, "SDL3/SDL_storage.h"),
            Path.Combine(sdlIncludePath, "SDL3/SDL_surface.h"),
            Path.Combine(sdlIncludePath, "SDL3/SDL_thread.h"),
            Path.Combine(sdlIncludePath, "SDL3/SDL_time.h"),
            Path.Combine(sdlIncludePath, "SDL3/SDL_timer.h"),
            Path.Combine(sdlIncludePath, "SDL3/SDL_touch.h"),
            Path.Combine(sdlIncludePath, "SDL3/SDL_version.h"),
            Path.Combine(sdlIncludePath, "SDL3/SDL_video.h"),
            Path.Combine(sdlIncludePath, "SDL3/SDL_vulkan.h"),
            Path.Combine(sdlIncludePath, "SDL3/SDL_system.h"),
            Path.Combine(sdlIncludePath, "SDL3/SDL_main.h"),
        ];

        var options = new CppParserOptions
        {
            ParseMacros = false,
            SystemIncludeFolders =
            {
                Path.Combine(AppContext.BaseDirectory, "include")
            },
            Defines =
            {
                "SDL_PLATFORM_ANDROID",
                "SDL_PLATFORM_IOS",
                "SDL_PLATFORM_WINRT",
            }
        };

        foreach (string header in headers)
        {
            CppCompilation compilation = CppParser.ParseFile(header, options);

            // Print diagnostic messages
            if (compilation.HasErrors)
            {
                foreach (CppDiagnosticMessage message in compilation.Diagnostics.Messages)
                {
                    if (message.Type == CppLogMessageType.Error)
                    {
                        var currentColor = Console.ForegroundColor;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(message);
                        Console.ForegroundColor = currentColor;
                    }
                }

                return 0;
            }

            CsCodeGenerator.Collect(compilation);
        }

        CsCodeGenerator.Generate(generateOptions);

        return 0;
    }
}
