﻿namespace LabCaseus.Analise.Api.Models
{
    public class TokenModel
    {
        public string Token { get; set; }
        public string Profile { get; set; }
        public DateTime ValidTo { get; set; }
    }
}