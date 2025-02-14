using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Security.AccessControl;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 28.01.2025
            //Создаем новый ПДФ-Документ
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Пример ПДФ";

            //добавляем новую стр
            PdfPage page = document.AddPage();

            PdfPage page2 = document.AddPage();

            //создаем объект для рисования
            XGraphics gfx = XGraphics.FromPdfPage(page);

            //указываем шрифт
            XFont font = new XFont("Times New Roman", 16, XFontStyleEx.Italic);

            //Пишем текст на странице
            gfx.DrawString("Борын борын заманда яшэгэн ди!!", font, XBrushes.Blue, new XRect(0, 20, page.Height, page.Height), XStringFormat.TopLeft);

            //сохранить
            string filepath = "C:\\Users\\Айдар\\OneDrive\\Рабочий стол\\SiSharp\\Lanic.pdf";
            document.Save(filepath);

            Console.WriteLine("Done!");
            Console.ReadKey();
        }

    }
}
