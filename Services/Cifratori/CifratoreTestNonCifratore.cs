﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNIBO.SET.Model;
using System.Security.Cryptography;

namespace UNIBO.SET.Services.Cifratori
{
    public class TestNonCifratore : ICifratore // Inserire qui la logica di cifrazione dei file
    {
        public string Algoritmo => "NONCIFRATORE";

        public Key CifraFile(UNIBO.SET.Model.File fileIn)
        {

            FileCifrato fc = new FileCifrato(fileIn.Path + ".sef"); // rimosso ", null" dopo il ".sef"

            using var streamOut = fc.Create();
            using var streamIn = fileIn.Open();

            streamIn.CopyTo(streamOut);

            return fc.Key;



        }
    }
}
