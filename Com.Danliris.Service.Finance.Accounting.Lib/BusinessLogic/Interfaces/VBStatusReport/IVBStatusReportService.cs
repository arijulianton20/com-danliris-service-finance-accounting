﻿using Com.Danliris.Service.Finance.Accounting.Lib.ViewModels.VBStatusReport;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Com.Danliris.Service.Finance.Accounting.Lib.BusinessLogic.Interfaces.VBStatusReport
{
    public interface IVBStatusReportService
    {
        List<VBStatusReportViewModel> GetReport(int unitId, long vbRequestId, string applicantName, string clearanceStatus, DateTimeOffset? requestDateFrom, DateTimeOffset? requestDateTo, DateTimeOffset? realizeDateFrom, DateTimeOffset? realizeDateTo, int offSet);
        ReportViewModel GetReportWithCurrency(int unitId, long vbRequestId, string applicantName, string clearanceStatus, DateTimeOffset? requestDateFrom, DateTimeOffset? requestDateTo, DateTimeOffset? realizeDateFrom, DateTimeOffset? realizeDateTo, int offSet);
        MemoryStream GenerateExcel(int unitId, long vbRequestId, string applicantName, string clearanceStatus, DateTimeOffset? requestDateFrom, DateTimeOffset? requestDateTo, DateTimeOffset? realizeDateFrom, DateTimeOffset? realizeDateTo, int offSet);
        Task<List<VbRequestModel>> GetByApplicantName(string applicantName);
    }
}
