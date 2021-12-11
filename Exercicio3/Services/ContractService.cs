using Exercicio3.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio3.Services
{
    class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;
            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updatedQuota = basicQuota + _onlinePaymentService.Interest(basicQuota, i);
                double fullQuota = updatedQuota + _onlinePaymentService.PaymentFee(updatedQuota);
                contract.AddInstallment(new Installments(date, fullQuota));
            }
        }
    }
}
