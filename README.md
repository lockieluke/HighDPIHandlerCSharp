# HighDPIHandlerCSharp
Feeling that your Windows Forms Application is blurry on high resolution screens?  Try this and implement this to your app, see if that solves your problem.

### Getting Started  
First add the [dll file](https://github.com/lockieluke/HighDPIHandlerCSharp/tree/master/High%20DPI%20Handler/High%20DPI%20Handler/bin/Debug) to your project by right-clicking the **reference** tree in your solution explorer, then follow the on screen intruction to import the dll file.

### Implement this into your Windows Forms Application
After adding the reference to your application, go to the **Program.cs** class then add this:  
### `HighDPIHandler.EnableHighDPISupport()`
to the start of the `static void Main()` function, voila!!!
