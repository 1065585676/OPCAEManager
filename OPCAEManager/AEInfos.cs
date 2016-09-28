namespace CShapTest
{
    class AEInfos
    {
        public string Time { get; set; }                //时间
        public string BitNumber { get; set; }           //位号
        public string BitNumberDescribe { get; set; }   //位号描述
        public string AEType { get; set; }              //报警类型
        public string Priority { get; set; }            //优先级
        public string RealTimeValue { get; set; }          //实时值
        public string LimitValue { get; set; }             //限值
        public string EngineeringUnit { get; set; }           //单位
        public string AEDescribe { get; set; }          //报警描述
        public string Device { get; set; }              //装置
        public string Area { get; set; }                //区域
        public string OperatingFloor { get; set; }      //操作台
        public string OperatingPersonnel { get; set; }  //操作人员
        public string Extension_1 { get; set; }         //扩展1
        public string Extension_2 { get; set; }         //扩展2
        public string Extension_3 { get; set; }         //扩展3
        public string Extension_4 { get; set; }         //扩展4
        public string Extension_5 { get; set; }         //扩展5
        //----------------------------------------------------------------------------
        public string MessageType { get; set; }         //报警与事件信息的类型
        public string IsDCS { get; set; }               //是否DCS

        public string AESubType { get; set; }           //报警子类型
        public string AreaNumber { get; set; }         //Area number
        public string StationNumber { get; set; }      //Station number
        public string AlarmLevel { get; set; }         //Alarm level
        public string AlarmOff { get; set; }           //Alarm off
        public string AlarmBlink { get; set; }         //Alarm blink
        public string AlarmFilter { get; set; }        //Alarm filter
        public string AckRequired { get; set; }         //Ack required
        public string Quality { get; set; }             //Quality

    }
}
