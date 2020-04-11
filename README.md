# EazyFirewallBlockerGUI
A very simple program written in C# for blocking a program in the Windows Defender Firewall made in a couple of hours. The program is intended to block many files at a time in the Windows Firewall as it is a hassle to do so one by one.

## Preliminaries
 - This program uses an external batch script *FirewallBlocker.bat* which is executed for each executable in the directory under consideration.
 - This program requires elevated privilege for executing the batch script.
 - The search path includes all the subdirectories under the directory where the program was copied.

## Usage
Copy the program *EazyFirewallBlockerGUI.exe* and the batch script *FirewallBlocker.bat*  in the directory containing the executable/executables you want to block in the firewall. The program will automatically fetch the executables in the directory and all subdirectories. Check the files you want to block and click on *Block Firewall* to block all the checked executables in the Windows Defender Firewall. You will have an option to view the results of the execution of the batch file at the end of the process. Clicking *Yes* will create a temporary file in the default temp folder *%TEMP%* and all the results are written in that file, which will be shown in the default text editor.

## TODO
Allow user to select the search directory via a button.

## Tested on 
Windows 10 Home 1903

## Disclaimer
This program was written for my personal convenience and provides no guarantee that it will work properly on your system correctly. RUN AT YOU OWN RISK!

### Microsoft Visual Studio Info
Microsoft Visual Studio Enterprise 2019
Version 16.0.4
VisualStudio.16.Release/16.0.4+28803.452
Microsoft .NET Framework
Version 4.8.03752