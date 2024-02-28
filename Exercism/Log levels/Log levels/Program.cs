namespace LogLevels
{
    class Logline
    {
        public static string Message(string logLine)
        {
            int endIndex = logLine.IndexOf("]:") + 2;
            string message = logLine.Substring(endIndex).Trim();
            return message;

        }

        public static string LogLevel(string logLine)
        {
           
            int startIndex = logLine.IndexOf("[") + 1;
            int endIndex = logLine.IndexOf("]");
            string logLevel = logLine.Substring(startIndex, endIndex - startIndex).ToLower();
            return logLevel;
        }

        public static string Reformat(string logLine)
        {
           
            string message = Message(logLine);
            string logLevel = LogLevel(logLine);
            return $"{message} ({logLevel})";
        }

        static void Main()
        {
            string testLogLine1 = "[ERROR]: Invalid operation";
            string testLogLine2 = "[WARNING]:  Disk almost full";
            string testLogLine3 = "[INFO]: Operation completed";

            Console.WriteLine(Message(testLogLine1));
            Console.WriteLine(Message(testLogLine2)); 

            Console.WriteLine(LogLevel(testLogLine1)); 
            Console.WriteLine(LogLevel(testLogLine2)); 

            Console.WriteLine(Reformat(testLogLine3)); 
        }



    } 



}