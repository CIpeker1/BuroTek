﻿using BuroTek.Core.Entities;

namespace BuroTek.Entities.Models
{
    public class Arsiv:IEntity
    {
        public string DosyaAdi { get; set; }
        public string DosyaTuru { get; set; }
        public DateTime EklendigiTarih { get; set; }
    }
}