﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD5reborn.DataChecker
{
    public interface IDataChecker
    {
        void GetStatus(out folderState state, out List<string> files);
        void GetLastWordOfFileInfo(string fileDir, out int lineNumber, out string word);
    }
}
