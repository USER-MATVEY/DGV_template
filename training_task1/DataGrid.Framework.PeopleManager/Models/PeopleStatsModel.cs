using DataGrid.Standart.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGrid.Framework.PeopleManager.Models
{
    public class IPeopleStatsModel : IPeopleStats
    {
        public int Count { get; set; }

        public int FemaleCount { get; set; }

        public int MaleCount { get; set; }

        public int ExpelledCount { get; set; }

        public int DeptCount { get; set; }

        public decimal AvrRate { get; set; }
    }
}
