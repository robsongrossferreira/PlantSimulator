using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Opc.Ua;
using Opc.Ua.Configuration;
using Opc.Ua.Server;

using System.Xml;
using System.Runtime.Serialization;

namespace PlantSimulator.Communication.OPC.App_Start_OPC
{
    class OPCApiConfig
    {
        public class PlantSimulatorServerConfiguration
        {
            public PlantSimulatorServerConfiguration()//34
            {//35
                Initialize();//36
            }//39

            /// <summary>
            /// Initializes the object during deserialization.
            /// </summary>
            [OnDeserializing()]
            private void Initialize(StreamingContext context)
            {
                Initialize();
            }

            /// <summary>
            /// Sets private members to default values.
            /// </summary>
            private void Initialize()
            {//37
            }//38
        }
    }
}