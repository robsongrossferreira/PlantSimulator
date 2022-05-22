/* ========================================================================
 * Copyright (c) 2005-2019 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace PlantSimulatorServer
{
    #region Method Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <summary>
        /// The identifier for the PlantSimulatorServer1Type_StartProcess Method.
        /// </summary>
        public const uint PlantSimulatorServer1Type_StartProcess = 15141;

        /// <summary>
        /// The identifier for the PlantSimulatorServer1Type_StopProcess Method.
        /// </summary>
        public const uint PlantSimulatorServer1Type_StopProcess = 15142;

        /// <summary>
        /// The identifier for the PlantSimulatorServer1_StartProcess Method.
        /// </summary>
        public const uint PlantSimulatorServer1_StartProcess = 15175;

        /// <summary>
        /// The identifier for the PlantSimulatorServer1_StopProcess Method.
        /// </summary>
        public const uint PlantSimulatorServer1_StopProcess = 15176;
    }
    #endregion

    #region Object Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <summary>
        /// The identifier for the PlantSimulatorServerType_PlantLevelIndicator Object.
        /// </summary>
        public const uint PlantSimulatorServerType_PlantLevelIndicator = 15079;

        /// <summary>
        /// The identifier for the PlantSimulatorServerType_PlantDischargeValve Object.
        /// </summary>
        public const uint PlantSimulatorServerType_PlantDischargeValve = 15087;

        /// <summary>
        /// The identifier for the PackagingUnitType_PackagingUnitLevelIndicator Object.
        /// </summary>
        public const uint PackagingUnitType_PackagingUnitLevelIndicator = 15101;

        /// <summary>
        /// The identifier for the PlantSimulatorServer1Type_PlantSimulatorServer Object.
        /// </summary>
        public const uint PlantSimulatorServer1Type_PlantSimulatorServer = 15110;

        /// <summary>
        /// The identifier for the PlantSimulatorServer1Type_PlantSimulatorServer_PlantLevelIndicator Object.
        /// </summary>
        public const uint PlantSimulatorServer1Type_PlantSimulatorServer_PlantLevelIndicator = 15111;

        /// <summary>
        /// The identifier for the PlantSimulatorServer1Type_PlantSimulatorServer_PlantDischargeValve Object.
        /// </summary>
        public const uint PlantSimulatorServer1Type_PlantSimulatorServer_PlantDischargeValve = 15119;

        /// <summary>
        /// The identifier for the PlantSimulatorServer1Type_PackagingUnit Object.
        /// </summary>
        public const uint PlantSimulatorServer1Type_PackagingUnit = 15132;

        /// <summary>
        /// The identifier for the PlantSimulatorServer1Type_PackagingUnit_PackagingUnitLevelIndicator Object.
        /// </summary>
        public const uint PlantSimulatorServer1Type_PackagingUnit_PackagingUnitLevelIndicator = 15133;

        /// <summary>
        /// The identifier for the PlantSimulatorServer1 Object.
        /// </summary>
        public const uint PlantSimulatorServer1 = 15143;

        /// <summary>
        /// The identifier for the PlantSimulatorServer1_PlantSimulatorServer Object.
        /// </summary>
        public const uint PlantSimulatorServer1_PlantSimulatorServer = 15144;

        /// <summary>
        /// The identifier for the PlantSimulatorServer1_PlantSimulatorServer_PlantLevelIndicator Object.
        /// </summary>
        public const uint PlantSimulatorServer1_PlantSimulatorServer_PlantLevelIndicator = 15145;

        /// <summary>
        /// The identifier for the PlantSimulatorServer1_PlantSimulatorServer_PlantDischargeValve Object.
        /// </summary>
        public const uint PlantSimulatorServer1_PlantSimulatorServer_PlantDischargeValve = 15153;

        /// <summary>
        /// The identifier for the PlantSimulatorServer1_PackagingUnit Object.
        /// </summary>
        public const uint PlantSimulatorServer1_PackagingUnit = 15166;

        /// <summary>
        /// The identifier for the PlantSimulatorServer1_PackagingUnit_PackagingUnitLevelIndicator Object.
        /// </summary>
        public const uint PlantSimulatorServer1_PackagingUnit_PackagingUnitLevelIndicator = 15167;
    }
    #endregion

    #region ObjectType Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <summary>
        /// The identifier for the GenericSensorType ObjectType.
        /// </summary>
        public const uint GenericSensorType = 15001;

        /// <summary>
        /// The identifier for the GenericActuatorType ObjectType.
        /// </summary>
        public const uint GenericActuatorType = 15009;

        /// <summary>
        /// The identifier for the GenericMotorType ObjectType.
        /// </summary>
        public const uint GenericMotorType = 15022;

        /// <summary>
        /// The identifier for the LevelIndicatorType ObjectType.
        /// </summary>
        public const uint LevelIndicatorType = 15029;

        /// <summary>
        /// The identifier for the LoadcellTransmitterType ObjectType.
        /// </summary>
        public const uint LoadcellTransmitterType = 15037;

        /// <summary>
        /// The identifier for the ValveType ObjectType.
        /// </summary>
        public const uint ValveType = 15051;

        /// <summary>
        /// The identifier for the MixerMotorType ObjectType.
        /// </summary>
        public const uint MixerMotorType = 15064;

        /// <summary>
        /// The identifier for the ConveyorMotorType ObjectType.
        /// </summary>
        public const uint ConveyorMotorType = 15071;

        /// <summary>
        /// The identifier for the PlantSimulatorServerType ObjectType.
        /// </summary>
        public const uint PlantSimulatorServerType = 15078;

        /// <summary>
        /// The identifier for the PackagingUnitType ObjectType.
        /// </summary>
        public const uint PackagingUnitType = 15100;

        /// <summary>
        /// The identifier for the PlantSimulatorServer1Type ObjectType.
        /// </summary>
        public const uint PlantSimulatorServer1Type = 15109;
    }
    #endregion

    #region Variable Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <summary>
        /// The identifier for the GenericSensorType_Output Variable.
        /// </summary>
        public const uint GenericSensorType_Output = 15002;

        /// <summary>
        /// The identifier for the GenericSensorType_Output_EURange Variable.
        /// </summary>
        public const uint GenericSensorType_Output_EURange = 15006;

        /// <summary>
        /// The identifier for the GenericSensorType_Units Variable.
        /// </summary>
        public const uint GenericSensorType_Units = 15008;

        /// <summary>
        /// The identifier for the GenericActuatorType_Input Variable.
        /// </summary>
        public const uint GenericActuatorType_Input = 15010;

        /// <summary>
        /// The identifier for the GenericActuatorType_Input_EURange Variable.
        /// </summary>
        public const uint GenericActuatorType_Input_EURange = 15014;

        /// <summary>
        /// The identifier for the GenericActuatorType_Output Variable.
        /// </summary>
        public const uint GenericActuatorType_Output = 15016;

        /// <summary>
        /// The identifier for the GenericActuatorType_Output_EURange Variable.
        /// </summary>
        public const uint GenericActuatorType_Output_EURange = 15020;

        /// <summary>
        /// The identifier for the GenericMotorType_Speed Variable.
        /// </summary>
        public const uint GenericMotorType_Speed = 15023;

        /// <summary>
        /// The identifier for the GenericMotorType_Speed_EURange Variable.
        /// </summary>
        public const uint GenericMotorType_Speed_EURange = 15027;

        /// <summary>
        /// The identifier for the LevelIndicatorType_Output_EURange Variable.
        /// </summary>
        public const uint LevelIndicatorType_Output_EURange = 15034;

        /// <summary>
        /// The identifier for the LoadcellTransmitterType_Output_EURange Variable.
        /// </summary>
        public const uint LoadcellTransmitterType_Output_EURange = 15042;

        /// <summary>
        /// The identifier for the LoadcellTransmitterType_ExcitationVoltage Variable.
        /// </summary>
        public const uint LoadcellTransmitterType_ExcitationVoltage = 15045;

        /// <summary>
        /// The identifier for the LoadcellTransmitterType_ExcitationVoltage_EURange Variable.
        /// </summary>
        public const uint LoadcellTransmitterType_ExcitationVoltage_EURange = 15049;

        /// <summary>
        /// The identifier for the ValveType_Input_EURange Variable.
        /// </summary>
        public const uint ValveType_Input_EURange = 15056;

        /// <summary>
        /// The identifier for the ValveType_Output_EURange Variable.
        /// </summary>
        public const uint ValveType_Output_EURange = 15062;

        /// <summary>
        /// The identifier for the MixerMotorType_Speed_EURange Variable.
        /// </summary>
        public const uint MixerMotorType_Speed_EURange = 15069;

        /// <summary>
        /// The identifier for the ConveyorMotorType_Speed_EURange Variable.
        /// </summary>
        public const uint ConveyorMotorType_Speed_EURange = 15076;

        /// <summary>
        /// The identifier for the PlantSimulatorServerType_PlantLevelIndicator_Output Variable.
        /// </summary>
        public const uint PlantSimulatorServerType_PlantLevelIndicator_Output = 15080;

        /// <summary>
        /// The identifier for the PlantSimulatorServerType_PlantLevelIndicator_Output_EURange Variable.
        /// </summary>
        public const uint PlantSimulatorServerType_PlantLevelIndicator_Output_EURange = 15084;

        /// <summary>
        /// The identifier for the PlantSimulatorServerType_PlantLevelIndicator_Units Variable.
        /// </summary>
        public const uint PlantSimulatorServerType_PlantLevelIndicator_Units = 15086;

        /// <summary>
        /// The identifier for the PlantSimulatorServerType_PlantDischargeValve_Input Variable.
        /// </summary>
        public const uint PlantSimulatorServerType_PlantDischargeValve_Input = 15088;

        /// <summary>
        /// The identifier for the PlantSimulatorServerType_PlantDischargeValve_Input_EURange Variable.
        /// </summary>
        public const uint PlantSimulatorServerType_PlantDischargeValve_Input_EURange = 15092;

        /// <summary>
        /// The identifier for the PlantSimulatorServerType_PlantDischargeValve_Output Variable.
        /// </summary>
        public const uint PlantSimulatorServerType_PlantDischargeValve_Output = 15094;

        /// <summary>
        /// The identifier for the PlantSimulatorServerType_PlantDischargeValve_Output_EURange Variable.
        /// </summary>
        public const uint PlantSimulatorServerType_PlantDischargeValve_Output_EURange = 15098;

        /// <summary>
        /// The identifier for the PackagingUnitType_PackagingUnitLevelIndicator_Output Variable.
        /// </summary>
        public const uint PackagingUnitType_PackagingUnitLevelIndicator_Output = 15102;

        /// <summary>
        /// The identifier for the PackagingUnitType_PackagingUnitLevelIndicator_Output_EURange Variable.
        /// </summary>
        public const uint PackagingUnitType_PackagingUnitLevelIndicator_Output_EURange = 15106;

        /// <summary>
        /// The identifier for the PackagingUnitType_PackagingUnitLevelIndicator_Units Variable.
        /// </summary>
        public const uint PackagingUnitType_PackagingUnitLevelIndicator_Units = 15108;

        /// <summary>
        /// The identifier for the PlantSimulatorServer1Type_PlantSimulatorServer_PlantLevelIndicator_Output Variable.
        /// </summary>
        public const uint PlantSimulatorServer1Type_PlantSimulatorServer_PlantLevelIndicator_Output = 15112;

        /// <summary>
        /// The identifier for the PlantSimulatorServer1Type_PlantSimulatorServer_PlantLevelIndicator_Output_EURange Variable.
        /// </summary>
        public const uint PlantSimulatorServer1Type_PlantSimulatorServer_PlantLevelIndicator_Output_EURange = 15116;

        /// <summary>
        /// The identifier for the PlantSimulatorServer1Type_PlantSimulatorServer_PlantLevelIndicator_Units Variable.
        /// </summary>
        public const uint PlantSimulatorServer1Type_PlantSimulatorServer_PlantLevelIndicator_Units = 15118;

        /// <summary>
        /// The identifier for the PlantSimulatorServer1Type_PlantSimulatorServer_PlantDischargeValve_Input Variable.
        /// </summary>
        public const uint PlantSimulatorServer1Type_PlantSimulatorServer_PlantDischargeValve_Input = 15120;

        /// <summary>
        /// The identifier for the PlantSimulatorServer1Type_PlantSimulatorServer_PlantDischargeValve_Input_EURange Variable.
        /// </summary>
        public const uint PlantSimulatorServer1Type_PlantSimulatorServer_PlantDischargeValve_Input_EURange = 15124;

        /// <summary>
        /// The identifier for the PlantSimulatorServer1Type_PlantSimulatorServer_PlantDischargeValve_Output Variable.
        /// </summary>
        public const uint PlantSimulatorServer1Type_PlantSimulatorServer_PlantDischargeValve_Output = 15126;

        /// <summary>
        /// The identifier for the PlantSimulatorServer1Type_PlantSimulatorServer_PlantDischargeValve_Output_EURange Variable.
        /// </summary>
        public const uint PlantSimulatorServer1Type_PlantSimulatorServer_PlantDischargeValve_Output_EURange = 15130;

        /// <summary>
        /// The identifier for the PlantSimulatorServer1Type_PackagingUnit_PackagingUnitLevelIndicator_Output Variable.
        /// </summary>
        public const uint PlantSimulatorServer1Type_PackagingUnit_PackagingUnitLevelIndicator_Output = 15134;

        /// <summary>
        /// The identifier for the PlantSimulatorServer1Type_PackagingUnit_PackagingUnitLevelIndicator_Output_EURange Variable.
        /// </summary>
        public const uint PlantSimulatorServer1Type_PackagingUnit_PackagingUnitLevelIndicator_Output_EURange = 15138;

        /// <summary>
        /// The identifier for the PlantSimulatorServer1Type_PackagingUnit_PackagingUnitLevelIndicator_Units Variable.
        /// </summary>
        public const uint PlantSimulatorServer1Type_PackagingUnit_PackagingUnitLevelIndicator_Units = 15140;

        /// <summary>
        /// The identifier for the PlantSimulatorServer1_PlantSimulatorServer_PlantLevelIndicator_Output Variable.
        /// </summary>
        public const uint PlantSimulatorServer1_PlantSimulatorServer_PlantLevelIndicator_Output = 15146;

        /// <summary>
        /// The identifier for the PlantSimulatorServer1_PlantSimulatorServer_PlantLevelIndicator_Output_EURange Variable.
        /// </summary>
        public const uint PlantSimulatorServer1_PlantSimulatorServer_PlantLevelIndicator_Output_EURange = 15150;

        /// <summary>
        /// The identifier for the PlantSimulatorServer1_PlantSimulatorServer_PlantLevelIndicator_Units Variable.
        /// </summary>
        public const uint PlantSimulatorServer1_PlantSimulatorServer_PlantLevelIndicator_Units = 15152;

        /// <summary>
        /// The identifier for the PlantSimulatorServer1_PlantSimulatorServer_PlantDischargeValve_Input Variable.
        /// </summary>
        public const uint PlantSimulatorServer1_PlantSimulatorServer_PlantDischargeValve_Input = 15154;

        /// <summary>
        /// The identifier for the PlantSimulatorServer1_PlantSimulatorServer_PlantDischargeValve_Input_EURange Variable.
        /// </summary>
        public const uint PlantSimulatorServer1_PlantSimulatorServer_PlantDischargeValve_Input_EURange = 15158;

        /// <summary>
        /// The identifier for the PlantSimulatorServer1_PlantSimulatorServer_PlantDischargeValve_Output Variable.
        /// </summary>
        public const uint PlantSimulatorServer1_PlantSimulatorServer_PlantDischargeValve_Output = 15160;

        /// <summary>
        /// The identifier for the PlantSimulatorServer1_PlantSimulatorServer_PlantDischargeValve_Output_EURange Variable.
        /// </summary>
        public const uint PlantSimulatorServer1_PlantSimulatorServer_PlantDischargeValve_Output_EURange = 15164;

        /// <summary>
        /// The identifier for the PlantSimulatorServer1_PackagingUnit_PackagingUnitLevelIndicator_Output Variable.
        /// </summary>
        public const uint PlantSimulatorServer1_PackagingUnit_PackagingUnitLevelIndicator_Output = 15168;

        /// <summary>
        /// The identifier for the PlantSimulatorServer1_PackagingUnit_PackagingUnitLevelIndicator_Output_EURange Variable.
        /// </summary>
        public const uint PlantSimulatorServer1_PackagingUnit_PackagingUnitLevelIndicator_Output_EURange = 15172;

        /// <summary>
        /// The identifier for the PlantSimulatorServer1_PackagingUnit_PackagingUnitLevelIndicator_Units Variable.
        /// </summary>
        public const uint PlantSimulatorServer1_PackagingUnit_PackagingUnitLevelIndicator_Units = 15174;
    }
    #endregion

    #region Method Node Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <summary>
        /// The identifier for the PlantSimulatorServer1Type_StartProcess Method.
        /// </summary>
        public static readonly ExpandedNodeId PlantSimulatorServer1Type_StartProcess = new ExpandedNodeId(PlantSimulatorServer.Methods.PlantSimulatorServer1Type_StartProcess, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the PlantSimulatorServer1Type_StopProcess Method.
        /// </summary>
        public static readonly ExpandedNodeId PlantSimulatorServer1Type_StopProcess = new ExpandedNodeId(PlantSimulatorServer.Methods.PlantSimulatorServer1Type_StopProcess, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the PlantSimulatorServer1_StartProcess Method.
        /// </summary>
        public static readonly ExpandedNodeId PlantSimulatorServer1_StartProcess = new ExpandedNodeId(PlantSimulatorServer.Methods.PlantSimulatorServer1_StartProcess, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the PlantSimulatorServer1_StopProcess Method.
        /// </summary>
        public static readonly ExpandedNodeId PlantSimulatorServer1_StopProcess = new ExpandedNodeId(PlantSimulatorServer.Methods.PlantSimulatorServer1_StopProcess, PlantSimulatorServer.Namespaces.PlantSimulatorServer);
    }
    #endregion

    #region Object Node Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <summary>
        /// The identifier for the PlantSimulatorServerType_PlantLevelIndicator Object.
        /// </summary>
        public static readonly ExpandedNodeId PlantSimulatorServerType_PlantLevelIndicator = new ExpandedNodeId(PlantSimulatorServer.Objects.PlantSimulatorServerType_PlantLevelIndicator, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the PlantSimulatorServerType_PlantDischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId PlantSimulatorServerType_PlantDischargeValve = new ExpandedNodeId(PlantSimulatorServer.Objects.PlantSimulatorServerType_PlantDischargeValve, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the PackagingUnitType_PackagingUnitLevelIndicator Object.
        /// </summary>
        public static readonly ExpandedNodeId PackagingUnitType_PackagingUnitLevelIndicator = new ExpandedNodeId(PlantSimulatorServer.Objects.PackagingUnitType_PackagingUnitLevelIndicator, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the PlantSimulatorServer1Type_PlantSimulatorServer Object.
        /// </summary>
        public static readonly ExpandedNodeId PlantSimulatorServer1Type_PlantSimulatorServer = new ExpandedNodeId(PlantSimulatorServer.Objects.PlantSimulatorServer1Type_PlantSimulatorServer, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the PlantSimulatorServer1Type_PlantSimulatorServer_PlantLevelIndicator Object.
        /// </summary>
        public static readonly ExpandedNodeId PlantSimulatorServer1Type_PlantSimulatorServer_PlantLevelIndicator = new ExpandedNodeId(PlantSimulatorServer.Objects.PlantSimulatorServer1Type_PlantSimulatorServer_PlantLevelIndicator, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the PlantSimulatorServer1Type_PlantSimulatorServer_PlantDischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId PlantSimulatorServer1Type_PlantSimulatorServer_PlantDischargeValve = new ExpandedNodeId(PlantSimulatorServer.Objects.PlantSimulatorServer1Type_PlantSimulatorServer_PlantDischargeValve, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the PlantSimulatorServer1Type_PackagingUnit Object.
        /// </summary>
        public static readonly ExpandedNodeId PlantSimulatorServer1Type_PackagingUnit = new ExpandedNodeId(PlantSimulatorServer.Objects.PlantSimulatorServer1Type_PackagingUnit, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the PlantSimulatorServer1Type_PackagingUnit_PackagingUnitLevelIndicator Object.
        /// </summary>
        public static readonly ExpandedNodeId PlantSimulatorServer1Type_PackagingUnit_PackagingUnitLevelIndicator = new ExpandedNodeId(PlantSimulatorServer.Objects.PlantSimulatorServer1Type_PackagingUnit_PackagingUnitLevelIndicator, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the PlantSimulatorServer1 Object.
        /// </summary>
        public static readonly ExpandedNodeId PlantSimulatorServer1 = new ExpandedNodeId(PlantSimulatorServer.Objects.PlantSimulatorServer1, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the PlantSimulatorServer1_PlantSimulatorServer Object.
        /// </summary>
        public static readonly ExpandedNodeId PlantSimulatorServer1_PlantSimulatorServer = new ExpandedNodeId(PlantSimulatorServer.Objects.PlantSimulatorServer1_PlantSimulatorServer, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the PlantSimulatorServer1_PlantSimulatorServer_PlantLevelIndicator Object.
        /// </summary>
        public static readonly ExpandedNodeId PlantSimulatorServer1_PlantSimulatorServer_PlantLevelIndicator = new ExpandedNodeId(PlantSimulatorServer.Objects.PlantSimulatorServer1_PlantSimulatorServer_PlantLevelIndicator, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the PlantSimulatorServer1_PlantSimulatorServer_PlantDischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId PlantSimulatorServer1_PlantSimulatorServer_PlantDischargeValve = new ExpandedNodeId(PlantSimulatorServer.Objects.PlantSimulatorServer1_PlantSimulatorServer_PlantDischargeValve, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the PlantSimulatorServer1_PackagingUnit Object.
        /// </summary>
        public static readonly ExpandedNodeId PlantSimulatorServer1_PackagingUnit = new ExpandedNodeId(PlantSimulatorServer.Objects.PlantSimulatorServer1_PackagingUnit, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the PlantSimulatorServer1_PackagingUnit_PackagingUnitLevelIndicator Object.
        /// </summary>
        public static readonly ExpandedNodeId PlantSimulatorServer1_PackagingUnit_PackagingUnitLevelIndicator = new ExpandedNodeId(PlantSimulatorServer.Objects.PlantSimulatorServer1_PackagingUnit_PackagingUnitLevelIndicator, PlantSimulatorServer.Namespaces.PlantSimulatorServer);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <summary>
        /// The identifier for the GenericSensorType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId GenericSensorType = new ExpandedNodeId(PlantSimulatorServer.ObjectTypes.GenericSensorType, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the GenericActuatorType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId GenericActuatorType = new ExpandedNodeId(PlantSimulatorServer.ObjectTypes.GenericActuatorType, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the GenericMotorType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId GenericMotorType = new ExpandedNodeId(PlantSimulatorServer.ObjectTypes.GenericMotorType, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the LevelIndicatorType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId LevelIndicatorType = new ExpandedNodeId(PlantSimulatorServer.ObjectTypes.LevelIndicatorType, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the LoadcellTransmitterType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId LoadcellTransmitterType = new ExpandedNodeId(PlantSimulatorServer.ObjectTypes.LoadcellTransmitterType, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the ValveType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ValveType = new ExpandedNodeId(PlantSimulatorServer.ObjectTypes.ValveType, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the MixerMotorType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId MixerMotorType = new ExpandedNodeId(PlantSimulatorServer.ObjectTypes.MixerMotorType, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the ConveyorMotorType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ConveyorMotorType = new ExpandedNodeId(PlantSimulatorServer.ObjectTypes.ConveyorMotorType, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the PlantSimulatorServerType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId PlantSimulatorServerType = new ExpandedNodeId(PlantSimulatorServer.ObjectTypes.PlantSimulatorServerType, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the PackagingUnitType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId PackagingUnitType = new ExpandedNodeId(PlantSimulatorServer.ObjectTypes.PackagingUnitType, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the PlantSimulatorServer1Type ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId PlantSimulatorServer1Type = new ExpandedNodeId(PlantSimulatorServer.ObjectTypes.PlantSimulatorServer1Type, PlantSimulatorServer.Namespaces.PlantSimulatorServer);
    }
    #endregion

    #region Variable Node Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <summary>
        /// The identifier for the GenericSensorType_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericSensorType_Output = new ExpandedNodeId(PlantSimulatorServer.Variables.GenericSensorType_Output, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the GenericSensorType_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericSensorType_Output_EURange = new ExpandedNodeId(PlantSimulatorServer.Variables.GenericSensorType_Output_EURange, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the GenericSensorType_Units Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericSensorType_Units = new ExpandedNodeId(PlantSimulatorServer.Variables.GenericSensorType_Units, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the GenericActuatorType_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericActuatorType_Input = new ExpandedNodeId(PlantSimulatorServer.Variables.GenericActuatorType_Input, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the GenericActuatorType_Input_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericActuatorType_Input_EURange = new ExpandedNodeId(PlantSimulatorServer.Variables.GenericActuatorType_Input_EURange, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the GenericActuatorType_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericActuatorType_Output = new ExpandedNodeId(PlantSimulatorServer.Variables.GenericActuatorType_Output, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the GenericActuatorType_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericActuatorType_Output_EURange = new ExpandedNodeId(PlantSimulatorServer.Variables.GenericActuatorType_Output_EURange, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the GenericMotorType_Speed Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericMotorType_Speed = new ExpandedNodeId(PlantSimulatorServer.Variables.GenericMotorType_Speed, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the GenericMotorType_Speed_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericMotorType_Speed_EURange = new ExpandedNodeId(PlantSimulatorServer.Variables.GenericMotorType_Speed_EURange, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the LevelIndicatorType_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId LevelIndicatorType_Output_EURange = new ExpandedNodeId(PlantSimulatorServer.Variables.LevelIndicatorType_Output_EURange, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the LoadcellTransmitterType_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId LoadcellTransmitterType_Output_EURange = new ExpandedNodeId(PlantSimulatorServer.Variables.LoadcellTransmitterType_Output_EURange, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the LoadcellTransmitterType_ExcitationVoltage Variable.
        /// </summary>
        public static readonly ExpandedNodeId LoadcellTransmitterType_ExcitationVoltage = new ExpandedNodeId(PlantSimulatorServer.Variables.LoadcellTransmitterType_ExcitationVoltage, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the LoadcellTransmitterType_ExcitationVoltage_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId LoadcellTransmitterType_ExcitationVoltage_EURange = new ExpandedNodeId(PlantSimulatorServer.Variables.LoadcellTransmitterType_ExcitationVoltage_EURange, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the ValveType_Input_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId ValveType_Input_EURange = new ExpandedNodeId(PlantSimulatorServer.Variables.ValveType_Input_EURange, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the ValveType_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId ValveType_Output_EURange = new ExpandedNodeId(PlantSimulatorServer.Variables.ValveType_Output_EURange, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the MixerMotorType_Speed_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId MixerMotorType_Speed_EURange = new ExpandedNodeId(PlantSimulatorServer.Variables.MixerMotorType_Speed_EURange, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the ConveyorMotorType_Speed_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConveyorMotorType_Speed_EURange = new ExpandedNodeId(PlantSimulatorServer.Variables.ConveyorMotorType_Speed_EURange, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the PlantSimulatorServerType_PlantLevelIndicator_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId PlantSimulatorServerType_PlantLevelIndicator_Output = new ExpandedNodeId(PlantSimulatorServer.Variables.PlantSimulatorServerType_PlantLevelIndicator_Output, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the PlantSimulatorServerType_PlantLevelIndicator_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId PlantSimulatorServerType_PlantLevelIndicator_Output_EURange = new ExpandedNodeId(PlantSimulatorServer.Variables.PlantSimulatorServerType_PlantLevelIndicator_Output_EURange, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the PlantSimulatorServerType_PlantLevelIndicator_Units Variable.
        /// </summary>
        public static readonly ExpandedNodeId PlantSimulatorServerType_PlantLevelIndicator_Units = new ExpandedNodeId(PlantSimulatorServer.Variables.PlantSimulatorServerType_PlantLevelIndicator_Units, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the PlantSimulatorServerType_PlantDischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId PlantSimulatorServerType_PlantDischargeValve_Input = new ExpandedNodeId(PlantSimulatorServer.Variables.PlantSimulatorServerType_PlantDischargeValve_Input, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the PlantSimulatorServerType_PlantDischargeValve_Input_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId PlantSimulatorServerType_PlantDischargeValve_Input_EURange = new ExpandedNodeId(PlantSimulatorServer.Variables.PlantSimulatorServerType_PlantDischargeValve_Input_EURange, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the PlantSimulatorServerType_PlantDischargeValve_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId PlantSimulatorServerType_PlantDischargeValve_Output = new ExpandedNodeId(PlantSimulatorServer.Variables.PlantSimulatorServerType_PlantDischargeValve_Output, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the PlantSimulatorServerType_PlantDischargeValve_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId PlantSimulatorServerType_PlantDischargeValve_Output_EURange = new ExpandedNodeId(PlantSimulatorServer.Variables.PlantSimulatorServerType_PlantDischargeValve_Output_EURange, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the PackagingUnitType_PackagingUnitLevelIndicator_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId PackagingUnitType_PackagingUnitLevelIndicator_Output = new ExpandedNodeId(PlantSimulatorServer.Variables.PackagingUnitType_PackagingUnitLevelIndicator_Output, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the PackagingUnitType_PackagingUnitLevelIndicator_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId PackagingUnitType_PackagingUnitLevelIndicator_Output_EURange = new ExpandedNodeId(PlantSimulatorServer.Variables.PackagingUnitType_PackagingUnitLevelIndicator_Output_EURange, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the PackagingUnitType_PackagingUnitLevelIndicator_Units Variable.
        /// </summary>
        public static readonly ExpandedNodeId PackagingUnitType_PackagingUnitLevelIndicator_Units = new ExpandedNodeId(PlantSimulatorServer.Variables.PackagingUnitType_PackagingUnitLevelIndicator_Units, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the PlantSimulatorServer1Type_PlantSimulatorServer_PlantLevelIndicator_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId PlantSimulatorServer1Type_PlantSimulatorServer_PlantLevelIndicator_Output = new ExpandedNodeId(PlantSimulatorServer.Variables.PlantSimulatorServer1Type_PlantSimulatorServer_PlantLevelIndicator_Output, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the PlantSimulatorServer1Type_PlantSimulatorServer_PlantLevelIndicator_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId PlantSimulatorServer1Type_PlantSimulatorServer_PlantLevelIndicator_Output_EURange = new ExpandedNodeId(PlantSimulatorServer.Variables.PlantSimulatorServer1Type_PlantSimulatorServer_PlantLevelIndicator_Output_EURange, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the PlantSimulatorServer1Type_PlantSimulatorServer_PlantLevelIndicator_Units Variable.
        /// </summary>
        public static readonly ExpandedNodeId PlantSimulatorServer1Type_PlantSimulatorServer_PlantLevelIndicator_Units = new ExpandedNodeId(PlantSimulatorServer.Variables.PlantSimulatorServer1Type_PlantSimulatorServer_PlantLevelIndicator_Units, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the PlantSimulatorServer1Type_PlantSimulatorServer_PlantDischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId PlantSimulatorServer1Type_PlantSimulatorServer_PlantDischargeValve_Input = new ExpandedNodeId(PlantSimulatorServer.Variables.PlantSimulatorServer1Type_PlantSimulatorServer_PlantDischargeValve_Input, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the PlantSimulatorServer1Type_PlantSimulatorServer_PlantDischargeValve_Input_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId PlantSimulatorServer1Type_PlantSimulatorServer_PlantDischargeValve_Input_EURange = new ExpandedNodeId(PlantSimulatorServer.Variables.PlantSimulatorServer1Type_PlantSimulatorServer_PlantDischargeValve_Input_EURange, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the PlantSimulatorServer1Type_PlantSimulatorServer_PlantDischargeValve_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId PlantSimulatorServer1Type_PlantSimulatorServer_PlantDischargeValve_Output = new ExpandedNodeId(PlantSimulatorServer.Variables.PlantSimulatorServer1Type_PlantSimulatorServer_PlantDischargeValve_Output, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the PlantSimulatorServer1Type_PlantSimulatorServer_PlantDischargeValve_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId PlantSimulatorServer1Type_PlantSimulatorServer_PlantDischargeValve_Output_EURange = new ExpandedNodeId(PlantSimulatorServer.Variables.PlantSimulatorServer1Type_PlantSimulatorServer_PlantDischargeValve_Output_EURange, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the PlantSimulatorServer1Type_PackagingUnit_PackagingUnitLevelIndicator_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId PlantSimulatorServer1Type_PackagingUnit_PackagingUnitLevelIndicator_Output = new ExpandedNodeId(PlantSimulatorServer.Variables.PlantSimulatorServer1Type_PackagingUnit_PackagingUnitLevelIndicator_Output, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the PlantSimulatorServer1Type_PackagingUnit_PackagingUnitLevelIndicator_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId PlantSimulatorServer1Type_PackagingUnit_PackagingUnitLevelIndicator_Output_EURange = new ExpandedNodeId(PlantSimulatorServer.Variables.PlantSimulatorServer1Type_PackagingUnit_PackagingUnitLevelIndicator_Output_EURange, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the PlantSimulatorServer1Type_PackagingUnit_PackagingUnitLevelIndicator_Units Variable.
        /// </summary>
        public static readonly ExpandedNodeId PlantSimulatorServer1Type_PackagingUnit_PackagingUnitLevelIndicator_Units = new ExpandedNodeId(PlantSimulatorServer.Variables.PlantSimulatorServer1Type_PackagingUnit_PackagingUnitLevelIndicator_Units, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the PlantSimulatorServer1_PlantSimulatorServer_PlantLevelIndicator_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId PlantSimulatorServer1_PlantSimulatorServer_PlantLevelIndicator_Output = new ExpandedNodeId(PlantSimulatorServer.Variables.PlantSimulatorServer1_PlantSimulatorServer_PlantLevelIndicator_Output, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the PlantSimulatorServer1_PlantSimulatorServer_PlantLevelIndicator_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId PlantSimulatorServer1_PlantSimulatorServer_PlantLevelIndicator_Output_EURange = new ExpandedNodeId(PlantSimulatorServer.Variables.PlantSimulatorServer1_PlantSimulatorServer_PlantLevelIndicator_Output_EURange, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the PlantSimulatorServer1_PlantSimulatorServer_PlantLevelIndicator_Units Variable.
        /// </summary>
        public static readonly ExpandedNodeId PlantSimulatorServer1_PlantSimulatorServer_PlantLevelIndicator_Units = new ExpandedNodeId(PlantSimulatorServer.Variables.PlantSimulatorServer1_PlantSimulatorServer_PlantLevelIndicator_Units, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the PlantSimulatorServer1_PlantSimulatorServer_PlantDischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId PlantSimulatorServer1_PlantSimulatorServer_PlantDischargeValve_Input = new ExpandedNodeId(PlantSimulatorServer.Variables.PlantSimulatorServer1_PlantSimulatorServer_PlantDischargeValve_Input, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the PlantSimulatorServer1_PlantSimulatorServer_PlantDischargeValve_Input_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId PlantSimulatorServer1_PlantSimulatorServer_PlantDischargeValve_Input_EURange = new ExpandedNodeId(PlantSimulatorServer.Variables.PlantSimulatorServer1_PlantSimulatorServer_PlantDischargeValve_Input_EURange, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the PlantSimulatorServer1_PlantSimulatorServer_PlantDischargeValve_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId PlantSimulatorServer1_PlantSimulatorServer_PlantDischargeValve_Output = new ExpandedNodeId(PlantSimulatorServer.Variables.PlantSimulatorServer1_PlantSimulatorServer_PlantDischargeValve_Output, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the PlantSimulatorServer1_PlantSimulatorServer_PlantDischargeValve_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId PlantSimulatorServer1_PlantSimulatorServer_PlantDischargeValve_Output_EURange = new ExpandedNodeId(PlantSimulatorServer.Variables.PlantSimulatorServer1_PlantSimulatorServer_PlantDischargeValve_Output_EURange, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the PlantSimulatorServer1_PackagingUnit_PackagingUnitLevelIndicator_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId PlantSimulatorServer1_PackagingUnit_PackagingUnitLevelIndicator_Output = new ExpandedNodeId(PlantSimulatorServer.Variables.PlantSimulatorServer1_PackagingUnit_PackagingUnitLevelIndicator_Output, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the PlantSimulatorServer1_PackagingUnit_PackagingUnitLevelIndicator_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId PlantSimulatorServer1_PackagingUnit_PackagingUnitLevelIndicator_Output_EURange = new ExpandedNodeId(PlantSimulatorServer.Variables.PlantSimulatorServer1_PackagingUnit_PackagingUnitLevelIndicator_Output_EURange, PlantSimulatorServer.Namespaces.PlantSimulatorServer);

        /// <summary>
        /// The identifier for the PlantSimulatorServer1_PackagingUnit_PackagingUnitLevelIndicator_Units Variable.
        /// </summary>
        public static readonly ExpandedNodeId PlantSimulatorServer1_PackagingUnit_PackagingUnitLevelIndicator_Units = new ExpandedNodeId(PlantSimulatorServer.Variables.PlantSimulatorServer1_PackagingUnit_PackagingUnitLevelIndicator_Units, PlantSimulatorServer.Namespaces.PlantSimulatorServer);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the ConveyorMotorType component.
        /// </summary>
        public const string ConveyorMotorType = "ConveyorMotorType";

        /// <summary>
        /// The BrowseName for the ExcitationVoltage component.
        /// </summary>
        public const string ExcitationVoltage = "ExcitationVoltage";

        /// <summary>
        /// The BrowseName for the GenericActuatorType component.
        /// </summary>
        public const string GenericActuatorType = "GenericActuatorType";

        /// <summary>
        /// The BrowseName for the GenericMotorType component.
        /// </summary>
        public const string GenericMotorType = "GenericMotorType";

        /// <summary>
        /// The BrowseName for the GenericSensorType component.
        /// </summary>
        public const string GenericSensorType = "GenericSensorType";

        /// <summary>
        /// The BrowseName for the Input component.
        /// </summary>
        public const string Input = "Input";

        /// <summary>
        /// The BrowseName for the LevelIndicatorType component.
        /// </summary>
        public const string LevelIndicatorType = "LevelIndicatorType";

        /// <summary>
        /// The BrowseName for the LoadcellTransmitterType component.
        /// </summary>
        public const string LoadcellTransmitterType = "LoadcellTransmitterType";

        /// <summary>
        /// The BrowseName for the MixerMotorType component.
        /// </summary>
        public const string MixerMotorType = "MixerMotorType";

        /// <summary>
        /// The BrowseName for the Output component.
        /// </summary>
        public const string Output = "Output";

        /// <summary>
        /// The BrowseName for the PackagingUnit component.
        /// </summary>
        public const string PackagingUnit = "PackagingUnitX001";

        /// <summary>
        /// The BrowseName for the PackagingUnitLevelIndicator component.
        /// </summary>
        public const string PackagingUnitLevelIndicator = "LI004";

        /// <summary>
        /// The BrowseName for the PackagingUnitType component.
        /// </summary>
        public const string PackagingUnitType = "PackagingUnitType";

        /// <summary>
        /// The BrowseName for the PlantDischargeValve component.
        /// </summary>
        public const string PlantDischargeValve = "INPUT";

        /// <summary>
        /// The BrowseName for the PlantLevelIndicator component.
        /// </summary>
        public const string PlantLevelIndicator = "OUTPUT";

        /// <summary>
        /// The BrowseName for the PlantSimulatorServer component.
        /// </summary>
        public const string PlantSimulatorServer = "PlantSimulatorServer";

        /// <summary>
        /// The BrowseName for the PlantSimulatorServer1 component.
        /// </summary>
        public const string PlantSimulatorServer1 = "Plant Simulator Server #1";

        /// <summary>
        /// The BrowseName for the PlantSimulatorServer1Type component.
        /// </summary>
        public const string PlantSimulatorServer1Type = "PlantSimulatorServer1Type";

        /// <summary>
        /// The BrowseName for the PlantSimulatorServerType component.
        /// </summary>
        public const string PlantSimulatorServerType = "PlantSimulatorServerType";

        /// <summary>
        /// The BrowseName for the Speed component.
        /// </summary>
        public const string Speed = "Speed";

        /// <summary>
        /// The BrowseName for the StartProcess component.
        /// </summary>
        public const string StartProcess = "StartProcess";

        /// <summary>
        /// The BrowseName for the StopProcess component.
        /// </summary>
        public const string StopProcess = "StopProcess";

        /// <summary>
        /// The BrowseName for the Units component.
        /// </summary>
        public const string Units = "Units";

        /// <summary>
        /// The BrowseName for the ValveType component.
        /// </summary>
        public const string ValveType = "ValveType";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";

        /// <summary>
        /// The URI for the PlantSimulatorServer namespace (.NET code namespace is 'PlantSimulatorServer').
        /// </summary>
        public const string PlantSimulatorServer = "http://opcfoundation.org/PlantSimulatorServer";
    }
    #endregion

    #region GenericSensorState Class
    #if (!OPCUA_EXCLUDE_GenericSensorState)
    /// <summary>
    /// Stores an instance of the GenericSensorType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GenericSensorState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public GenericSensorState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(PlantSimulatorServer.ObjectTypes.GenericSensorType, PlantSimulatorServer.Namespaces.PlantSimulatorServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAC0AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvUGxhbnRTaW11bGF0b3JTZXJ2ZXL/////BGCA" +
           "AgEAAAABABkAAABHZW5lcmljU2Vuc29yVHlwZUluc3RhbmNlAQGZOgEBmTqZOgAA/////wIAAAAVYIkK" +
           "AgAAAAEABgAAAE91dHB1dAEBmjoALwEAQAmaOgAAAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAA" +
           "RVVSYW5nZQEBnjoALgBEnjoAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAFAAAAVW5pdHMBAaA6" +
           "AC4ARKA6AAAADP////8DA/////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogItemState<double> Output
        {
            get
            {
                return m_output;
            }

            set
            {
                if (!Object.ReferenceEquals(m_output, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_output = value;
            }
        }

        /// <remarks />
        public PropertyState<string> Units
        {
            get
            {
                return m_units;
            }

            set
            {
                if (!Object.ReferenceEquals(m_units, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_units = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_output != null)
            {
                children.Add(m_output);
            }

            if (m_units != null)
            {
                children.Add(m_units);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case PlantSimulatorServer.BrowseNames.Output:
                {
                    if (createOrReplace)
                    {
                        if (Output == null)
                        {
                            if (replacement == null)
                            {
                                Output = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                Output = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = Output;
                    break;
                }

                case PlantSimulatorServer.BrowseNames.Units:
                {
                    if (createOrReplace)
                    {
                        if (Units == null)
                        {
                            if (replacement == null)
                            {
                                Units = new PropertyState<string>(this);
                            }
                            else
                            {
                                Units = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Units;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private AnalogItemState<double> m_output;
        private PropertyState<string> m_units;
        #endregion
    }
    #endif
    #endregion

    #region GenericActuatorState Class
    #if (!OPCUA_EXCLUDE_GenericActuatorState)
    /// <summary>
    /// Stores an instance of the GenericActuatorType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GenericActuatorState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public GenericActuatorState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(PlantSimulatorServer.ObjectTypes.GenericActuatorType, PlantSimulatorServer.Namespaces.PlantSimulatorServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAC0AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvUGxhbnRTaW11bGF0b3JTZXJ2ZXL/////BGCA" +
           "AgEAAAABABsAAABHZW5lcmljQWN0dWF0b3JUeXBlSW5zdGFuY2UBAaE6AQGhOqE6AAD/////AgAAABVg" +
           "iQoCAAAAAQAFAAAASW5wdXQBAaI6AC8BAEAJojoAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAA" +
           "AEVVUmFuZ2UBAaY6AC4ARKY6AAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEABgAAAE91dHB1dAEB" +
           "qDoALwEAQAmoOgAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBrDoALgBErDoA" +
           "AAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogItemState<double> Input
        {
            get
            {
                return m_input;
            }

            set
            {
                if (!Object.ReferenceEquals(m_input, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_input = value;
            }
        }

        /// <remarks />
        public AnalogItemState<double> Output
        {
            get
            {
                return m_output;
            }

            set
            {
                if (!Object.ReferenceEquals(m_output, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_output = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_input != null)
            {
                children.Add(m_input);
            }

            if (m_output != null)
            {
                children.Add(m_output);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case PlantSimulatorServer.BrowseNames.Input:
                {
                    if (createOrReplace)
                    {
                        if (Input == null)
                        {
                            if (replacement == null)
                            {
                                Input = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                Input = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = Input;
                    break;
                }

                case PlantSimulatorServer.BrowseNames.Output:
                {
                    if (createOrReplace)
                    {
                        if (Output == null)
                        {
                            if (replacement == null)
                            {
                                Output = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                Output = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = Output;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private AnalogItemState<double> m_input;
        private AnalogItemState<double> m_output;
        #endregion
    }
    #endif
    #endregion

    #region GenericMotorState Class
    #if (!OPCUA_EXCLUDE_GenericMotorState)
    /// <summary>
    /// Stores an instance of the GenericMotorType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GenericMotorState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public GenericMotorState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(PlantSimulatorServer.ObjectTypes.GenericMotorType, PlantSimulatorServer.Namespaces.PlantSimulatorServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAC0AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvUGxhbnRTaW11bGF0b3JTZXJ2ZXL/////BGCA" +
           "AgEAAAABABgAAABHZW5lcmljTW90b3JUeXBlSW5zdGFuY2UBAa46AQGuOq46AAD/////AQAAABVgiQoC" +
           "AAAAAQAFAAAAU3BlZWQBAa86AC8BAEAJrzoAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVV" +
           "UmFuZ2UBAbM6AC4ARLM6AAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogItemState<double> Speed
        {
            get
            {
                return m_speed;
            }

            set
            {
                if (!Object.ReferenceEquals(m_speed, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_speed = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_speed != null)
            {
                children.Add(m_speed);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case PlantSimulatorServer.BrowseNames.Speed:
                {
                    if (createOrReplace)
                    {
                        if (Speed == null)
                        {
                            if (replacement == null)
                            {
                                Speed = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                Speed = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = Speed;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private AnalogItemState<double> m_speed;
        #endregion
    }
    #endif
    #endregion

    #region LevelIndicatorState Class
    #if (!OPCUA_EXCLUDE_LevelIndicatorState)
    /// <summary>
    /// Stores an instance of the LevelIndicatorType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LevelIndicatorState : GenericSensorState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public LevelIndicatorState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(PlantSimulatorServer.ObjectTypes.LevelIndicatorType, PlantSimulatorServer.Namespaces.PlantSimulatorServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAC0AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvUGxhbnRTaW11bGF0b3JTZXJ2ZXL/////BGCA" +
           "AgEAAAABABoAAABMZXZlbEluZGljYXRvclR5cGVJbnN0YW5jZQEBtToBAbU6tToAAP////8CAAAAFWCJ" +
           "CgIAAAABAAYAAABPdXRwdXQBAbY6AC8BAEAJtjoAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAA" +
           "AEVVUmFuZ2UBAbo6AC4ARLo6AAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEABQAAAFVuaXRzAQG8" +
           "OgAuAES8OgAAAAz/////AwP/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region LoadcellTransmitterState Class
    #if (!OPCUA_EXCLUDE_LoadcellTransmitterState)
    /// <summary>
    /// Stores an instance of the LoadcellTransmitterType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LoadcellTransmitterState : GenericSensorState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public LoadcellTransmitterState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(PlantSimulatorServer.ObjectTypes.LoadcellTransmitterType, PlantSimulatorServer.Namespaces.PlantSimulatorServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAC0AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvUGxhbnRTaW11bGF0b3JTZXJ2ZXL/////BGCA" +
           "AgEAAAABAB8AAABMb2FkY2VsbFRyYW5zbWl0dGVyVHlwZUluc3RhbmNlAQG9OgEBvTq9OgAA/////wMA" +
           "AAAVYIkKAgAAAAEABgAAAE91dHB1dAEBvjoALwEAQAm+OgAAAAv/////AQH/////AQAAABVgiQoCAAAA" +
           "AAAHAAAARVVSYW5nZQEBwjoALgBEwjoAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAFAAAAVW5p" +
           "dHMBAcQ6AC4ARMQ6AAAADP////8DA/////8AAAAAFWCJCgIAAAABABEAAABFeGNpdGF0aW9uVm9sdGFn" +
           "ZQEBxToALwEAQAnFOgAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEByToALgBE" +
           "yToAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogItemState<double> ExcitationVoltage
        {
            get
            {
                return m_excitationVoltage;
            }

            set
            {
                if (!Object.ReferenceEquals(m_excitationVoltage, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_excitationVoltage = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_excitationVoltage != null)
            {
                children.Add(m_excitationVoltage);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case PlantSimulatorServer.BrowseNames.ExcitationVoltage:
                {
                    if (createOrReplace)
                    {
                        if (ExcitationVoltage == null)
                        {
                            if (replacement == null)
                            {
                                ExcitationVoltage = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                ExcitationVoltage = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = ExcitationVoltage;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private AnalogItemState<double> m_excitationVoltage;
        #endregion
    }
    #endif
    #endregion

    #region ValveState Class
    #if (!OPCUA_EXCLUDE_ValveState)
    /// <summary>
    /// Stores an instance of the ValveType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ValveState : GenericActuatorState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ValveState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(PlantSimulatorServer.ObjectTypes.ValveType, PlantSimulatorServer.Namespaces.PlantSimulatorServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAC0AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvUGxhbnRTaW11bGF0b3JTZXJ2ZXL/////BGCA" +
           "AgEAAAABABEAAABWYWx2ZVR5cGVJbnN0YW5jZQEByzoBAcs6yzoAAP////8CAAAAFWCJCgIAAAABAAUA" +
           "AABJbnB1dAEBzDoALwEAQAnMOgAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEB" +
           "0DoALgBE0DoAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAGAAAAT3V0cHV0AQHSOgAvAQBACdI6" +
           "AAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQHWOgAuAETWOgAAAQB0A/////8B" +
           "Af////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region MixerMotorState Class
    #if (!OPCUA_EXCLUDE_MixerMotorState)
    /// <summary>
    /// Stores an instance of the MixerMotorType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MixerMotorState : GenericMotorState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MixerMotorState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(PlantSimulatorServer.ObjectTypes.MixerMotorType, PlantSimulatorServer.Namespaces.PlantSimulatorServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAC0AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvUGxhbnRTaW11bGF0b3JTZXJ2ZXL/////BGCA" +
           "AgEAAAABABYAAABNaXhlck1vdG9yVHlwZUluc3RhbmNlAQHYOgEB2DrYOgAA/////wEAAAAVYIkKAgAA" +
           "AAEABQAAAFNwZWVkAQHZOgAvAQBACdk6AAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJh" +
           "bmdlAQHdOgAuAETdOgAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ConveyorMotorState Class
    #if (!OPCUA_EXCLUDE_ConveyorMotorState)
    /// <summary>
    /// Stores an instance of the ConveyorMotorType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ConveyorMotorState : GenericMotorState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ConveyorMotorState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(PlantSimulatorServer.ObjectTypes.ConveyorMotorType, PlantSimulatorServer.Namespaces.PlantSimulatorServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAC0AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvUGxhbnRTaW11bGF0b3JTZXJ2ZXL/////BGCA" +
           "AgEAAAABABkAAABDb252ZXlvck1vdG9yVHlwZUluc3RhbmNlAQHfOgEB3zrfOgAA/////wEAAAAVYIkK" +
           "AgAAAAEABQAAAFNwZWVkAQHgOgAvAQBACeA6AAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABF" +
           "VVJhbmdlAQHkOgAuAETkOgAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region PlantSimulatorServerState Class
    #if (!OPCUA_EXCLUDE_PlantSimulatorServerState)
    /// <summary>
    /// Stores an instance of the PlantSimulatorServerType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PlantSimulatorServerState : FolderState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public PlantSimulatorServerState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(PlantSimulatorServer.ObjectTypes.PlantSimulatorServerType, PlantSimulatorServer.Namespaces.PlantSimulatorServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAC0AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvUGxhbnRTaW11bGF0b3JTZXJ2ZXL/////BGCA" +
           "AgEAAAABACAAAABQbGFudFNpbXVsYXRvclNlcnZlclR5cGVJbnN0YW5jZQEB5joBAeY65joAAAEAAAAA" +
           "MAABAec6AgAAAIRgwAoBAAAAEwAAAFBsYW50TGV2ZWxJbmRpY2F0b3IBAAYAAABPVVRQVVQBAec6AC8B" +
           "AbU65zoAAAEBAAAAADABAQHmOgIAAAAVYIkKAgAAAAEABgAAAE91dHB1dAEB6DoALwEAQAnoOgAAAAv/" +
           "////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEB7DoALgBE7DoAAAEAdAP/////AQH/////" +
           "AAAAABVgiQoCAAAAAQAFAAAAVW5pdHMBAe46AC4ARO46AAAADP////8DA/////8AAAAAhGDACgEAAAAT" +
           "AAAAUGxhbnREaXNjaGFyZ2VWYWx2ZQEABQAAAElOUFVUAQHvOgAvAQHLOu86AAAB/////wIAAAAVYIkK" +
           "AgAAAAEABQAAAElucHV0AQHwOgAvAQBACfA6AAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABF" +
           "VVJhbmdlAQH0OgAuAET0OgAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABAAYAAABPdXRwdXQBAfY6" +
           "AC8BAEAJ9joAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAfo6AC4ARPo6AAAB" +
           "AHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public LevelIndicatorState PlantLevelIndicator
        {
            get
            {
                return m_plantLevelIndicator;
            }

            set
            {
                if (!Object.ReferenceEquals(m_plantLevelIndicator, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_plantLevelIndicator = value;
            }
        }

        /// <remarks />
        public ValveState PlantDischargeValve
        {
            get
            {
                return m_plantDischargeValve;
            }

            set
            {
                if (!Object.ReferenceEquals(m_plantDischargeValve, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_plantDischargeValve = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_plantLevelIndicator != null)
            {
                children.Add(m_plantLevelIndicator);
            }

            if (m_plantDischargeValve != null)
            {
                children.Add(m_plantDischargeValve);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case PlantSimulatorServer.BrowseNames.PlantLevelIndicator:
                {
                    if (createOrReplace)
                    {
                        if (PlantLevelIndicator == null)
                        {
                            if (replacement == null)
                            {
                                PlantLevelIndicator = new LevelIndicatorState(this);
                            }
                            else
                            {
                                PlantLevelIndicator = (LevelIndicatorState)replacement;
                            }
                        }
                    }

                    instance = PlantLevelIndicator;
                    break;
                }

                case PlantSimulatorServer.BrowseNames.PlantDischargeValve:
                {
                    if (createOrReplace)
                    {
                        if (PlantDischargeValve == null)
                        {
                            if (replacement == null)
                            {
                                PlantDischargeValve = new ValveState(this);
                            }
                            else
                            {
                                PlantDischargeValve = (ValveState)replacement;
                            }
                        }
                    }

                    instance = PlantDischargeValve;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private LevelIndicatorState m_plantLevelIndicator;
        private ValveState m_plantDischargeValve;
        #endregion
    }
    #endif
    #endregion

    #region PackagingUnitState Class
    #if (!OPCUA_EXCLUDE_PackagingUnitState)
    /// <summary>
    /// Stores an instance of the PackagingUnitType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PackagingUnitState : FolderState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public PackagingUnitState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(PlantSimulatorServer.ObjectTypes.PackagingUnitType, PlantSimulatorServer.Namespaces.PlantSimulatorServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAC0AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvUGxhbnRTaW11bGF0b3JTZXJ2ZXL/////BGCA" +
           "AgEAAAABABkAAABQYWNrYWdpbmdVbml0VHlwZUluc3RhbmNlAQH8OgEB/Dr8OgAAAQAAAAAwAAEB/ToB" +
           "AAAAhGDACgEAAAAbAAAAUGFja2FnaW5nVW5pdExldmVsSW5kaWNhdG9yAQAFAAAATEkwMDQBAf06AC8B" +
           "AbU6/ToAAAEBAAAAADABAQH8OgIAAAAVYIkKAgAAAAEABgAAAE91dHB1dAEB/joALwEAQAn+OgAAAAv/" +
           "////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBAjsALgBEAjsAAAEAdAP/////AQH/////" +
           "AAAAABVgiQoCAAAAAQAFAAAAVW5pdHMBAQQ7AC4ARAQ7AAAADP////8DA/////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public LevelIndicatorState PackagingUnitLevelIndicator
        {
            get
            {
                return m_packagingUnitLevelIndicator;
            }

            set
            {
                if (!Object.ReferenceEquals(m_packagingUnitLevelIndicator, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_packagingUnitLevelIndicator = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_packagingUnitLevelIndicator != null)
            {
                children.Add(m_packagingUnitLevelIndicator);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case PlantSimulatorServer.BrowseNames.PackagingUnitLevelIndicator:
                {
                    if (createOrReplace)
                    {
                        if (PackagingUnitLevelIndicator == null)
                        {
                            if (replacement == null)
                            {
                                PackagingUnitLevelIndicator = new LevelIndicatorState(this);
                            }
                            else
                            {
                                PackagingUnitLevelIndicator = (LevelIndicatorState)replacement;
                            }
                        }
                    }

                    instance = PackagingUnitLevelIndicator;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private LevelIndicatorState m_packagingUnitLevelIndicator;
        #endregion
    }
    #endif
    #endregion

    #region PlantSimulatorServer1State Class
    #if (!OPCUA_EXCLUDE_PlantSimulatorServer1State)
    /// <summary>
    /// Stores an instance of the PlantSimulatorServer1Type ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PlantSimulatorServer1State : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public PlantSimulatorServer1State(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(PlantSimulatorServer.ObjectTypes.PlantSimulatorServer1Type, PlantSimulatorServer.Namespaces.PlantSimulatorServer, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAAC0AAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvUGxhbnRTaW11bGF0b3JTZXJ2ZXL/////hGCA" +
           "AgEAAAABACEAAABQbGFudFNpbXVsYXRvclNlcnZlcjFUeXBlSW5zdGFuY2UBAQU7AQEFOwU7AAABAgAA" +
           "AAAwAAEBBjsAMAABARw7BAAAAIRggAoBAAAAAQAUAAAAUGxhbnRTaW11bGF0b3JTZXJ2ZXIBAQY7AC8B" +
           "AeY6BjsAAAECAAAAADABAQEFOwAwAAEBBzsCAAAAhGDACgEAAAATAAAAUGxhbnRMZXZlbEluZGljYXRv" +
           "cgEABgAAAE9VVFBVVAEBBzsALwEBtToHOwAAAQEAAAAAMAEBAQY7AgAAABVgiQoCAAAAAQAGAAAAT3V0" +
           "cHV0AQEIOwAvAQBACQg7AAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQEMOwAu" +
           "AEQMOwAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABAAUAAABVbml0cwEBDjsALgBEDjsAAAAM////" +
           "/wMD/////wAAAACEYMAKAQAAABMAAABQbGFudERpc2NoYXJnZVZhbHZlAQAFAAAASU5QVVQBAQ87AC8B" +
           "Acs6DzsAAAH/////AgAAABVgiQoCAAAAAQAFAAAASW5wdXQBARA7AC8BAEAJEDsAAAAL/////wMD////" +
           "/wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBARQ7AC4ARBQ7AAABAHQD/////wEB/////wAAAAAVYIkK" +
           "AgAAAAEABgAAAE91dHB1dAEBFjsALwEAQAkWOwAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAA" +
           "RVVSYW5nZQEBGjsALgBEGjsAAAEAdAP/////AQH/////AAAAAIRgwAoBAAAADQAAAFBhY2thZ2luZ1Vu" +
           "aXQBABEAAABQYWNrYWdpbmdVbml0WDAwMQEBHDsALwEB/DocOwAAAQIAAAAAMAEBAQU7ADAAAQEdOwEA" +
           "AACEYMAKAQAAABsAAABQYWNrYWdpbmdVbml0TGV2ZWxJbmRpY2F0b3IBAAUAAABMSTAwNAEBHTsALwEB" +
           "tTodOwAAAQEAAAAAMAEBARw7AgAAABVgiQoCAAAAAQAGAAAAT3V0cHV0AQEeOwAvAQBACR47AAAAC///" +
           "//8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQEiOwAuAEQiOwAAAQB0A/////8BAf////8A" +
           "AAAAFWCJCgIAAAABAAUAAABVbml0cwEBJDsALgBEJDsAAAAM/////wMD/////wAAAAAEYYIKBAAAAAEA" +
           "DAAAAFN0YXJ0UHJvY2VzcwEBJTsALwEBJTslOwAAAQH/////AAAAAARhggoEAAAAAQALAAAAU3RvcFBy" +
           "b2Nlc3MBASY7AC8BASY7JjsAAAEB/////wAAAAA=";
        internal static readonly object m_Plant1;
        #endregion
#endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PlantSimulatorServerState PlantSimulatorServerS
        {
            get
            {
                return m_plantSimulatorServer;
            }

            set
            {
                if (!Object.ReferenceEquals(m_plantSimulatorServer, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_plantSimulatorServer = value;
            }
        }

        /// <remarks />
        public PackagingUnitState PackagingUnit
        {
            get
            {
                return m_packagingUnit;
            }

            set
            {
                if (!Object.ReferenceEquals(m_packagingUnit, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_packagingUnit = value;
            }
        }

        /// <remarks />
        public MethodState StartProcess
        {
            get
            {
                return m_startProcessMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_startProcessMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_startProcessMethod = value;
            }
        }

        /// <remarks />
        public MethodState StopProcess
        {
            get
            {
                return m_stopProcessMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_stopProcessMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_stopProcessMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_plantSimulatorServer != null)
            {
                children.Add(m_plantSimulatorServer);
            }

            if (m_packagingUnit != null)
            {
                children.Add(m_packagingUnit);
            }

            if (m_startProcessMethod != null)
            {
                children.Add(m_startProcessMethod);
            }

            if (m_stopProcessMethod != null)
            {
                children.Add(m_stopProcessMethod);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case PlantSimulatorServer.BrowseNames.PlantSimulatorServer:
                {
                    if (createOrReplace)
                    {
                        if (PlantSimulatorServerS == null)
                        {
                            if (replacement == null)
                            {
                                PlantSimulatorServerS = new PlantSimulatorServerState(this);
                            }
                            else
                            {
                                PlantSimulatorServerS = (PlantSimulatorServerState)replacement;
                            }
                        }
                    }

                    instance = PlantSimulatorServerS;
                    break;
                }

                case PlantSimulatorServer.BrowseNames.PackagingUnit:
                {
                    if (createOrReplace)
                    {
                        if (PackagingUnit == null)
                        {
                            if (replacement == null)
                            {
                                PackagingUnit = new PackagingUnitState(this);
                            }
                            else
                            {
                                PackagingUnit = (PackagingUnitState)replacement;
                            }
                        }
                    }

                    instance = PackagingUnit;
                    break;
                }

                case PlantSimulatorServer.BrowseNames.StartProcess:
                {
                    if (createOrReplace)
                    {
                        if (StartProcess == null)
                        {
                            if (replacement == null)
                            {
                                StartProcess = new MethodState(this);
                            }
                            else
                            {
                                StartProcess = (MethodState)replacement;
                            }
                        }
                    }

                    instance = StartProcess;
                    break;
                }

                case PlantSimulatorServer.BrowseNames.StopProcess:
                {
                    if (createOrReplace)
                    {
                        if (StopProcess == null)
                        {
                            if (replacement == null)
                            {
                                StopProcess = new MethodState(this);
                            }
                            else
                            {
                                StopProcess = (MethodState)replacement;
                            }
                        }
                    }

                    instance = StopProcess;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PlantSimulatorServerState m_plantSimulatorServer;
        private PackagingUnitState m_packagingUnit;
        private MethodState m_startProcessMethod;
        private MethodState m_stopProcessMethod;
        #endregion
    }
    #endif
    #endregion
}