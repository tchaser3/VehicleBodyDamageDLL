/* Title:           Vehicle Body Damage Class
 * Date:            7-11-17
 * Author:          Terry Holmes */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;

namespace VehicleBodyDamageDLL
{
    public class VehicleBodyDamageClass
    {
        //setting up the classes
        EventLogClass TheEventLogClass = new EventLogClass();

        VehicleBodyDamageDataSet aVehicleBodyDamageDataSet;
        VehicleBodyDamageDataSetTableAdapters.vehiclebodydamageTableAdapter aVehicleBodyDamageTableAdapter;

        FindVehicleBodyDamageByVehicleIDDataSet aFindVehicleBodyDamageByVehicleIDDataSet;
        FindVehicleBodyDamageByVehicleIDDataSetTableAdapters.FindVehicleBodyDamageByVehicleIDTableAdapter aFindVehicleBodyDamageByVehicleIDTableAdapter;

        FindVehicleBodyDamageByDateRangeDataSet aFindVehicleBodyDamageByDateRangeDataSet;
        FindVehicleBodyDamageByDateRangeDataSetTableAdapters.FindVehicleBodyDamageByDateRangeTableAdapter aFindVehicleBodyDamageByDateRangeTableAdapter;

        InsertNewVehicleBodyDamageEntryTableAdapters.QueriesTableAdapter aInsertNewVehicleBodyDamageTableAdapter;

        UpdateVehicleBodyDamageRepairEntryTableAdapters.QueriesTableAdapter aUpdateVehicleBodyDamageRepairTableAdapter;

        FindVehicleMainBodyDamageByDateRangeDataSet aFindVehicleMainBodyDamageByDateRangeDataSet;
        FindVehicleMainBodyDamageByDateRangeDataSetTableAdapters.FindVehicleMainBodyDamageByDateRangeTableAdapter aFindVehicleMainBodyDamageByDateRangeTableAdapter;

        FindVehicleMainBodyDamageByVehicleIDDataSet aFindVehicleMainBodyDamageByVehicleIDDataSet;
        FindVehicleMainBodyDamageByVehicleIDDataSetTableAdapters.FindVehicleMainBodyDamageByVehicleIDTableAdapter aFindVehicleMainBodyDamageByVehicleIDTableAdapter;

        public FindVehicleMainBodyDamageByVehicleIDDataSet FindVehicleMainBodyDamageByVehicleID(int intVehicleID)
        {
            try
            {
                aFindVehicleMainBodyDamageByVehicleIDDataSet = new FindVehicleMainBodyDamageByVehicleIDDataSet();
                aFindVehicleMainBodyDamageByVehicleIDTableAdapter = new FindVehicleMainBodyDamageByVehicleIDDataSetTableAdapters.FindVehicleMainBodyDamageByVehicleIDTableAdapter();
                aFindVehicleMainBodyDamageByVehicleIDTableAdapter.Fill(aFindVehicleMainBodyDamageByVehicleIDDataSet.FindVehicleMainBodyDamageByVehicleID, intVehicleID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Body Damage // Find Vehicle Body Damage By Vehicle ID " + Ex.Message);
            }

            return aFindVehicleMainBodyDamageByVehicleIDDataSet;
        }
        public FindVehicleMainBodyDamageByDateRangeDataSet FindVehicleMainBodyDamageByDateRange(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindVehicleMainBodyDamageByDateRangeDataSet = new FindVehicleMainBodyDamageByDateRangeDataSet();
                aFindVehicleMainBodyDamageByDateRangeTableAdapter = new FindVehicleMainBodyDamageByDateRangeDataSetTableAdapters.FindVehicleMainBodyDamageByDateRangeTableAdapter();
                aFindVehicleMainBodyDamageByDateRangeTableAdapter.Fill(aFindVehicleMainBodyDamageByDateRangeDataSet.FindVehicleMainBodyDamageByDateRange, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Body Damage // Find Vehicle Body Damage By Date Range " + Ex.Message);
            }

            return aFindVehicleMainBodyDamageByDateRangeDataSet;
        }
        public bool UpdateVehicleBodyDamageRepair(int intTransactionID, bool blnRepair)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateVehicleBodyDamageRepairTableAdapter = new UpdateVehicleBodyDamageRepairEntryTableAdapters.QueriesTableAdapter();
                aUpdateVehicleBodyDamageRepairTableAdapter.UpdateVehicleBodyDamageRepaired(intTransactionID, blnRepair);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Body Damage // Update Vehicle Body Damage Repair " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool InsertNewVehicleBodyDamage(int intVehicleID, string strBodyDamage, DateTime datDateReported, bool blnRepaired)
        {
            bool blnFatalError = false;

            try
            {
                aInsertNewVehicleBodyDamageTableAdapter = new InsertNewVehicleBodyDamageEntryTableAdapters.QueriesTableAdapter();
                aInsertNewVehicleBodyDamageTableAdapter.InsertNewVehicleBodyDamage(intVehicleID, strBodyDamage, datDateReported, blnRepaired);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Body Damage Class // Insert New Body Damage " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public FindVehicleBodyDamageByDateRangeDataSet FindVehicleBodyDamageByDateRange(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindVehicleBodyDamageByDateRangeDataSet = new FindVehicleBodyDamageByDateRangeDataSet();
                aFindVehicleBodyDamageByDateRangeTableAdapter = new FindVehicleBodyDamageByDateRangeDataSetTableAdapters.FindVehicleBodyDamageByDateRangeTableAdapter();
                aFindVehicleBodyDamageByDateRangeTableAdapter.Fill(aFindVehicleBodyDamageByDateRangeDataSet.FindVehicleBodyDamageByDateRange, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Body Damage Class // Find Vehicle Body Damage By Date Range " + Ex.Message);
            }

            return aFindVehicleBodyDamageByDateRangeDataSet;
        }
        public FindVehicleBodyDamageByVehicleIDDataSet FindVehicleBodyDamageByVehicleID(int intVehicleID)
        {
            try
            {
                aFindVehicleBodyDamageByVehicleIDDataSet = new FindVehicleBodyDamageByVehicleIDDataSet();
                aFindVehicleBodyDamageByVehicleIDTableAdapter = new FindVehicleBodyDamageByVehicleIDDataSetTableAdapters.FindVehicleBodyDamageByVehicleIDTableAdapter();
                aFindVehicleBodyDamageByVehicleIDTableAdapter.Fill(aFindVehicleBodyDamageByVehicleIDDataSet.FindVehicleBodyDamageByVehicleID, intVehicleID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Body Damage class // Find Vehicle Body Damage By Vehicle ID " + Ex.Message);
            }

            return aFindVehicleBodyDamageByVehicleIDDataSet;
        }
        public VehicleBodyDamageDataSet GetVehicleBodyDamageInfo()
        {
            try
            {
                aVehicleBodyDamageDataSet = new VehicleBodyDamageDataSet();
                aVehicleBodyDamageTableAdapter = new VehicleBodyDamageDataSetTableAdapters.vehiclebodydamageTableAdapter();
                aVehicleBodyDamageTableAdapter.Fill(aVehicleBodyDamageDataSet.vehiclebodydamage);   
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Body Damage Class // Get Vehicle Body Damage Info " + Ex.Message);
            }

            return aVehicleBodyDamageDataSet;
        }
        public void UpdateVehicleBodyDamageDB(VehicleBodyDamageDataSet aVehicleBodyDamageDataSet)
        {
            try
            {
                aVehicleBodyDamageTableAdapter = new VehicleBodyDamageDataSetTableAdapters.vehiclebodydamageTableAdapter();
                aVehicleBodyDamageTableAdapter.Update(aVehicleBodyDamageDataSet.vehiclebodydamage);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Vehicle Body Damage Class // Update Vehicle Body Damage DB " + Ex.Message);
            }
        }
    }
}
