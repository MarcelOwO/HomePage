namespace HomePage;

public class ProjectController
{
    public Dictionary<string, string> Projects = new()
    {
        ["LEDMatrix"] = @"
                              A small group project during my apprenticeship.
                              The project goal was to build a working led matrix. I was mainly responsible for the code running the matrix and setting up the electronics that was controlling everything.
                              The matrix itself was made out of a neo-pixel led strip that we cut up and glued on wooden board, that was made by another teammate.
                              The matrix was controlled by an arduino mega, a bit overkill but we had on laying around.
                              The code that was running the matrix was rather simple. As i wasn't too familiar with coding at the time. I sourced most code from the web.
                              The main feature that I implemented were control flow and the control logic. The displayed images and games were sourced from the web.
                              ",
        ["Websites"] = @"
                             I am currently hosting 3 websites that are built with the same tech stack, namely .net blazor.
                             Also also use the mudblazor library for the frontend.
                             The applications were originally hosted on my private proxmox server but out of laziness I moved them to azure, also I was getting some weird network problems since I do not have enough bandwidth.
                             The websites are my homepage, a page to advertise my avatar comissions and another website that is supposed be a planned for my friend group that would allow them to make it easier to go to conventions.
                             Though the last one is still in development.
                                    ",
        ["ProxmoxServer"] = @"
                                 I was inspired by a friend who was hosting a complete proxmox server at home to also host something similar.
                                  So I reused on of my older laptops that I got from my old workplace to use it as a proxmox server.
                                  The server was mainly used to host a couple small services and to play around with networking.
                                  I had a container running that was hosting nginx so that I could host some websites.
                                  I had a container for my homepage, for pi-hole, next-cloud and a couple other services.
                                  The server is currently not in use as I moved some of my services to azure and am also not in need of the other ones.
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
                                  A small  project  that was based on a kit one could buy from a company called oneTesla.
                                  It is a kit for building a small musical tesla coil.
                                  Annoying while ordering it was cought by customs and I needed to pay a fee to get it.
                                  At least it was categorized as a instrument so I had to pay less.
                                  Anyway the kit was a simple solid state tesla coil with a external controller that would send light signal to the coil to play music.
                                  Apart from having some issues on applying enough varnish to the coil and the disgusting smell of ozone while using it, it was a fun project.
                              ",
        ["DiscordBot"] = @" 
                               A small discord bot that I built with d sharp plus.
                               The bot would be controlled by a desktop client built with wpf, that would give you the ability to select mp3 files from your computer and load them.
                               The bot would then join the voice channel that was programmed into.
                               And in the UI you could then select which one of those song you want to play.
                               ",
        ["Arch"] = @"
                         To learn more about linux and using it for development and university I wanted to try out arch linux.
                         I have already tried other distros like unbuntu, debain and rasbian, but I wanted to try arch since it seemed rather popular.
                         Anyway I have setup a dual boot environment on my laptop with windows 11 and arch linux.
                         I am currently using kde as the desktop environment and before that I was using hyprland.
                         ",
        ["ChatGBTDesktopApp"] = @"
                                     A small .net console application that can send some api calls to interact with the openai api to have a small chat window with some commands.
                                     At the time this would allow me to interact with the chat-gbt-3-turbo model.
                                     ",
        ["GameEngine"] = @"
                                 A small project that I plan to revisit in the future.
                                 Since I was curious about how game engines work and how they are built, so I decided to follow a tutorial to built one from scratch in c++.
                                 Though I haven't gotten too far into the project and have so far only implemented a wrapper for the windows api to create a window.
                                 This would so far only allow me to control pixels individually in the window.
     
                                 In the future I might plan to start this project over to actually learn the inner workings, though I will probably still use libraries like sdl2 and openGL/Vulkan.
                                 ",
        ["UnityMobileApp"] = @"
                                     A small unity mobile app that I built for my android phone. 
                                     The app renders a small environment with a 3d model in the center.
                                     You could swipe the screen to rotate the camera around the model.
                                     ",
        ["MassDownloader"] = @"
                                     A small console app that is used to scrape pictures from a picture board by allowing the used to specify filters. 
                                     The picture board had options to download a database export of all images and tags. The application would then use the data from the export.
                                     ",
        ["Unity Game"] = @"
                                 To learn more about game development and see how far I could get in a about 4 days of development I decided to join a gamejam.
                                 The gamejam I joined was GTKM 2024 with the theme 'built to scale'.
                                 For the gamejam I choose to make a horror game, since I find those the most interesting, even though that choice didn't make it any easier for me.
                                 I created the game in unity with the HDRP render-pipeline and used Blender for the models.
                                 The game was supposed to be about a person that was trapped in a basement and the goal was to escape.
                                 I haven't really finished the game and therefore didn't submit it at the end.
                                 It was still a fun experience, enough though I made my life harder with the choice of game.
     
                                 The game was also using analog horror as the main theme. 
                                 The final version allowed you to wander around the small basement and you where able to interact and pickup some items.
                                 Like a flashlight, a key and a computer.
                                 The latter was used as a guide in the game.   
                                 ",
        ["Voxel Engine"] = @"
                                 Just a small project in unity to play around with the low level mesh api that unity provides. 
                                 The project was rather simple, I had a simple methode that creates all the voxel data like position and type.
                                 The data would then be sent to be split into chunks, which would then be sent to a function to create the mesh for each chunk.
                                 It would also reuse the textures from minecraft to texture the voxels.
                                 During the creation of th mesh I also skipped faces that would be inside the mesh of the chunk. The creation also uses unity's job system with burst compile to improve performance.
     
                                 I might update the project in the future to improve the runtime performance by disabling rendering faces that are facing the other way, 
                                 add greedy meshing to the generating methods, some procedural generation and other things if I am bored enough. 
                                 ",
        ["Restful API"] = @"
                                 A simple project to learn how to build restful api's with asp.net. The project is still in early development.
                                 The project is using .net minimal api and entity framework core.
                                 It should in the future be used as the backend for a app for loading product data with prices.
                                 ",
        ["Scrapper with simple AI"] = @"
                                             This is another small project that is still in very early development; with some of the scrapping logic already implemented.
                                             The project is using .net and  selenium to scrape images and tags from a website.
                                             In the future it should prepare the data that is scraped and use it to train an ai model, which then might be deployed on a raspberry pi.
                                             ",
        ["Windows service for audio control"] = @"
                                                     This project was created to deal with a very weird issue that I sometimes encounter on windows and for learning more about how .net handles loading c++ libraries.
                                                     The issues that I encountered that caused me to create this project, is that windows when encountering with new sound devices, would sometimes change the default audio device to the new one.
                                                     This service should run in the background and use the windows api to check if the default audio device has changed and if it has it would change it back.
                                                     Currently still in development. I am currently able to load the functions of c++ libraries into the .net code and call them. Though changing audio devices is still something I am working on.
                                                     ",
        ["Unity Shaders"] = @"
                                 Not a project in it self, just a compilation of side projects to understand the workings of unity shaders.
                                 The shaders are made for the unity birp, to be compatible with the game vrchat. 
                                 I usually either use amplify shader editor or use unity's shader lab and hlsl to write the shaders.
                                 For example I wrote some simple spiral shaders, fire shaders and basic toon shaders.
                                 Also sometimes just converting shaders form shadertoy to unity.
                                 ",
    };
}