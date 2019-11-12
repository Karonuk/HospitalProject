﻿using E_Hospital.BLL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace E_Hospital.BLL.Services
{
    public interface IPatientCallBack
    {
        [OperationContract] void UpdateRequestState(VisitRequestDto visitRequest);
    }
}
