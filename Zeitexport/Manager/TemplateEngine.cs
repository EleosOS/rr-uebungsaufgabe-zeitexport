using Scriban;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeitexport.Manager
{
    class TemplateEngine
    {
        public static int GetKalenderwoche(DateTime Datum)
        {
            var deCulture = new CultureInfo("DE-de");
            return deCulture.Calendar.GetWeekOfYear(Datum, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
        }

        public static void Export(int Kalenderwoche, string Dateipfad, List<Models.ZeitItem> Zeiten, string Projektnummer)
        {
            try
            {
                var deCulture = new CultureInfo("DE-de");
                var Woche = Zeiten
                    .FindAll(Item => Kalenderwoche == GetKalenderwoche(Item.Datum.Value))
                    // Alle Einträge in dieser Kalenderwoche holen
                    .OrderBy(Item => Item.Datum) // Nach Datum sortieren
                    .GroupBy(Item => Item.Datum); // Alle Einträge mit dem gleichen Datum gruppieren

                // Die Template lesen
                StreamReader InputTemplate = new StreamReader(@"..\..\Public\HTMLTemplate.html");

                //Pfad zu CSS und JS-Files aus Config lesen
                var jsCssPath = ConfigurationManager.AppSettings.Get("JsCssPath");


                var Template = Scriban.Template.Parse(InputTemplate.ReadToEnd());

                if (Template.HasErrors)
                {
                    foreach (var Error in Template.Messages)
                    {
                        Console.WriteLine(Error);
                    }

                    throw new Exception("Error in Template");
                }

                using (StreamWriter Datei = new StreamWriter(Dateipfad))
                {
                    var ScriptObject = new Scriban.Runtime.ScriptObject
                        {
                            { "PathToAssets", jsCssPath },
                            { "wochenUeberschrift", Projektnummer + " - Kalenderwoche " + Kalenderwoche},
                            { "wochenUeberschriftTag1BisTag5", $"{Woche.First().Key:dd.MM.yyyy} bis {Woche.Last().Key:dd.MM.yyyy}" },
                        };

                    // Durch jeden Tag loopen
                    for (int i = 0; i < Woche.Count(); i++)
                    {
                        // i benutzen für einfachere Template füllung
                        var Tag = Woche.ElementAt(i);

                        ScriptObject.Add($"tag{i + 1}Datum", Tag.Key.Value.ToString("dd.MM"));
                        string EinträgeString = "";

                        // Durch jeden Eintrag im Tag loopen
                        foreach (var Eintrag in Tag)
                        {
                            EinträgeString += string.Format(@"          <li>
            <div class=""eintrag"">
              <p class=""notiz"">{0}</p>
              <p class=""stunden"">{1}</p>
            </div>
          </li>
", Eintrag.Notiz, TimeSpan.FromHours(Eintrag.Stunden).ToString(@"hh\:mm"));
                        }

                        ScriptObject.Add($"tag{i + 1}Liste", EinträgeString);
                    }

                    string result = Template.Render(ScriptObject);
                    Datei.WriteLine(result);
                }

                InputTemplate.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
