using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Kt10WcfServiceLibrary2
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде и файле конфигурации.
    public class Service1 : ISecureService
    {
        public string SecureMethod(string input)
        {
            return "Response from SecureMethod: " + input;
        }

    }
}
