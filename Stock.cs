using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAccountManagement
{
    internal class Stock
    {

        public List<TataGroup> tataGroup;
        public List<AdaniGroup> adaniGroup;
        public List<AdityaBirlaGroup> adityaBirlaGroup;
    }


    public class TataGroup
    {
        public string Stockname;
        public int Shares;
        public int Price;
    }
    public class AdaniGroup
    {
        public string Stockname;
        public int Shares;
        public int Price;
    }
    public class AdityaBirlaGroup
    {
        public string Stockname;
        public int Shares;
        public int Price;
    }
}