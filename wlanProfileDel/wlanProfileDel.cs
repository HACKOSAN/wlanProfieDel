using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


    // its frickin 2:47 AM, srlsy you should start paying me..

Process process = new Process();
process.StartInfo.FileName = "netsh.exe"; //command name
process.StartInfo.Arguments = "wlan delete profile name=*"; //command args
process.StartInfo.UseShellExecute = false;
process.StartInfo.RedirectStandardOutput = true;
process.Start(); // excute

string output = process.StandardOutput.ReadToEnd();
    process.WaitForExit(); //exists directly after excution


