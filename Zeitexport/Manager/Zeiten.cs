using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeitexport.Manager
{
    public class Zeiten
    {
        /// <summary>
        /// Liefert alle Zeiteinträge zur Projketnummer
        /// </summary>
        /// <param name="projektnummer">Projektnummer</param>
        /// <returns></returns>
        public List<Models.ZeitItem> LoadByProjektnummer(string projektnummer)
        {
            var result = new List<Models.ZeitItem>();

            var qry = @"SELECT 
                        P.Projektnummer
                        ,P.Projektbezeichnung
                        ,Z.Datum
                        ,Z.ZeitVon
                        ,Z.ZeitBis
                        ,Z.Stunden
                        ,Z.Notiz
                        ,ISNULL(R.Ressourcename,Z.Ressource)
                        ,Z.PosID
                        FROM BCSPjmProjekteVorgaengeZeiten AS Z
                        INNER JOIN BCSPjmProjekte AS P ON P.ProjektID = Z.ProjektID AND P.Mandant = Z.Mandant
                        INNER JOIN BCSPjmRessourcen AS R ON R.Ressourcenummer = Z.Ressource AND R.Mandant = Z.Mandant
                        WHERE P.Projektnummer = @Projektnummer";
            var conStr = ConfigurationManager.ConnectionStrings["DataModel"].ConnectionString;
            //Verbindung zur Datenbank herstellen
            using (var con = new SqlConnection(conStr))
            {
                con.Open();
                // Eine Abfrage ausführen
                using (var cmd = new SqlCommand(qry, con))
                {
                    cmd.Parameters.AddWithValue("@Projektnummer", projektnummer);
                    //Ergebnisse der Abfrage auslesen
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var item = new Models.ZeitItem();
                            result.Add(item);
                            //Prüfen, ob Wert vorhanden, weil DBNull != null in c#
                            if (!dr.IsDBNull(0))
                                item.Projektnummer = dr.GetString(0);
                            if (!dr.IsDBNull(1))
                                item.Projektbezeichnung = dr.GetString(1);
                            if (!dr.IsDBNull(2))
                                item.Datum = dr.GetDateTime(2);
                            if (!dr.IsDBNull(3))
                                item.ZeitVon = dr.GetDateTime(3);
                            if (!dr.IsDBNull(4))
                                item.ZeitBis = dr.GetDateTime(4);
                            if (!dr.IsDBNull(5))
                                item.Stunden = dr.GetSqlMoney(5).ToDouble();
                            if (!dr.IsDBNull(6))
                                item.Notiz = dr.GetString(6);
                            if (!dr.IsDBNull(7))
                                item.Ressource = dr.GetString(7);
                        }
                    }
                }
                con.Close();
            }
            return result;
        }

        /*public List<Models.ZeitItem> LoadByProjektnummerEf(string projektnummer)
        {
            var result = new List<Models.ZeitItem>();
            using (var ctx = new DAL.DataModel())
            {
                result = ctx.BCSPjmProjekteVorgaengeZeiten
                .Join(ctx.BCSPjmProjekte, zeiten => zeiten.ProjektID, projeke => projeke.ProjektID,
                (zeiten, projekte) => new { zeiten, projekte.Projektnummer, projekte.Projektbezeichnung })
                .Where (w => w.Projektnummer == projektnummer)
                .Select(x => new
                Models.ZeitItem()
                {
                    Datum = x.zeiten.Datum,
                    Notiz = x.zeiten.Notiz,
                    ZeitBis = x.zeiten.ZeitBis,
                    ZeitVon = x.zeiten.ZeitVon,
                    Ressource = x.zeiten.Ressource,
                    Projektnummer = x.Projektnummer,
                    Projektbezeichnung = x.Projektbezeichnung
                }
                ).ToList();
            }
            return result;
        }


        public List<Models.ZeitItem> LoadByProjektnummerIdiotStyle(string projektnummer)
        {
            var result = new List<Models.ZeitItem>();
            using (var ctx = new DAL.DataModel())
            {

                var projekt = ctx.BCSPjmProjekte.FirstOrDefault(x => x.Projektnummer == projektnummer);


                result = ctx.BCSPjmProjekteVorgaengeZeiten
                .Where(w => w.ProjektID == projekt.ProjektID)
                .Select(x => new
                Models.ZeitItem()
                {
                    Datum = x.Datum,
                    Notiz = x.Notiz,
                    ZeitBis = x.ZeitBis,
                    ZeitVon = x.ZeitVon,
                    Ressource = x.Ressource,
                    Projektnummer = projekt.Projektnummer,
                    Projektbezeichnung = projekt.Projektbezeichnung
                }
                ).ToList();
            }
            return result;
        }*/
    }
}
