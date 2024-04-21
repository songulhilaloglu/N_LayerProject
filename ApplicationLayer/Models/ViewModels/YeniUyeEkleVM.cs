﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Models.ViewModels
{
    public class YeniUyeEkleVM
    {
        [Required]
        public string Ad { get; set; }
        [Required]
        public string Soyad { get; set; }
        [Required]
        public string KullaniciAdi { get; set; }
        [Required, EmailAddress]
        public string EPosta { get; set; }
        [Required]
        public string Adres { get; set; }
   
        [Required, Compare("SifreTekrar")]
        public string Sifre { get; set; }

        [Required]
        public string SifreTekrar { get; set; }

    }
}
