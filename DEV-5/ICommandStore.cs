using System.Collections.Generic;

namespace DEV_5
{
    public interface ICommandStore
    {
        void Work(List<CarShop> list);
    }
}