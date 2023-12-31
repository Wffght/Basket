//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace баскетбол
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Media;

    public partial class Matchup
    {
        public int MatchupId { get; set; }
        public int SeasonId { get; set; }
        public int MatchupTypeId { get; set; }
        public int Team_Away { get; set; }
        public int Team_Home { get; set; }
        public System.DateTime Starttime { get; set; }
        public int Team_Away_Score { get; set; }
        public int Team_Home_Score { get; set; }
        public string Location { get; set; }
        public int Status { get; set; }
        public string CurrentQuarter { get; set; }

        public virtual Season Season { get; set; }
        public virtual MatchupType MatchupType { get; set; }
        public virtual Team Team { get; set; }
        public virtual Team Team1 { get; set; }

        public string StatusString
        {
            get
            {
                switch (Status)
                {
                    case -1:
                        return "Not Start";
                    case 0:
                        return "Running";
                    case 1:
                        return "Finished";
                    default:
                        return "?????";
                }
            }
        }

        public SolidColorBrush StatusColor
        {
            get
            {
                switch (Status)
                {
                    case -1:
                        return Brushes.LightBlue;
                    case 0:
                        return Brushes.Red;
                    case 1:
                        return Brushes.Gray;
                    default:
                        return Brushes.Green;
                }
            }
        }
    }
}


    
