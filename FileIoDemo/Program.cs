using FileIoDemo;

Console.WriteLine("-----------------Welcome--------------");
FileDemo operations = new FileDemo();
operations.FileExist();
operations.ReadAllLines();
operations.ReadAllText();
//operations.CopyFile();
//operations.DeleteFilePath();
operations.UsingStreamReader();
Console.ReadLine();