// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

System.IO.FileSystemWatcher watcher = new System.IO.FileSystemWatcher(@"..\..\..\","*.txt");
watcher.EnableRaisingEvents = true;
//watcher.Changed += (s,e) => Console.WriteLine($"File changed: {e.FullPath} at {DateTime.Now}"); // Notify on file changes using lambda expression
watcher.Changed += OnChanged; // Notify on file changes using method reference
watcher.Created += OnCreated; // Notify on file creation using method reference
// Wait for user to close the console window
Console.WriteLine("Press any key to exit...");
Console.ReadKey();

void OnCreated(object sender, System.IO.FileSystemEventArgs e)
{
    Console.WriteLine($"File created: {e.FullPath} at {DateTime.Now}");
}
void OnChanged(object sender, System.IO.FileSystemEventArgs e)
{
    Console.WriteLine($"File changed: {e.FullPath} at {DateTime.Now}");
}
