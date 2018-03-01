using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Manager
{
    class RoomAvailability
    {
        public static MarkType []slots = new MarkType[127];

        static RoomAvailability()
        {
            for (int i = 0; i < 128; i++)
            {
                slots[i] = MarkType.Free;
            }
        }
    }

    enum MarkType
    {
        Free,

        Taken
    }
}
