using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hercules_Inspection
{
    class Product
    {
        String code;
        int processNo;
        String processName;
        int status;
        int locNo;

        public static readonly int NEW = 1; //When loaded
        public static readonly int COMPLETE = 2; //Production done
        public static readonly int MANUAL = 3; //Manual process
        public static readonly int IN_PROGRESS = 4; //in progress at station
        public static readonly int IN_TRANSIT = 5; //moving with AGV
        public static readonly int STORAGE = 6; //in storage area
        public static readonly int INSPECTED = 7; //inspecting done and at inspect area
        public static readonly int WAIT_STATION = 8; //in station and wait to move
        public static readonly int INSPECT_REQ = 9; //happen when worker press INSPECT button
        public static readonly int INSPECT_STATION = 10; //in station and wait to inspect
        public static readonly int INSPECT_STORAGE = 11; //in inspect area and wait to inspect
        public static readonly int INSPECTING_STATION = 12; //Calling inspector for inspecting at station
        public static readonly int INSPECTING_STORAGE = 13; //Calling inspector for inspecting at storage


        public string Code { get => code; set => code = value; }
        public int ProcessNo { get => processNo; set => processNo = value; }
        public string ProcessName { get => processName; set => processName = value; }
        public int Status { get => status; set => status = value; }
        public int LocNo { get => locNo; set => locNo = value; }
    }
}
