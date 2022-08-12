﻿using UNIBO.SET.Services.Cifratori;
using UNIBO.SET.Services.Shared;
using System;
using UNIBO.SET.Interfaces;
using UNIBO.SET.Model;
using UNIBO.SET.ModelLog;

namespace UNIBO.SET.Services.Presenters
{

    public class GestioneCifraturaPresenter : IGestioneCifratura
    {
        private ILogger _logger;
        public USB? SelectedUSB { get; set; }
        public HashSet<string> ListaFileSelezionati { get; set; }

        ICifratore Cifratore { get; set; }

        public GestioneCifraturaPresenter(ICifratore cifratore, ILogger logger)
        {
            Cifratore = cifratore;
            ListaFileSelezionati = new HashSet<string>();
            _logger = logger;
        }

        public bool Aggiungi(FileSystemElement sysElement)
        {
            foreach(string path in sysElement.OttieniPaths())
                ListaFileSelezionati.Add(path);
            return true;
        }

        public FileCifrato Cifra(Model.File file) // dA vedere altre eccezioni
        {
            this.LogIt(EntryType.Operazione, $"Cifrato file nel path: {file.Path}");
            try
            {
                return this.Cifratore.CifraFile(file);
            }
            catch(FileNotFoundException ex)
            {
                this.LogIt(EntryType.Errore, $"Il file non esiste: {file.Path}");
                throw ex;
            }

        }

        public USB[] ElencaDispositiviEsterni()
        {
            return SystemHelper.GetUsbs();
        }


        public void LogIt(EntryType type, string messaggio)
        {
            _logger.WriteLog(type, this.GetType().Name, messaggio);
        }

        public bool Rimuovi(FileSystemElement sysElement)
        {
            return ListaFileSelezionati.Remove(sysElement);
        }

        public bool SelezionaDestinazione(string path)
        {
            throw new NotImplementedException();
        }

        public void SelezionaUSB(USB usb)
        {
            this.SelectedUSB = usb;
        }
    }
}