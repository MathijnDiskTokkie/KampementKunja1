using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wagenpark.Models
{
    public class BoekingenModel
    {

        public List<BoekingInformation> listboekingen { get; set; }
        public bool popuplatenzien { get; set; }
        public int gastid { get; set; }
        
        
    }
    public class BoekingInformation {

        public Boekingen boekingen { get; set; }
        public Gasten gasten { get; set; }
    }
}