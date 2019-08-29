﻿//
// Copyright Seth Hendrick 2019.
// Distributed under the MIT License.
// (See accompanying file LICENSE in the root of the repository).
//

using System;

namespace Cake.ArgumentBinder
{
    [AttributeUsage( AttributeTargets.Property, Inherited = true, AllowMultiple = false )]
    public class StringArgumentAttribute : BaseStringAttribute
    {
        // ---------------- Constructor ----------------

        public StringArgumentAttribute( string arg ):
            base( arg )
        {
        }
    }

    [AttributeUsage( AttributeTargets.Property, Inherited = true, AllowMultiple = false )]
    public class IntegerArgumentAttribute : BaseIntegerAttribute
    {
        // ---------------- Constructor ----------------

        public IntegerArgumentAttribute( string arg ) :
            base( arg )
        {
        }
    }

    [AttributeUsage( AttributeTargets.Property, Inherited = true, AllowMultiple = false )]
    public class BooleanArgumentAttribute : BaseBooleanAttribute
    {
        // ---------------- Constructor ----------------

        public BooleanArgumentAttribute( string arg ) :
            base( arg )
        {
        }
    }
}
