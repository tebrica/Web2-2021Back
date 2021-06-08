﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    [Table ("Potrosaci")]
    public class Potrosac
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Id { get; set; }
        public string Lokacija { get; set; }
        public int Prioritet { get; set; }
        public string TelefonskiBroj { get; set; }
        public TipPotrosaca PotrosacType { get; set; }


        public Potrosac() { }
        public Potrosac(string ime, string prezime, string id, string lokacija, int prio, string tele, TipPotrosaca tip)
        {

            this.Ime = ime;
            this.Prezime = prezime;
            this.Id = id;
            this.Lokacija = lokacija;
            this.Prioritet = prio;
            this.TelefonskiBroj = tele;
            this.PotrosacType = tip;


        }
    }
}
