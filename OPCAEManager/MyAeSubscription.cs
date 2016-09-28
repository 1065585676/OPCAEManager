//-----------------------------------------------------------------------------
//                                                                            |
//                   Softing Industrial Automation GmbH                       |
//                        Richard-Reitzner-Allee 6                            |
//                           85540 Haar, Germany                              |
//                                                                            |
//                 This is a part of the Softing OPC Toolkit                  |
//       Copyright (c) 1998 - 2016 Softing Industrial Automation GmbH         |
//                           All Rights Reserved                              |
//                                                                            |
//-----------------------------------------------------------------------------
//-----------------------------------------------------------------------------
//                             OPC Toolkit C#                                 |
//                                                                            |
//  Filename    : MyAeSubscription.cs		                                  |
//  Version     : 4.45                                                        |
//  Date        : 27-June-2016                                                |
//                                                                            |
//  Description : OPC AE Subscription template class definition               |
//                                                                            |
//-----------------------------------------------------------------------------
using Softing.OPCToolbox;
using Softing.OPCToolbox.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace CShapTest
{
    public class MyAeSubscription : AeSubscription
    {

        #region Constructor
        //-----------------

        public MyAeSubscription(MyAeSession parentSession) : base(parentSession)
        {
            PerformStateTransitionCompleted += new PerformStateTransitionEventHandler(HandlePerformObjectStateTransitionCompleted);
            StateChangeCompleted += new StateChangeEventHandler(HandleStateChangeCompleted);
            AeEventsReceived += new AeEventsReceivedEventHandler(HandleEventsReceived);
            AeConditionsChanged += new AeConditionsChangedEventHandler(HandleConditionsChanged);
        }

        //--
        #endregion

        #region Private Members
        //---------------------

        #region Private Attributes
        //------------------------


        //--
        #endregion


        //--
        #endregion

        #region Public Methods
        //---------------------

        // creates the string representation of the AeCondition.State property
        public static string GetState(EnumConditionState state)
        {
            string stateToString = string.Empty;
            if ((state & EnumConditionState.ACKED) == EnumConditionState.ACKED)
            {
                stateToString += "ACKED ";
            }
            if ((state & EnumConditionState.ACTIVE) == EnumConditionState.ACTIVE)
            {
                stateToString += "ACTIVE ";
            }
            if ((state & EnumConditionState.ENABLED) == EnumConditionState.ENABLED)
            {
                stateToString += "ENABLED ";
            }
            return stateToString;
        }// end GetState

        // creates the string representation of the AeCondition.ChangeMask property
        public static string GetWhatChanged(EnumConditionChange change)
        {
            string changeToString = string.Empty;
            if ((change & EnumConditionChange.ACK_DATA) == EnumConditionChange.ACK_DATA)
            {
                changeToString += "ACK_DATA ";
            }
            if ((change & EnumConditionChange.ACK_STATE) == EnumConditionChange.ACK_STATE)
            {
                changeToString += "ACK_STATE ";
            }
            if ((change & EnumConditionChange.ACTIVE_STATE) == EnumConditionChange.ACTIVE_STATE)
            {
                changeToString += "ACTIVE_STATE ";
            }
            if ((change & EnumConditionChange.ATTRIBUTE) == EnumConditionChange.ATTRIBUTE)
            {
                changeToString += "ATTRIBUTE ";
            }
            if ((change & EnumConditionChange.ENABLE_STATE) == EnumConditionChange.ENABLE_STATE)
            {
                changeToString += "ENABLE_STATE ";
            }
            if ((change & EnumConditionChange.MESSAGE) == EnumConditionChange.MESSAGE)
            {
                changeToString += "MESSAGE ";
            }
            if ((change & EnumConditionChange.QUALITY) == EnumConditionChange.QUALITY)
            {
                changeToString += "QUALITY ";
            }
            if ((change & EnumConditionChange.SEVERITY) == EnumConditionChange.SEVERITY)
            {
                changeToString += "SEVERITY ";
            }
            if ((change & EnumConditionChange.STATE) == EnumConditionChange.STATE)
            {
                changeToString += "STATE ";
            }
            if ((change & EnumConditionChange.SUBCONDITION) == EnumConditionChange.SUBCONDITION)
            {
                changeToString += "SUBCONDITION ";
            }
            return changeToString;
        }// end GetWhatChanged

        //--
        #endregion

        #region Public Properties
        //-----------------------


        //--
        #endregion

        #region Handles

        // method that handles the completion of performing the ObjectSpaceElement state transition
        public static void HandlePerformObjectStateTransitionCompleted(ObjectSpaceElement obj, uint executionContext, int result)
        {
            if (ResultCode.SUCCEEDED(result))
            {
                System.Console.WriteLine(obj.ToString() + " Performed state transition " + executionContext);
            }
            else
            {
                System.Console.WriteLine(obj.ToString() + " Performed state transition failed");
            }
        }

        // method that handles the completion of state changing of an ObjectSpaceElement
        public static void HandleStateChangeCompleted(ObjectSpaceElement obj, EnumObjectState state)
        {
            System.Console.WriteLine(obj + " State Changed - " + state);
        }

        // method that handles the AeSubscription.AeEventsReceived event; it displays on the console the received events
        public static void HandleEventsReceived(AeSubscription anAeSubscription, bool refresh, bool lastRefresh, AeEvent[] events)
        {
            for (int i = 0; i < events.Length; i++)
            {
                string time = events[i].OccurenceTime.AddHours(8).ToString();
                string bitNumber = events[i].SourcePath;
                string bitNumberDescribe = string.Empty;
                string aeType = string.Empty;
                string priority = events[i].Severity.ToString();
                string realTimeValue = string.Empty;
                string limitValue = string.Empty;
                string engineeringUnit = string.Empty;
                string aeDescribe = events[i].Message;
                string device = string.Empty;
                string area = string.Empty;
                string operatingFloor = string.Empty;
                string operatingPersonnel = string.Empty;
                string extension_1 = string.Empty;
                string extension_2 = string.Empty;
                string extension_3 = string.Empty;
                string extension_4 = string.Empty;
                string extension_5 = string.Empty;

                string messageType = events[i].Category.ToString();
                string isDCS = string.Empty;

                string aeSubType = string.Empty;
                string areaNumber = string.Empty;
                string stationNumber = string.Empty;
                string alarmLevel = string.Empty;
                string alarmOff = string.Empty;
                string alarmBlink = string.Empty;
                string alarmFilter = string.Empty;
                string ackRequired = string.Empty;
                string quality = string.Empty;

                if (events[i].EventType == EnumEventType.CONDITION)
                {
                    aeType = ((AeCondition)events[i]).ConditionName;
                    aeSubType = ((AeCondition)events[i]).SubConditionName;
                    ackRequired = ((AeCondition)events[i]).AckRequired.ToString();
                    quality = ((AeCondition)events[i]).Quality.ToString();
                }

                ArrayList attributes = events[i].Attributes;
                List<string> temp = CategoriesAndAttribute.getAttributeNamesFromCategoryID(events[i].Category);
                for (int j = 0; j < events[i].Attributes.Count; j++)
                {
                    if (temp[j].Equals("Data_value"))
                        realTimeValue = attributes[j].ToString();
                    if (temp[j].Equals("Engineering_unit"))
                        engineeringUnit = attributes[j].ToString();
                    if (temp[j].Equals("Area_number"))
                        areaNumber = attributes[j].ToString();
                    if (temp[j].Equals("Station_number"))
                        stationNumber = attributes[j].ToString();
                    if (temp[j].Equals("Alarm_level"))
                        alarmLevel = attributes[j].ToString();
                    if (temp[j].Equals("Alarm_off"))
                        alarmOff = attributes[j].ToString();
                    if (temp[j].Equals("Alarm_blink"))
                        alarmBlink = attributes[j].ToString();
                    if (temp[j].Equals("Alarm_filter"))
                        alarmFilter = attributes[j].ToString();
                }

                AEInfos oneAEInfo = new AEInfos
                {
                    Time = time,
                    BitNumber = bitNumber,
                    BitNumberDescribe = bitNumberDescribe,
                    AEType = aeType,
                    Priority = priority,
                    RealTimeValue = realTimeValue,
                    LimitValue = limitValue,
                    EngineeringUnit = engineeringUnit,
                    AEDescribe = aeDescribe,
                    Device = device,
                    Area = area,
                    OperatingFloor = operatingFloor,
                    OperatingPersonnel = operatingPersonnel,
                    Extension_1 = extension_1,
                    Extension_2 = extension_2,
                    Extension_3 = extension_3,
                    Extension_4 = extension_4,
                    Extension_5 = extension_5,

                    MessageType = messageType,
                    IsDCS = isDCS,

                    AESubType = aeSubType,
                    AreaNumber = areaNumber,
                    StationNumber = stationNumber,
                    AlarmLevel = alarmLevel,
                    AlarmOff = alarmOff,
                    AlarmBlink = alarmBlink,
                    AlarmFilter = alarmFilter,
                    AckRequired = ackRequired,
                    Quality = quality
                };

                MessageQueueTool.EnMessage(oneAEInfo);

                File.AppendAllText(@"./AEInfos.json", JsonConvert.SerializeObject(oneAEInfo, Formatting.Indented) + "\n");
                if (new FileInfo(@"./AEInfos.json").Length >= 50 * 1024 * 1024)
                {
                    File.Delete(@"./AEInfos_backup.json");
                    File.Move(@"./AEInfos.json", @"./AEInfos_backup.json");
                }
            }//end  for	
        }

        // method that handles the AeSubscription.AeConditionsChanged event
        public static void HandleConditionsChanged(AeSubscription anAeSubscription, AeCondition[] conditions)
        {
            System.Diagnostics.Debug.WriteLine("Conditions changed");
        }

        //--
        #endregion

    }	//	end class MyAeItem

}	//	end namespace
