using System;
using System.IO;

class Journal
{
    static void Main(string[] args)
    {
        string choices = "";
        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write & Save");
            Console.WriteLine("2. Load");
            Console.WriteLine("3. Delete");
            Console.WriteLine("4. Quit");
            choices = Console.ReadLine();
            if(choices == "1")
            {
                public void SaveTxt()
                {
                    //ファイル名
                    var fileName = "sample.txt";
                    //var fileName = @"C:\sample.txt";  絶対パスでも良い

                    //書き込むテキスト
                    var days = new string[] { "月曜日", "火曜日", "水曜日", "木曜日", "金曜日" };

                    try
                    {
                        //ファイルをオープンする
                        using (StreamWriter sw = new StreamWriter(fileName, false, Encoding.GetEncoding("Shift_JIS")))
                        {
                            foreach (var day in days)
                            {
                                //テキストを書き込む
                                sw.Write(day);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                Entry.WriteEntry();
            }
            else if(choices == "2")
            {
                Entry.SaveEntry();
            }
            else if(choices == "3")
            {
                Entry.LoadEntry();
            }
            else if(choices == "4")
            {
                Entry.DeleteEntry();
            }
        } while (choices != "5");
    }
}