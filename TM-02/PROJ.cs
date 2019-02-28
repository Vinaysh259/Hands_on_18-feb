using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Show
    {
        private int ShowID { get; set; }
        private int MovieID { get; set; }
        private int TheatreID { get; set; }
        private int ScreenID { get; set; }
        private DateTime StartDate { get; set; }
        private DateTime EndDate { get; set; }
        private decimal PlatinumSeatRate { get; set; }
        private decimal GoldSeatRate { get; set; }
        private decimal SilverSeatRate { get; set; }

        public Show(int s_id, int m_id, int t_id, int sc_id, DateTime s_date, DateTime e_date, decimal g_rate, decimal p_rate, decimal s_rate)
        {
            if (m_id > 0)
                MovieID = m_id;
            else
                throw new Exception("MovieID cannot be negative");
            if (t_id > 0)
                TheatreID = t_id;
            else
                throw new Exception("TheatreID cannot be negative");
            if (s_id >0)
                ScreenID = s_id;
            else
                throw new Exception("ScreenID cannot be negative");
            


        }


        static void Main(string[] args)
        {
        }
    }
}
