//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Classroom_Fund
{
    using System;
    using System.Collections.Generic;
    
    public partial class act_of_renting
    {
        public act_of_renting() { }
        public act_of_renting(long firm_id, byte floor_number, DateTime start_date, DateTime end_date, decimal sum_of_money)
        {
            this.firm_id = firm_id;
            this.floor_number = floor_number;
            this.start_date = start_date;
            this.end_date = end_date;
            this.sum_of_money = sum_of_money;
        }
        public long id { get; set; }
        public long firm_id { get; set; }
        public byte floor_number { get; set; }
        public System.DateTime start_date { get; set; }
        public System.DateTime end_date { get; set; }
        public decimal sum_of_money { get; set; }
    
        public virtual firm firm { get; set; }
        public virtual floor floor { get; set; }
        public void Update(act_of_renting aor)
        {
            this.firm_id = aor.firm_id;
            this.floor_number = aor.floor_number;
            this.start_date = aor.start_date;
            this.end_date = aor.end_date;
            this.sum_of_money = aor.sum_of_money;
        }
    }
}
