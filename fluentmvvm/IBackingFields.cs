﻿// <auto-generated>
// This file is generated by a T4 template. Make changes directly in the .tt file.
// </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FluentMvvm
{
    internal interface IBackingFields
    {
        Type OnType { get; }

        T Get<T>(string propertyName);
        Boolean GetBoolean(string propertyName);
        Byte GetByte(string propertyName);
        SByte GetSByte(string propertyName);
        Char GetChar(string propertyName);
        Decimal GetDecimal(string propertyName);
        Double GetDouble(string propertyName);
        Single GetSingle(string propertyName);
        Int16 GetInt16(string propertyName);
        UInt16 GetUInt16(string propertyName);
        Int32 GetInt32(string propertyName);
        UInt32 GetUInt32(string propertyName);
        Int64 GetInt64(string propertyName);
        UInt64 GetUInt64(string propertyName);
        DateTime GetDateTime(string propertyName);
        String GetString(string propertyName);

        bool Set<T>(T value, string propertyName);
        bool Set(Boolean value, string propertyName);
        bool Set(Byte value, string propertyName);
        bool Set(SByte value, string propertyName);
        bool Set(Char value, string propertyName);
        bool Set(Decimal value, string propertyName);
        bool Set(Double value, string propertyName);
        bool Set(Single value, string propertyName);
        bool Set(Int16 value, string propertyName);
        bool Set(UInt16 value, string propertyName);
        bool Set(Int32 value, string propertyName);
        bool Set(UInt32 value, string propertyName);
        bool Set(Int64 value, string propertyName);
        bool Set(UInt64 value, string propertyName);
        bool Set(DateTime value, string propertyName);
        bool Set(String value, string propertyName);
    }
}
