using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class GL_IncomeModel
    {
        public List<GL_IncomeData>? GL_IncomeData { get; set; }
        public decimal Sum_GL { get; set; }
        public decimal Sum_supply { get; set; }
        public decimal diff { get; set; }
        public List<SupplyModel>? SupplyModels { get; set; }
    }

    public class GL_IncomeData
    {
        public int Income_Booking_Resp_GL_ID { get; set; }
        public string? GL_Code { get; set; }
        public string? GL_Description { get; set; }
        public decimal Amount { get; set; }
    }

    public class SupplyModel
    {
        public string? GL_Code { get; set; }
        public string? Accounting_voucher { get; set; }
        public string? Amount { get; set; }
        public string? Description { get; set; }
        public string? Date { get; set; }
        public string? HSN_SAC { get; set; }
        public string? CGST { get; set; }
        public string? SGST { get; set; }
        public string? IGST { get; set; }
        public string? CESS { get; set; }
        public string? GSTIN { get; set; }
        public string? Remarks { get; set; }
        public string? Action { get; set; }

    }
}
