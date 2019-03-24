using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fridge_and_Forms
{
    public interface IHomeService
    {
        Fridge CreateFridge();

        bool CheckIsSuccessThrow(Fridge fridge);
    }
}
