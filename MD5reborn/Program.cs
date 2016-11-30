﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MD5reborn.logger;
using MD5reborn.format;
using MD5reborn.dataSaver;
using MD5reborn.DataChecker;

namespace MD5reborn
{
    class Program
    {
        static void Main(string[] args)
        {
            //arg
            string directory = args[0];

            //initial vars
            string fileUnfinishedTag = "unf";
            string logFileName = "MD5rebornLogs";

            //initial classes
            Logger logger = new FileLogger(logFileName);
            logSystemInfo(logger);

            Format format = new FormatSingleLine(logger);

            //dirCheck
            DataChecker.DataChecker dataChecker = new DataCheckerLocalHDD(logger, directory, fileUnfinishedTag);
            DataSaver dataSaver = new DataSaverLocalHDD(logger, directory, fileUnfinishedTag);

            folderState state;
            List<string> files = new List<string>();

            dataSaver.GetStatus(out state, out files);
            dataChecker.GetStatus(out state, out files);

            if (state == folderState.unfinished)
            {

            }
            else if (state == folderState.finished)
            {

            }
            else
            {
                
            }

            //startAguments dir
            //make logger writes down basic info in a txt file like cores/os id etc

            //checklatestmake hash

            //depending on outcome -> fire up and finish files then fire up threadmanager

            //else fire up threadmanager and hash new files

            //fire up diffrent thread for console commands

            //fire up extra thread for displaying data
        }

        private static void logSystemInfo(Ilogger logger)
        {
            logger.log("OS: " + Environment.OSVersion);
            logger.log("Cores: " + Environment.ProcessorCount);
        }
    }
}