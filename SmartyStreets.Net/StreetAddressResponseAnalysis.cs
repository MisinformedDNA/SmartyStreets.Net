using System;
using System.Collections.Generic;
using System.Linq;

namespace SmartyStreets
{
    public class StreetAddressResponseAnalysis
    {
        public string DpvMatchCode { get; set; }
        public string DpvFootnotes { get; set; }
        public string DpvCmra { get; set; }
        public string DpvVacant { get; set; }
        public string Active { get; set; }
        public string EwsMatch { get; set; }
        public string Footnotes { get; set; }
        public string LacslinkCode { get; set; }
        public string LacslinkIndicator { get; set; }
        public string SuiteLinkMatch { get; set; }

        public List<string> DpvFootnoteList
        {
            get
            {
                if (string.IsNullOrEmpty(DpvFootnotes))
                    return new List<string>(0);

                var list = new List<string>(DpvFootnotes.Length / 2);
                for (var i = 0; i < DpvFootnotes.Length; i += 2)
                {
                    list.Add(DpvFootnotes.Substring(i, 2));
                }

                return list;
            }
        }

        public List<string> FootnoteList
        {
            get
            {
                if (string.IsNullOrEmpty(Footnotes))
                    return new List<string>(0);

                return Footnotes
                    .Split(new[] { '#' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
            }
        }
    }
}
