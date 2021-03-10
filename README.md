# SkidClientLibrary
A template library to inject into [Skid Client](https://discord.gg/K8VQZutWkA)

# C# Injectable Librarys
Normal c++ librarys have a DllMain that gets executed when you inject the library and passed through a switch statement, you would normally put your code inside of DLL_PROCESS_ATTACH case, there is not an equivalent for c# but we can do a trick to make a similar effect by using a static constructor, we would make a class and then initilize an object of that class

# Notice
If you inject the code as it is, and then close the Client, the client will not fully be closed and you will not be able to delete the dll because the program is not closed, the library doesnt have a close function, so if you do inject it into any program you will need to force close it with Task Manager or an application like that

# System.Windows.Forms error
A library project does not auto add this, if you are getting an error for it the dll is located at C:\Windows\Microsoft.NET\Framework\v2.0.50727, click add reference then add the dll

