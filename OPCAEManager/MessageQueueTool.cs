using System.Collections.Generic;
using System;

namespace CShapTest
{
    class MessageQueueTool
    {
        private static Queue<AEInfos> msgQueue = new Queue<AEInfos>();

        public static ulong MESSAGE_TOTAL_COUNT = 0;
        public static uint MESSAGE_QUEUE_MAX_LENGTH = 66666;
        public static string MESSAGE_SEND_TIME = string.Empty;

        public static void EnMessage(AEInfos msgInfo)
        {
            MESSAGE_TOTAL_COUNT++;
            if (msgQueue.Count >= MESSAGE_QUEUE_MAX_LENGTH)
            {
                msgQueue.Dequeue();
            }
            msgQueue.Enqueue(msgInfo);
        }

        public static AEInfos DeMessage()
        {
            if (msgQueue.Count <= 0)
            {
                return null;
            }
            MESSAGE_SEND_TIME = DateTime.Now.ToLocalTime().ToString();
            return msgQueue.Dequeue();
        }

        public static int Count()
        {
            return msgQueue.Count;
        }
    }
}
