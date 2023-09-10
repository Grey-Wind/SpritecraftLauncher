using System.Diagnostics;

string command = Command.CommandStr.command;

// 在这里使用 command 进行进一步处理

// Console.WriteLine(command);

// 创建Process实例
Process process = new Process();

// 设置要执行的Shell命令
process.StartInfo.FileName = "cmd.exe";
process.StartInfo.Arguments = "/c" + command;

// 启动进程
process.Start();

// 等待进程执行完成
process.WaitForExit();