using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


    // its frickin 2:47 AM, srlsy you should start paying me..

Process process = new Process();
process.StartInfo.FileName = "netsh.exe";
process.StartInfo.Arguments = "wlan delete profile name=*";
process.StartInfo.UseShellExecute = false;
process.StartInfo.RedirectStandardOutput = true;
process.Start();

string output = process.StandardOutput.ReadToEnd();
    process.WaitForExit();


