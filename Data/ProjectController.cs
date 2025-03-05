namespace HomePage;

public class ProjectController
{
    public Dictionary<string, string> Projects = new()
    {
        ["LEDMatrix"] = @"
                         During my apprenticeship, I participated in a group project aimed at building a working LED matrix. I was responsible for developing the control code and setting up the electronics behind the display. The matrix was constructed using a NeoPixel LED strip that we cut and mounted on a wooden board crafted by a teammate, and it was controlled by an Arduino Mega—more than sufficient for our needs. At that time, my coding skills were still developing, so I sourced much of the initial code from the web, while I focused on implementing the control flow and logic. The images and games displayed on the matrix were also sourced online, rounding out a project that provided a hands-on experience with both hardware and software integration.
                              ",
        ["Websites"] = @"
                           I am currently hosting three websites built using a consistent tech stack—.NET Blazor combined with the MudBlazor library for the frontend. Initially, these applications were hosted on my private Proxmox server, but due to bandwidth limitations and some network issues, I migrated them to Azure for improved performance and ease of management. The websites include my personal homepage, a dedicated page for advertising my avatar commissions, and another site in development intended to help my friend group coordinate attending conventions.
                                    ",
        ["ProxmoxServer"] = @"
                            Inspired by a friend who hosted a complete Proxmox server at home, I repurposed an older laptop from my previous workplace to create my own Proxmox server. This setup allowed me to experiment with networking while hosting several small services, including a container running Nginx for websites, as well as containers for my homepage, Pi-hole, Nextcloud, and a few other services. Although the server provided a versatile platform for these experiments, it is currently not in use since I've moved some services to Azure and no longer require the others.
                                  ",
        ["Wordle"] = @"
                          I small project that I built with .net and WPF. 
                          It is just a small desktop application that runs the game wordle locally.
                          ",
        ["Zipper"] = @"
                          A small .net desktop application built on maui with blazor.
                          The application was built to pretty much annoy my non so tech savvy friends.
                          The app allows me to select a file on my desktop and then enter a number, which would correspond to the number of times the file would be zipped.
                          It would then allow me to save the file where I want.
                          ",
        ["TeslaCoil"] = @"
                           This project involved building a small musical Tesla coil using a kit from oneTesla. The kit features a solid-state Tesla coil paired with an external controller that sends light signals to produce music. Despite a hiccup during ordering—customs intercepted the package, and I had to pay a fee, albeit reduced by its classification as an instrument—I managed to complete the project. Although there were challenges, such as applying enough varnish to the coil and contending with the pungent smell of ozone during use, it turned out to be an enjoyable and rewarding endeavor.
                              ",
        ["DiscordBot"] = @" 
                     This small Discord bot, built with D# (D Sharp Plus), is controlled by a desktop client developed using WPF. The client allows users to select and load MP3 files from their computer, and once the bot joins a predetermined voice channel, users can choose which songs to play through the interface.
                               ",
        ["Arch"] = @"
To learn more about Linux for development and university, I decided to try Arch Linux. I had already experimented with distributions like Ubuntu, Debian, and Raspbian, but Arch's popularity intrigued me. I set up a dual boot environment on my laptop with Windows 11 and Arch Linux, and I am currently using Hyprland as my desktop environment.
                         ",
        ["ChatGBTDesktopApp"] = @"
                                  This project is a small .NET console application that sends API calls to the OpenAI API, creating a simple chat interface with command functionalities. Initially designed to interact with the ChatGPT-3-Turbo model, it enables users to engage in a streamlined conversation directly from the console. The application demonstrates the basics of integrating API communication in a .NET environment, making it a practical tool for exploring conversational AI.
                                     ",
        ["GameEngine"] = @"
                           This small project, which I plan to revisit in the future, was sparked by my curiosity about the inner workings of game engines. I followed a tutorial to build one from scratch in C++, and so far, I've only managed to implement a basic wrapper for the Windows API that creates a window, allowing me to control pixels individually. In the future, I might restart the project with a more robust approach using libraries like SDL2 and OpenGL/Vulkan to gain a deeper understanding of game engine development.
                                 ",
        ["UnityMobileApp"] = @"
                                   This small Unity mobile app, built for Android, features a compact 3D environment centered around a single 3D model. Users can interact by swiping the screen, which rotates the camera around the model, allowing them to view it from multiple angles.
                                     ",
        ["MassDownloader"] = @"
                                  This small console application is designed to scrape images from a picture board by allowing users to specify filters. It leverages the board’s feature to download a complete database export of all images and tags, using that data to efficiently extract and display pictures that match the user-defined criteria.
                                     ",
        ["Unity Game"] = @"
                              In an effort to deepen my understanding of game development, I joined the GTKM 2024 gamejam with the theme ""Built to Scale"" and challenged myself to create a horror game within about four days. I built the game in Unity using the HDRP render pipeline and modeled assets in Blender, designing a narrative centered on a person trapped in a basement with the goal of escape. Although the project remains unfinished and was ultimately not submitted, it was a rewarding experience, even if the choice of a horror theme—particularly with an analog horror twist—added to the challenge. The final version allowed players to explore the confined basement environment, interact with items such as a flashlight, key, and computer, with the computer serving as an in-game guide.
                                 ",
        ["Voxel Engine"] = @"
                           This small Unity project was developed to explore Unity's low-level mesh API. It generates voxel data—including positions and types—and then splits this data into chunks, each of which is processed to create a mesh. Minecraft textures are reused to add detail to the voxels, and the mesh creation process is optimized by skipping faces that are internal to the chunk. Additionally, the project leverages Unity’s Job System with Burst compilation to boost performance. Future enhancements may include disabling rendering for backfaces, implementing greedy meshing, adding procedural generation, and other performance improvements.
                                 ",
        ["Restful API"] = @"
                 This project is a simple exploration into building RESTful APIs using ASP.NET, currently in early development. It leverages .NET Minimal API and Entity Framework Core to establish a foundational backend, with the future goal of serving an application that loads product data along with pricing information.
                                 ",
        ["Scrapper with simple AI"] = @"
               This small project is still in its early stages, with some of the scraping logic already implemented. It uses .NET and Selenium to extract images and tags from a website, and the long-term plan is to prepare the scraped data for training an AI model, which may eventually be deployed on a Raspberry Pi.
                                             ",
        ["Windows service for audio control"] = @"
                                This project was created to address a peculiar issue on Windows, where new sound devices can inadvertently become the default audio device, and to explore how .NET handles loading C++ libraries. The goal is to develop a background service that uses the Windows API to monitor for changes in the default audio device and revert them if needed. Although the project is still in development, progress has been made in integrating C++ library functions within the .NET code, with the audio device switching functionality remaining a work in progress.
                                                     ",
        ["Unity Shaders"] = @"
                         This compilation isn't a project in itself but a series of side projects aimed at exploring and understanding the intricacies of Unity shaders. The shaders, developed for the Unity Built-In Render Pipeline to ensure compatibility with VRChat, are created using either the Amplify Shader Editor or by writing directly in Unity's Shader Lab and HLSL. The collection includes various examples such as simple spiral shaders, fire shaders, and basic toon shaders, along with conversions of ShaderToy shaders into Unity.
                                 ",
        ["Backpack Controller"] = @"
The Backpack Controller is a project developed to get more exercise in C++ and is composed of two interconnected applications. One part is a small Android app built with .NET MAUI, which serves as the controller for the system. The other, more substantial component is a Linux application that renders a full-screen window, replacing the traditional LED matrix with a display mounted on the back of a backpack. Currently a work in progress, the Linux app utilizes libraries like SDL3 for window creation, and the entire system communicates via Bluetooth.
",

        ["Badge Controller"] = @"
The Badge Controller is a project designed to operate similarly to the Backpack Controller but on an ESP32 platform instead of a full Linux system. Its current implementation focuses on loading BMP images from an SD card and cycling through them, providing a simplified yet effective display solution. Although the app component is still under development, future plans include possibly reusing the existing app from the Backpack Controller while potentially offloading more computing tasks to the app itself, thus optimizing the performance of the ESP32.
",
    };
}