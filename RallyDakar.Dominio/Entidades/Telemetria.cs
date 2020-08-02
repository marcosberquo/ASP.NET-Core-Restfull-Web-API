﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RallyDakar.Dominio.Entidades
{
    public class Telemetria
    {
        public int Id { get; set; }
        public int TemporadaId { get; set; }
        public int PilotoId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Hora { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public decimal PercentualCombustivel { get; set; }
        public decimal Velocidade { get; set; }
        public double RMP { get; set; }
        public int TemperaturaExerna { get; set; }
        public int TemperaturaMotor { get; set; }
        public double AltitudeNivelMar { get; set; }

        public bool PedalAcelerador { get; set; }
        public bool PedalFreio { get; set; }

    }
}
