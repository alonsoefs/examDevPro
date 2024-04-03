using System;
using System.IO;

public class ExamTask1
{
    public static void Main(string[] args)
    {
        //call log_message funciton
log_message("application.log","User logged in","INFO");
log_message("application.log","Failed login attempt","WARNING");
    }

public static void log_message(string location, string message, string type){

//create new date with now fucntion
DateTime currentDate = DateTime.Now;
//create log message using correct formats
string log = currentDate.ToString("[yyyy-MM-dd HH:mm:ss]")+"["+type+"]"+message;
Console.WriteLine(log);

//create file with log info
/*string folder = @"C:\Temp\";
string fileName = "test.txt";
string fullPath = folder + fileName;

File.WriteAllLines(fullPath, log);
//string readText = File.ReadAllText(fullPath);
//Console.WriteLine(readText);
*/
  
}


    }
