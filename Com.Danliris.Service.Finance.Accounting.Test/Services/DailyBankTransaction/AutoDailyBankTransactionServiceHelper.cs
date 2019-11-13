using Com.Danliris.Service.Finance.Accounting.Lib.BusinessLogic.Services.DailyBankTransaction;
using Com.Danliris.Service.Finance.Accounting.Lib.BusinessLogic.Services.JournalTransaction;
using Com.Danliris.Service.Finance.Accounting.Lib.Models.OthersExpenditureProofDocument;
using Com.Danliris.Service.Finance.Accounting.Lib.Models.PaymentDispositionNote;
using Com.Danliris.Service.Finance.Accounting.Lib.ViewModels.OthersExpenditureProofDocumentViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Com.Danliris.Service.Finance.Accounting.Test.Services.DailyBankTransaction
{
    public class AutoDailyBankTransactionServiceHelper : IAutoDailyBankTransactionService
    {
        public async Task<int> AutoCreateFromOthersExpenditureProofDocument(OthersExpenditureProofDocumentModel model, List<OthersExpenditureProofDocumentItemModel> itemModels)
        {
            return await Task.FromResult(1);
        }

        public async Task<int> AutoCreateFromPaymentDisposition(PaymentDispositionNoteModel model)
        {
            return await Task.FromResult(1);
        }

        public async Task<int> AutoRevertFromOthersExpenditureProofDocument(OthersExpenditureProofDocumentModel model, List<OthersExpenditureProofDocumentItemModel> itemModels)
        {
            return await Task.FromResult(1);
        }

        public async Task<int> AutoRevertFromPaymentDisposition(PaymentDispositionNoteModel model)
        {
            return await Task.FromResult(1);
        }
    }
}
