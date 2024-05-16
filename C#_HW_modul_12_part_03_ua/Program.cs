namespace C__HW_modul_12_part_03_ua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter choice: ");

            int choice = int.Parse(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                    Console.Write("Enter folder path: ");
                    string folderPath1 = Console.ReadLine();

                    Console.Write("Enter search pattern: ");
                    string searchPattern1 = Console.ReadLine();

                    List<string> foundFiles1 = FileManager.SearchFiles(folderPath1, searchPattern1);

                    Console.WriteLine("\nFound files:");
                    foreach (string file in foundFiles1)
                    {
                        Console.WriteLine(file);
                    }
                    break;
                case 2:
                    Console.Write("Enter folder path: ");
                    string folderPath2 = Console.ReadLine();

                    Console.Write("Enter search pattern: ");
                    string searchPattern2 = Console.ReadLine();

                    FileManager.DeleteFiles(folderPath2, searchPattern2);
                    FileManager.DeleteFolders(folderPath2);
                    break;
                case 3:
                    Console.Write("Enter folder path to view contents: ");
                    string folderPath = Console.ReadLine();

                    FileManager.ShowFolderContents(folderPath);
                    break;
            }
        }
    }
}
