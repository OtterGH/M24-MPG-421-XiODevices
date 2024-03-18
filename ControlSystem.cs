using System;
using Crestron.SimplSharp;                          	// For Basic SIMPL# Classes
using Crestron.SimplSharpPro;                       	// For Basic SIMPL#Pro classes
using Crestron.SimplSharpPro.CrestronThread;        	// For Threading
using Crestron.SimplSharpPro.Diagnostics;		    	// For System Monitor Access
using Crestron.SimplSharpPro.DeviceSupport;             // For Generic Device Support
using System.Net.Http;
using System.Collections.Generic;
using Newtonsoft.Json;         	

namespace XiODevices
{
    public class ControlSystem : CrestronControlSystem
    {
        public ControlSystem()
            : base()
        {
            try
            {
                Thread.MaxNumberOfUserThreads = 20;
            }
            catch (Exception e)
            {
                ErrorLog.Error("Error in the constructor: {0}", e.Message);
            }
        }

        public override void InitializeSystem()
        {
            try
            {
                // TODO Last:[Student] Add Call to GetXiODevices
            }
            catch (Exception e)
            {
                ErrorLog.Error("Error in InitializeSystem: {0}", e.Message);
            }
        }

        public async void GetXiODevices()
        {
            // TODO #1:[Student] Make Acccount and Group ID string variable - Copy Values from Postman XiO Workspace Variables 
            
            // TODO #2:[Student] Make URL string variable - Copy URL from Device Request (Remove the extra {} from the Account and Group IDs)
            
            // TODO #3:[Student] Make the Http Request Message package with Method and URL - reference Postman Code
            
            // TODO #6:[Student] Add Header to Http Request Message containing the Subscription Key - Copy Values from Postman XiO Auth
            
            // TODO #5:[Student] Make the Client
            
            // TODO #6:[Student] Make Http Response Message and await the SendAsync of Http Request Message 
            
            // TODO #7:[Instructor Discuss] Grab the response as string
            
            // TODO #8:[Instructor Discuss] Deserialize in to a list of Device
            
            // TODO #9:[Student >> Instructor]  Proof of life, loop through the devices list and log DeviceName
            
        }

    }
}