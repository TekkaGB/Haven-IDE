﻿using IDE_test;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// IMPORTANT: this and every thing else in the folder not mine is indeed as the name already should tell
// not mine and i dont have any right or reason to claim that i code this.
// i got this script from the AtlusScriptCompilerGUI source code and i selfishly modified use it. 
// you can find the source code here: https://github.com/ShrineFox/AtlusScriptCompiler-GUI


namespace AtlusScriptCompilerGUI
{
    public partial class GUI
    {
        public static bool Hook { get; set; }
        public static bool Disassemble { get; set; }
        public static bool Overwrite { get; set; }
        public static bool Log { get; set; }
        public static int Selection { get; set; }

        public static List<string> GamesDropdown = new List<string>()
        {
            "SMT 3 Nocturne",
            "SMT Digital Devil Saga",
            "Persona 3 Portable",
            "Persona 3",
            "Persona 3 FES",
            "Persona 4",
            "Persona 4 Golden",
            "Persona 5",
            "Persona 5 Royal",
            "Persona Q2",
        };

        public static void Compile(string[] fileList, string compilerPath)
        {
            ArrayList args = new ArrayList();
            for (int i = 0; i < fileList.Count(); i++)
            {
                string ext = Path.GetExtension(fileList[i]).ToUpper();
                if (ext == ".MSG" || ext == ".FLOW")
                {
                    args.Add(GetArgument(fileList[i], ext, "-Compile ", compilerPath));
                }
            }
            
            RunCMD(args, compilerPath);
        }
        
        public static void Decompile(string[] fileList, string compilerPath)
        {
            ArrayList args = new ArrayList();
            for (int i = 0; i < fileList.Count(); i++)
            {
                MessageBox.Show(fileList[i]);
                string ext = Path.GetExtension(fileList[i]).ToUpper();
                if (ext == ".BMD" || ext == ".BF")
                {
                    args.Add(GetArgument(fileList[i], ext, "-Decompile ", compilerPath));
                }
            }
            RunCMD(args, compilerPath);
        }

        private static string GetArgument(string droppedFilePath, string extension, string compileArg, string compilerPath)
        {
            string encodingArg = "";
            string libraryArg = "";
            string outFormatArg = "";

            switch (Selection)
            {
                case 0: //SMT3
                    encodingArg = "-Encoding P3";
                    if (extension != ".BMD")
                        libraryArg = "-Library SMT3";
                    if (extension == ".MSG")
                        outFormatArg = "-OutFormat V1";
                    if (extension == ".FLOW")
                        outFormatArg = "-OutFormat V1";
                    break;
                case 1: //DDS
                    encodingArg = "-Encoding P3";
                    if (extension != ".BMD")
                        libraryArg = "-Library DDS";
                    if (extension == ".MSG")
                        outFormatArg = "-OutFormat V1DDS";
                    if (extension == ".FLOW")
                        outFormatArg = "-OutFormat V1DDS";
                    break;
                case 2: //P3P
                    encodingArg = "-Encoding P3";
                    if (extension != ".BMD")
                        libraryArg = "-Library P3P";
                    if (extension == ".MSG" || extension == ".FLOW")
                        outFormatArg = "-OutFormat V1";
                    break;
                case 3: //P3
                    encodingArg = "-Encoding P3";
                    if (extension != ".BMD")
                        libraryArg = "-Library P3";
                    if (extension == ".MSG" || extension == ".FLOW")
                        outFormatArg = "-OutFormat V1";
                    break;
                case 4: //P3FES
                    encodingArg = "-Encoding P3";
                    if (extension != ".BMD")
                        libraryArg = "-Library P3F";
                    if (extension == ".MSG" || extension == ".FLOW")
                        outFormatArg = "-OutFormat V1";
                    break;
                case 5: //P4
                    encodingArg = "-Encoding P4";
                    if (extension != ".BMD")
                        libraryArg = "-Library P4";
                    if (extension == ".MSG" || extension == ".FLOW")
                        outFormatArg = "-OutFormat V1";
                    break;
                case 6: //P4G
                    encodingArg = "-Encoding P4";
                    if (extension != ".BMD")
                        libraryArg = "-Library P4G";
                    if (extension == ".MSG" || extension == ".FLOW")
                        outFormatArg = "-OutFormat V1";
                    break;
                case 7: //P5
                    encodingArg = "-Encoding P5";
                    if (extension != ".BMD")
                        libraryArg = "-Library P5";
                    if (extension == ".MSG")
                        outFormatArg = "-OutFormat V1BE";
                    if (extension == ".FLOW")
                        outFormatArg = "-OutFormat V3BE";
                    break;
                case 8: //P5R
                    encodingArg = "-Encoding P5";
                    if (extension != ".BMD")
                        libraryArg = "-Library P5R";
                    if (extension == ".MSG")
                        outFormatArg = "-OutFormat V1BE";
                    if (extension == ".FLOW")
                        outFormatArg = "-OutFormat V3BE";
                    break;
                case 9: //PQ2
                    encodingArg = "-Encoding SJ";
                    if (extension != ".BMD")
                        libraryArg = "-Library PQ2";
                    if (extension == ".MSG")
                        outFormatArg = "-OutFormat V1";
                    if (extension == ".FLOW")
                        outFormatArg = "-OutFormat V1";
                    break;
            }

            StringBuilder args = new StringBuilder();
            //args.Append($"\"{compilerPath}\" ");
            args.Append($"\"{droppedFilePath}\" ");
            if (Disassemble) //Omits all args if you are disassembling
                args.Append($" -Disassemble");
            else
            {
                args.Append($"{compileArg} ");
                args.Append($"{outFormatArg} ");
                args.Append($"{libraryArg} ");
                args.Append($"{encodingArg} ");
                if (Hook)
                    args.Append($" -Hook ");
                if (compileArg == "-Compile " && Overwrite)
                {
                    string outPath = droppedFilePath.Replace(".flow", "")
                        .Replace(".FLOW", "").Replace(".msg", "").Replace(".MSG", "")
                        .Replace(".bf", "").Replace(".BF", "").Replace(".bmd", "")
                        .Replace(".BMD", "");
                    if (extension == ".MSG")
                        args.Append($"-Out \"{outPath + ".bmd"}\" ");
                    else if (extension == ".FLOW")
                        args.Append($"-Out \"{outPath + ".bf"}\" ");
                }
            }

            return args.ToString();
        }

        private async static void RunCMD(ArrayList args, string compilerPath)
        {
            await StartProcessAsync(args, compilerPath);
        }

        private static Task StartProcessAsync(ArrayList args, string compilerPath)
        {
            return Task.Run(() =>
            {
                ProcessStartInfo start = new ProcessStartInfo();
                start.FileName = compilerPath;
                start.UseShellExecute = false;
                start.CreateNoWindow = true;
                start.RedirectStandardOutput = true;
                start.RedirectStandardError = true;

                foreach (string arg in args)
                {
                    Console.WriteLine($"{compilerPath} {arg}");
                    start.Arguments = arg;
                    using (Process process = Process.Start(start))
                    {

                        process.OutputDataReceived += (sender, args) => Display(args.Data);
                        process.ErrorDataReceived += (sender, args) => Display(args.Data);

                        process.Start();
                        process.BeginOutputReadLine();
                        process.BeginErrorReadLine();

                        process.WaitForExit(); //you need this in order to flush the output buffer
                    }
                }
            });
        }

        static void Display(string output)
        {
            Console.WriteLine(output);
        }

        static void Exit(object sender, System.EventArgs e)
        {

        }

        public static void OpenLog()
        {
            if (File.Exists("AtlusScriptCompiler.log"))
            {
                ProcessStartInfo start = new ProcessStartInfo();
                start.FileName = "AtlusScriptCompiler.log";
                start.UseShellExecute = true;
                Process.Start(start);
            }
        }
    }
}
