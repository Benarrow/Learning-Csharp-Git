

#### This is the learning record of C#, .NET, and git. 

In the directories, the code has been modified to do some exercises for C#. 

You can find the original code within the following tutorial:

[用 C# 生成 .NET 应用程序 - Learn | Microsoft Docs](https://docs.microsoft.com/zh-cn/learn/paths/build-dotnet-applications-csharp/)

[Git教程 - 廖雪峰的官方网站 (liaoxuefeng.com)](https://www.liaoxuefeng.com/wiki/896043488029600)

---

2021.08.31

To create a new project in Try.NET, we need to check whether you have written the right code fence with symbol ```. 

Advice: directly type in this symbol instead of copying and pasting things from internet, or your ```dotnet try verify``` would fail to compile the code.

---

2021.08.30

* Issue: When I installed `dotnet-try` module and ran `dotnet try demo`, I always found a red area at the output pane when I tried to run a demo.

* Solution:

  ```bash
  dotnet --version # Show the current .NET version used by VS
  dotnet --info # Show all the .NET Framework and Runtime installed on the computer
  
  # Visit https://github.com/dotnet/cli-lab/releases to get the uninstall tool
  # Find the guidelines on https://docs.microsoft.com/zh-cn/dotnet/core/additional-tools/uninstall-tool?tabs=windows#step-3---uninstall-net-sdks-and-runtimes
  dotnet-core-uninstall remove <version> --sdk (--force) # Uninstall .NET
  
  # Install .NET 3.0.x and 2.1.x from official website
  # It seems that dotnet-try has not supported .NET 5.0, so I suggest uninstalling all the .NET 5.0+ versions. 
  # But be careful of your VS Projects that requires .NET 5.0+!
  
  dotnet try verify # Must be executed before dotnet try
  dotnet try
  ```

* Visit [dotnet/try-samples (github.com)](https://github.com/dotnet/try-samples) to get all the practice code for `dotnet-try`.

---

2021.08.26

```bash
# CMD
start <dirname> # Open the directory in a browser
```

``` bash
# Git Bash
git clean -f <filename> # Delete the files
git submodule add <link> <filename> # Add a submodule to the repository
git submodule deinit <filename> # Delete a submodule
git rm --cached <modulename> # Delete a module from the record
# Do not forget to commit the deletion!
git push origin master # Upload the newest version to Github
```

