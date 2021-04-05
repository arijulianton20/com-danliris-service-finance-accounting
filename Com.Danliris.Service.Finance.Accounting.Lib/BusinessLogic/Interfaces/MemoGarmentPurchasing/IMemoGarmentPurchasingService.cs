﻿using Com.Danliris.Service.Finance.Accounting.Lib.Models.MemoGarmentPurchasing;
using Com.Danliris.Service.Finance.Accounting.Lib.Utilities;
using Com.Danliris.Service.Finance.Accounting.Lib.Utilities.BaseInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Danliris.Service.Finance.Accounting.Lib.BusinessLogic.Interfaces.MemoGarmentPurchasing
{
    public interface IMemoGarmentPurchasingService : IBaseService<MemoGarmentPurchasingModel>
    {
        ReadResponse<MemoGarmentPurchasingDetailModel> ReadReport(int page, int size, string filter);
    }
}
