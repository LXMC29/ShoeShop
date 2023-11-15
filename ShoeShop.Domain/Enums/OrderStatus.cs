using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeShop.Domain.Enums
{
    public enum OrderStatus
    {
        Success, // Hoàn thành
        Cancel, // Huỷ
        Confirmed, // Xác nhận
        PendingForComfirmation, // Chưa xác nhận
        Shipping
    }
}
