using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlantSimulatorServer;
using System.Runtime.Serialization;

namespace PlantSimulatorServer
{
    //[DataContract(Namespace = Namespaces.PlantSimulatorServer)]
    class PlantSimulatorServerConfiguration
    {
        public PlantSimulatorServerConfiguration()
        {
            Initialize();
        }

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
        {
        }
    }
}
