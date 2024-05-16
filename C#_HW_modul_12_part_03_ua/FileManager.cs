using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__HW_modul_12_part_03_ua
{
    public static class FileManager
    {
        public static List<string> SearchFiles(string folderPath, string searchPattern)
        {
            List<string> foundFiles = new List<string>();

            try
            {
                string[] files = Directory.GetFiles(folderPath, searchPattern, SearchOption.AllDirectories);
                foundFiles.AddRange(files);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error searching files: {ex.Message}");
            }

            return foundFiles;
        }

        public static void DeleteFiles(string folderPath, string searchPattern)
        {
            try
            {
                string[] files = Directory.GetFiles(folderPath, searchPattern, SearchOption.AllDirectories);

                foreach (string file in files)
                {
                    File.Delete(file);
                    Console.WriteLine($"Deleted file: {file}");
                }

                Console.WriteLine("\nAll matching files have been deleted.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting files: {ex.Message}");
            }
        }

        public static void DeleteFolders(string folderPath)
        {
            try
            {
                string[] folders = Directory.GetDirectories(folderPath, "*", SearchOption.AllDirectories);

                foreach (string folder in folders)
                {
                    if (Directory.GetFiles(folder).Length == 0 && Directory.GetDirectories(folder).Length == 0)
                    {
                        Directory.Delete(folder);
                        Console.WriteLine($"Deleted empty folder: {folder}");
                    }
                }

                Console.WriteLine("\nAll empty folders have been deleted.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting folders: {ex.Message}");
            }
        }

        public static void ShowFolderContents(string folderPath)
        {
            try
            {
                if (!Directory.Exists(folderPath))
                {
                    Console.WriteLine("Folder does not exist.");
                    return;
                }

                Console.WriteLine($"Contents of folder '{folderPath}':");

                string[] files = Directory.GetFiles(folderPath);
                foreach (string file in files)
                {
                    Console.WriteLine($"File: {file}");
                }

                string[] directories = Directory.GetDirectories(folderPath);
                foreach (string directory in directories)
                {
                    Console.WriteLine($"Directory: {directory}");
                    ShowFolderContents(directory);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

}
