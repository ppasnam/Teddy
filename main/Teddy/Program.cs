using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.NetworkInformation;
using System.Diagnostics;
using HtmlAgilityPack;
using System.Net;

namespace Teddy
{
    class Program
    {
        static void _hle(string user_name){
            Console.WriteLine("This feature is currently unavailable");
        }
        static void _eror_404(){
            Console.WriteLine("Eror");
            Console.WriteLine("The default location is incorrect. Please make sure it is installed on your computer and you are on the latest version");
        }
        static void _licence(){
            Console.WriteLine("You are redirected to license page");
            Process.Start("https://github.com/berat0123/Teddy/blob/main/LICENSE");
            Console.WriteLine("");
            Console.WriteLine("MIT License");
            Console.WriteLine("Copyright (c) 2022 Berat bayraktar");
            Console.WriteLine("");
            Console.WriteLine("Permission is hereby granted, free of charge, to any person obtaining a copy");
            Console.WriteLine("of this software and associated documentation files (the 'Software'), to deal");
            Console.WriteLine("in the Software without restriction, including without limitation the rights");
            Console.WriteLine("to use, copy, modify, merge, publish, distribute, sublicense, and/or sell");
            Console.WriteLine("copies of the Software, and to permit persons to whom the Software is");
            Console.WriteLine("furnished to do so, subject to the following conditions:");
            Console.WriteLine("");
            Console.WriteLine("The above copyright notice and this permission notice shall be included in all");
            Console.WriteLine("copies or substantial portions of the Software.");
            Console.WriteLine("");
            Console.WriteLine("THE SOFTWARE IS PROVIDED 'AS IS', WITHOUT WARRANTY OF ANY KIND, EXPRESS OR");
            Console.WriteLine("IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,");
            Console.WriteLine("FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE");
            Console.WriteLine("AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER");
            Console.WriteLine("LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,");
            Console.WriteLine("OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE");
            Console.WriteLine("SOFTWARE.");
        }

        static void _help(){
            Console.WriteLine("cls - Clean the console");
            Console.WriteLine("help - calls for help");
            Console.WriteLine("date - Returns the date value (system defoult)");
            Console.WriteLine("time - Returns the time value (system defoult)");
            Console.WriteLine("licence - Shows licenses");
            Console.WriteLine("version - Shows version number");
            Console.WriteLine("language - Shows the language used");
            Console.WriteLine("user name - Shows the registered user-name");
            Console.WriteLine("open source - Redirects to open source page");
            Console.WriteLine("version control - Test version current");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("cmd - Opens a cmd console");
            Console.WriteLine("paint - Opens a paint page");
            Console.WriteLine("notepad - Opens a notepad document");
            Console.WriteLine("calculator - Opens a calculator");
            Console.WriteLine("powershell - Opens a powershell console");
            Console.WriteLine("password generator - Opens the password generation service");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("write {text} - Prints the specified word to the console");
            Console.WriteLine("ping {server} - Sends a packet to the specified server");
            Console.WriteLine("start {location} - Runs the specified location");
            Console.WriteLine("delete {location} - Deletes the specified location");
        }

        static void Main(string[] args)
        {
            // test
            string defould_dzn_settings = @"C:\Teddy";
            string ctrl_dzn_settings = @"C:\Teddy\set.txt";
            if (System.IO.File.Exists(ctrl_dzn_settings))
            {
                // Settings
                string data_file_path = @"C:\Teddy\set.txt";
                string user_name = System.IO.File.ReadAllText(data_file_path);

                // start values
                var src = "no_information";
                var language = "English(en)";
                var version = 0.1;
                var start_ctrl = "on";

                Console.WriteLine("Hello "+user_name+" Welcome");

                // main
                while (start_ctrl=="on")
                {
                    Console.WriteLine("");
                    var t_reply = Console.ReadLine();
                    var reply = t_reply.ToLower();
                    Console.WriteLine("");
                    if(reply=="version"){
                        Console.WriteLine(version);
                    }
                    else if(reply=="hle"){
                        _hle(user_name);
                    }
                    else if (reply == "help")
                    {
                        _help();
                    }
                    else if (reply == "lisance")
                    {
                        _licence();
                    }
                    else if(reply=="password generator"){
                        src = @"system\password-generator.exe";
                        Process.Start(src);
                    }
                    else if(reply=="powershell"){
                        src = @"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe";
                        if (System.IO.File.Exists(src)){
                            Process.Start(src);
                        }
                        else{
                            _eror_404();
                        }
                    }
                    else if(reply=="cmd"){
                        src = @"C:\Windows\system32\cmd.exe";
                        if (System.IO.File.Exists(src)){
                            Process.Start(src);
                        }
                        else{
                            _eror_404();
                        }
                    }
                    else if(reply=="open source"){
                        Console.WriteLine("Redirecting to source...");
                        src = "https://github.com/berat0123/Teddy";
                        Process.Start(src);
                    }
                    else if(reply=="user name"){
                        Console.WriteLine(user_name);
                    }
                    else if(reply=="notepad"){
                        src = @"C:\Windows\System32\notepad.exe";
                        if (System.IO.File.Exists(src)){
                            Console.WriteLine("Notepad is starting");
                            Process.Start(src);
                        }
                        else{
                            _eror_404();
                        }
                    }
                    else if(reply=="paint"){
                        src = @"C:\Windows\System32\mspaint.exe";
                        if (System.IO.File.Exists(src)){
                            Console.WriteLine("Paint is starting");
                            Process.Start(src);
                        }
                        else{
                            _eror_404();
                        }
                    }
                    else if(reply=="calculator"){
                        src = @"C:\Windows\System32\calc.exe";
                        if (System.IO.File.Exists(src)){
                            Console.WriteLine("Calculator is starting");
                            Process.Start(src);
                        }
                        else{
                            _eror_404();
                        }
                    }
                    else if(reply=="time"){
                        var time = DateTime.Now.ToLongTimeString();
                        Console.WriteLine(time);
                    }
                    else if(reply=="date"){
                        var date = DateTime.Now.ToLongDateString();
                        Console.WriteLine(date); 
                    }
                    else if(reply=="language"){
                        Console.WriteLine(language);
                    }
                    else
                    {
                        string[] dzn = reply.Split(' ');
                        if(dzn[0]=="ping")
                        {
                            src = dzn[1];
                            int ping_response_time = 10;
                            string location_to_ping = dzn[1];
                            src = location_to_ping;
                            Ping server_to_go = new Ping();
                            try
                            {
                                PingReply aim_server_reply = server_to_go.Send(src, ping_response_time);
                                if (aim_server_reply.Status == IPStatus.Success)
                                {
                                    Console.WriteLine("the answer came");
                                }
                                else
                                {
                                    Console.WriteLine(dzn[1] + " not responding");
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Server "+dzn[1]+" not found");
                            }
                        }
                        else if(dzn[0]=="delete"){
                            src = dzn[1];
                            try
                            {
                                if (System.IO.File.Exists(src))
                                {
                                    System.IO.File.Delete(src);
                                    Console.WriteLine("Transaction completed successfully");
                                }
                                else
                                {
                                    if (System.IO.Directory.Exists(src))
                                    {
                                        System.IO.Directory.Delete(src);
                                        Console.WriteLine("Transaction completed successfully");
                                    }
                                    else
                                    {
                                        Console.WriteLine("The location you specified " + src + " was not found");
                                    }
                                }
                            }
                            catch
                            {
                                Console.WriteLine(src+ " Cannot be deleted");
                            }
                        }
                        else if(dzn[0]=="write"){
                            src = dzn[1];
                            Console.WriteLine(src);
                        }
                        else if(dzn[0]=="start"){
                            src = dzn[1];
                            if (System.IO.File.Exists(src))
                            {
                                Console.WriteLine(src+" is starting");
                                Process.Start(src);
                            }
                            else
                            {
                                if (System.IO.Directory.Exists(src))
                                {
                                    Console.WriteLine(src + " is starting");
                                    Process.Start(src);
                                }
                                else
                                {
                                    Console.WriteLine(src+" Cannot found");
                                }
                            }
                        }
                        else
                        {
                            if (reply == "cls")
                            {
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("?");
                            }
                        }
                    }
                }
            }
            else
            {
                /*
                Console.WriteLine("What is your name");
                var user_name = Console.ReadLine();
                string text = user_name;
                System.IO.Directory.CreateDirectory();
                Console.WriteLine("Adjustments made, please restart the application");
                */
                Console.WriteLine("What is your name");
                string user_name = Console.ReadLine();
                string defould_file_name = "set.txt";
                string defould_file_path = @"C:\Teddy";
                string defould_file_settings = System.IO.Path.Combine(defould_file_path, defould_file_name);
                string text = user_name;
                System.IO.Directory.CreateDirectory(defould_dzn_settings);
                System.IO.File.Create(defould_file_settings).Close();
                // write
                System.IO.File.WriteAllText(@"C:\Teddy\set.txt", text);
                Console.WriteLine("Adjustments made, please restart the application");
                Console.ReadLine();
            }
        }
    }
}