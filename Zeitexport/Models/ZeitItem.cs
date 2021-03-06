﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeitexport.Models
{
    public class ZeitItem
    {

        public string Projektnummer { get; set; }
        public string Projektbezeichnung { get; set; }

        public string Ressource { get; set; }

        public DateTime? Datum { get; set; }

        public DateTime? ZeitVon { get; set; }

        public string Startzeit
        {
            get
            {
                return ZeitVon == null ? "--:--" : ZeitVon.Value.ToString("hh:mm");
            }
        }

        public DateTime? ZeitBis { get; set; }

        public string Endzeit
        {
            get
            {
                return ZeitBis == null ? "--:--" : ZeitBis.Value.ToString("hh:mm");
            }
        }

        public double Stunden { get; set; }

        public string Notiz { get; set; }

    }
}
