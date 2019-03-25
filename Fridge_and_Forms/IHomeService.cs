using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fridge_and_Forms
{
    public interface IHomeService
    {
        Fridge CreateFridgeParalelepiped();
        Fridge CreateFridgeSphere();
        Fridge CreateFridgeCylinder();

        bool CheckIsSuccessParalelepipedThrow(Fridge fridge);
        bool CheckIsSuccessSphereThrow(Fridge fridge);
        bool CheckIsSuccessCelinderThrow(Fridge fridge);
    }
}
