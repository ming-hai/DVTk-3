// ------------------------------------------------------
// DVTk - The Healthcare Validation Toolkit (www.dvtk.org)
// Copyright � 2009 DVTk
// ------------------------------------------------------
// This file is part of DVTk.
//
// DVTk is free software; you can redistribute it and/or modify it under the terms of the GNU
// Lesser General Public License as published by the Free Software Foundation; either version 3.0
// of the License, or (at your option) any later version. 
// 
// DVTk is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even
// the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU Lesser
// General Public License for more details. 
// 
// You should have received a copy of the GNU Lesser General Public License along with this
// library; if not, see <http://www.gnu.org/licenses/>

using System;
using System.IO;
using System.ComponentModel;
using System.Globalization;

namespace DvtkData.Activities
{
    using System.Collections;
    using DvtkData.Dul;
    using DvtkData.Dimse;
    using DvtkData.DvtDetailToXml;

    /// <summary>
    /// Activity performed.
    /// </summary>
    /// <remarks>
    /// Maps to basic Dvtk activities performed by Dvtk.
    /// </remarks>
    public class Activity
    {

        /// <summary>
        /// This item holds the <see cref="DvtkData.Dimse.DicomMessage"/> or <see cref="DvtkData.Dul.DulMessage"/> related to this <see cref="Activity"/>.
        /// </summary>
        public object Item;

        /// <summary>
        /// The type of activity performed by Dvtk.
        /// </summary>
        public ActivityType Type;
    }

    /// <summary>
    /// Types of <see cref="Activity"/> performed.
    /// </summary>
    public enum ActivityType
    {

        /// <summary>
        /// A <see cref="DvtkData.Dimse.DicomMessage"/> or <see cref="DvtkData.Dul.DulMessage"/> was send.
        /// </summary>
        Send,

        /// <summary>
        /// A <see cref="DvtkData.Dimse.DicomMessage"/> or <see cref="DvtkData.Dul.DulMessage"/> was received.
        /// </summary>
        Receive,

        /// <summary>
        /// A <see cref="DvtkData.Dimse.DicomMessage"/> or <see cref="DvtkData.Dul.DulMessage"/> was received and stored as reference object.
        /// </summary>
        Import,

        /// <summary>
        /// A <see cref="DvtkData.Dimse.DicomMessage"/> or <see cref="DvtkData.Dul.DulMessage"/> was validated.
        /// </summary>
        Validate,

        /// <summary>
        /// A <see cref="DvtkData.Media.DicomFile"/> was read.
        /// </summary>
        MediaRead,

        /// <summary>
        /// A <see cref="DvtkData.Media.DicomFile"/> was written.
        /// </summary>
        MediaWrite,

        /// <summary>
        /// A reference object was updated.
        /// </summary>
        Set,
    }

    /// <summary>
    /// A generic application activity report. This is generic <see cref="ApplicationActivityReport"/> is complementary to the <see cref="Activity"/> items.
    /// </summary>
    /// <remarks>Generated by the core of the Dvtk application.</remarks>
    public class ApplicationActivityReport //: IDvtDetailToXml, IDvtSummaryToXml
    {

        /// <summary>
        /// The severity level.
        /// </summary>
        public ActivityReportLevel Level;

        /// <summary>
        /// A literal message.
        /// </summary>
        public string Message;

        /// <summary>
        /// Serialize DVT Detail Data to Xml.
        /// </summary>
        /// <param name="streamWriter">Stream writer to serialize to.</param>
        /// <param name="messageIndex">Message Index.</param>
        /// <param name="level">Recursion level. 0 = Top.</param> 
        /// <returns>bool - success/failure</returns>
        public bool DvtDetailToXml(StreamWriter streamWriter, UInt32 messageIndex, int level)
        {
            if (streamWriter == null) return true;

            string levelString = string.Empty;
            switch (Level)
            {
                case ActivityReportLevel.Debug: levelString = "Debug"; break;
                case ActivityReportLevel.DicomObjectRelationship: levelString = "Relation"; break;
                case ActivityReportLevel.DulpMachineState: levelString = "State"; break;
                case ActivityReportLevel.Error: levelString = "Error"; break;
                case ActivityReportLevel.Information: levelString = "Info"; break;
                case ActivityReportLevel.ConditionText: levelString = "ConditionText"; break;
                case ActivityReportLevel.None: levelString = "None"; break;
                case ActivityReportLevel.Scripting: levelString = "Script"; break;
                case ActivityReportLevel.ScriptName: levelString = "ScriptName"; break;
                case ActivityReportLevel.MediaFilename: levelString = "DCM"; break;
                case ActivityReportLevel.WareHouseLabel: levelString = "Label"; break;
                case ActivityReportLevel.Warning: levelString = "Warning"; break;
                default: break;
            }

            if (levelString != string.Empty)
            {
                streamWriter.WriteLine("<Activity Index=\"A{0}\" Level=\"{1}\">{2}</Activity>", messageIndex, levelString, Message);
            }

            return true;
        }

        /// <summary>
        /// Serialize DVT Summary Data to Xml.
        /// </summary>
        /// <param name="streamWriter">Stream writer to serialize to.</param>
        /// <param name="messageIndex">Message Index.</param>
        /// <param name="level">Recursion level. 0 = Top.</param> 
        /// <returns>bool - success/failure</returns>
        public bool DvtSummaryToXml(StreamWriter streamWriter, UInt32 messageIndex, int level)
        {
            if (streamWriter == null) return true;

            string levelString = string.Empty;
            switch (Level)
            {
                // we are only intrested in Errors and Warnings in the summary
                case ActivityReportLevel.Error: levelString = "Error"; break;
                case ActivityReportLevel.Warning: levelString = "Warning"; break;
                case ActivityReportLevel.ConditionText: levelString = "ConditionText"; break;
                case ActivityReportLevel.ScriptName: levelString = "ScriptName"; break;
                case ActivityReportLevel.MediaFilename: levelString = "DCM"; break;
                default: break;
            }

            if (levelString != string.Empty)
            {
                streamWriter.WriteLine("<Activity Index=\"A{0}\" Level=\"{1}\">{2}</Activity>", messageIndex, levelString, Message);
            }

            return true;
        }
    }

    /// <summary>
    /// A generic user activity report. This is generic <see cref="UserActivityReport"/> is complementary to the <see cref="Activity"/> items.
    /// </summary>
    /// <remarks>This type of message is generated in response to the users request by a call to write a user message via the session.</remarks>
    public class UserActivityReport //: IDvtDetailToXml, IDvtSummaryToXml
    {

        /// <summary>
        /// The severity level.
        /// </summary>
        public ActivityReportLevel Level;

        /// <summary>
        /// Indicates if HTML is written.
        /// </summary>
        public bool IsHtml = false;

        /// <summary>
        /// A literal message.
        /// </summary>
        public string Message;

        /// <summary>
        /// Serialize DVT Detail Data to Xml.
        /// </summary>
        /// <param name="streamWriter">Stream writer to serialize to.</param>
        /// <param name="messageIndex">Message Index.</param>
        /// <param name="level">Recursion level. 0 = Top.</param> 
        /// <returns>bool - success/failure</returns>
        public bool DvtDetailToXml(StreamWriter streamWriter, UInt32 messageIndex, int level)
        {
            if (streamWriter == null) return true;

            string levelString = string.Empty;
            switch (Level)
            {
                case ActivityReportLevel.Debug: levelString = "Debug"; break;
                case ActivityReportLevel.DicomObjectRelationship: levelString = "Relation"; break;
                case ActivityReportLevel.DulpMachineState: levelString = "State"; break;
                case ActivityReportLevel.Error: levelString = "Error"; break;
                case ActivityReportLevel.Information: levelString = "Info"; break;
                case ActivityReportLevel.ConditionText: levelString = "ConditionText"; break;
                case ActivityReportLevel.None: levelString = "None"; break;
                case ActivityReportLevel.Scripting: levelString = "Script"; break;
                case ActivityReportLevel.ScriptName: levelString = "ScriptName"; break;
                case ActivityReportLevel.MediaFilename: levelString = "DCM"; break;
                case ActivityReportLevel.WareHouseLabel: levelString = "Label"; break;
                case ActivityReportLevel.Warning: levelString = "Warning"; break;
                default: break;
            }

            if (IsHtml)
            {
                if (levelString != string.Empty)
                {
                    streamWriter.WriteLine("<HTMLUserActivity Level=\"{0}\">{1}</HTMLUserActivity>", levelString, Message);
                }
            }
            else
            {
                if (levelString != string.Empty)
                {
                    streamWriter.WriteLine("<UserActivity Index=\"U{0}\" Level=\"{1}\">{2}</UserActivity>", messageIndex, levelString, Message);
                }
            }

            return true;
        }

        /// <summary>
        /// Serialize DVT Test Log Data to Xml.
        /// </summary>
        /// <param name="streamWriter">Stream writer to serialize to.</param>
        /// <param name="messageIndex">Message Index.</param>
        /// <param name="level">Recursion level. 0 = Top.</param> 
        /// <returns>bool - success/failure</returns>
        public bool DvtTestLogToXml(StreamWriter streamWriter, UInt32 messageIndex, int level)
        {
            if (streamWriter == null) return true;

            string levelString = string.Empty;
            switch (Level)
            {
                case ActivityReportLevel.Debug: levelString = "Debug"; break;
                case ActivityReportLevel.DicomObjectRelationship: levelString = "Relation"; break;
                case ActivityReportLevel.DulpMachineState: levelString = "State"; break;
                case ActivityReportLevel.Error: levelString = "Error"; break;
                case ActivityReportLevel.Information: levelString = "Info"; break;
                case ActivityReportLevel.ConditionText: levelString = "ConditionText"; break;
                case ActivityReportLevel.None: levelString = "None"; break;
                case ActivityReportLevel.Scripting: levelString = "Script"; break;
                case ActivityReportLevel.ScriptName: levelString = "ScriptName"; break;
                case ActivityReportLevel.MediaFilename: levelString = "DCM"; break;
                case ActivityReportLevel.WareHouseLabel: levelString = "Label"; break;
                case ActivityReportLevel.Warning: levelString = "Warning"; break;
                default: break;
            }

            if (IsHtml)
            {
                if (levelString != string.Empty)
                {
                    streamWriter.WriteLine("<HTMLUserActivity Level=\"{0}\">{1}</HTMLUserActivity>", levelString, Message);
                }
            }
            else
            {
                if (levelString != string.Empty)
                {
                    streamWriter.WriteLine("<UserActivity Index=\"U{0}\" Level=\"{1}\">{2}</UserActivity>", messageIndex, levelString, Message);
                }
            }

            return true;
        }

        /// <summary>
        /// Serialize DVT Summary Data to Xml.
        /// </summary>
        /// <param name="streamWriter">Stream writer to serialize to.</param>
        /// <param name="messageIndex">Message Index.</param>
        /// <param name="level">Recursion level. 0 = Top.</param> 
        /// <returns>bool - success/failure</returns>
        public bool DvtSummaryToXml(StreamWriter streamWriter, UInt32 messageIndex, int level)
        {
            if (streamWriter == null) return true;

            string levelString = string.Empty;
            switch (Level)
            {
                // Always show HTML information.
                case ActivityReportLevel.Information:
                    if (IsHtml)
                    {
                        levelString = "Info";
                    }
                    break;
                // we are only intrested in Errors and Warnings in the summary
                case ActivityReportLevel.Error: levelString = "Error"; break;
                case ActivityReportLevel.Warning: levelString = "Warning"; break;
                case ActivityReportLevel.ConditionText: levelString = "ConditionText"; break;
                case ActivityReportLevel.ScriptName: levelString = "ScriptName"; break;
                case ActivityReportLevel.MediaFilename: levelString = "DCM"; break;
                default: break;
            }

            if (IsHtml)
            {
                if (levelString != string.Empty)
                {
                    streamWriter.WriteLine("<HTMLUserActivity Level=\"{0}\">{1}</HTMLUserActivity>", levelString, Message);
                }
            }
            else
            {
                if (levelString != string.Empty)
                {
                    streamWriter.WriteLine("<UserActivity Index=\"U{0}\" Level=\"{1}\">{2}</UserActivity>", messageIndex, levelString, Message);
                }
            }

            return true;
        }
    }

    /// <summary>
    /// The types of activity report severity levels.
    /// </summary>
    public enum ActivityReportLevel
    {

        /// <summary>
        /// Unspecified.
        /// </summary>
        None,

        /// <summary>
        /// Error level.
        /// </summary>
        Error,

        /// <summary>
        /// Warning level.
        /// </summary>
        Warning,

        /// <summary>
        /// Information level.
        /// </summary>
        Information,

        /// <summary>
        /// Debug related information.
        /// </summary>
        Debug,

        /// <summary>
        /// Script related information.
        /// </summary>
        Scripting,

        /// <summary>
        /// ScriptName related information.
        /// </summary>
        ScriptName,

        /// <summary>
        /// MediaFilename related information.
        /// </summary>
        MediaFilename,

        /// <summary>
        /// Information Object Definition, object relationship related information.
        /// </summary>
        DicomObjectRelationship,

        /// <summary>
        /// Dicom Upper Layer Internal Machine State related information.
        /// </summary>
        DulpMachineState,

        /// <summary>
        /// Application reference object related information.
        /// </summary>
        WareHouseLabel,

        /// <summary>
        /// ConditionText.
        /// </summary>
        ConditionText,
    }
}
