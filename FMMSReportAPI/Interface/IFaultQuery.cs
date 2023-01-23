﻿using FMMSReportAPI.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMMSReportAPI.Interface
{
    public interface IFaultQuery
    {
        string CreateFaultReport(IDataReader dataReader);

        string GetFaultReport(FaultModel status);
    }
}
