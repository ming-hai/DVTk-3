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

#pragma once
#include "Idefinition.h"
//#define LogMask System::UInt32

namespace Wrappers
{
    using namespace System::Runtime::InteropServices;

    public value struct MDefinitionFileDetails
    {
        System::String^ AEName;
        System::String^ AEVersion;
        System::String^ SOPClassName;
        System::String^ SOPClassUID;
        System::Boolean IsMetaSOPClass;
    };

    public ref class MDefinition abstract
    {
    public:
        // <summary>
        // Definition File Details
        // </summary>
        // <remarks>
        // Get Property
        // </remarks>
        
        static MDefinitionFileDetails get_FileDetails(System::String^ pFileName);
    };
}