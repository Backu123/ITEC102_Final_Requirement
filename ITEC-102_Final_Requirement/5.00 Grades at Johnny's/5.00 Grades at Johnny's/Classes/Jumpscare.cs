﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Sample_Game_1.Classes
{
    public class Jumpscare
    {

        public static void scare()
        {

            string[] jumpscare ={
                "@@@@@@@@@@@@@@@@@@@@@@@@@@@%%#%%@@%%%@@@@@%#*+%%%@%%#*%##%########%%%@@@@%#%%%%%@%%%@%%@@@@@@@@@@@@@",
                "@@@@@@@@@@@@@@@@@@@@@@@@%%####%%@%%%%@@@@%%#*%###@@#%%%#%%#%#####%@%@%@@@%%%%%%%%%%%@@%@@@@@@@@@@@@@",
                "@@@@@@@@@@@@@@@@@@@%%%%%%#####%@%%%@%%%##***#%%%#%@@%%%%%%#%%@%%@@@%%%@@@@%%%%%%%#%%%@@@@@@@@@@@@@@@",
                "@@@@@@@@@@@@@@@%%%%%%%%#%*%#%#%@%%@@%#*+--====+*%@@@@%%%%%%%%@@%#*%%%@@@%####%%##%%%%@@@@@@@@@@@@@@@",
                "@@@@@@@@%%%%%%%%%%%%%%%%##%#%@@%#%@%#*+=-*+==**+*%@@@%%%###+#@@++==#%%@@@@%##%###%%%%@@@@@@@@@@@@@@@",
                "@@@@@@%%%%%%%%%%%%##%%%%%%#%%@%%%#%%%**=*+:::==*#%@%#%%####%@@@%%%%%%%@@@@@@@##%%%%%@@@@@@@@@@@@@@@@",
                "@@@@%%%%%%%%%######*%#%#%%#%@%%#%##%%#*+**+==+*######%%%#%%@%%**+====+*%@@@@@%%%%%%@@@@@@@@@@@@@@@@@",
                "@@@%%%%%%%%#####****##%%%#%%%#######%##%%######%#####%#####%#*+++++***+**%@@@%%%%%%%@@@@@@@@@@@@@@@@",
                "@@@%%%%%#*##*****++++#%%%%%###################%%@%%%%%##%##%#*+*=:::=***#%@@@%%%%%%%%@@@@@@@@@@@@@@@",
                "@@%%%%%###***++*+++++#%%#**+++*******+*######@@%%%%%@@@@%%##%#*+==-=****#%@@@%%####%%@%%%@@@@@@@@@@@",
                "@%%%####************#%##****=-====++*+++*#*+%@%###***#%%@@%%#%###*****#%%%%%%%#####%#%%%%%@@@@@@@@@%",
                "%%###*+*++++++=====######***+=-++*+###%#*+==#@@%%%%#####%@%#%%%%%%%%%%%%%%%%##%##%#%%%%%%%%@@@@@@@%%",
                "%###*+=+++++++==---####***++*+*@@@@@@%%*+===++*%@@@@%%%@@%**#####%######%%%%#######%%%@%%%@@@@@@@%%%",
                "%###*******+++====-###***#**%@@@%@%#*+++++=====+%@@%#*##*==****+***##%%###%%%%#####%%@%%%%@@@@@@%%%%",
                "##*****########***+#%%%%%%@%%%%@#*********+====+++====-=====+*+*****######%%%%%###%%%%##%%%@@@@@%%%%",
                "#*****#%%%%%%%%%%%@%%#@@@@@@%%##%########*+==++++++=-=======+*+=====+++***#%%%%#%%%%%%##%%%@@@@%%%%%",
                "%###%%%%%%%##%%%@@@%%%%@@@@@@@@%%%%#####***+++**+*+===+*%#*+++=========++**#%%%%%%%%%%%%%%%%%%@%%%%%",
                "%%%###%%#%%%%@@@@%%%@%@@%@@@@@@@@%###**+++++=+*+++++***%@@%#*++*=====+*#*###%%%%#%%%####%%%%%%%%%@@@",
                "%%%#####%####%%%%%%#@@@%%@@@%@@@@@@%#********++*+=++**#*%@@%#*+++++****######%%%####*####%%%%%%%%@@@",
                "#%##*#####+====+*#%%@@@@@@@%%@@@@%@@%#########**#**+++#%%%%%#****++****######%%%%%#######%%%%%%%%@@@",
                "%#######*##%+++++*##%%%%@%%@@@@@%%@@@@%%%%%########***#%%#**#######**#####%%%%%%%%%%%####%%%%%%%%@@@",
                "%%##%%####*%@#*+*##%##%%*%#%@@@@@@@@@@%@@@@%@@@%%%#%%%@@%*+***##%%%%####%%%%##%%%%%%%%####%%%%%%%@@@",
                "%%%@%%%#%###*#%####%%@@+*@@@@@@@@@%##%@@@@@%@@@@%%%%#%@@%%#%#%%%%%@@%%#%%%%%####%%%%%%%###%%%%%%%%@@",
                "%%@%%%###%%%####%%@%@@#+@%=%@@@@@@@%#%%*+#@%#%@@%@@@@%%@@@@%%@@@%@@@%#######%###%%#%%%%%#%%%%%%%%%@@",
                "%%%%@@%%#@@%####%%%%@%%%%=*@@%*@@@@@@@%**##+==%@%%%@@%@@@@@%@@@%%@@%#*#**######*###%%%%%%%%%%%%%%%%%",
                "%%@%@@%%%@%%%#%%@@%%%@@@#*%@#-#@@@%*@@@@*%%###@%%%@@@@@@@@@#@@@@@%#@###########*#%#%%%%@%%@@@%%%%%%%",
                "%%%%@@%%%@%%%##%@%@@@@@@@%@%+*@@@%-#%@@*=%@@@#@%%@@@@@@@@%#*@@@@@*-%%%%%%%#####*###%#%%%%%%%#%@@%@%@",
                "%%%%%%%%%%%%%%%%%%@@%%%@@@@%%%@@@++@@@#-%@@@*=@@@@*%@@#*@@=%@##@@*:+@%%%%%%##%##%@#%%%%%%%*=-+%%@%@@"
        };

            SoundPlayer sound = new SoundPlayer();
            string musicPlayer = "fnafSound.wav";
            
            for (int i = 0; i < 7; i++) { Console.WriteLine(); }
            for (int i = 0; i < jumpscare.Length; i++) { Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (jumpscare[i].Length / 2)) + "}", jumpscare[i])); }
            sound.SoundLocation = musicPlayer;
            sound.Play();
            Console.ReadKey();
            Console.WriteLine();
            



        }
    }
}
