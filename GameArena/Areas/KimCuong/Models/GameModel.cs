using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameArena.Areas.KimCuong.Models
{
    public class DataModel<T>
    {
        public int step { get;set;}

        public string mess { get; set; }

        public T data { get; set; }

        public List<T> datas { get; set; } 
    }
}