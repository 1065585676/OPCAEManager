using Softing.OPCToolbox;
using Softing.OPCToolbox.Client;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;

namespace CShapTest
{
    class MyOPCClientManager
    {

        MainWindow tempForm;

        public static bool ISACTIVED = false;

        public MyOPCClientManager(MainWindow P_form)
        {
            tempForm = P_form;
        }

        private MyAeSession m_aeSession = null;
        private MyAeSubscription m_aeSubscription = null;
        private ExecutionOptions m_executionOptions = null;

        private string GetStateToString(EnumConditionState state)
        {
            string stateToString = string.Empty;

            if ((state & EnumConditionState.ACTIVE) == EnumConditionState.ACTIVE)
                stateToString += " ACT";
            if ((state & EnumConditionState.ENABLED) == EnumConditionState.ENABLED)
                stateToString += " ENA";
            if ((state & EnumConditionState.ACKED) == EnumConditionState.ACKED)
                stateToString += " ACK";
            if (state == 0)
                stateToString += " DIS";

            return stateToString;
        }

        public Softing.OPCToolbox.Client.Application GetApplication()
        {
            return Softing.OPCToolbox.Client.Application.Instance;
        }

        public int Initialize()
        {
            int result = (int)EnumResultCode.S_OK;
            GetApplication().VersionOtb = 445;

            //    TODO - binary license activation
            //    Fill in your binary license activation keys here
            //
            //    NOTE: you can activate one or all of the features at the same time
            //    activate the COM-AE Client Feature
            //result = Application.Instance.Activate(EnumFeature.AE_CLIENT, "0ee0-0393-870e-28d9-68d7");
            if (!ISACTIVED)
            {
                //EnumFeature.AE_CLIENT;
                //EnumFeature.AE_SERVER;
                //EnumFeature.DA_CLIENT;
                //EnumFeature.DA_SERVER;
                //EnumFeature.TP_CLIENT;
                //EnumFeature.TP_SERVER;
                //EnumFeature.XMLDA_CLIENT;
                //EnumFeature.XMLDA_SERVER;
                if (!File.Exists("./Config/License.config"))
                {
                    MessageBox.Show("程序未注册，请点击“帮助”-“License”进行注册！", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //Environment.Exit(-1);
                    return (int)EnumResultCode.E_EXCEPTION;
                }
                else
                {
                    string licenseInfos = File.ReadAllText("./Config/License.config");

                    result = Softing.OPCToolbox.Client.Application.Instance.Activate(EnumFeature.AE_CLIENT, licenseInfos);
                    if (!ResultCode.SUCCEEDED(result))
                    {
                        MessageBox.Show("许可证认证失败！请联系相关人员确认！", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        return result;
                    }
                    ISACTIVED = true;
                }
            }
            //    END TODO - binary license activation

            //    proceed with the OPC Toolkit core initialization
            result = GetApplication().Initialize();

            if (ResultCode.SUCCEEDED(result))
            {
                //    enable toolkit internal initialization
                GetApplication().EnableTracing(
                    EnumTraceGroup.ALL,
                    EnumTraceGroup.ALL,
                    EnumTraceGroup.CLIENT,
                    EnumTraceGroup.CLIENT,
                    "Trace.txt",
                    1000000,
                    0);
            }
            return result;
        }

        public void Terminate()
        {
            // disconnect all the connected objects
            if (m_aeSubscription != null && m_aeSubscription.CurrentState != EnumObjectState.DISCONNECTED)
            {
                m_aeSubscription.Disconnect(new ExecutionOptions());
            }

            if (m_aeSession != null && m_aeSession.CurrentState != EnumObjectState.DISCONNECTED)
            {
                m_aeSession.Disconnect(new ExecutionOptions());
                // remove subscription from session
                if (m_aeSession != null) m_aeSession.RemoveAeSubscription(m_aeSubscription);
            }

            // remove session from application
            GetApplication().RemoveAeSession(m_aeSession);

            // terminate the application
            GetApplication().Terminate();
            m_aeSession = null;
            m_aeSubscription = null;
            m_executionOptions = null;
        }

        public int InitializeAeObjects(string url)
        {
            int connectResult = (int)EnumResultCode.E_FAIL;
            m_executionOptions = new ExecutionOptions();
            m_executionOptions.ExecutionType = EnumExecutionType.ASYNCHRONOUS;
            m_executionOptions.ExecutionContext = 0;

            try
            {

                m_aeSession = new MyAeSession(url);
                m_aeSubscription = new MyAeSubscription(m_aeSession);

                connectResult = m_aeSession.Connect(true, false, new ExecutionOptions());

                uint[] categoryIds = new uint[]
                {
                    (uint)CategoriesAndAttribute.Categories.System_alarm,
                    (uint)CategoriesAndAttribute.Categories.Process_alarm,
                    (uint)CategoriesAndAttribute.Categories.Operation_record
                };
                m_aeSubscription.FilterCategories = categoryIds;

                AeReturnedAttributes[] returnedAttributes = new AeReturnedAttributes[categoryIds.Length];
                for (int i = 0; i < categoryIds.Length; i++)
                {
                    List<uint> temp = CategoriesAndAttribute.getAttributeIDsFromCategoryID(categoryIds[i]);
                    uint[] attributeIds = new uint[temp.Count];
                    attributeIds = temp.ToArray();
                    returnedAttributes[i] = new AeReturnedAttributes();
                    returnedAttributes[i].AttributeIds = attributeIds;
                    returnedAttributes[i].CategoryId = categoryIds[i];
                }
                m_aeSubscription.ReturnedAttributes = returnedAttributes;

            }
            catch (Exception exc)
            {
                GetApplication().Trace(
                    EnumTraceLevel.ERR,
                    EnumTraceGroup.USER,
                    "OpcClient::InitializeAeObjects",
                    exc.ToString());
            }   //    end try...catch

            return connectResult;
        }	//    end InitializeAeObjects

        public void activateObjectsAsync()
        {
            System.Console.WriteLine();
            // activate the session asynchronously
            m_aeSession.Connect(true, true, m_executionOptions);
            // increment the execution context used to identify the callback that comes as response
            m_executionOptions.ExecutionContext++;
        }// end activateObjectsAsync

        public void activateObjectsSync()
        {
            System.Console.WriteLine();
            // activate the session synchronously
            m_aeSession.Connect(true, true, new ExecutionOptions());
        }// end activateObjectsSync

        public void ConnectOPCServer()
        {
            //	initialize the client instance
            if (!ResultCode.SUCCEEDED(Initialize()))
            {
                MessageBox.Show("Client Initialize Failed.");
                throw new Exception("Client Initialize Failed.");
            }   //	end if
            string url = "opcae://" + tempForm.OPCServerIp.Text + "/" + tempForm.ClassID.Text + "/{" + tempForm.ProgramID.Text + "}";

            if (!ResultCode.SUCCEEDED(InitializeAeObjects(url)))
            {
                MessageBox.Show("Client InitializeAeObjects Failed.");
                throw new Exception("Client InitializeAeObjects Failed.");
            }

            activateObjectsSync();      //同步--连接点少时
            //activateObjectsAsync();     //异步--连接点多时
        }

        public void StopConnectedOPC()
        {
            Terminate();
        }
    }
}
