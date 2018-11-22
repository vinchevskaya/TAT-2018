using System.Collections.Generic;

namespace DEV_5
{
    class Storage
    {
        ICommandStore command;
        public void SetCommand(ICommandStore com)
        {
            command = com;
        }
        public void WorkCommand(List<CarShop> list)
        {
            command.Work(list);
        }
    }
}