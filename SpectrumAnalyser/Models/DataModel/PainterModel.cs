using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SpectrumAnalyser.Models.BD;

namespace SpectrumAnalyser.Models.DataModel
{
    public class PainterModel
    {
        public IEnumerable<SpectrumAnalyser.Models.BD.tbl_13_HistoryPeriod> HistoryPeriod { get; set; }
        public IEnumerable<SpectrumAnalyser.Models.BD.tbl_14_WorksOfArt> AuthorPainter { get; set; }

    }
}