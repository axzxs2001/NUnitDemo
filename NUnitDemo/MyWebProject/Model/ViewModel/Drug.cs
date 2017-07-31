using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebProject.Model.ViewModel
{
    /// <summary>
    /// 返回界面的实体类
    /// </summary>
    public class Drug
    {
        public string No { get; set; }
        public string Name { get; set; }
        public double Quantity { get; set; }
        public decimal Price { get; set; }
        public string PlaceOrigin { get; set; }
        public string Memo { get; set; }
    }
}
