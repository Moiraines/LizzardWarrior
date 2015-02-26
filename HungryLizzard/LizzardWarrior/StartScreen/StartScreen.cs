﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

class StartScreen
{

    public static int SelectLevel()
    {
        HungryLizard.MainGame.InitConsole(ConsoleColor.White, ConsoleColor.Black);
        int levelSelected=0;
        string select = @"
    /$$$$$$  /$$$$$$$$ /$$       /$$$$$$$$  /$$$$$$  /$$$$$$$$       /$$       /$$$$$$$$ /$$    /$$ /$$$$$$$$ /$$          
   /$$__  $$| $$_____/| $$      | $$_____/ /$$__  $$|__  $$__/      | $$      | $$_____/| $$   | $$| $$_____/| $$          
  | $$  \__/| $$      | $$      | $$      | $$  \__/   | $$         | $$      | $$      | $$   | $$| $$      | $$       /$$
  |  $$$$$$ | $$$$$   | $$      | $$$$$   | $$         | $$         | $$      | $$$$$   |  $$ / $$/| $$$$$   | $$      |__/
   \____  $$| $$__/   | $$      | $$__/   | $$         | $$         | $$      | $$__/    \  $$ $$/ | $$__/   | $$          
   /$$  \ $$| $$      | $$      | $$      | $$    $$   | $$         | $$      | $$        \  $$$/  | $$      | $$       /$$
  |  $$$$$$/| $$$$$$$$| $$$$$$$$| $$$$$$$$|  $$$$$$/   | $$         | $$$$$$$$| $$$$$$$$   \  $/   | $$$$$$$$| $$$$$$$$|__/
   \______/ |________/|________/|________/ \______/    |__/         |________/|________/    \_/    |________/|________/                                                                                                                              
 ___      _    __    _               _    _____                     _   _         
|_  |    |_|  |  |  |_|___ ___ ___ _| |  |  _  |___ ___ ___ ___ ___| |_|_|___ ___ 
 _| |_    _   |  |__| |- _| .'|  _| . |  |     | . | . |  _| -_|   |  _| |  _| -_|
|_____|  |_|  |_____|_|___|__,|_| |___|  |__|__|  _|  _|_| |___|_|_|_| |_|___|___|
                                               |_| |_|                                                                                                    
 ___    _    _____           _                  __    _               _ 
|_  |  |_|  |  _  |_____ ___| |_ ___ _ _ ___   |  |  |_|___ ___ ___ _| |
|  _|   _   |     |     | .'|  _| -_| | |  _|  |  |__| |- _| .'|  _| . |
|___|  |_|  |__|__|_|_|_|__,|_| |___|___|_|    |_____|_|___|__,|_| |___|
                                                                                                                                                            
 ___    _    _____                 _                   _    __    _               _ 
|_  |  |_|  |   __|_ _ ___ ___ ___|_|___ ___ ___ ___ _| |  |  |  |_|___ ___ ___ _| |
|_  |   _   |   __|_'_| . | -_|  _| | -_|   |  _| -_| . |  |  |__| |- _| .'|  _| . |
|___|  |_|  |_____|_,_|  _|___|_| |_|___|_|_|___|___|___|  |_____|_|___|__,|_| |___|
                      |_|                                                                                                                 
 ___    _    _____            __    _               _
| | |  |_|  |  _  |___ ___   |  |  |_|___ ___ ___ _| |
|_  |   _   |   __|  _| . |  |  |__| |- _| .'|  _| . |
  |_|  |_|  |__|  |_| |___|  |_____|_|___|__,|_| |___|
                                                                                                                  
 ___    _    _____ _ _              __    _               _ 
|  _|  |_|  |  |  | | |_ ___ ___   |  |  |_|___ ___ ___ _| |
|_  |   _   |  |  | |  _|  _| .'|  |  |__| |- _| .'|  _| . |
|___|  |_|  |_____|_|_| |_| |__,|  |_____|_|___|__,|_| |___|";
        Console.Write(select);
        while (true)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                while (Console.KeyAvailable) Console.ReadKey(true);
                switch (key.KeyChar)
                {
                    case '1': levelSelected = 30; break;
                    case '2': levelSelected = 0; break;
                    case '3': levelSelected = -30; break;
                    case '4': levelSelected = -60; break;
                    case '5': levelSelected = -100; break;
                    default: HungryLizard.MainGame.PrintStringOnPosition(0, Console.WindowHeight - 2, "Invalid Selection!", ConsoleColor.White); break;
                }

            }
            if (levelSelected!=0)
            {
                break;
            }
        }
        return levelSelected;
    }
    public static int DrawScreen()
    {

        HungryLizard.MainGame.InitConsole(ConsoleColor.White, ConsoleColor.Black);
        string screen = @"        
  *------------------------------------------------------------------------------------------------------------------------*
  *   ___________.__               ___ ___                                     .____    .__                         .___   *
  *   \__    ___/|  |__   ____    /   |   \ __ __  ____    ___________ ___.__. |    |   |__|____________ _______  __| _/   *
  *     |    |   |  |  \_/ __ \  /    ~    \  |  \/    \  / ___\_  __ <   |  | |    |   |  \___   /\__  \\_  __ \/ __ |    *
  *     |    |   |   Y  \  ___/  \    Y    /  |  /   |  \/ /_/  >  | \/\___  | |    |___|  |/    /  / __ \|  | \/ /_/ |    *
  *     |____|   |___|  /\___  >  \___|_  /|____/|___|  /\___  /|__|   / ____| |_______ \__/_____ \(____  /__|  \____ |    *
  *                   \/     \/         \/            \//_____/        \/              \/        \/     \/           \/    *
  *------------------------------------------------------------------------------------------------------------------------*
                                                                                                                                               			               
                                               __,---*::.-  -::_ _ `-----.___      ______
                                            _,-*::_  ::-  -  -. _   ::-::_   .`--,*   :: .:`-._
                                         ,-*_ ::   _  ::_ .:   :: - _ .:   ::- _/ ::   ,-. ::. `-._
                                     _,-*   ::-  ::        ::-  _ ::  -  ::     |  .: ((|))      ::`.
                             ___,---*   ::    ::    ;::   ::     :.- _ ::._  :: \ :    `_____::..--*
                         ,-**  ::  ::.   ,------.  (.  ::  \  ::  ::  ,-- :. _  :`. ::  \       `-._
                       ,*     ::   *   _._.:_  :.)___,-------------._(.:: ____`-._ `._ ::`--...___; ;
                      ;:::. ,--*--*****      /  /                     \. |     ``-----`**`---------*
                     ;  `::;              _ /.:/_,                    _\.:\_,
                     |    ;             =*-//\\--*                  =*-//\\--*
                     `   .|               **  ``                      **  ``
                      \::*\
                       \   \
                        `..:`.		              
                          `.  `--.____                  Catch the fly!
                            `-:______ `-._	              
                                     `---*`           ░░░▒▒▒▒▒▓▓▓▒▒▒▒▒░░░                        
                                                      ░╔╦╦╦═╦╗╔═╦═╦══╦═╗░                         
                                 Catch the fly!       ░║║║║╩╣╚╣═╣║║║║║╩╣░       Catch the fly!             
                                                      ░╚══╩═╩═╩═╩═╩╩╩╩═╝░                        
                                                      ░░░▒▒▒▒▒▓▓▓▒▒▒▒▒░░░
            		                        
                                                        Catch the fly!";
        Console.Write(screen);
        for (int i = 0; i < Console.WindowWidth; i++)
        {
            HungryLizard.MainGame.PrintOnPosition(i, Console.WindowHeight - 1, '|', ConsoleColor.Black);
            Thread.Sleep(15);
        }
        return SelectLevel();
    }
}

