using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Models.DTOs
{
    public class LoginResultDTO
    {
        public bool UyeVarmi { get; set; }
        public bool YoneticiMi { get; set; }
        public bool NormalUyeMi { get; set; }
    }
}
