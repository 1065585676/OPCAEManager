using System;
using System.Collections.Generic;
using System.Text;

namespace CShapTest
{
    class CategoriesAndAttribute
    {

        public enum Categories
        {
            System_alarm = 101,
            Process_alarm = 102,
            Operation_record = 107
        }

        public enum Attributes
        {
            CENTUM_message_ID_number = 160,
            Station_name = 161,
            Tag_name = 162,
            Item_name = 163,
            Data_value = 164,
            Recipe_group_number = 165,
            Recipe_name = 166,
            Batch_ID = 167,
            Unit_recipe_number = 168,
            Engineering_unit = 169,
            ModeOrStatus_name = 170,
            Element_name = 171,
            Operator_name = 174,
            Operation_station_name = 175,
            Station_time_GMT = 179,
            Station_time_Millisecond = 180,
            Plant_hierarchy = 181,
            Station_number = 182,
            Area_number = 183,
            Common_block_number = 184,
            Sequence_number = 185,
            Old_status_name = 186,
            Alarm_level = 187,
            Alarm_off = 188,
            Alarm_blink = 189,
            Alarm_filter = 190,
            Project_ID = 191
        }

        public static List<uint> getAttributeIDsFromCategoryID(uint categoriesID)
        {
            List<uint> result = new List<uint>();
            switch (categoriesID)
            {
                case (uint)Categories.System_alarm:
                    result.Add((uint)Attributes.CENTUM_message_ID_number);
                    result.Add((uint)Attributes.Station_name);
                    result.Add((uint)Attributes.Station_time_GMT);
                    result.Add((uint)Attributes.Station_time_Millisecond);
                    result.Add((uint)Attributes.Operator_name);
                    result.Add((uint)Attributes.Operation_station_name);
                    result.Add((uint)Attributes.Recipe_group_number);
                    result.Add((uint)Attributes.Recipe_name);
                    result.Add((uint)Attributes.Batch_ID);
                    result.Add((uint)Attributes.Unit_recipe_number);
                    result.Add((uint)Attributes.Plant_hierarchy);
                    result.Add((uint)Attributes.Station_number);
                    result.Add((uint)Attributes.Area_number);
                    result.Add((uint)Attributes.Common_block_number);
                    result.Add((uint)Attributes.Project_ID);
                    break;
                case (uint)Categories.Process_alarm:
                    result.Add((uint)Attributes.CENTUM_message_ID_number);
                    result.Add((uint)Attributes.Station_name);
                    result.Add((uint)Attributes.Tag_name);
                    result.Add((uint)Attributes.Item_name);
                    result.Add((uint)Attributes.Data_value);
                    result.Add((uint)Attributes.Recipe_group_number);
                    result.Add((uint)Attributes.Recipe_name);
                    result.Add((uint)Attributes.Batch_ID);
                    result.Add((uint)Attributes.Unit_recipe_number);
                    result.Add((uint)Attributes.Engineering_unit);
                    result.Add((uint)Attributes.Station_time_GMT);
                    result.Add((uint)Attributes.Station_time_Millisecond);
                    result.Add((uint)Attributes.Plant_hierarchy);
                    result.Add((uint)Attributes.ModeOrStatus_name);
                    result.Add((uint)Attributes.Element_name);
                    result.Add((uint)Attributes.Station_number);
                    result.Add((uint)Attributes.Area_number);
                    result.Add((uint)Attributes.Common_block_number);
                    result.Add((uint)Attributes.Sequence_number);
                    result.Add((uint)Attributes.Alarm_level);
                    result.Add((uint)Attributes.Alarm_off);
                    result.Add((uint)Attributes.Alarm_blink);
                    result.Add((uint)Attributes.Alarm_filter);
                    result.Add((uint)Attributes.Project_ID);
                    break;
                case (uint)Categories.Operation_record:
                    result.Add((uint)Attributes.CENTUM_message_ID_number);
                    result.Add((uint)Attributes.Station_name);
                    result.Add((uint)Attributes.Operator_name);
                    result.Add((uint)Attributes.Operation_station_name);
                    result.Add((uint)Attributes.Tag_name);
                    result.Add((uint)Attributes.Item_name);
                    result.Add((uint)Attributes.Data_value);
                    result.Add((uint)Attributes.Recipe_group_number);
                    result.Add((uint)Attributes.Recipe_name);
                    result.Add((uint)Attributes.Batch_ID);
                    result.Add((uint)Attributes.Unit_recipe_number);
                    result.Add((uint)Attributes.Engineering_unit);
                    result.Add((uint)Attributes.ModeOrStatus_name);
                    result.Add((uint)Attributes.Station_time_GMT);
                    result.Add((uint)Attributes.Station_time_Millisecond);
                    result.Add((uint)Attributes.Plant_hierarchy);
                    result.Add((uint)Attributes.Station_number);
                    result.Add((uint)Attributes.Area_number);
                    result.Add((uint)Attributes.Common_block_number);
                    result.Add((uint)Attributes.Old_status_name);
                    result.Add((uint)Attributes.Project_ID);
                    break;
                default:
                    break;
            }
            return result;
        }

        public static List<string> getAttributeNamesFromCategoryID(uint categoriesID)
        {
            List<string> result = new List<string>();

            List<uint> temp = getAttributeIDsFromCategoryID(categoriesID);
            for (int i = 0; i < temp.Count; i++)
            {
                result.Add(getAttributeNameFromID(temp[i]));
            }

            return result;
        }


        public static string getAttributeNameFromID(uint id)
        {
            string result = string.Empty;
            switch (id)
            {
                case 160:
                    result = "CENTUM_message_ID_number";
                    break;
                case 161:
                    result = "Station_name";
                    break;
                case 162:
                    result = "Tag_name";
                    break;
                case 163:
                    result = "Item_name";
                    break;
                case 164:
                    result = "Data_value";
                    break;
                case 165:
                    result = "Recipe_group_number";
                    break;
                case 166:
                    result = "Recipe_name";
                    break;
                case 167:
                    result = "Batch_ID";
                    break;
                case 168:
                    result = "Unit_recipe_number";
                    break;
                case 169:
                    result = "Engineering_unit";
                    break;
                case 170:
                    result = "ModeOrStatus_name";
                    break;
                case 171:
                    result = "Element_name";
                    break;
                case 174:
                    result = "Operator_name";
                    break;
                case 175:
                    result = "Operation_station_name";
                    break;
                case 179:
                    result = "Station_time_GMT";
                    break;
                case 180:
                    result = "Station_time_Millisecond";
                    break;
                case 181:
                    result = "Plant_hierarchy";
                    break;
                case 182:
                    result = "Station_number";
                    break;
                case 183:
                    result = "Area_number";
                    break;
                case 184:
                    result = "Common_block_number";
                    break;
                case 185:
                    result = "Sequence_number";
                    break;
                case 186:
                    result = "Old_status_name";
                    break;
                case 187:
                    result = "Alarm_level";
                    break;
                case 188:
                    result = "Alarm_off";
                    break;
                case 189:
                    result = "Alarm_blink";
                    break;
                case 190:
                    result = "Alarm_filter";
                    break;
                case 191:
                    result = "Project_ID";
                    break;
                default:
                    break;
            }
            return result;
        }

        public static string getCategoryNameFromID(uint id)
        {
            string result = string.Empty;
            switch (id)
            {
                case (uint)Categories.System_alarm:
                    result = "System alarm";
                    break;
                case (uint)Categories.Process_alarm:
                    result = "Process alarm";
                    break;
                case (uint)Categories.Operation_record:
                    result = "Operation record";
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
