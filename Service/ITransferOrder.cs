using WarehouseTransferOrders.Model;

namespace WarehouseTransferOrders.Service
{
    public interface ITransferOrder
    {
        Task<List<erpTransferOrder>> GetTransferOrders();
    }
}
