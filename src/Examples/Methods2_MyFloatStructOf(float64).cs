//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2018 August 10 20:17:57 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.1.0")]
        public partial struct MyFloat : EmptyInterface
        {
            // Value of the MyFloat struct
            private readonly float64 m_value;

            public MyFloat(float64 value) => m_value = value;

            // Enable implicit conversions between float64 and MyFloat struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator MyFloat(float64 value) => new MyFloat(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator float64(MyFloat value) => value.m_value;
            
            // Enable comparisons between nil and MyFloat struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(MyFloat value, NilType nil) => value.Equals(default(MyFloat));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(MyFloat value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, MyFloat value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, MyFloat value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator MyFloat(NilType nil) => default(MyFloat);
        }
    }
}
